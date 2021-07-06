namespace GeometryDashPlus
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.GDPTitle = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.developerToolsButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.discoverTab = new System.Windows.Forms.Button();
            this.savedAddonsButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GDPTitle
            // 
            this.GDPTitle.AutoSize = true;
            this.GDPTitle.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDPTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.GDPTitle.Location = new System.Drawing.Point(3, 9);
            this.GDPTitle.Name = "GDPTitle";
            this.GDPTitle.Size = new System.Drawing.Size(110, 48);
            this.GDPTitle.TabIndex = 0;
            this.GDPTitle.Text = "GD+";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(66)))));
            this.panelSideMenu.Controls.Add(this.closeButton);
            this.panelSideMenu.Controls.Add(this.settingsPanel);
            this.panelSideMenu.Controls.Add(this.settingsButton);
            this.panelSideMenu.Controls.Add(this.discoverTab);
            this.panelSideMenu.Controls.Add(this.savedAddonsButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(330, 720);
            this.panelSideMenu.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(0, 418);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.closeButton.Size = new System.Drawing.Size(330, 67);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(100)))));
            this.settingsPanel.Controls.Add(this.aboutButton);
            this.settingsPanel.Controls.Add(this.developerToolsButton);
            this.settingsPanel.Controls.Add(this.updateButton);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(0, 268);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(330, 150);
            this.settingsPanel.TabIndex = 4;
            // 
            // aboutButton
            // 
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Location = new System.Drawing.Point(0, 100);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.aboutButton.Size = new System.Drawing.Size(330, 50);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // developerToolsButton
            // 
            this.developerToolsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.developerToolsButton.FlatAppearance.BorderSize = 0;
            this.developerToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.developerToolsButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerToolsButton.ForeColor = System.Drawing.Color.White;
            this.developerToolsButton.Location = new System.Drawing.Point(0, 50);
            this.developerToolsButton.Name = "developerToolsButton";
            this.developerToolsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.developerToolsButton.Size = new System.Drawing.Size(330, 50);
            this.developerToolsButton.TabIndex = 1;
            this.developerToolsButton.Text = "Developer Tools";
            this.developerToolsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.developerToolsButton.UseVisualStyleBackColor = true;
            this.developerToolsButton.Click += new System.EventHandler(this.DeveloperToolsButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(0, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.updateButton.Size = new System.Drawing.Size(330, 50);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(0, 201);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(330, 67);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // discoverTab
            // 
            this.discoverTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.discoverTab.FlatAppearance.BorderSize = 0;
            this.discoverTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discoverTab.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discoverTab.ForeColor = System.Drawing.Color.White;
            this.discoverTab.Location = new System.Drawing.Point(0, 134);
            this.discoverTab.Name = "discoverTab";
            this.discoverTab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.discoverTab.Size = new System.Drawing.Size(330, 67);
            this.discoverTab.TabIndex = 2;
            this.discoverTab.Text = "Discover";
            this.discoverTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discoverTab.UseVisualStyleBackColor = true;
            this.discoverTab.Click += new System.EventHandler(this.DiscoverTab_Click);
            // 
            // savedAddonsButton
            // 
            this.savedAddonsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.savedAddonsButton.FlatAppearance.BorderSize = 0;
            this.savedAddonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedAddonsButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedAddonsButton.ForeColor = System.Drawing.Color.White;
            this.savedAddonsButton.Location = new System.Drawing.Point(0, 67);
            this.savedAddonsButton.Name = "savedAddonsButton";
            this.savedAddonsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.savedAddonsButton.Size = new System.Drawing.Size(330, 67);
            this.savedAddonsButton.TabIndex = 1;
            this.savedAddonsButton.Text = "Saved Addons";
            this.savedAddonsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savedAddonsButton.UseVisualStyleBackColor = true;
            this.savedAddonsButton.Click += new System.EventHandler(this.SavedAddonsButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.GDPTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(330, 67);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "v2.1.2";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(330, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(950, 720);
            this.panelChildForm.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Geometry Dash Plus";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GDPTitle;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button developerToolsButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button discoverTab;
        private System.Windows.Forms.Button savedAddonsButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
    }
}

