using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GeometryDashPlus
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            HideSubMenus();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            //this.Text = String.Empty;

            Dictionary<string, string> versionInfo = GetLatestVersion();

            if (versionInfo["latest_version"] != "2.1.2")
            {
                DialogResult result = MessageBox.Show("Update " + versionInfo["latest_version"] + " is available. Update now?", "GD+ Update", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Process.Start(versionInfo["latest_version_link"]);
                }
            }
        }

        private void HideSubMenus()
        {
            settingsPanel.Visible = false;
        }

        private void ToggleSettingsSubMenu() {
            settingsPanel.Visible = !settingsPanel.Visible;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ToggleSettingsSubMenu();
        }

        private void SavedAddonsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SavedAddons());
            HideSubMenus();
        }

        private void DiscoverTab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ComingSoon());
            HideSubMenus();
        }

        #region SettingsSubMenu;

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            HideSubMenus();

            Dictionary<string, string> versionInfo = GetLatestVersion();

            if (versionInfo["latest_version"] != "2.1.2")
            {
                Process.Start(versionInfo["latest_version_link"]);
            }
            else
            {
                MessageBox.Show("You are already up to date!", "GD+ Notification", MessageBoxButtons.OK);
            }
        }

        private void DeveloperToolsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ComingSoon());
            HideSubMenus();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new About());
            HideSubMenus();
        }

        #endregion

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if(activeForm == childForm)
                activeForm.Close();
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;

                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Dictionary<string, string> GetLatestVersion()
        {
            WebClient webClient = new WebClient();
            string postLink = "/raw/AHe6zSK2";
            string preLink = "://pastebin.";
            string link = "https" + preLink + "com" + postLink;

            string versionInfoRaw = webClient.DownloadString(link);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            var versionInfoData = jss.Deserialize<Dictionary<string, string>>(versionInfoRaw);

            return versionInfoData;
        }
    }
}
