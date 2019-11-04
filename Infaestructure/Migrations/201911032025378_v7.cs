namespace Infaestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentCode", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "active", c => c.Boolean());
            DropColumn("dbo.Students", "studenCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "studenCode", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "active", c => c.Boolean(nullable: false));
            DropColumn("dbo.Students", "studentCode");
        }
    }
}
