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
    public partial class FrmEditLHP : MetroFramework.Forms.MetroForm
    {
        private LopHocPhan _lhp;
        public FrmEditLHP(Object lhp)
        {
            InitializeComponent();
            _lhp = lhp as LopHocPhan;
            lopHocPhanBindingSource.DataSource = _lhp;
            
        }

        private void FrmEditLHP_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LopHocPhan obj = lopHocPhanBindingSource.Current as LopHocPhan;
            if(obj != null)
            {
                HomeController.editLHP(obj);
                MetroFramework.MetroMessageBox.Show(this, "Sửa thành công");

                Form1 frm = new Form1();
                frm.Focus();
            }
            
            
        }

        private void MetroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
