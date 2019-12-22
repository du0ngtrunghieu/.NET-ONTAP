using ONTAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP.Controllers
{
    class HomeController
    {
        public static List<MonHoc> getAll_mh()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.MonHoc.ToList();
            }
        }
        public static List<SinhVien> getAll_sv()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.SinhVien.ToList();
            }
        }
        public static List<SinhVien> getSVbyLHP(LopHocPhan lhp)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.SinhVien.Where(x=>x.LopHocPhan_id == lhp.Id ).ToList();
            }
        }
        public static List<LopHocPhan> getAll_lhp()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.LopHocPhan.ToList();
            }
        }

        public static List<LopHocPhan> getAll_lhpBymh(MonHoc mh)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.LopHocPhan.Include("SinhVien").Where(x => x.MonHoc.Id == mh.Id).ToList();
            }
        }
        public static void saveLHP(LopHocPhan lhp)
        {
            using (ModelContext db = new ModelContext())
            {
                db.LopHocPhan.Add(lhp);
                db.SaveChanges();
            }
        }
        public static void deleteLHP(LopHocPhan obj)
        {
            using (ModelContext db = new ModelContext())
            {
                if (db.Entry<LopHocPhan>(obj).State == System.Data.Entity.EntityState.Detached)
                    db.Set<LopHocPhan>().Attach(obj);
                db.Entry<LopHocPhan>(obj).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public static void deleteLSV(SinhVien obj)
        {
            using (ModelContext db = new ModelContext())
            {
                if (db.Entry<SinhVien>(obj).State == System.Data.Entity.EntityState.Detached)
                    db.Set<SinhVien>().Attach(obj);
                db.Entry<SinhVien>(obj).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public static void editLHP(LopHocPhan obj)
        {
            using (ModelContext db = new ModelContext())
            {
                
                db.Entry<LopHocPhan>(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static bool addSVintoLHP(SinhVien sv,LopHocPhan lhp)
        {
            using (ModelContext db = new ModelContext())
            {
                bool kt = true;
                SinhVien sinhVien = db.SinhVien.Where(x => x.Id == sv.Id).FirstOrDefault();
               
                LopHocPhan lopHocPhan = db.LopHocPhan.Include("SinhVien").Where(x => x.Id == lhp.Id).FirstOrDefault();
                foreach (SinhVien item in lopHocPhan.sinhvien)
                {
                    if(item.Id == sinhVien.Id)
                    {
                        // sinh viên này đã có trong lớp học phần
                        kt = false;
                    }
                }
                if(kt == true)
                {
                    // sinh viên này chưa có -> thêm vào
                    lopHocPhan.sinhvien.Add(sinhVien);
                    // sinh vien đăng ký đến định mức max
                    if(lopHocPhan.SoLuongSv + 1 == lopHocPhan.Max_Sv)
                    {
                        kt = false;
                    }
                    else
                    {
                        lopHocPhan.SoLuongSv = lopHocPhan.sinhvien.Count +1;
                        db.SaveChanges();
                        return true;
                    }
                    
                }
                return kt;
                
            }
                
        }
    }
}
