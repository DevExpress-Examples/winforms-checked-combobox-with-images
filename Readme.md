<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622424/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2804)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Checked ComboBox - Show images in the edit box and drop-down window

In this example, the [CheckedComboBoxEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.CheckedComboBoxEdit) is bound to a data source. The example creates a custom editor (`CheckedImageComboBoxEdit`) that can display images in the edit box and drop-down window.

* To show images in the drop-down window, use the [Properties.ImageMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.BaseImageListBoxControl.ImageMember) property to specify the name of the data field with images (`Image` objects or a byte array).
* Enable the `RepositoryItemCheckedImageComboBoxEdit.ShowImagesInEditBox` option to display images in the edit box.

![WinForms Checked Combobox - Show images in the edit box and dropdown window](https://raw.githubusercontent.com/DevExpress-Examples/winforms-checked-combobox-with-images/13.1.4%2B/media/winforms-checked-combobox-with-images.png)


## Files to Review

* [CheckedImageComboBoxEdit.cs](./CS/WindowsApplication3/CheckedImageComboBoxEdit.cs) (VB: [CheckedImageComboBoxEdit.vb](./VB/WindowsApplication3/CheckedImageComboBoxEdit.vb))
* [CheckedImageComboBoxEditPainter.cs](./CS/WindowsApplication3/CheckedImageComboBoxEditPainter.cs) (VB: [CheckedImageComboBoxEditPainter.vb](./VB/WindowsApplication3/CheckedImageComboBoxEditPainter.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [RepositoryItemCheckedImageComboBoxEdit.cs](./CS/WindowsApplication3/RepositoryItemCheckedImageComboBoxEdit.cs) (VB: [RepositoryItemCheckedImageComboBoxEdit.vb](./VB/WindowsApplication3/RepositoryItemCheckedImageComboBoxEdit.vb))


## Documentation

* [Custom Editors](https://docs.devexpress.com/WindowsForms/4716/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/custom-editors)
