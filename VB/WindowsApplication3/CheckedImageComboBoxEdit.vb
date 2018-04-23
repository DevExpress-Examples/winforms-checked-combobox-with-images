Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports System.ComponentModel


Namespace DXSample

	Public Class CheckedImageComboBoxEdit
		Inherits CheckedComboBoxEdit

		Shared Sub New()
			RepositoryItemCheckedImageComboBoxEdit.RegisterCheckedImageComboBoxEdit()
		End Sub

		Public Sub New()
		End Sub

		Private listBox As CheckedListBoxControl = Nothing

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCheckedImageComboBoxEdit.CustomEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCheckedImageComboBoxEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCheckedImageComboBoxEdit)
			End Get
		End Property

		Protected Overrides Function CreatePopupCheckListControl() As PopupContainerControl
			Dim ctrl As PopupContainerControl = MyBase.CreatePopupCheckListControl()
			Dim listBox As CheckedListBoxControl = GetCheckedListBoxControl(ctrl)
			If Properties.CanShowImageInDropDown Then
				AddHandler listBox.DrawItem, AddressOf OnDrawItem
			End If
			Return ctrl
		End Function

		Private Function GetCheckedListBoxControl(ByVal ctrl As PopupContainerControl) As CheckedListBoxControl
			For Each c As Control In ctrl.Controls
				If TypeOf c Is CheckedListBoxControl Then
					Return TryCast(c, CheckedListBoxControl)
				End If
			Next c
			Return Nothing
		End Function

		Private Sub OnDrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs)
			If e.Index = 0 Then
				Return
			End If
			listBox = TryCast(sender, CheckedListBoxControl)
			Dim viewInfo As CheckedListBoxViewInfo = TryCast(listBox.GetViewInfo(), CheckedListBoxViewInfo)
			Dim image As Image = Properties.GetItemImage(e.Index - 1)
			If image Is Nothing Then
				Return
			End If
			DrawCheckedItem(e, viewInfo, image)
			e.Handled = True
		End Sub

		Private Sub DrawCheckedItem(ByVal e As ListBoxDrawItemEventArgs, ByVal viewInfo As CheckedListBoxViewInfo, ByVal image As Image)
			Dim itInfo As CheckedListBoxViewInfo.CheckedItemInfo = viewInfo.GetItemByIndex(e.Index)
			FillRectangle(e.Appearance, e.Cache, e.Bounds)
			DrawCheckBox(itInfo.CheckArgs, e.Graphics, viewInfo)
			DrawImage(itInfo.CheckArgs.GlyphRect, e.Graphics, image)
			DrawString(itInfo, e.Appearance, e.Cache)
		End Sub

		Private Sub FillRectangle(ByVal appearance As AppearanceObject, ByVal cache As GraphicsCache, ByVal rect As Rectangle)
			appearance.FillRectangle(cache, rect)
		End Sub

		Private Sub DrawCheckBox(ByVal checkArgs As CheckObjectInfoArgs, ByVal gr As Graphics, ByVal viewInfo As CheckedListBoxViewInfo)
			checkArgs.Graphics = gr
			viewInfo.CheckMarkPainter.DrawObject(checkArgs)
		End Sub

		Private Sub DrawImage(ByVal rect As Rectangle, ByVal gr As Graphics, ByVal image As Image)
			Dim point As New Point(rect.Right + 2, rect.Y)
			gr.DrawImage(image, point)
		End Sub

		Private Sub DrawString(ByVal itInfo As CheckedListBoxViewInfo.CheckedItemInfo, ByVal appearance As AppearanceObject, ByVal cache As GraphicsCache)
			Dim textRect As New Rectangle(itInfo.TextRect.X + RepositoryItemCheckedImageComboBoxEdit.ImageWidth + 2, itInfo.TextRect.Y, itInfo.TextRect.Width - RepositoryItemCheckedImageComboBoxEdit.ImageWidth - 2, itInfo.TextRect.Height)
			appearance.DrawString(cache, itInfo.Text, textRect)
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If listBox IsNot Nothing Then
					RemoveHandler listBox.DrawItem, AddressOf OnDrawItem
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

	End Class
End Namespace


