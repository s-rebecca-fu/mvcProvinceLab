namespace CanadaLab.Migrations.CanadaMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Popuation = c.Int(nullable: false),
                        ProvinceCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.ProvinceCode)
                .Index(t => t.ProvinceCode);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceCode = c.String(nullable: false, maxLength: 128),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "ProvinceCode", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "ProvinceCode" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
