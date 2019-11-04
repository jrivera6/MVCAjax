namespace Infaestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studenCode", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentLastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "createdAt", c => c.DateTime());
            AddColumn("dbo.Students", "updateAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "updateAt");
            DropColumn("dbo.Students", "createdAt");
            DropColumn("dbo.Students", "studentLastName");
            DropColumn("dbo.Students", "studenCode");
        }
    }
}
