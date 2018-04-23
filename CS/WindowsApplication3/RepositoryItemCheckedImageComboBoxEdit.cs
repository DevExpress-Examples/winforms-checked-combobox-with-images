using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using System.Reflection;
using System.ComponentModel;
using DevExpress.XtraEditors.ViewInfo;
using System.IO;


namespace DXSample {
    
    [UserRepositoryItem("RegisterCheckedImageComboBoxEdit")]
    public class RepositoryItemCheckedImageComboBoxEdit : RepositoryItemCheckedComboBoxEdit{
        
        static RepositoryItemCheckedImageComboBoxEdit() { RegisterCheckedImageComboBoxEdit(); }
        public RepositoryItemCheckedImageComboBoxEdit() {  } 

        public const string CustomEditName = "CheckedImageComboBoxEdit";

        public override string EditorTypeName { get { return CustomEditName; } }

        internal const int ImageWidth = 16, ImageHeight = 16;

        public static void RegisterCheckedImageComboBoxEdit() {
            Image img = null;
            try {
                img = (Bitmap)Bitmap.FromStream(Assembly.GetExecutingAssembly().
                  GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp"));
            }
            catch {
            }
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, 
              typeof(CheckedImageComboBoxEdit), typeof(RepositoryItemCheckedImageComboBoxEdit),
              typeof(PopupContainerEditViewInfo), new CheckedImageComboBoxEditPainter(), true, img));
        }

        string imageMember;

        [DefaultValue(""), TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"),
        Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor))]
        public string ImageMember {
            get { return imageMember; }
            set {
                if(imageMember != value)
                    imageMember = value;
            }
        }

        bool showImagesInEditBox = false;

        [DefaultValue(false)]
        public bool ShowImagesInEditBox {
            get { return showImagesInEditBox; }
            set {
                if(showImagesInEditBox != value)
                    showImagesInEditBox = value;
            }
        }

        internal Image GetItemImage(int index){
            object imageValue = DataAdapter.GetRowValue(index, ImageMember);
            if(imageValue is Image)
                return new Bitmap((Image)imageValue, 
                    RepositoryItemCheckedImageComboBoxEdit.ImageWidth, RepositoryItemCheckedImageComboBoxEdit.ImageHeight);
            if(imageValue is byte[])
                return new Bitmap(ConvertToImage(imageValue as byte[]), 
                    RepositoryItemCheckedImageComboBoxEdit.ImageWidth, RepositoryItemCheckedImageComboBoxEdit.ImageHeight);
            return null;
        }

        Image ConvertToImage(byte[] array) {
            using(MemoryStream str = new MemoryStream(array))
                return Image.FromStream(str);
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate(); 
            try {
                base.Assign(item);
                RepositoryItemCheckedImageComboBoxEdit source = item as RepositoryItemCheckedImageComboBoxEdit;
                if(source == null) return;
                imageMember = source.ImageMember;
                showImagesInEditBox = source.ShowImagesInEditBox;
            }
            finally {
                EndUpdate();
            }
        }

        internal bool CanShowImageInDropDown {
            get {
                return IsBoundMode && ImageMember != null && !ImageMember.Equals(string.Empty);
            }
        }

        internal bool CanShowImageInEditBox {
            get {
                return CanShowImageInDropDown && ShowImagesInEditBox;
            }
        }
    }
}


