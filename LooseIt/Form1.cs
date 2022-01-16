using LooseIt.Data;
using LooseIt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LooseIt
{
    public partial class Form1 : Form
    {
        AppDbContext db = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void lbCikisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lbKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlForm kayitOlForm = new KayitOlForm();
            kayitOlForm.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string usr, pswd; //usr kullanıcının girdiği kullanıcı adı bilgisi, pswd kullanıcının girdiği şifre bilgisi
            usr = txtKullaniciMail.Text.Trim();
            pswd = txtSifre.Text.Trim();
            
            var kullaniciListe = db.Kullanicilar.ToList(); 
            Kullanici loginUser = kullaniciListe.Where(x => x.KullaniciMail == usr).FirstOrDefault();
            if (loginUser==null)
            {
                MessageBox.Show("girilen kullanıcı adı ya da şifre hatalı");
            }
            else if (loginUser.Sifre!=pswd)
            {
                MessageBox.Show("girilen kullanıcı adı ya da şifre hatalı");
            }
            else
            {
                
                YemeklerForm yemeklerForm = new YemeklerForm(loginUser);
                yemeklerForm.ShowDialog();
            }

            
            
        }
    }
}
