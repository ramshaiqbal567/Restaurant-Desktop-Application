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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            panel2.Visible = false;
            panel11.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Visible = true;
        }

        private void Dashboard_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            //panel2.Visible = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel3.Show();
            panel4.Hide();
            panel6.Hide();
            panel5.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Show();
            panel6.Hide();
            panel5.Hide();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Hide();
            panel6.Show();
            panel5.Hide();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Hide();
            panel6.Hide();
            panel5.Show();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Hide();
            panel4.Hide();
            panel6.Hide();
            panel5.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.v4usolutionspk.com");
        }
        
        Order_New_Items myForm = new Order_New_Items();
        Edit_Products myEditForm = new Edit_Products();
        Restock_Items myRestockForm = new Restock_Items();
        private void pictureBox1_Click(object sender, EventArgs e)
        {    
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel11.Controls.Add(myForm);
            panel11.Show();

            myRestockForm.Hide();
            myEditForm.Hide();
            myForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            myEditForm.TopLevel = false;
            myEditForm.AutoScroll = true;
            this.panel11.Controls.Add(myEditForm);
            panel11.Show();

            myForm.Hide();
            myRestockForm.Hide();
            myEditForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            myRestockForm.TopLevel = false;
            myRestockForm.AutoScroll = true;
            this.panel11.Controls.Add(myRestockForm);
            panel11.Show();

            myForm.Hide();
            myEditForm.Hide();
            myRestockForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
