namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Photos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Photos", "Title", c => c.String(nullable: false));
            AddColumn("dbo.Photos", "AltText", c => c.String());
            AddColumn("dbo.Photos", "Caption", c => c.String());
            AddColumn("dbo.Photos", "ImageUrl", c => c.String(nullable: false));
            AddColumn("dbo.Photos", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Photos", "Name");
            DropColumn("dbo.Photos", "Path");
            DropColumn("dbo.Photos", "Date");
            DropColumn("dbo.Photos", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Photos", "Author", c => c.String());
            AddColumn("dbo.Photos", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Photos", "Path", c => c.String());
            AddColumn("dbo.Photos", "Name", c => c.String());
            DropColumn("dbo.Photos", "CreatedDate");
            DropColumn("dbo.Photos", "ImageUrl");
            DropColumn("dbo.Photos", "Caption");
            DropColumn("dbo.Photos", "AltText");
            DropColumn("dbo.Photos", "Title");
        }
    }
}
