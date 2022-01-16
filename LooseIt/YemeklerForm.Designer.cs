
namespace LooseIt
{
    partial class YemeklerForm
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
            this.dgvYemekler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYemekAdi = new System.Windows.Forms.TextBox();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cboOgun = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOgunYemek = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYemekYolu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pboYemekler = new System.Windows.Forms.PictureBox();
            this.btnOgunEkle = new System.Windows.Forms.Button();
            this.btnGunSonuRaporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYemekler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYemekler
            // 
            this.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekler.Location = new System.Drawing.Point(10, 65);
            this.dgvYemekler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvYemekler.MultiSelect = false;
            this.dgvYemekler.Name = "dgvYemekler";
            this.dgvYemekler.RowHeadersWidth = 62;
            this.dgvYemekler.RowTemplate.Height = 28;
            this.dgvYemekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYemekler.Size = new System.Drawing.Size(986, 634);
            this.dgvYemekler.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yemek Listesi";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(557, 722);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(209, 108);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Yeni Yemek Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtYemekAdi
            // 
            this.txtYemekAdi.Location = new System.Drawing.Point(238, 746);
            this.txtYemekAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYemekAdi.Name = "txtYemekAdi";
            this.txtYemekAdi.Size = new System.Drawing.Size(272, 26);
            this.txtYemekAdi.TabIndex = 6;
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(238, 880);
            this.txtKalori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(272, 26);
            this.txtKalori.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 746);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yemek Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 814);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 877);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kalori(100gr için):";
            // 
            // cboKategori
            // 
            this.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Items.AddRange(new object[] {
            "Çorba",
            "AnaYemek",
            "Salata",
            "Tatlı",
            "Meyve",
            "Kuruyemiş",
            "İçecek",
            "Diğer"});
            this.cboKategori.Location = new System.Drawing.Point(238, 812);
            this.cboKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(272, 28);
            this.cboKategori.TabIndex = 10;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(774, 722);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 108);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Yemek Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cboOgun
            // 
            this.cboOgun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOgun.FormattingEnabled = true;
            this.cboOgun.Items.AddRange(new object[] {
            "Kahvaltı",
            "Öğlen  Yemeği",
            "Akşam Yemeği",
            "Ara Öğün 1",
            "Ara Öğün 2",
            "Ara Öğün 3",
            "Ara Öğün 4",
            "Ara Öğün 5"});
            this.cboOgun.Location = new System.Drawing.Point(57, 345);
            this.cboOgun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboOgun.Name = "cboOgun";
            this.cboOgun.Size = new System.Drawing.Size(475, 28);
            this.cboOgun.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Öğün:";
            // 
            // cboOgunYemek
            // 
            this.cboOgunYemek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOgunYemek.FormattingEnabled = true;
            this.cboOgunYemek.Location = new System.Drawing.Point(57, 446);
            this.cboOgunYemek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboOgunYemek.Name = "cboOgunYemek";
            this.cboOgunYemek.Size = new System.Drawing.Size(475, 28);
            this.cboOgunYemek.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yemek:";
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(57, 609);
            this.nudMiktar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMiktar.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(477, 26);
            this.nudMiktar.TabIndex = 7;
            this.nudMiktar.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 562);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Miktar(gram):";
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.AutoSize = true;
            this.lblToplamKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKalori.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblToplamKalori.Location = new System.Drawing.Point(166, 686);
            this.lblToplamKalori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(229, 37);
            this.lblToplamKalori.TabIndex = 1;
            this.lblToplamKalori.Text = "Toplam Kalori";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 686);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kalori:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYemekYolu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pboYemekler);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudMiktar);
            this.groupBox1.Controls.Add(this.cboOgun);
            this.groupBox1.Controls.Add(this.btnOgunEkle);
            this.groupBox1.Controls.Add(this.cboOgunYemek);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblToplamKalori);
            this.groupBox1.Location = new System.Drawing.Point(1046, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(552, 831);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Ayarlarım";
            // 
            // txtYemekYolu
            // 
            this.txtYemekYolu.Location = new System.Drawing.Point(47, 522);
            this.txtYemekYolu.Name = "txtYemekYolu";
            this.txtYemekYolu.Size = new System.Drawing.Size(475, 26);
            this.txtYemekYolu.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 479);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Yemek Yolu:";
            // 
            // pboYemekler
            // 
            this.pboYemekler.Location = new System.Drawing.Point(122, 55);
            this.pboYemekler.Name = "pboYemekler";
            this.pboYemekler.Size = new System.Drawing.Size(285, 200);
            this.pboYemekler.TabIndex = 8;
            this.pboYemekler.TabStop = false;
            // 
            // btnOgunEkle
            // 
            this.btnOgunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgunEkle.ForeColor = System.Drawing.Color.Black;
            this.btnOgunEkle.Location = new System.Drawing.Point(96, 752);
            this.btnOgunEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOgunEkle.Name = "btnOgunEkle";
            this.btnOgunEkle.Size = new System.Drawing.Size(381, 58);
            this.btnOgunEkle.TabIndex = 4;
            this.btnOgunEkle.Text = "Öğün Ekle";
            this.btnOgunEkle.UseVisualStyleBackColor = true;
            this.btnOgunEkle.Click += new System.EventHandler(this.btnOgunEkle_Click);
            // 
            // btnGunSonuRaporu
            // 
            this.btnGunSonuRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunSonuRaporu.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnGunSonuRaporu.Location = new System.Drawing.Point(557, 838);
            this.btnGunSonuRaporu.Name = "btnGunSonuRaporu";
            this.btnGunSonuRaporu.Size = new System.Drawing.Size(439, 70);
            this.btnGunSonuRaporu.TabIndex = 13;
            this.btnGunSonuRaporu.Text = "Gün Sonu Raporu";
            this.btnGunSonuRaporu.UseVisualStyleBackColor = true;
            this.btnGunSonuRaporu.Click += new System.EventHandler(this.btnGunSonuRaporu_Click);
            // 
            // YemeklerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1608, 920);
            this.Controls.Add(this.btnGunSonuRaporu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cboKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.txtYemekAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvYemekler);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YemeklerForm";
            this.Text = "YemeklerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYemekler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYemekler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtYemekAdi;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKategori;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cboOgun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOgunYemek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToplamKalori;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgunEkle;
        private System.Windows.Forms.PictureBox pboYemekler;
        private System.Windows.Forms.TextBox txtYemekYolu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGunSonuRaporu;
    }
}