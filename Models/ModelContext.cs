using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP.Models
{
    class ModelContext: DbContext
    {
        public ModelContext()
           : base("Data Source=ADMIN;Initial Catalog=ontap.net;Persist Security Info=True;User ID=sa;Password=1234")
        {

        }
        public DbSet<LopHocPhan> LopHocPhan { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
    }
}
