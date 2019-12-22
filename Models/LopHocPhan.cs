using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP.Models
{
    class LopHocPhan
    {
        [Key]
        public int Id { get; set; }
        public String TenLopHocPhan { get; set; }
        public String MaLopHocPhan { get; set; }
        public int Min_Sv { get; set; }
        public int Max_Sv { get; set; }
        [DefaultValue(1)]
        public int SoLuongSv { get; set; }
        public String GiaoVien { get; set; }
        [ForeignKey("MonHoc")]
        public int MonHoc_id { get; set; }
        public MonHoc MonHoc { get; set; }
        public ICollection<SinhVien> sinhvien { get; set; }

    }
}
