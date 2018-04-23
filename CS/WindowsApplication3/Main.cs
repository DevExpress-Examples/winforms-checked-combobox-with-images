using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
      

        private void OnFormLoad(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet1.Categories);
        }
    }
}
