using ONTAP.Controllers;
using ONTAP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTAP.Views
{
    public partial class FrmAddLHP : MetroFramework.Forms.MetroForm
    {
        
        public FrmAddLHP()
        {
            InitializeComponent();
            
        }

        private void FrmAddLHP_Load(object sender, EventArgs e)
        {
            metroComboBox1.DataSource = HomeController.getAll_mh();
            metroComboBox1.SelectedItem = null;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            MonHoc mh = metroComboBox1.SelectedItem as MonHoc;

            
            LopHocPhan obj = new LopHocPhan() {
                MaLopHocPhan = txtmhp.Text,
                TenLopHocPhan = txttenhp.Text,
                Min_Sv = int.Parse(txtmin.Text),
                Max_Sv = int.Parse(txtmax.Text),
                GiaoVien = txtgv.Text,
                MonHoc_id = mh.Id,
        };
            


            if (obj != null)
            {
                HomeController.saveLHP(obj);
                MetroFramework.MetroMessageBox.Show(this, "Thêm thành công");
                Form1 fmr = new Form1();
                fmr.Show();
            }
        }
    }
}
