using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Reflection;

namespace GeometryDashPlus
{
    public partial class SavedAddons : Form
    {
        public SavedAddons()
        {
            InitializeComponent();

            RefreshAddons();

            Console.WriteLine(Assembly.GetExecutingAssembly().Location);
        }

        private string selectedAddon = null;
        private readonly string exeUrl = Assembly.GetExecutingAssembly().Location;

        private void RefreshAddons()
        {
            selectedAddon = null;

            addonsList.Controls.Clear();

            //string[] addons = Directory.GetDirectories(@"C:\GeometryDashPlus\Addons\");
            string[] addons = Directory.GetDirectories(exeUrl + @"\..\..\Addons\");

            foreach (string addonDir in addons)
            {
                string addonsUrl = exeUrl + @"\..\..\Addons\";
                string addonName = addonDir.Substring(addonsUrl.Length);
                CreateAddonButton(addonName);
                Console.WriteLine(addonName);
            }
        }

        private void AddonButtonPressHandler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (selectedAddon != btn.Text)
            {
                selectedAddon = btn.Text;
                selectedAddonLabel.Text = selectedAddon;
            } else
            {
                selectedAddon = null;
                selectedAddonLabel.Text = "-";
            }
        }

        private async void LoadAddon()
        {
            //CopyFilesRecursively(@"C:\GeometryDashPlus\Addons\" + selectedAddon, @"E:\Steam Develop\steamapps\common\Geometry Dash\Resources\");
            await Task.Run(() => CopyFilesRecursively(exeUrl + @"\..\..\Addons\" + selectedAddon, exeUrl + @"\..\..\..\"));
        }

        private static async void CopyFilesRecursively(string sourcePath, string targetPath)
        { 
            await Task.Run(() =>
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourcePath, " * ", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
            });
        }

        private Button CreateAddonButton(string addonName)
        {
            Button myButton = new Button()
            {
                Text = addonName,
                BackColor = Color.FromArgb(15, 15, 66),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Consolas", 12),
                ForeColor = Color.FromArgb(255, 255, 255),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Size = new Size(881, 50),
                Padding = new Padding(35, 0, 0, 0)
        };

            myButton.Click += AddonButtonPressHandler;
            addonsList.Controls.Add(myButton);

            return myButton;
        }

        private void ActivateAddonButton_Click(object sender, EventArgs e)
        {
            activateAddonButton.Text = "Activating...";
            if (selectedAddon is string)
            {
                LoadAddon();
                MessageBox.Show("Addon loaded successfully!", "GD+ Notification", MessageBoxButtons.OK);
            }
            activateAddonButton.Text = "Activate";
        }

        private void RemoveAddonButton_Click(object sender, EventArgs e)
        {
            if (selectedAddon is string)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this addon?", "GD+ Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Directory.Delete(@"C:\GeometryDashPlus\Addons\" + selectedAddon, true);
                    Directory.Delete(exeUrl + @"\..\..\Addons\" + selectedAddon, true);
                    RefreshAddons();
                }
            }
        }

        private void RenameAddonButton_Click(object sender, EventArgs e)
        {
            if (selectedAddon is string) {
                string newAddonName = Interaction.InputBox("What will this addon's new name be?", "GD+ Input");
                //Directory.Move(@"C:\GeometryDashPlus\Addons\" + selectedAddon, @"C:\GeometryDashPlus\Addons\" + newAddonName);
                Directory.Move(exeUrl + @"\..\..\Addons\" + selectedAddon, exeUrl + @"\..\..\Addons\" + newAddonName);

                selectedAddon = newAddonName;
                selectedAddonLabel.Text = newAddonName;

                RefreshAddons();
            }
        }

        private void ExplorerAddonButton_Click(object sender, EventArgs e)
        {
            if (selectedAddon is string)
            {
                //Process.Start(@"C:\GeometryDashPlus\Addons\" + selectedAddon);
                Process.Start(exeUrl + @"\..\..\Addons\" + selectedAddon);
            }
        }

        private void RefreshAddonsButton_Click(object sender, EventArgs e)
        {
            selectedAddon = null;
            selectedAddonLabel.Text = "-";

            RefreshAddons();
        }
    }
}
