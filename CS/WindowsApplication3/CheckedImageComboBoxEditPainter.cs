using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Text;


namespace DXSample {

    public class CheckedImageComboBoxEditPainter: ButtonEditPainter {
        public CheckedImageComboBoxEditPainter() : base() { }

        protected override void DrawString(ControlGraphicsInfoArgs info, Rectangle bounds, string text, DevExpress.Utils.AppearanceObject appearance) {
            PopupContainerEditViewInfo viewInfo = info.ViewInfo as PopupContainerEditViewInfo;
            RepositoryItemCheckedImageComboBoxEdit edit = viewInfo.Item as RepositoryItemCheckedImageComboBoxEdit;
            if(!edit.CanShowImageInEditBox)
                base.DrawString(info, bounds, text, appearance);
            else 
                DrawContent(info, bounds, text, appearance);
        }

        private void DrawContent(ControlGraphicsInfoArgs info, Rectangle bounds, string text, DevExpress.Utils.AppearanceObject appearance) {
            PopupContainerEditViewInfo viewInfo = info.ViewInfo as PopupContainerEditViewInfo;
            RepositoryItemCheckedImageComboBoxEdit edit = viewInfo.Item as RepositoryItemCheckedImageComboBoxEdit;
            string[] values = text.Split(edit.SeparatorChar);
            Rectangle valRect = new Rectangle(bounds.X, bounds.Y, 0, bounds.Height);
            foreach(string val in values) {
                int index = GetIndexByDescription(edit.GetItems(), val.Trim());
                if(index != -1) {
                    DrawImage(edit, info.Graphics, index, ref valRect);
                   
                }
                string str = val;
                if(Array.IndexOf(values, val) < values.Length - 1)
                    str = string.Concat(val, edit.SeparatorChar);
                DrawString(info, appearance, ref valRect, str);
            }
        }

        private void DrawString(ControlGraphicsInfoArgs info, DevExpress.Utils.AppearanceObject appearance, 
            ref Rectangle valRect, string str) {
            int width = TextUtils.GetStringSize(info.Graphics, str, appearance.Font).Width;
            valRect.Width = width;
            base.DrawString(info, valRect, str, appearance);
            valRect.X += width;
        }

        private void DrawImage(RepositoryItemCheckedImageComboBoxEdit edit, Graphics gr, int index, ref Rectangle valRect) {
            Image image = edit.GetItemImage(index);
            Rectangle rect = new Rectangle(valRect.X, valRect.Y, RepositoryItemCheckedImageComboBoxEdit.ImageWidth,
                RepositoryItemCheckedImageComboBoxEdit.ImageHeight);
            if(image != null) {
                gr.DrawImage(image, rect);
                valRect.X += RepositoryItemCheckedImageComboBoxEdit.ImageWidth + 2;
            }
        }

        int GetIndexByDescription(CheckedListBoxItemCollection collection, string description) {
            for(int i = 0;i < collection.Count;i++) {
                if(collection[i].Description.Equals(description))
                    return i;
            }
            return -1;
        }
    }
}


