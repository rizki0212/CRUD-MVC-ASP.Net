namespace Indomaret.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Indomaretkus",
                c => new
                    {
                        kode_barang = c.String(nullable: false, maxLength: 128),
                        nama = c.String(),
                        harga = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.kode_barang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Indomaretkus");
        }
    }
}
