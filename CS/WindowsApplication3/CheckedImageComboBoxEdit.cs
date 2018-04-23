using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using System.Drawing;
using System.ComponentModel;


namespace DXSample {
    
    public class CheckedImageComboBoxEdit : CheckedComboBoxEdit {
        
        static CheckedImageComboBoxEdit() { RepositoryItemCheckedImageComboBoxEdit.RegisterCheckedImageComboBoxEdit(); }

        public CheckedImageComboBoxEdit() { }

        CheckedListBoxControl listBox = null;

        public override string EditorTypeName { get { return 
            RepositoryItemCheckedImageComboBoxEdit.CustomEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCheckedImageComboBoxEdit Properties {
            get { return base.Properties as RepositoryItemCheckedImageComboBoxEdit; }
        }

        protected override PopupContainerControl CreatePopupCheckListControl() {
            PopupContainerControl ctrl = base.CreatePopupCheckListControl();
            CheckedListBoxControl listBox = GetCheckedListBoxControl(ctrl);
            if(Properties.CanShowImageInDropDown)
                listBox.DrawItem += OnDrawItem;
            return ctrl;
        }

        private CheckedListBoxControl GetCheckedListBoxControl(PopupContainerControl ctrl) {
            foreach(Control c in ctrl.Controls)
                if(c is CheckedListBoxControl)
                    return c as CheckedListBoxControl;
            return null;
        }

        void OnDrawItem(object sender, ListBoxDrawItemEventArgs e) {
            if(e.Index == 0) return;
            listBox = sender as CheckedListBoxControl;
            CheckedListBoxViewInfo viewInfo = listBox.GetViewInfo() as CheckedListBoxViewInfo;
            Image image = Properties.GetItemImage(e.Index - 1);
            if(image == null) return;
            DrawCheckedItem(e, viewInfo, image);
            e.Handled = true;
        }

        private void DrawCheckedItem(ListBoxDrawItemEventArgs e, CheckedListBoxViewInfo viewInfo, Image image) {
            CheckedListBoxViewInfo.CheckedItemInfo itInfo = viewInfo.GetItemByIndex(e.Index);
            FillRectangle(e.Appearance, e.Cache, e.Bounds);
            DrawCheckBox(itInfo.CheckArgs, e.Graphics, viewInfo);
            DrawImage(itInfo.CheckArgs.GlyphRect, e.Graphics, image);
            DrawString(itInfo, e.Appearance, e.Cache);
        }

        private void FillRectangle(AppearanceObject appearance, GraphicsCache cache, Rectangle rect) {
            appearance.FillRectangle(cache, rect);
        }

        private void DrawCheckBox(CheckObjectInfoArgs checkArgs, Graphics gr, CheckedListBoxViewInfo viewInfo) {
            checkArgs.Graphics = gr;
            viewInfo.CheckMarkPainter.DrawObject(checkArgs);
        }

        private void DrawImage(Rectangle rect, Graphics gr, Image image) {
            Point point = new Point(rect.Right + 2, rect.Y);
            gr.DrawImage(image, point);
        }

        private void DrawString(CheckedListBoxViewInfo.CheckedItemInfo itInfo, 
            AppearanceObject appearance, GraphicsCache cache) {
            Rectangle textRect = new Rectangle(itInfo.TextRect.X + RepositoryItemCheckedImageComboBoxEdit.ImageWidth + 2,
                itInfo.TextRect.Y, itInfo.TextRect.Width - RepositoryItemCheckedImageComboBoxEdit.ImageWidth - 2,
                itInfo.TextRect.Height);
            appearance.DrawString(cache, itInfo.Text, textRect);
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(listBox != null)
                    listBox.DrawItem -= OnDrawItem;
            }
            base.Dispose(disposing);
        }
       
    }
}


