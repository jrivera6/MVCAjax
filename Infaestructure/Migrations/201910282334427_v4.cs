namespace Infaestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");

            DropColumn("dbo.Students", "studenID");
            DropColumn("dbo.Students", "studenAddress");
            AddColumn("dbo.Students", "studentID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Students", "studentAddress", c => c.String(nullable: false));
            
        }
        
        public override void Down()
        {   DropPrimaryKey("dbo.Students");
            DropColumn("dbo.Students", "studentAddress");
            DropColumn("dbo.Students", "studentID");
            AddPrimaryKey("dbo.Students", "studenID");
            AddColumn("dbo.Students", "studenAddress", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studenID", c => c.Int(nullable: false, identity: true));
        }
    }
}
