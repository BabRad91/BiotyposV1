namespace BiotyposV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumbers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicalCenterPhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false),
                        MedicalCenterRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MedicalCenters", t => t.MedicalCenterRefId, cascadeDelete: true)
                .Index(t => t.MedicalCenterRefId);
            
            DropColumn("dbo.MedicalCenters", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MedicalCenters", "PhoneNumber", c => c.String(nullable: false));
            DropForeignKey("dbo.MedicalCenterPhones", "MedicalCenterRefId", "dbo.MedicalCenters");
            DropIndex("dbo.MedicalCenterPhones", new[] { "MedicalCenterRefId" });
            DropTable("dbo.MedicalCenterPhones");
        }
    }
}
