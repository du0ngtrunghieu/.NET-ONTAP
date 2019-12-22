using ONTAP.Controllers;
using ONTAP.Models;
using ONTAP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTAP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroComboBox1.DataSource = HomeController.getAll_mh();
            metroComboBox1.SelectedItem = null;
           
            update_panel2();

            
        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void MetroComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            MonHoc obj = metroComboBox1.SelectedItem as MonHoc;
            if (obj != null)
            {
                lopHocPhanBindingSource.DataSource = HomeController.getAll_lhpBymh(obj);
                tblhp.DataSource = lopHocPhanBindingSource;


            }
            else
            {
                tblhp.DataSource = null;
                update_panel2();
            }
                
            
        }

        private void Tblhp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LopHocPhan lhp = lopHocPhanBindingSource.Current as LopHocPhan;
            if(lhp != null)
            {
                sinhVienBindingSource.DataSource = HomeController.getSVbyLHP(lhp);
                if (lhp.sinhvien != null)
                    txtsl.Text = lhp.sinhvien.Count().ToString();
                else
                    txtsl.Text = "0";
            }
        }
        public void update_panel2()
        {
            txtgv.Text = null;
            txtmalhp.Text = null;
            txtminlhp.Text = null;
            txtmaxlhp.Text = null;
            txtsl.Text = null;
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            
            FrmAddLHP frm = new FrmAddLHP();
            frm.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            LopHocPhan lhp = lopHocPhanBindingSource.Current as LopHocPhan;
            if (lhp != null)
            {
                FrmEditLHP frm = new FrmEditLHP(lhp);
                frm.Show();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng chọn lớp học phần !!");
            
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xoá sinh viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                LopHocPhan lhp = lopHocPhanBindingSource.Current as LopHocPhan;
                if (lhp != null)
                {
                    HomeController.deleteLHP(lhp);
                    MetroFramework.MetroMessageBox.Show(this, "Xoá thành công");
                    lopHocPhanBindingSource.RemoveCurrent();
                }
            }
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xoá sinh viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SinhVien sv = sinhVienBindingSource.Current as SinhVien;
                if (sv != null)
                {
                    HomeController.deleteLSV(sv);
                    MetroFramework.MetroMessageBox.Show(this, "Xoá thành công");
                    sinhVienBindingSource.RemoveCurrent();
                }
            }
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            sinhVienBindingSource.DataSource = HomeController.getAll_sv();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhVien sv = sinhVienBindingSource.Current as SinhVien;
            if(sv != null)
            {

            }
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            SinhVien sv = sinhVienBindingSource.Current as SinhVien;
            LopHocPhan lhp = lopHocPhanBindingSource.Current as LopHocPhan;
            if (sv != null && lhp != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn thêm sinh viên vào lớp học phần"+lhp.TenLopHocPhan+" này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool t =  HomeController.addSVintoLHP(sv, lhp);
                    if(t == true)
                        MetroFramework.MetroMessageBox.Show(this,"Thêm sinh viên vào lớp học phần thành công");
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Sinh viên này đã trong lớp học phần này","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
