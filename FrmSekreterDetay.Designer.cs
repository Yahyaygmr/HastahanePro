namespace HastahanePro
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTcNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDuyuruOlustur = new System.Windows.Forms.Button();
            this.RTxtDuyuruOlustur = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuGuncelle = new System.Windows.Forms.Button();
            this.MTxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MTxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.MTxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtRandevuId = new System.Windows.Forms.TextBox();
            this.CheckDurum = new System.Windows.Forms.CheckBox();
            this.BtnRandevuKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgwBranslar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DgwDoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnBransPaneli = new System.Windows.Forms.Button();
            this.BtnRandevuListe = new System.Windows.Forms.Button();
            this.BtnDoktorPaneli = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwBranslar)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwDoktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTcNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(138, 104);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(203, 29);
            this.LblAdSoyad.TabIndex = 15;
            this.LblAdSoyad.Text = "Deneme Deneme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ad Soyad :";
            // 
            // LblTcNo
            // 
            this.LblTcNo.AutoSize = true;
            this.LblTcNo.Location = new System.Drawing.Point(138, 48);
            this.LblTcNo.Name = "LblTcNo";
            this.LblTcNo.Size = new System.Drawing.Size(156, 29);
            this.LblTcNo.TabIndex = 13;
            this.LblTcNo.Text = "12345678901";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tc No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.RTxtDuyuruOlustur);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnDuyuruOlustur
            // 
            this.BtnDuyuruOlustur.Location = new System.Drawing.Point(18, 240);
            this.BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            this.BtnDuyuruOlustur.Size = new System.Drawing.Size(376, 52);
            this.BtnDuyuruOlustur.TabIndex = 1;
            this.BtnDuyuruOlustur.Text = "Oluştur";
            this.BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.BtnDuyuruOlustur.Click += new System.EventHandler(this.BtnDuyuruOlustur_Click);
            // 
            // RTxtDuyuruOlustur
            // 
            this.RTxtDuyuruOlustur.Location = new System.Drawing.Point(18, 34);
            this.RTxtDuyuruOlustur.Name = "RTxtDuyuruOlustur";
            this.RTxtDuyuruOlustur.Size = new System.Drawing.Size(376, 188);
            this.RTxtDuyuruOlustur.TabIndex = 0;
            this.RTxtDuyuruOlustur.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnRandevuGuncelle);
            this.groupBox3.Controls.Add(this.MTxtTcNo);
            this.groupBox3.Controls.Add(this.CmbDoktor);
            this.groupBox3.Controls.Add(this.CmbBrans);
            this.groupBox3.Controls.Add(this.MTxtSaat);
            this.groupBox3.Controls.Add(this.MTxtTarih);
            this.groupBox3.Controls.Add(this.TxtRandevuId);
            this.groupBox3.Controls.Add(this.CheckDurum);
            this.groupBox3.Controls.Add(this.BtnRandevuKaydet);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(436, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 474);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // BtnRandevuGuncelle
            // 
            this.BtnRandevuGuncelle.Location = new System.Drawing.Point(215, 416);
            this.BtnRandevuGuncelle.Name = "BtnRandevuGuncelle";
            this.BtnRandevuGuncelle.Size = new System.Drawing.Size(174, 52);
            this.BtnRandevuGuncelle.TabIndex = 33;
            this.BtnRandevuGuncelle.Text = "Güncelle";
            this.BtnRandevuGuncelle.UseVisualStyleBackColor = true;
            // 
            // MTxtTcNo
            // 
            this.MTxtTcNo.Location = new System.Drawing.Point(108, 311);
            this.MTxtTcNo.Mask = "00000000000";
            this.MTxtTcNo.Name = "MTxtTcNo";
            this.MTxtTcNo.Size = new System.Drawing.Size(227, 34);
            this.MTxtTcNo.TabIndex = 32;
            this.MTxtTcNo.ValidatingType = typeof(int);
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(108, 256);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(227, 37);
            this.CmbDoktor.TabIndex = 31;
            this.CmbDoktor.Text = "Seçiniz";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(108, 202);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(227, 37);
            this.CmbBrans.TabIndex = 30;
            this.CmbBrans.Text = "Seçiniz";
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MTxtSaat
            // 
            this.MTxtSaat.Location = new System.Drawing.Point(108, 148);
            this.MTxtSaat.Mask = "00:00";
            this.MTxtSaat.Name = "MTxtSaat";
            this.MTxtSaat.Size = new System.Drawing.Size(227, 34);
            this.MTxtSaat.TabIndex = 29;
            this.MTxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MTxtTarih
            // 
            this.MTxtTarih.Location = new System.Drawing.Point(108, 100);
            this.MTxtTarih.Mask = "00/00/0000";
            this.MTxtTarih.Name = "MTxtTarih";
            this.MTxtTarih.Size = new System.Drawing.Size(227, 34);
            this.MTxtTarih.TabIndex = 28;
            this.MTxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtRandevuId
            // 
            this.TxtRandevuId.Location = new System.Drawing.Point(108, 51);
            this.TxtRandevuId.Name = "TxtRandevuId";
            this.TxtRandevuId.Size = new System.Drawing.Size(227, 34);
            this.TxtRandevuId.TabIndex = 27;
            // 
            // CheckDurum
            // 
            this.CheckDurum.AutoSize = true;
            this.CheckDurum.Location = new System.Drawing.Point(148, 366);
            this.CheckDurum.Name = "CheckDurum";
            this.CheckDurum.Size = new System.Drawing.Size(106, 33);
            this.CheckDurum.TabIndex = 26;
            this.CheckDurum.Text = "Durum";
            this.CheckDurum.UseVisualStyleBackColor = true;
            // 
            // BtnRandevuKaydet
            // 
            this.BtnRandevuKaydet.Location = new System.Drawing.Point(6, 416);
            this.BtnRandevuKaydet.Name = "BtnRandevuKaydet";
            this.BtnRandevuKaydet.Size = new System.Drawing.Size(174, 52);
            this.BtnRandevuKaydet.TabIndex = 25;
            this.BtnRandevuKaydet.Text = "Kaydet";
            this.BtnRandevuKaydet.UseVisualStyleBackColor = true;
            this.BtnRandevuKaydet.Click += new System.EventHandler(this.BtnRandevuKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tc No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Doktor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Branş :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Saat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Id :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgwBranslar);
            this.groupBox4.Location = new System.Drawing.Point(838, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 332);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // DgwBranslar
            // 
            this.DgwBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgwBranslar.Location = new System.Drawing.Point(3, 30);
            this.DgwBranslar.Name = "DgwBranslar";
            this.DgwBranslar.RowHeadersWidth = 51;
            this.DgwBranslar.RowTemplate.Height = 24;
            this.DgwBranslar.Size = new System.Drawing.Size(474, 299);
            this.DgwBranslar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DgwDoktorlar);
            this.groupBox5.Location = new System.Drawing.Point(841, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 302);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // DgwDoktorlar
            // 
            this.DgwDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgwDoktorlar.Location = new System.Drawing.Point(3, 30);
            this.DgwDoktorlar.Name = "DgwDoktorlar";
            this.DgwDoktorlar.RowHeadersWidth = 51;
            this.DgwDoktorlar.Size = new System.Drawing.Size(474, 269);
            this.DgwDoktorlar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnDuyurular);
            this.groupBox6.Controls.Add(this.BtnBransPaneli);
            this.groupBox6.Controls.Add(this.BtnRandevuListe);
            this.groupBox6.Controls.Add(this.BtnDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(30, 524);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(805, 151);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnBransPaneli
            // 
            this.BtnBransPaneli.Location = new System.Drawing.Point(212, 62);
            this.BtnBransPaneli.Name = "BtnBransPaneli";
            this.BtnBransPaneli.Size = new System.Drawing.Size(178, 52);
            this.BtnBransPaneli.TabIndex = 28;
            this.BtnBransPaneli.Text = "Branş Paneli";
            this.BtnBransPaneli.UseVisualStyleBackColor = true;
            this.BtnBransPaneli.Click += new System.EventHandler(this.BtnBransPaneli_Click);
            // 
            // BtnRandevuListe
            // 
            this.BtnRandevuListe.Location = new System.Drawing.Point(417, 62);
            this.BtnRandevuListe.Name = "BtnRandevuListe";
            this.BtnRandevuListe.Size = new System.Drawing.Size(178, 52);
            this.BtnRandevuListe.TabIndex = 27;
            this.BtnRandevuListe.Text = "Randevu Liste";
            this.BtnRandevuListe.UseVisualStyleBackColor = true;
            this.BtnRandevuListe.Click += new System.EventHandler(this.BtnRandevuListe_Click);
            // 
            // BtnDoktorPaneli
            // 
            this.BtnDoktorPaneli.Location = new System.Drawing.Point(10, 62);
            this.BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            this.BtnDoktorPaneli.Size = new System.Drawing.Size(178, 52);
            this.BtnDoktorPaneli.TabIndex = 26;
            this.BtnDoktorPaneli.Text = "Doktor Paneli";
            this.BtnDoktorPaneli.UseVisualStyleBackColor = true;
            this.BtnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.Location = new System.Drawing.Point(621, 62);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(178, 52);
            this.BtnDuyurular.TabIndex = 29;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = true;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 690);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwBranslar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwDoktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox RTxtDuyuruOlustur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.MaskedTextBox MTxtSaat;
        private System.Windows.Forms.MaskedTextBox MTxtTarih;
        private System.Windows.Forms.TextBox TxtRandevuId;
        private System.Windows.Forms.CheckBox CheckDurum;
        private System.Windows.Forms.Button BtnRandevuKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRandevuGuncelle;
        private System.Windows.Forms.MaskedTextBox MTxtTcNo;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgwBranslar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DgwDoktorlar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnBransPaneli;
        private System.Windows.Forms.Button BtnRandevuListe;
        private System.Windows.Forms.Button BtnDoktorPaneli;
        private System.Windows.Forms.Button BtnDuyurular;
    }
}