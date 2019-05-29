Imports DevExpress.XtraEditors
Imports System
Imports System.Data
Imports System.Drawing


Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function GetCategoriesDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Categories"
            table.Columns.Add(New DataColumn("CategoryID", GetType(Integer)))
            table.Columns.Add(New DataColumn("CategoryName", GetType(String)))
            table.Columns.Add(New DataColumn("Picture", GetType(Image)))
            Dim random As Random = New Random()

            For i As Integer = 0 To 20 - 1
                Dim index As Integer = i + 1
                Dim image As Image = Resources.about_32x32
                If random.[Next](0, 2) = 0 Then image = Resources.convert_32x32
                table.Rows.Add(index, "Category " & index, image)
            Next

            Return table
        End Function

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            categoriesBindingSource.DataSource = GetCategoriesDataTable()
        End Sub
    End Class
End Namespace
