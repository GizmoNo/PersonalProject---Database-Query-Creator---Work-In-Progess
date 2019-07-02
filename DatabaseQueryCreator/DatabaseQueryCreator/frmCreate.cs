using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseQueryCreator
{
    public partial class frmCreate : Form
    {
        //private Dictionary<string, frmCreate> DataTypes = new Dictionary<string, frmCreate>();
        


        public frmCreate()
        {
            InitializeComponent();
            cboField1.DataSource = cboDataSorce.DataTypes;
            cboField2.DataSource = cboDataSorce.DataTypes;
            cboField3.DataSource = cboDataSorce.DataTypes;
            //foreach(ComboBox CB in this.Controls.OfType<ComboBox>())
            //{
            //    CB.DataSource = cboDataSorce.DataTypes;
            //}

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            
        }
    }
}
