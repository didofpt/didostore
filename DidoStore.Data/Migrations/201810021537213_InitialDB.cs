namespace DidoStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 250),
                        UpdatedBy = c.String(maxLength: 250),
                        Image = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CommentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentId = c.Int(nullable: false),
                        Content = c.String(nullable: false, maxLength: 500),
                        CreatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.CommentId, cascadeDelete: true)
                .ForeignKey("dbo.CommentDetails", t => t.ParentId)
                .Index(t => t.CommentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        BranchId = c.Int(nullable: false),
                        Image = c.String(),
                        MoreImages = c.String(storeType: "xml"),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Quantity = c.Int(),
                        CreatedBy = c.String(maxLength: 100),
                        UpdatedBy = c.String(maxLength: 100),
                        Warranty = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.ProductId })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DestinationAddress = c.String(nullable: false, maxLength: 250),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        PaymentMethod = c.String(nullable: false, maxLength: 250),
                        CreatedDate = c.DateTime(),
                        PaymentStatus = c.Boolean(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Mark = c.Int(nullable: false),
                        Feedback = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.CommentDetails", "ParentId", "dbo.CommentDetails");
            DropForeignKey("dbo.CommentDetails", "CommentId", "dbo.Comments");
            DropForeignKey("dbo.Comments", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "BranchId", "dbo.Branches");
            DropIndex("dbo.Ratings", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Products", new[] { "BranchId" });
            DropIndex("dbo.Comments", new[] { "ProductId" });
            DropIndex("dbo.CommentDetails", new[] { "ParentId" });
            DropIndex("dbo.CommentDetails", new[] { "CommentId" });
            DropTable("dbo.Ratings");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Comments");
            DropTable("dbo.CommentDetails");
            DropTable("dbo.Branches");
        }
    }
}
