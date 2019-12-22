using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP.Models
{
    class SinhVien
    {
        [Key]
        public int Id { get; set; }
        public String MaSv { get; set; }
        public String HoDem { get; set; }
        public String Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public String QueQuan { get; set; }
        [ForeignKey("LopHocPhan")]
        public int? LopHocPhan_id { get; set; }
        public LopHocPhan LopHocPhan { get; set; }
    }
}
