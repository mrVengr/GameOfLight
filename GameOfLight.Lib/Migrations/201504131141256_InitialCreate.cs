namespace GameOfLight.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        LevelId = c.Guid(nullable: false),
                        Number = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.LevelId);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        RecordId = c.Guid(nullable: false),
                        GameTime = c.DateTime(nullable: false),
                        Player_Name = c.String(),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Records");
            DropTable("dbo.Levels");
        }
    }
}
