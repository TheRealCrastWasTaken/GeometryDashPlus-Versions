namespace GeometryDashPlus
{
    partial class ComingSoon
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
            this.comingSoonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comingSoonLabel
            // 
            this.comingSoonLabel.AutoSize = true;
            this.comingSoonLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingSoonLabel.ForeColor = System.Drawing.Color.White;
            this.comingSoonLabel.Location = new System.Drawing.Point(308, 320);
            this.comingSoonLabel.Name = "comingSoonLabel";
            this.comingSoonLabel.Size = new System.Drawing.Size(336, 56);
            this.comingSoonLabel.TabIndex = 0;
            this.comingSoonLabel.Text = "Coming Soon!";
            // 
            // ComingSoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.Controls.Add(this.comingSoonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComingSoon";
            this.Text = "ComingSoon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comingSoonLabel;
    }
}