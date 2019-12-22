using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP.Models
{
    class MonHoc
    {
        public int Id { get; set; }
        public String TenMonHoc { get; set; }

        public ICollection<LopHocPhan> lopHocPhan { get; set; }
    }
}
