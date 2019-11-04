namespace Infaestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studenID = c.Int(nullable: false, identity: true),
                        studentName = c.Int(nullable: false),
                        studenAddress = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.studenID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
