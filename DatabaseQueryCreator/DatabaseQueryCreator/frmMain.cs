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
    public partial class frmMain : Form
    {

        public frmCreate _Create = new frmCreate();
        
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _Create.Show();
            //Hide();
        }
    }
}
