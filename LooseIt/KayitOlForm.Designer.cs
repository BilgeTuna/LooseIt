
namespace LooseIt
{
    partial class KayitOlForm
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
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCinsiyet = new System.Windows.Forms.ComboBox();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.nudKilogram = new System.Windows.Forms.NumericUpDown();
            this.nudBoy = new System.Windows.Forms.NumericUpDown();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cboEgzersizDurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnGeriDon.Location = new System.Drawing.Point(12, 797);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(227, 42);
            this.btnGeriDon.TabIndex = 5;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCinsiyet);
            this.groupBox1.Controls.Add(this.nudYas);
            this.groupBox1.Controls.Add(this.nudKilogram);
            this.groupBox1.Controls.Add(this.nudBoy);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.cboEgzersizDurum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 779);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // cboCinsiyet
            // 
            this.cboCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinsiyet.FormattingEnabled = true;
            this.cboCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "LGBT+"});
            this.cboCinsiyet.Location = new System.Drawing.Point(243, 464);
            this.cboCinsiyet.Name = "cboCinsiyet";
            this.cboCinsiyet.Size = new System.Drawing.Size(232, 28);
            this.cboCinsiyet.TabIndex = 10;
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(243, 410);
            this.nudYas.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(232, 26);
            this.nudYas.TabIndex = 9;
            this.nudYas.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudKilogram
            // 
            this.nudKilogram.Location = new System.Drawing.Point(243, 347);
            this.nudKilogram.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudKilogram.Name = "nudKilogram";
            this.nudKilogram.Size = new System.Drawing.Size(232, 26);
            this.nudKilogram.TabIndex = 8;
            this.nudKilogram.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // nudBoy
            // 
            this.nudBoy.Location = new System.Drawing.Point(243, 285);
            this.nudBoy.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudBoy.Name = "nudBoy";
            this.nudBoy.Size = new System.Drawing.Size(232, 26);
            this.nudBoy.TabIndex = 7;
            this.nudBoy.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(24, 668);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(476, 40);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(24, 622);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(476, 40);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(24, 714);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(476, 40);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cboEgzersizDurum
            // 
            this.cboEgzersizDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEgzersizDurum.FormattingEnabled = true;
            this.cboEgzersizDurum.Items.AddRange(new object[] {
            "yoğun",
            "hafif",
            "yok"});
            this.cboEgzersizDurum.Location = new System.Drawing.Point(243, 569);
            this.cboEgzersizDurum.Name = "cboEgzersizDurum";
            this.cboEgzersizDurum.Size = new System.Drawing.Size(232, 28);
            this.cboEgzersizDurum.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 569);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Egzersiz Durum :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cinsiyet :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(243, 223);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(232, 26);
            this.txtSoyad.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(243, 162);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(232, 26);
            this.txtAd.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(243, 97);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(232, 26);
            this.txtSifre.TabIndex = 0;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(243, 43);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(232, 26);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yaş :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kilo(kg) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Boy(cm) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail Adresi:";
            // 
            // KayitOlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(578, 848);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "KayitOlForm";
            this.Text = "KayitOlForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCinsiyet;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.NumericUpDown nudKilogram;
        private System.Windows.Forms.NumericUpDown nudBoy;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cboEgzersizDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}