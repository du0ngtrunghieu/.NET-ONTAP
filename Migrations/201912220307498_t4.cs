namespace ONTAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.LopHocPhans", new[] { "MonHoc_Id" });
            AlterColumn("dbo.LopHocPhans", "MonHoc_id", c => c.Int(nullable: false));
            CreateIndex("dbo.LopHocPhans", "MonHoc_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.LopHocPhans", new[] { "MonHoc_Id" });
            AlterColumn("dbo.LopHocPhans", "MonHoc_id", c => c.Int());
            CreateIndex("dbo.LopHocPhans", "MonHoc_Id");
        }
    }
}
