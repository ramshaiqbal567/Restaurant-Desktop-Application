using Microsoft.Win32;
using OMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OMSSettings");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {

                    string code = key.GetValue("licensecode").ToString();
                    bool status = dbOperations.getMasterConnection(code);
                    if (!status)
                    {
                        MessageBox.Show("Error establishing connection.\nContact your service provider");
                        Application.Exit();
                    }
                    else
                    {
                        Application.Run(new Dashboard());
                        key.Close();
                    }

                }
                else
                {
                    Application.Run(new Registration());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            Application.Run(new frm_Login());
        }
    }
}
