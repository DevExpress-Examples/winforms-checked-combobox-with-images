Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Text


Namespace DXSample

	Public Class CheckedImageComboBoxEditPainter
		Inherits ButtonEditPainter
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub DrawString(ByVal info As ControlGraphicsInfoArgs, ByVal bounds As Rectangle, ByVal text As String, ByVal appearance As DevExpress.Utils.AppearanceObject)
			Dim viewInfo As PopupContainerEditViewInfo = TryCast(info.ViewInfo, PopupContainerEditViewInfo)
			Dim edit As RepositoryItemCheckedImageComboBoxEdit = TryCast(viewInfo.Item, RepositoryItemCheckedImageComboBoxEdit)
			If (Not edit.CanShowImageInEditBox) Then
				MyBase.DrawString(info, bounds, text, appearance)
			Else
                DrawEditContent(info, bounds, text, appearance)
            End If
        End Sub

        Private Sub DrawEditContent(ByVal info As ControlGraphicsInfoArgs, ByVal bounds As Rectangle, ByVal text As String, ByVal appearance As DevExpress.Utils.AppearanceObject)
            Dim viewInfo As PopupContainerEditViewInfo = TryCast(info.ViewInfo, PopupContainerEditViewInfo)
            Dim edit As RepositoryItemCheckedImageComboBoxEdit = TryCast(viewInfo.Item, RepositoryItemCheckedImageComboBoxEdit)
            Dim values() As String = text.Split(edit.SeparatorChar)
            Dim valRect As New Rectangle(bounds.X, bounds.Y, 0, bounds.Height)
            For Each val As String In values
                Dim index As Integer = GetIndexByDescription(edit.GetItems(), val.Trim())
                If index <> -1 Then
                    DrawImage(edit, info.Graphics, index, valRect)

                End If
                Dim str As String = val
                If Array.IndexOf(values, val) < values.Length - 1 Then
                    str = String.Concat(val, edit.SeparatorChar)
                End If
                DrawDisplayText(info, appearance, valRect, str)
            Next val
        End Sub

        Private Sub DrawDisplayText(ByVal info As ControlGraphicsInfoArgs, ByVal appearance As DevExpress.Utils.AppearanceObject, ByRef valRect As Rectangle, ByVal str As String)
            Dim width As Integer = TextUtils.GetStringSize(info.Graphics, str, appearance.Font).Width
            valRect.Width = width
            MyBase.DrawString(info, valRect, str, appearance)
            valRect.X += width
        End Sub

		Private Sub DrawImage(ByVal edit As RepositoryItemCheckedImageComboBoxEdit, ByVal gr As Graphics, ByVal index As Integer, ByRef valRect As Rectangle)
			Dim image As Image = edit.GetItemImage(index)
			Dim rect As New Rectangle(valRect.X, valRect.Y, RepositoryItemCheckedImageComboBoxEdit.ImageWidth, RepositoryItemCheckedImageComboBoxEdit.ImageHeight)
			If image IsNot Nothing Then
				gr.DrawImage(image, rect)
				valRect.X += RepositoryItemCheckedImageComboBoxEdit.ImageWidth + 2
			End If
		End Sub

		Private Function GetIndexByDescription(ByVal collection As CheckedListBoxItemCollection, ByVal description As String) As Integer
			For i As Integer = 0 To collection.Count - 1
				If collection(i).Description.Equals(description) Then
					Return i
				End If
			Next i
			Return -1
		End Function
	End Class
End Namespace


