
namespace RandevuYonetimSistemi.WindowsFormsUI
{
    partial class RandevuYonetimi
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
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHastalar = new System.Windows.Forms.ComboBox();
            this.cbDoktorlar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.RichTextBox();
            this.cbKronikHastalik = new System.Windows.Forms.CheckBox();
            this.cbSgk = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Location = new System.Drawing.Point(12, 12);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.RowHeadersWidth = 51;
            this.dgvRandevular.RowTemplate.Height = 24;
            this.dgvRandevular.Size = new System.Drawing.Size(776, 220);
            this.dgvRandevular.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbSgk);
            this.groupBox1.Controls.Add(this.cbKronikHastalik);
            this.groupBox1.Controls.Add(this.txtSikayet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpRandevuTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDoktorlar);
            this.groupBox1.Controls.Add(this.cbHastalar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor";
            // 
            // cbHastalar
            // 
            this.cbHastalar.FormattingEnabled = true;
            this.cbHastalar.Location = new System.Drawing.Point(135, 40);
            this.cbHastalar.Name = "cbHastalar";
            this.cbHastalar.Size = new System.Drawing.Size(121, 24);
            this.cbHastalar.TabIndex = 3;
            // 
            // cbDoktorlar
            // 
            this.cbDoktorlar.FormattingEnabled = true;
            this.cbDoktorlar.Location = new System.Drawing.Point(135, 70);
            this.cbDoktorlar.Name = "cbDoktorlar";
            this.cbDoktorlar.Size = new System.Drawing.Size(121, 24);
            this.cbDoktorlar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Randevu Tarihi";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(513, 35);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpRandevuTarihi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şikayet";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(513, 73);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(200, 46);
            this.txtSikayet.TabIndex = 8;
            this.txtSikayet.Text = "";
            // 
            // cbKronikHastalik
            // 
            this.cbKronikHastalik.AutoSize = true;
            this.cbKronikHastalik.Location = new System.Drawing.Point(135, 101);
            this.cbKronikHastalik.Name = "cbKronikHastalik";
            this.cbKronikHastalik.Size = new System.Drawing.Size(132, 21);
            this.cbKronikHastalik.TabIndex = 9;
            this.cbKronikHastalik.Text = "Kronik Hastalık?";
            this.cbKronikHastalik.UseVisualStyleBackColor = true;
            // 
            // cbSgk
            // 
            this.cbSgk.AutoSize = true;
            this.cbSgk.Location = new System.Drawing.Point(135, 129);
            this.cbSgk.Name = "cbSgk";
            this.cbSgk.Size = new System.Drawing.Size(62, 21);
            this.cbSgk.TabIndex = 10;
            this.cbSgk.Text = "Sgk?";
            this.cbSgk.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(457, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(325, 162);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(201, 162);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // RandevuYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRandevular);
            this.Name = "RandevuYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDoktorlar;
        private System.Windows.Forms.ComboBox cbHastalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSikayet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbKronikHastalik;
        private System.Windows.Forms.CheckBox cbSgk;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}