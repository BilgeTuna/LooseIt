namespace LooseIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        KullaniciMail = c.String(nullable: false, maxLength: 500),
                        Sifre = c.String(nullable: false, maxLength: 500),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Boy = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kilogram = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Yas = c.Int(nullable: false),
                        Cinsiyet = c.String(),
                        EgzersizDurum = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Ogunler",
                c => new
                    {
                        OgunId = c.Int(nullable: false, identity: true),
                        OgunAdi = c.String(),
                        OgunTarih = c.DateTime(nullable: false),
                        ToplamKalori = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OgunId);
            
            CreateTable(
                "dbo.Yemekler",
                c => new
                    {
                        YemekId = c.Int(nullable: false, identity: true),
                        YemekAdi = c.String(nullable: false, maxLength: 500),
                        Kategori = c.String(),
                        Kalori = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Miktar = c.Int(nullable: false),
                        YemekResim = c.String(),
                        YemekKategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YemekId)
                .ForeignKey("dbo.YemekKategoris", t => t.YemekKategoriId, cascadeDelete: true)
                .Index(t => t.YemekKategoriId);
            
            CreateTable(
                "dbo.YemekKategoris",
                c => new
                    {
                        YemekKategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.YemekKategoriId);
            
            CreateTable(
                "dbo.OgunKullanicis",
                c => new
                    {
                        Ogun_OgunId = c.Int(nullable: false),
                        Kullanici_KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogun_OgunId, t.Kullanici_KullaniciId })
                .ForeignKey("dbo.Ogunler", t => t.Ogun_OgunId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicilar", t => t.Kullanici_KullaniciId, cascadeDelete: true)
                .Index(t => t.Ogun_OgunId)
                .Index(t => t.Kullanici_KullaniciId);
            
            CreateTable(
                "dbo.YemekOguns",
                c => new
                    {
                        Yemek_YemekId = c.Int(nullable: false),
                        Ogun_OgunId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Yemek_YemekId, t.Ogun_OgunId })
                .ForeignKey("dbo.Yemekler", t => t.Yemek_YemekId, cascadeDelete: true)
                .ForeignKey("dbo.Ogunler", t => t.Ogun_OgunId, cascadeDelete: true)
                .Index(t => t.Yemek_YemekId)
                .Index(t => t.Ogun_OgunId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yemekler", "YemekKategoriId", "dbo.YemekKategoris");
            DropForeignKey("dbo.YemekOguns", "Ogun_OgunId", "dbo.Ogunler");
            DropForeignKey("dbo.YemekOguns", "Yemek_YemekId", "dbo.Yemekler");
            DropForeignKey("dbo.OgunKullanicis", "Kullanici_KullaniciId", "dbo.Kullanicilar");
            DropForeignKey("dbo.OgunKullanicis", "Ogun_OgunId", "dbo.Ogunler");
            DropIndex("dbo.YemekOguns", new[] { "Ogun_OgunId" });
            DropIndex("dbo.YemekOguns", new[] { "Yemek_YemekId" });
            DropIndex("dbo.OgunKullanicis", new[] { "Kullanici_KullaniciId" });
            DropIndex("dbo.OgunKullanicis", new[] { "Ogun_OgunId" });
            DropIndex("dbo.Yemekler", new[] { "YemekKategoriId" });
            DropTable("dbo.YemekOguns");
            DropTable("dbo.OgunKullanicis");
            DropTable("dbo.YemekKategoris");
            DropTable("dbo.Yemekler");
            DropTable("dbo.Ogunler");
            DropTable("dbo.Kullanicilar");
        }
    }
}
