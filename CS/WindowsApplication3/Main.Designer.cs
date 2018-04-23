namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet1 = new DXSample.nwindDataSet1();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.checkedImageComboBoxEdit2 = new DXSample.CheckedImageComboBoxEdit();
            this.categoriesTableAdapter = new DXSample.nwindDataSet1TableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedImageComboBoxEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.categoriesBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(413, 12);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit2});
            this.gridControl2.Size = new System.Drawing.Size(588, 524);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet1;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet1";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colPicture});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // colPicture
            // 
            this.colPicture.ColumnEdit = this.repositoryItemPictureEdit2;
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 2;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // checkedImageComboBoxEdit2
            // 
            this.checkedImageComboBoxEdit2.EditValue = "";
            this.checkedImageComboBoxEdit2.Location = new System.Drawing.Point(12, 120);
            this.checkedImageComboBoxEdit2.Name = "checkedImageComboBoxEdit2";
            this.checkedImageComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedImageComboBoxEdit2.Properties.DataSource = this.categoriesBindingSource;
            this.checkedImageComboBoxEdit2.Properties.DisplayMember = "CategoryName";
            this.checkedImageComboBoxEdit2.Properties.ImageMember = "Picture";
            this.checkedImageComboBoxEdit2.Properties.ShowImagesInEditBox = true;
            this.checkedImageComboBoxEdit2.Properties.ValueMember = "CategoryID";
            this.checkedImageComboBoxEdit2.Size = new System.Drawing.Size(395, 22);
            this.checkedImageComboBoxEdit2.TabIndex = 1;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1013, 564);
            this.Controls.Add(this.checkedImageComboBoxEdit2);
            this.Controls.Add(this.gridControl2);
            this.Name = "Main";
            this.Text = "CheckedImageComboBoxEdit";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedImageComboBoxEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private CheckedImageComboBoxEdit checkedImageComboBoxEdit2;
        private nwindDataSet1 nwindDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DXSample.nwindDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
    }
}

