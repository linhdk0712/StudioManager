namespace Studio.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhoiTaoDBv2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Business", newName: "Businesses");
            AlterColumn("dbo.Businesses", "BusName", c => c.String());
            AlterColumn("dbo.Businesses", "Description", c => c.String());
            AlterColumn("dbo.StudioUsers", "UserName", c => c.String());
            AlterColumn("dbo.StudioUsers", "PassWord", c => c.String());
            AlterColumn("dbo.Studios", "StudioCode", c => c.String());
            AlterColumn("dbo.Studios", "StudioName", c => c.String());
            AlterColumn("dbo.Studios", "SkypeName", c => c.String());
            AlterColumn("dbo.Studios", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Studios", "Email", c => c.String());
            AlterColumn("dbo.Studios", "Address", c => c.String());
            AlterColumn("dbo.Studios", "Logo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Studios", "Logo", c => c.String(maxLength: 500));
            AlterColumn("dbo.Studios", "Address", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Studios", "Email", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Studios", "PhoneNumber", c => c.String(nullable: false, maxLength: 15, unicode: false));
            AlterColumn("dbo.Studios", "SkypeName", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AlterColumn("dbo.Studios", "StudioName", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Studios", "StudioCode", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudioUsers", "PassWord", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudioUsers", "UserName", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Businesses", "Description", c => c.String(maxLength: 250));
            AlterColumn("dbo.Businesses", "BusName", c => c.String(nullable: false));
            RenameTable(name: "dbo.Businesses", newName: "Business");
        }
    }
}
