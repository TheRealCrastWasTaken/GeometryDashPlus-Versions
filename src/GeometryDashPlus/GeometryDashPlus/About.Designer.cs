namespace GeometryDashPlus
{
    partial class About
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
            this.aboutTitle = new System.Windows.Forms.Label();
            this.aboutDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutTitle
            // 
            this.aboutTitle.AutoSize = true;
            this.aboutTitle.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTitle.ForeColor = System.Drawing.Color.White;
            this.aboutTitle.Location = new System.Drawing.Point(349, 27);
            this.aboutTitle.Name = "aboutTitle";
            this.aboutTitle.Size = new System.Drawing.Size(235, 84);
            this.aboutTitle.TabIndex = 0;
            this.aboutTitle.Text = "About";
            // 
            // aboutDescription
            // 
            this.aboutDescription.AutoSize = true;
            this.aboutDescription.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutDescription.ForeColor = System.Drawing.Color.White;
            this.aboutDescription.Location = new System.Drawing.Point(151, 129);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(636, 28);
            this.aboutDescription.TabIndex = 1;
            this.aboutDescription.Text = "GD+ is a free-to-use product made by Team K&K ZX.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.Controls.Add(this.aboutDescription);
            this.Controls.Add(this.aboutTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutTitle;
        private System.Windows.Forms.Label aboutDescription;
    }
}