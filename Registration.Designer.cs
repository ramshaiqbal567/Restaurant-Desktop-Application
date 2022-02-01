
namespace OMS
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frmreg_txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmreg_btnEnter = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 420);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.frmreg_btnEnter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.frmreg_txtCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 420);
            this.panel2.TabIndex = 1;
            // 
            // frmreg_txtCode
            // 
            this.frmreg_txtCode.Font = new System.Drawing.Font("Tahoma", 18F);
            this.frmreg_txtCode.Location = new System.Drawing.Point(56, 196);
            this.frmreg_txtCode.Name = "frmreg_txtCode";
            this.frmreg_txtCode.Size = new System.Drawing.Size(271, 36);
            this.frmreg_txtCode.TabIndex = 0;
            this.frmreg_txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmreg_txtCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(51, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter License Code";
            // 
            // frmreg_btnEnter
            // 
            this.frmreg_btnEnter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.frmreg_btnEnter.Location = new System.Drawing.Point(86, 266);
            this.frmreg_btnEnter.Name = "frmreg_btnEnter";
            this.frmreg_btnEnter.Size = new System.Drawing.Size(200, 40);
            this.frmreg_btnEnter.TabIndex = 2;
            this.frmreg_btnEnter.Text = "Enter";
            this.frmreg_btnEnter.UseSelectable = true;
            this.frmreg_btnEnter.Click += new System.EventHandler(this.frmreg_btnEnter_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton frmreg_btnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frmreg_txtCode;
    }
}

