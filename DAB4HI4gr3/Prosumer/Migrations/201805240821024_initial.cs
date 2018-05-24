namespace Prosumer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vejnavn = c.String(),
                        Husnummer = c.Int(nullable: false),
                        By = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ForventetDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Forbrug = c.Int(nullable: false),
                        Produktion = c.Int(nullable: false),
                        StartTidspunkt = c.String(),
                        SlutTidspunkt = c.String(),
                        Prosumer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prosumers", t => t.Prosumer_Id)
                .Index(t => t.Prosumer_Id);
            
            CreateTable(
                "dbo.Prosumers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Navn = c.String(),
                        Type = c.String(),
                        Tokens = c.Int(nullable: false),
                        Adresse_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adresse_Id)
                .Index(t => t.Adresse_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ForventetDatas", "Prosumer_Id", "dbo.Prosumers");
            DropForeignKey("dbo.Prosumers", "Adresse_Id", "dbo.Adresses");
            DropIndex("dbo.Prosumers", new[] { "Adresse_Id" });
            DropIndex("dbo.ForventetDatas", new[] { "Prosumer_Id" });
            DropTable("dbo.Prosumers");
            DropTable("dbo.ForventetDatas");
            DropTable("dbo.Adresses");
        }
    }
}
