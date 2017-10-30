namespace MVCDBfirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        post_id = c.Int(nullable: false, identity: true),
                        post_title = c.String(),
                        author = c.String(),
                    })
                .PrimaryKey(t => t.post_id);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        user_name = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
            DropTable("dbo.posts");
        }
    }
}
