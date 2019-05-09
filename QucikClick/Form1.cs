using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace QucikClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adexplorer_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Tools\\ADExplorer.exe");
        }

        private void cmd_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void SAMS_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\MS\\SAMS\\SvcActMnt.exe");
        }

        private void SCOM_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files\\System Center 2012\\Operations Manager\\Console\\Microsoft.EnterpriseManagement.Monitoring.Console.exe");
        }

        private void SSMS_Click(object sender, EventArgs e)
        {
            Process.Start("ssms");
        }

        private void BlankIE_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files\\Internet Explorer\\iexplore.exe");
        }

        private void VS2012_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\Common7\\IDE\\devenv.exe");
        }

        private void PS_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Microsoft Product Studio\\ps.exe");
        }

        private void RDP_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc");
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.Focus();
        }

        private void MyVip_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\myvips.url");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false; 
        }

        private void VS2013_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE\\devenv.exe");
        }

        private void VSTeamSite_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\VSTFTeamSite.url");
        }

        private void VSPerf_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\VSTFPerformance.url");
        }

        private void VSNoti_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\VSTFNotification.url");
        }

        private void VSTFNew_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\NewVSTFRequest.url");
        }

        private void IDWEB_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\IDWEB.url");
        }

        private void SDAdminExp_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\SDAdminExplorer\\SDAdmExp.exe");
        }

        private void SDTeam_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\SD_Team_Site.url");
        }

        private void SDAdminSite_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\BGITSDADMIN.url");
        }

        private void SDME_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\SD_ME.url");
        }

        private void SDPerf_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\SDPerformance.url");
        }

        private void PSTeam_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\PSTeamSite.url");
        }

        private void PSNoti_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\PSNotification.url");
        }

        private void VSAlert_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Favorites\\VSTF-SuspendAlert.url");
        }

        private void PowerShell_Click(object sender, EventArgs e)
        {
            Process.Start("PowerShell");
        }

        private void PowerShell_ISE_Click(object sender, EventArgs e)
        {
            Process.Start("PowerShell_ISE");
        }

    }
}
