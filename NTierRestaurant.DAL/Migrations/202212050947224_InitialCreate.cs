namespace NTierRestaurant.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanıcılar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullanıcıAdı = c.String(name: "Kullanıcı Adı", nullable: false),
                        EPosta = c.String(name: "E-Posta", nullable: false),
                        KullanıcıŞifresi = c.String(name: "Kullanıcı Şifresi", nullable: false),
                        VeriGirişTarihi = c.DateTime(name: "Veri Giriş Tarihi", nullable: false),
                        GüncellemeTarihi = c.DateTime(name: "Güncelleme Tarihi"),
                        VeriSilmeTarihi = c.DateTime(name: "Veri Silme Tarihi", precision: 7, storeType: "datetime2"),
                        YaratanKişi = c.String(name: "Yaratan Kişi"),
                        SilenKişi = c.String(name: "Silen Kişi"),
                        GüncelleyenKişi = c.String(name: "Güncelleyen Kişi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Siparişler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppUserID = c.Int(nullable: false),
                        ShipperID = c.Int(nullable: false),
                        GönderimAdresi = c.String(name: "Gönderim Adresi"),
                        VeriGirişTarihi = c.DateTime(name: "Veri Giriş Tarihi", nullable: false),
                        GüncellemeTarihi = c.DateTime(name: "Güncelleme Tarihi"),
                        VeriSilmeTarihi = c.DateTime(name: "Veri Silme Tarihi", precision: 7, storeType: "datetime2"),
                        YaratanKişi = c.String(name: "Yaratan Kişi"),
                        SilenKişi = c.String(name: "Silen Kişi"),
                        GüncelleyenKişi = c.String(name: "Güncelleyen Kişi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.AppUserID, cascadeDelete: true)
                .ForeignKey("dbo.Kargocular", t => t.ShipperID, cascadeDelete: true)
                .Index(t => t.AppUserID)
                .Index(t => t.ShipperID);
            
            CreateTable(
                "dbo.Satışlar",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        VeriGirişTarihi = c.DateTime(name: "Veri Giriş Tarihi", nullable: false),
                        GüncellemeTarihi = c.DateTime(name: "Güncelleme Tarihi"),
                        VeriSilmeTarihi = c.DateTime(name: "Veri Silme Tarihi", precision: 7, storeType: "datetime2"),
                        YaratanKişi = c.String(name: "Yaratan Kişi"),
                        SilenKişi = c.String(name: "Silen Kişi"),
                        GüncelleyenKişi = c.String(name: "Güncelleyen Kişi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Siparişler", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Ürünler", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Ürünler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ürünİsmi = c.String(name: "Ürün İsmi", nullable: false),
                        ÜrünFiyatı = c.Decimal(name: "Ürün Fiyatı", nullable: false, storeType: "money"),
                        ÜrünStokSayısı = c.Int(name: "Ürün Stok Sayısı", nullable: false),
                        VeriGirişTarihi = c.DateTime(name: "Veri Giriş Tarihi", nullable: false),
                        GüncellemeTarihi = c.DateTime(name: "Güncelleme Tarihi"),
                        VeriSilmeTarihi = c.DateTime(name: "Veri Silme Tarihi", precision: 7, storeType: "datetime2"),
                        YaratanKişi = c.String(name: "Yaratan Kişi"),
                        SilenKişi = c.String(name: "Silen Kişi"),
                        GüncelleyenKişi = c.String(name: "Güncelleyen Kişi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdı = c.String(name: "Kategori Adı", nullable: false),
                        KategoriAçıklaması = c.String(name: "Kategori Açıklaması", nullable: false),
                        VeriGirişTarihi = c.DateTime(name: "Veri Giriş Tarihi", nullable: false),
                        GüncellemeTarihi = c.DateTime(name: "Güncelleme Tarihi"),
                        VeriSilmeTarihi = c.DateTime(name: "Veri Silme Tarihi", precision: 7, storeType: "datetime2"),
                        YaratanKişi = c.String(name: "Yaratan Kişi"),
                        SilenKişi = c.String(name: "Silen Kişi"),
                        GüncelleyenKişi = c.String(name: "Güncelleyen Kişi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kargocular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Şirketİsmi = c.String(name: "Şirket İsmi", nullable: false),
                        Telefon = c.String(nullable: false),
                        VeriGirişTarihi = c.DateTime(name: "Veri Giriş Tarihi", nullable: false),
                        GüncellemeTarihi = c.DateTime(name: "Güncelleme Tarihi"),
                        VeriSilmeTarihi = c.DateTime(name: "Veri Silme Tarihi", precision: 7, storeType: "datetime2"),
                        YaratanKişi = c.String(name: "Yaratan Kişi"),
                        SilenKişi = c.String(name: "Silen Kişi"),
                        GüncelleyenKişi = c.String(name: "Güncelleyen Kişi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanıcı Profilleri",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        İsim = c.String(nullable: false),
                        Soyisim = c.String(nullable: false),
                        VeriGirişTarihi = c.DateTime(name: "Veri Giriş Tarihi", nullable: false),
                        GüncellemeTarihi = c.DateTime(name: "Güncelleme Tarihi"),
                        VeriSilmeTarihi = c.DateTime(name: "Veri Silme Tarihi", precision: 7, storeType: "datetime2"),
                        YaratanKişi = c.String(name: "Yaratan Kişi"),
                        SilenKişi = c.String(name: "Silen Kişi"),
                        GüncelleyenKişi = c.String(name: "Güncelleyen Kişi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kullanıcı Profilleri", "Id", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Siparişler", "ShipperID", "dbo.Kargocular");
            DropForeignKey("dbo.Satışlar", "ProductID", "dbo.Ürünler");
            DropForeignKey("dbo.Ürünler", "Category_Id", "dbo.Kategoriler");
            DropForeignKey("dbo.Satışlar", "OrderID", "dbo.Siparişler");
            DropForeignKey("dbo.Siparişler", "AppUserID", "dbo.Kullanıcılar");
            DropIndex("dbo.Kullanıcı Profilleri", new[] { "Id" });
            DropIndex("dbo.Ürünler", new[] { "Category_Id" });
            DropIndex("dbo.Satışlar", new[] { "ProductID" });
            DropIndex("dbo.Satışlar", new[] { "OrderID" });
            DropIndex("dbo.Siparişler", new[] { "ShipperID" });
            DropIndex("dbo.Siparişler", new[] { "AppUserID" });
            DropTable("dbo.Kullanıcı Profilleri");
            DropTable("dbo.Kargocular");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Ürünler");
            DropTable("dbo.Satışlar");
            DropTable("dbo.Siparişler");
            DropTable("dbo.Kullanıcılar");
        }
    }
}
