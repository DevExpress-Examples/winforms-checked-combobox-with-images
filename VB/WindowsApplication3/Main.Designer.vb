Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet1 = New DXSample.nwindDataSet1()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.checkedImageComboBoxEdit2 = New DXSample.CheckedImageComboBoxEdit()
			Me.categoriesTableAdapter = New DXSample.nwindDataSet1TableAdapters.CategoriesTableAdapter()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedImageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
			' 
			' gridControl2
			' 
			Me.gridControl2.DataSource = Me.categoriesBindingSource
			Me.gridControl2.Location = New System.Drawing.Point(413, 12)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit2})
			Me.gridControl2.Size = New System.Drawing.Size(588, 524)
			Me.gridControl2.TabIndex = 0
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet1
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet1"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName, Me.colPicture})
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsBehavior.Editable = False
			Me.gridView2.OptionsView.RowAutoHeight = True
			Me.gridView2.OptionsView.ShowGroupPanel = False
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' colPicture
			' 
			Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit2
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.Name = "colPicture"
			Me.colPicture.Visible = True
			Me.colPicture.VisibleIndex = 2
			' 
			' repositoryItemPictureEdit2
			' 
			Me.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2"
			Me.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' checkedImageComboBoxEdit2
			' 
			Me.checkedImageComboBoxEdit2.EditValue = ""
			Me.checkedImageComboBoxEdit2.Location = New System.Drawing.Point(12, 120)
			Me.checkedImageComboBoxEdit2.Name = "checkedImageComboBoxEdit2"
			Me.checkedImageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedImageComboBoxEdit2.Properties.DataSource = Me.categoriesBindingSource
			Me.checkedImageComboBoxEdit2.Properties.DisplayMember = "CategoryName"
			Me.checkedImageComboBoxEdit2.Properties.ImageMember = "Picture"
			Me.checkedImageComboBoxEdit2.Properties.ShowImagesInEditBox = True
			Me.checkedImageComboBoxEdit2.Properties.ValueMember = "CategoryID"
			Me.checkedImageComboBoxEdit2.Size = New System.Drawing.Size(395, 22)
			Me.checkedImageComboBoxEdit2.TabIndex = 1
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' Main
			' 
			Me.ClientSize = New System.Drawing.Size(1013, 564)
			Me.Controls.Add(Me.checkedImageComboBoxEdit2)
			Me.Controls.Add(Me.gridControl2)
			Me.Name = "Main"
			Me.Text = "CheckedImageComboBoxEdit"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedImageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private checkedImageComboBoxEdit2 As CheckedImageComboBoxEdit
		Private nwindDataSet1 As nwindDataSet1
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As DXSample.nwindDataSet1TableAdapters.CategoriesTableAdapter
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

