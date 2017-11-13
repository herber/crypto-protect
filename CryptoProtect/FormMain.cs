using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CryptoProtect
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void lnk_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/herber/cryptoprotect");
            Process.Start(sInfo);
        }

        private void btn_Install_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (chk_BadRabbit.Checked)
                {
                    Protect.BadRabbitInstall();
                    stat_lbl_main.Text = "Installed!";
                }

                if (chk_Petya.Checked)
                {
                    Protect.PetyaInstall();
                    stat_lbl_main.Text = "Installed!";
                }
            }
            catch (Exception err)
            {
                stat_lbl_main.Text = "Error";
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Uninstall_Click(object sender, EventArgs e)
        {
            try
            {
                if (chk_BadRabbit.Checked)
                {
                    Protect.BadRabbitUninstall();
                    stat_lbl_main.Text = "Uninstalled!";
                }

                if (chk_Petya.Checked)
                {
                    Protect.PetyaUninstall();
                    stat_lbl_main.Text = "Uninstalled!";
                }
            }
            catch (Exception err)
            {
                stat_lbl_main.Text = "Error";
                MessageBox.Show(err.Message);
            }
        }
    }
}
