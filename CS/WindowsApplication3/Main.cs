using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;


namespace DXSample
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        DataTable GetCategoriesDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Categories";
            table.Columns.Add(new DataColumn("CategoryID", typeof(int)));
            table.Columns.Add(new DataColumn("CategoryName", typeof(string)));
            table.Columns.Add(new DataColumn("Picture", typeof(Image)));
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                int index = i + 1;
                Image image = DXSample.Properties.Resources.about_32x32;
                if(random.Next(0, 2) == 0) image = DXSample.Properties.Resources.convert_32x32;
                table.Rows.Add(index, "Category " + index, image);
            }
            return table;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            categoriesBindingSource.DataSource = GetCategoriesDataTable();
        }
    }
}
