
namespace RandevuYonetimSistemi.WindowsFormsUI
{
    partial class AnaEkran
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doktorYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorYönetimiToolStripMenuItem,
            this.hastaYönetimiToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.randevuYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doktorYönetimiToolStripMenuItem
            // 
            this.doktorYönetimiToolStripMenuItem.Name = "doktorYönetimiToolStripMenuItem";
            this.doktorYönetimiToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.doktorYönetimiToolStripMenuItem.Text = "Doktor Yönetimi";
            this.doktorYönetimiToolStripMenuItem.Click += new System.EventHandler(this.doktorYönetimiToolStripMenuItem_Click);
            // 
            // hastaYönetimiToolStripMenuItem
            // 
            this.hastaYönetimiToolStripMenuItem.Name = "hastaYönetimiToolStripMenuItem";
            this.hastaYönetimiToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.hastaYönetimiToolStripMenuItem.Text = "Hasta Yönetimi";
            this.hastaYönetimiToolStripMenuItem.Click += new System.EventHandler(this.hastaYönetimiToolStripMenuItem_Click);
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            this.kullanıcıYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıYönetimiToolStripMenuItem_Click);
            // 
            // randevuYönetimiToolStripMenuItem
            // 
            this.randevuYönetimiToolStripMenuItem.Name = "randevuYönetimiToolStripMenuItem";
            this.randevuYönetimiToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.randevuYönetimiToolStripMenuItem.Text = "Randevu Yönetimi";
            this.randevuYönetimiToolStripMenuItem.Click += new System.EventHandler(this.randevuYönetimiToolStripMenuItem_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuYönetimiToolStripMenuItem;
    }
}