namespace Infaestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "studentName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "studenAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "studenAddress", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "studentName", c => c.Int(nullable: false));
        }
    }
}
