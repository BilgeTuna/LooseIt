
namespace LooseIt
{
    partial class Form1
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
            this.sifreDogruMu = new System.Windows.Forms.Label();
            this.lbCikisYap = new System.Windows.Forms.LinkLabel();
            this.lbKayitOl = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciMail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sifreDogruMu
            // 
            this.sifreDogruMu.AutoSize = true;
            this.sifreDogruMu.Location = new System.Drawing.Point(401, 473);
            this.sifreDogruMu.Name = "sifreDogruMu";
            this.sifreDogruMu.Size = new System.Drawing.Size(0, 20);
            this.sifreDogruMu.TabIndex = 21;
            // 
            // lbCikisYap
            // 
            this.lbCikisYap.AutoSize = true;
            this.lbCikisYap.Location = new System.Drawing.Point(487, 715);
            this.lbCikisYap.Name = "lbCikisYap";
            this.lbCikisYap.Size = new System.Drawing.Size(84, 20);
            this.lbCikisYap.TabIndex = 20;
            this.lbCikisYap.TabStop = true;
            this.lbCikisYap.Text = "Çıkış Yap";
            this.lbCikisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCikisYap_LinkClicked);
            // 
            // lbKayitOl
            // 
            this.lbKayitOl.AutoSize = true;
            this.lbKayitOl.Location = new System.Drawing.Point(5, 715);
            this.lbKayitOl.Name = "lbKayitOl";
            this.lbKayitOl.Size = new System.Drawing.Size(70, 20);
            this.lbKayitOl.TabIndex = 19;
            this.lbKayitOl.TabStop = true;
            this.lbKayitOl.Text = "Kayıt Ol";
            this.lbKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbKayitOl_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(179, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kalori Ölçer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şifre :";
            // 
            // btnGiris
            // 
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(219, 513);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(343, 63);
            this.btnGiris.TabIndex = 16;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kullanıcı Adı :\r\n(e-mail)\r\n";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(219, 434);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(343, 26);
            this.txtSifre.TabIndex = 14;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciMail
            // 
            this.txtKullaniciMail.Location = new System.Drawing.Point(219, 366);
            this.txtKullaniciMail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKullaniciMail.Name = "txtKullaniciMail";
            this.txtKullaniciMail.Size = new System.Drawing.Size(343, 26);
            this.txtKullaniciMail.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LooseIt.Properties.Resources.diyet;
            this.pictureBox1.Location = new System.Drawing.Point(81, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(640, 761);
            this.Controls.Add(this.sifreDogruMu);
            this.Controls.Add(this.lbCikisYap);
            this.Controls.Add(this.lbKayitOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciMail);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifreDogruMu;
        private System.Windows.Forms.LinkLabel lbCikisYap;
        private System.Windows.Forms.LinkLabel lbKayitOl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciMail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

