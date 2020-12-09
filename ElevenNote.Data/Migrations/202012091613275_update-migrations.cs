namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemigrations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Note", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "Content", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Note", "Title", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
