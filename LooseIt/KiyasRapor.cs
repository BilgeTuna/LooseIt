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
    public partial class KiyasRapor : Form
    {
        private readonly AppDbContext db;
        private readonly Kullanici kullanici;
        List<string> ogunIsimleri;
        public KiyasRapor(AppDbContext db, Kullanici kullanici)
        {
            InitializeComponent();
            this.db = db;
            this.kullanici = kullanici;
            ogunIsimleri = new List<string>()
            {
                "Kahvaltı","Öğlen Yemeği","Akşam Yemeği","Ara Öğün 1","Ara Öğün 2","Ara Öğün 3","Ara Öğün 4","Ara Öğün 5",
            };
            GunlukKaloriOgun();
        }

        public KiyasRapor()
        {
        }

        private void GunlukKaloriOgun()
        {

        }

        private void cboZamanAraliği_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (cboZamanAraliği.SelectedIndex == 0)
            {
                dt = DateTime.Now.AddDays(-7);
            }
            else if (cboZamanAraliği.SelectedIndex == 1)
            {
                dt = DateTime.Now.AddMonths(-1);
            }
            else if(cboZamanAraliği.SelectedIndex==2)
            {
                dt=DateTime.Now.AddDays(-1);
            }

            GenelOrtHesapla("Kahvaltı", lblGenelKahvalti, dt);
            GenelOrtHesapla("Oglen Yemeği", lblGenelKahvalti, dt);
            GenelOrtHesapla("Akşam Yemeği", lblGenelKahvalti, dt);
            GenelOrtHesapla("Ara Öğün 1", lblGenelKahvalti, dt);
            GenelOrtHesapla("Ara Öğün 2", lblGenelKahvalti, dt);
            GenelOrtHesapla("Ara Öğün 3", lblGenelKahvalti, dt);
            GenelOrtHesapla("Ara Öğün 4", lblGenelKahvalti, dt);
            GenelOrtHesapla("Ara Öğün 5", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Kahvaltı", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Oglen Yemeği", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Akşam Yemeği", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Ara Öğün 1", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Ara Öğün 2", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Ara Öğün 3", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Ara Öğün 4", lblGenelKahvalti, dt);
            KullaniciOrtHesapla("Ara Öğün 5", lblGenelKahvalti, dt);

        }

        private void KullaniciOrtHesapla(string ogunAdi, Label label, DateTime dt)
        {
            List<Ogun> kullaniciOgunListesi = kullanici.Ogunler.Where(x => x.OgunAdi == ogunAdi && x.OgunTarih.Date > dt.Date).ToList();
            double ogunToplamKalori = kullaniciOgunListesi.Sum(z => z.ToplamKalori);

            if (ogunToplamKalori > 0)
            {
                int ogunSayisi = kullaniciOgunListesi.Count();
                double avg = ogunToplamKalori / ogunSayisi;
                label.Text = $"{avg:n2} kcal";
            }
        }

        private void GenelOrtHesapla(string ogunAdi, Label label, DateTime dt)
        {
            List<Ogun> ogunListesi = db.Ogunler.Where(x => x.OgunAdi == ogunAdi && DbFunctions.TruncateTime(x.OgunTarih) > dt.Date).ToList();
            double ogunToplamKlaori = ogunListesi.Sum(z => z.ToplamKalori);

            if (ogunToplamKlaori > 0)
            {
                int ogunSayisi = ogunListesi.Count();
                double avg = ogunToplamKlaori / ogunSayisi;
                label.Text = $"{avg:n2} kcal";
            }
        }
    }
}
