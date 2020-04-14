namespace Indomaret.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuplier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Indomaretkus", "suplier", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Indomaretkus", "suplier");
        }
    }
}
