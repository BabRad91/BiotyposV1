namespace BiotyposV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MedicalCenterAddFinalAttributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MedicalCenters", "PhoneNumber", c => c.String(nullable: false));
            AddColumn("dbo.MedicalCenters", "Description", c => c.String(nullable: false));
            AddColumn("dbo.MedicalCenters", "GoogleMapUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MedicalCenters", "GoogleMapUrl");
            DropColumn("dbo.MedicalCenters", "Description");
            DropColumn("dbo.MedicalCenters", "PhoneNumber");
        }
    }
}
