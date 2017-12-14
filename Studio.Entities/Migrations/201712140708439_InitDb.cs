namespace Studio.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Businesses",
                c => new
                    {
                        BusId = c.Guid(nullable: false),
                        BusName = c.String(maxLength: 100, unicode: false),
                        Description = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BusId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        PermissionId = c.Guid(nullable: false),
                        PermissionName = c.String(maxLength: 50, unicode: false),
                        Description = c.String(maxLength: 500),
                        BusId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PermissionId)
                .ForeignKey("dbo.Businesses", t => t.BusId, cascadeDelete: true)
                .Index(t => t.BusId);
            
            CreateTable(
                "dbo.GrantPermissions",
                c => new
                    {
                        PermissionId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => new { t.PermissionId, t.UserId })
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.StudioUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.PermissionId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.StudioUsers",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(maxLength: 30, unicode: false),
                        PassWord = c.String(maxLength: 30),
                        FullName = c.String(maxLength: 255),
                        PhoneNumber = c.String(maxLength: 20),
                        Address = c.String(maxLength: 500),
                        Email = c.String(maxLength: 100),
                        Avatar = c.String(maxLength: 500),
                        IsAdmin = c.Boolean(nullable: false),
                        StudioId = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        ModifyDate = c.DateTime(),
                        ModifyBy = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Studios", t => t.StudioId, cascadeDelete: true)
                .Index(t => t.StudioId);
            
            CreateTable(
                "dbo.Studios",
                c => new
                    {
                        StudioId = c.Guid(nullable: false),
                        StudioCode = c.String(maxLength: 50, unicode: false),
                        StudioName = c.String(maxLength: 500, unicode: false),
                        SkypeName = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 20),
                        Email = c.String(maxLength: 100),
                        Address = c.String(maxLength: 500),
                        Logo = c.String(maxLength: 500),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        ModifyDate = c.DateTime(),
                        ModifyBy = c.String(),
                    })
                .PrimaryKey(t => t.StudioId);
            
            CreateTable(
                "dbo.StudioActives",
                c => new
                    {
                        StudioActiveId = c.Guid(nullable: false),
                        ActiveFrom = c.DateTime(),
                        ActiveTo = c.DateTime(),
                        StudioId = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        ModifyDate = c.DateTime(),
                        ModifyBy = c.String(),
                    })
                .PrimaryKey(t => t.StudioActiveId)
                .ForeignKey("dbo.Studios", t => t.StudioId, cascadeDelete: true)
                .Index(t => t.StudioId);
            
            CreateTable(
                "dbo.StudioInvoices",
                c => new
                    {
                        InvoiceId = c.Guid(nullable: false),
                        InvoiceNumber = c.String(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RepaymentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrincipalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RepaymentDate = c.DateTime(),
                        StudioId = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        ModifyDate = c.DateTime(),
                        ModifyBy = c.String(),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.Studios", t => t.StudioId, cascadeDelete: true)
                .Index(t => t.StudioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudioInvoices", "StudioId", "dbo.Studios");
            DropForeignKey("dbo.StudioActives", "StudioId", "dbo.Studios");
            DropForeignKey("dbo.GrantPermissions", "UserId", "dbo.StudioUsers");
            DropForeignKey("dbo.StudioUsers", "StudioId", "dbo.Studios");
            DropForeignKey("dbo.GrantPermissions", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.Permissions", "BusId", "dbo.Businesses");
            DropIndex("dbo.StudioInvoices", new[] { "StudioId" });
            DropIndex("dbo.StudioActives", new[] { "StudioId" });
            DropIndex("dbo.StudioUsers", new[] { "StudioId" });
            DropIndex("dbo.GrantPermissions", new[] { "UserId" });
            DropIndex("dbo.GrantPermissions", new[] { "PermissionId" });
            DropIndex("dbo.Permissions", new[] { "BusId" });
            DropTable("dbo.StudioInvoices");
            DropTable("dbo.StudioActives");
            DropTable("dbo.Studios");
            DropTable("dbo.StudioUsers");
            DropTable("dbo.GrantPermissions");
            DropTable("dbo.Permissions");
            DropTable("dbo.Businesses");
        }
    }
}
