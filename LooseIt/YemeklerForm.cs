using LooseIt.Data;
using LooseIt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LooseIt
{
    public partial class YemeklerForm : Form
    {
        AppDbContext db = new AppDbContext();
        Kullanici kullanici;
        private List<string> ogunIsimleri;
        private Kullanici loginUser;
        DataTable tablo = new DataTable();


        public YemeklerForm(Kullanici loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
            ogunIsimleri = new List<string>()
            {
                "Kahvaltı","Öğlen Yemeği","Akşam Yemeği","Ara Öğün 1","Ara Öğün 2","Ara Öğün 3","Ara Öğün 4","Ara Öğün 5",
            };
            dgvYemekler.DataSource = db.Yemekler.ToList();
            YemekResimEkle();
        }

        //public YemeklerForm(Kullanici loginUser)
        //{
        //    this.loginUser = loginUser;
        //}
        private void YemekResimEkle()
        {
            if (cboOgunYemek.SelectedItem != null && cboOgunYemek.SelectedIndex != 0)
            {
                Yemek yemekResim = (Yemek)cboOgunYemek.SelectedItem;
                pboYemekler.ImageLocation = yemekResim.YemekResim;
                pboYemekler.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pboYemekler.ImageLocation = "https://im.haberturk.com/2020/03/25/ver1609166671/2624671_1024x576.jpg";
                pboYemekler.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yemekAdi = txtYemekAdi.Text.Trim();
            string kategori = cboKategori.SelectedItem.ToString();
            int kalori = Convert.ToInt32(txtKalori.Text);

            Yemek yemek = new Yemek()
            {
                YemekAdi = yemekAdi,
                Kategori = kategori,
                Kalori = kalori
            };
            db.Yemekler.Add(yemek);
            FormSifirla();
            //db.SaveChanges();
            db.Yemekler.Load();
            
            cboOgunYemek.Items.Add(yemekAdi);
            tablo.Columns.Add("yemek adı", typeof(string));
            tablo.Columns.Add("kategori", typeof(string));
            tablo.Columns.Add("kalori(100 gram için)", typeof(string));
            tablo.Columns.Add("öğün", typeof(string));
            tablo.Columns.Add("yemek miktarı", typeof(string));
            dgvYemekler.DataSource = tablo;
        }

        private void FormSifirla()
        {
            txtYemekAdi.Clear();
            cboKategori.SelectedItem = null;
            txtKalori.Clear();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvYemekler.SelectedRows.Count != 1)
            {
                return;
            }
            Yemek yemek2 =(Yemek)dgvYemekler.SelectedRows[0].DataBoundItem;
            db.Yemekler.Remove(yemek2);
            db.SaveChanges();
            dgvYemekler.DataSource = db.Yemekler.ToList();
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;
            string ogunAdi = (string)cboOgun.SelectedItem;
            cboOgunYemek.DataSource = db.Yemekler.ToList();
            string ogunYemek = (string)cboOgunYemek.SelectedItem;
            int yemekMiktar = (int)nudMiktar.Value;
            Yemek secilenYemek = new Yemek()
            {
                YemekAdi = ogunYemek
            };

            Ogun ogun = new Ogun()
            {
                OgunAdi = ogunAdi,
                OgunTarih = dt,
                ToplamKalori = 0


            };
            ogun.ToplamKalori += (int)secilenYemek.Kalori * yemekMiktar / 100;
            ogun.Yemekler.Add(secilenYemek);
            //db.SaveChanges();
            
           
            tablo.Rows.Add(txtYemekAdi.Text, cboKategori.SelectedItem, txtKalori.Text, cboOgun.SelectedItem, nudMiktar.Value);
            dgvYemekler.DataSource = tablo;

            YemekResimEkle();
            
        }

        private void btnGunSonuRaporu_Click(object sender, EventArgs e)
        {
            KiyasRapor kiyasRapor = new KiyasRapor(db,kullanici);
            kiyasRapor.ShowDialog();
        }
    }
}
