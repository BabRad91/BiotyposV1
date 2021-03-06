namespace BiotyposV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MedicalCenter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicalCenters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Street = c.String(nullable: false, maxLength: 255),
                        StreetNumber = c.String(nullable: false),
                        Region = c.String(nullable: false, maxLength: 255),
                        City = c.String(nullable: false, maxLength: 255),
                        ZipCode = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MedicalCenters");
        }
    }
}
