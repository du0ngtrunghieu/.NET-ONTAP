namespace ONTAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LopHocPhans", "MonHoc_Id", "dbo.MonHocs");
            DropIndex("dbo.LopHocPhans", new[] { "MonHoc_Id" });
            DropIndex("dbo.SinhViens", new[] { "LopHocPhan_Id" });
            AlterColumn("dbo.LopHocPhans", "MonHoc_id", c => c.Int(nullable: false));
            CreateIndex("dbo.LopHocPhans", "MonHoc_id");
            CreateIndex("dbo.SinhViens", "LopHocPhan_id");
            AddForeignKey("dbo.LopHocPhans", "MonHoc_id", "dbo.MonHocs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LopHocPhans", "MonHoc_id", "dbo.MonHocs");
            DropIndex("dbo.SinhViens", new[] { "LopHocPhan_id" });
            DropIndex("dbo.LopHocPhans", new[] { "MonHoc_id" });
            AlterColumn("dbo.LopHocPhans", "MonHoc_id", c => c.Int());
            CreateIndex("dbo.SinhViens", "LopHocPhan_Id");
            CreateIndex("dbo.LopHocPhans", "MonHoc_Id");
            AddForeignKey("dbo.LopHocPhans", "MonHoc_Id", "dbo.MonHocs", "Id");
        }
    }
}
