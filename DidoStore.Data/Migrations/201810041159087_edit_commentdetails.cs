namespace DidoStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_commentdetails : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CommentDetails", new[] { "ParentId" });
            AlterColumn("dbo.CommentDetails", "ParentId", c => c.Int());
            CreateIndex("dbo.CommentDetails", "ParentId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CommentDetails", new[] { "ParentId" });
            AlterColumn("dbo.CommentDetails", "ParentId", c => c.Int(nullable: false));
            CreateIndex("dbo.CommentDetails", "ParentId");
        }
    }
}
