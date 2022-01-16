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
    public partial class KayitOlForm : Form
    {
        AppDbContext db = new AppDbContext();


        public KayitOlForm()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            //kaydet butonuna tıklandığında formdaki bilgilere sahip yeni bir kullanıcı oluşturulacak
            if (!txtKullaniciAdi.Text.Contains("@"))
            {
                MessageBox.Show("Lütfen Bir Mail Giriniz");
            }
            else
            {
                string kullaniciMail = txtKullaniciAdi.Text.Trim();
                string sifre = txtSifre.Text.Trim();
                string ad = txtAd.Text.Trim();
                string soyad = txtSoyad.Text.Trim();
                decimal boy = Convert.ToDecimal(nudBoy.Value);
                decimal kilogram = Convert.ToDecimal(nudKilogram.Value);
                int yas = Convert.ToInt32(nudBoy.Value);
                string cinsiyet = (string)cboCinsiyet.SelectedItem;
                string egzersizDurum = (string)cboEgzersizDurum.SelectedItem;
                Kullanici kullanici = new Kullanici()
                {
                    KullaniciMail = kullaniciMail,
                    Sifre = sifre,
                    Ad = ad,
                    Soyad = soyad,
                    Boy = boy,
                    Kilogram = kilogram,
                    Yas = yas,
                    Cinsiyet = cinsiyet,
                    EgzersizDurum = egzersizDurum

                };
                db.Kullanicilar.Add(kullanici);
                db.SaveChanges();
                FormSifirla();
            }
        }

        

        private void FormSifirla()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            nudBoy.Value = 170;
            nudKilogram.Value = 70;
            nudKilogram.Value = 20;
            cboCinsiyet.SelectedItem = null;
            cboEgzersizDurum.SelectedItem = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string usr, pswd; //usr kullanıcının girdiği kullanıcı adı bilgisi, pswd kullanıcının girdiği şifre bilgisi
            usr = txtKullaniciAdi.Text.Trim();
            pswd = txtSifre.Text.Trim();

            var kullaniciListe = db.Kullanicilar.ToList();
            Kullanici deleteUser = kullaniciListe.Where(x => x.KullaniciMail == usr).FirstOrDefault();
            if (deleteUser == null)
            {
                MessageBox.Show("girilen kullanıcı adı ya da şifre hatalı");
            }
            else if (deleteUser.Sifre != pswd)
            {
                MessageBox.Show("girilen kullanıcı adı ya da şifre hatalı");
            }
            else
            {
                kullaniciListe.Remove(deleteUser);
            }
            db.SaveChanges();
            FormSifirla();
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string usr, pswd; //usr kullanıcının girdiği kullanıcı adı bilgisi, pswd kullanıcının girdiği şifre bilgisi
            usr = txtKullaniciAdi.Text.Trim();
            pswd = txtSifre.Text.Trim();

            var kullaniciListe = db.Kullanicilar.ToList();
            Kullanici updateUser = kullaniciListe.Where(x => x.KullaniciMail == usr).FirstOrDefault();
            if (updateUser == null)
            {
                MessageBox.Show("girilen kullanıcı adı ya da şifre hatalı");
            }
            else if (updateUser.Sifre != pswd)
            {
                MessageBox.Show("girilen kullanıcı adı ya da şifre hatalı");
            }
            else
            {
                updateUser.KullaniciMail = txtKullaniciAdi.Text.Trim();
                updateUser.Ad = txtAd.Text.Trim();
                updateUser.Soyad = txtSoyad.Text.Trim();
                updateUser.Boy = nudBoy.Value;
                updateUser.Kilogram = nudKilogram.Value;
                updateUser.Yas = Convert.ToInt32(nudYas.Value);
                updateUser.Cinsiyet = (string)cboCinsiyet.SelectedItem;
                updateUser.EgzersizDurum = (string)cboEgzersizDurum.SelectedItem;
            }
            db.SaveChanges();
            FormSifirla();
        }
    }
}
