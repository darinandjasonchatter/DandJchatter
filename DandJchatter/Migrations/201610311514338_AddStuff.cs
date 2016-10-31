namespace DandJchatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStuff : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Chat", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Chat", c => c.String());
        }
    }
}
