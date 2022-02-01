using MetroFramework.Forms;
using OMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMS
{
    public partial class Registration : MetroForm
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void frmreg_txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmreg_btnEnter_Click(object sender, EventArgs e)
        {
            string code = frmreg_txtCode.Text;
            bool status = dbOperations.verifyCode(code);

            if (status)
            {
                new frm_Login().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Invalid license code.\nContact your service provider");
            }
        }
    }
}
