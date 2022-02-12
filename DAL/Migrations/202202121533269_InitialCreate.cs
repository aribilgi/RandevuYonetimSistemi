namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doktorlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Soyadi = c.String(nullable: false, maxLength: 50),
                        TcNo = c.String(nullable: false, maxLength: 11),
                        Telefon = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        Adres = c.String(),
                        KayitTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Randevular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HastaId = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                        DoktorId = c.Int(nullable: false),
                        RandevuTarihi = c.DateTime(nullable: false),
                        Sikayet = c.String(),
                        KronikHastalik = c.Boolean(nullable: false),
                        Sgk = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doktorlar", t => t.DoktorId, cascadeDelete: true)
                .ForeignKey("dbo.Hastalar", t => t.HastaId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicilar", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.HastaId)
                .Index(t => t.KullaniciId)
                .Index(t => t.DoktorId);
            
            CreateTable(
                "dbo.Hastalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Soyadi = c.String(nullable: false, maxLength: 50),
                        TcNo = c.String(nullable: false, maxLength: 11),
                        Yasi = c.Int(nullable: false),
                        Telefon = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 50),
                        Adres = c.String(),
                        HastaYakinBilgisi = c.String(maxLength: 100),
                        KanGrubu = c.String(maxLength: 10),
                        Meslek = c.String(maxLength: 50),
                        KayitTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 50),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Soyadi = c.String(nullable: false, maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Durum = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Error = c.String(),
                        CreateDate = c.DateTime(),
                        HataBilgi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Randevular", "KullaniciId", "dbo.Kullanicilar");
            DropForeignKey("dbo.Randevular", "HastaId", "dbo.Hastalar");
            DropForeignKey("dbo.Randevular", "DoktorId", "dbo.Doktorlar");
            DropIndex("dbo.Randevular", new[] { "DoktorId" });
            DropIndex("dbo.Randevular", new[] { "KullaniciId" });
            DropIndex("dbo.Randevular", new[] { "HastaId" });
            DropTable("dbo.Logs");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.Hastalar");
            DropTable("dbo.Randevular");
            DropTable("dbo.Doktorlar");
        }
    }
}
