namespace DoAnWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flashsale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.table_TimeFLS",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ngayBD = c.DateTime(),
                        ngayKT = c.DateTime(),
                        createdby = c.String(),
                        createddate = c.DateTime(nullable: false),
                        modifierdate = c.DateTime(nullable: false),
                        modifierby = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.table_Product", "isflashsale", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.table_Product", "isflashsale");
            DropTable("dbo.table_TimeFLS");
        }
    }
}
