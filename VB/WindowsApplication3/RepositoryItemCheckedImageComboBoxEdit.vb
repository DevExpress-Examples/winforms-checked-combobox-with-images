Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports System.Reflection
Imports System.ComponentModel
Imports DevExpress.XtraEditors.ViewInfo
Imports System.IO


Namespace DXSample

	<UserRepositoryItem("RegisterCheckedImageComboBoxEdit")> _
	Public Class RepositoryItemCheckedImageComboBoxEdit
		Inherits RepositoryItemCheckedComboBoxEdit

		Shared Sub New()
			RegisterCheckedImageComboBoxEdit()
		End Sub
		Public Sub New()
		End Sub

		Public Const CustomEditName As String = "CheckedImageComboBoxEdit"

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property

		Friend Const ImageWidth As Integer = 16, ImageHeight As Integer = 16

		Public Shared Sub RegisterCheckedImageComboBoxEdit()
			Dim img As Image = Nothing
			Try
				img = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly(). GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp")), Bitmap)
			Catch
			End Try
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CheckedImageComboBoxEdit), GetType(RepositoryItemCheckedImageComboBoxEdit), GetType(PopupContainerEditViewInfo), New CheckedImageComboBoxEditPainter(), True, img))
		End Sub

		Private imageMember_Renamed As String

		<DefaultValue(""), TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"), Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", GetType(System.Drawing.Design.UITypeEditor))> _
		Public Property ImageMember() As String
			Get
				Return imageMember_Renamed
			End Get
			Set(ByVal value As String)
				If imageMember_Renamed <> value Then
					imageMember_Renamed = value
				End If
			End Set
		End Property

		Private showImagesInEditBox_Renamed As Boolean = False

		<DefaultValue(False)> _
		Public Property ShowImagesInEditBox() As Boolean
			Get
				Return showImagesInEditBox_Renamed
			End Get
			Set(ByVal value As Boolean)
				If showImagesInEditBox_Renamed <> value Then
					showImagesInEditBox_Renamed = value
				End If
			End Set
		End Property

		Friend Function GetItemImage(ByVal index As Integer) As Image
			Dim imageValue As Object = DataAdapter.GetRowValue(index, ImageMember)
			If TypeOf imageValue Is Image Then
				Return New Bitmap(CType(imageValue, Image), RepositoryItemCheckedImageComboBoxEdit.ImageWidth, RepositoryItemCheckedImageComboBoxEdit.ImageHeight)
			End If
			If TypeOf imageValue Is Byte() Then
				Return New Bitmap(ConvertToImage(TryCast(imageValue, Byte())), RepositoryItemCheckedImageComboBoxEdit.ImageWidth, RepositoryItemCheckedImageComboBoxEdit.ImageHeight)
			End If
			Return Nothing
		End Function

		Private Function ConvertToImage(ByVal array() As Byte) As Image
			Using str As New MemoryStream(array)
				Return Image.FromStream(str)
			End Using
		End Function

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemCheckedImageComboBoxEdit = TryCast(item, RepositoryItemCheckedImageComboBoxEdit)
				If source Is Nothing Then
					Return
				End If
				imageMember_Renamed = source.ImageMember
				showImagesInEditBox_Renamed = source.ShowImagesInEditBox
			Finally
				EndUpdate()
			End Try
		End Sub

		Friend ReadOnly Property CanShowImageInDropDown() As Boolean
			Get
				Return IsBoundMode AndAlso ImageMember IsNot Nothing AndAlso Not ImageMember.Equals(String.Empty)
			End Get
		End Property

		Friend ReadOnly Property CanShowImageInEditBox() As Boolean
			Get
				Return CanShowImageInDropDown AndAlso ShowImagesInEditBox
			End Get
		End Property
	End Class
End Namespace


