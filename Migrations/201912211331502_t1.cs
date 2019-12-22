namespace ONTAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocPhans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenLopHocPhan = c.String(),
                        MaLopHocPhan = c.String(),
                        Min_Sv = c.Int(nullable: false),
                        Max_Sv = c.Int(nullable: false),
                        SoLuongSv = c.Int(nullable: false),
                        GiaoVien = c.String(),
                        MonHoc_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MonHocs", t => t.MonHoc_Id)
                .Index(t => t.MonHoc_Id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaSv = c.String(),
                        HoDem = c.String(),
                        Ten = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        QueQuan = c.String(),
                        LopHocPhan_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LopHocPhans", t => t.LopHocPhan_Id)
                .Index(t => t.LopHocPhan_Id);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LopHocPhans", "MonHoc_Id", "dbo.MonHocs");
            DropForeignKey("dbo.SinhViens", "LopHocPhan_Id", "dbo.LopHocPhans");
            DropIndex("dbo.SinhViens", new[] { "LopHocPhan_Id" });
            DropIndex("dbo.LopHocPhans", new[] { "MonHoc_Id" });
            DropTable("dbo.MonHocs");
            DropTable("dbo.SinhViens");
            DropTable("dbo.LopHocPhans");
        }
    }
}
