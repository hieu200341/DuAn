using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View.FrmNhanvien
{
    public partial class FrmChucVu : Form
    {
        private IQLchucVuServices qLchucVuServices;
        public chucVu _chucVu;
        public FrmChucVu()
        {
            _chucVu = new chucVu();
            InitializeComponent();
            qLchucVuServices = new QLchucVuServices();
        }
        public void load()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 2;
            dtg_show.Columns[0].Name = "Mã chức vụ";
            dtg_show.Columns[1].Name = "Tên chức vụ";
            foreach (var item in qLchucVuServices.GetchucVuFromDB())
            {
                dtg_show.Rows.Add(item.IDChucVu, item.tenCV);
            }
        }
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            //chucVu accchucvu = qLchucVuServices.GetchucVuFromDB().FirstOrDefault(p => p.maChucVu == tb_macv.Text);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (tb_tencv.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            //else if (accchucvu != null)
            //{
            //    MessageBox.Show("Mã chức vụ đã tồn tại");
            //    tb_macv.Text = "";
            //}
            else if (dialogResult == DialogResult.Yes)
            {
                chucVu chucVu = new chucVu();
                {
                    chucVu.tenCV = tb_tencv.Text;
                }
                qLchucVuServices.addChucVu(chucVu);
                load();
            }
            else
            {
                MessageBox.Show("bạn đã hủy thêm");
            }
        }

        private void btb_CapNhat_Click_1(object sender, EventArgs e)
        {
            ////var update = qLchucVuServices.GetchucVuFromDB().FirstOrDefault(p => p.maChucVu == tb_macv.Text);
            //DialogResult dialogResult = MessageBox.Show("bạn có muốn sửa không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    //update.tenCV = tb_tencv.Text;
            //    //qLchucVuServices.UpdateChucVu(update);
            //    //MessageBox.Show("cập nhật chức vụ thành công");
            //    //load();
            //}
            //else
            //{
            //    MessageBox.Show("bạn đã hủy sửa");
            //}
            if (_chucVu == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
            else
            {
                if (_chucVu.tenCV == tb_tencv.Text || (_chucVu.tenCV != tb_tencv.Text && qLchucVuServices.GetchucVuFromDB().FirstOrDefault(x => x.tenCV == tb_tencv.Text) == null))
                {
                    _chucVu.tenCV = tb_tencv.Text;
                    qLchucVuServices.UpdateChucVu(_chucVu);
                    MessageBox.Show("Cập nhật thành công");
                    load();
                    tb_tencv.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên chức vụ đã tồn tại");
                }
            }
        }

        private void dtg_cv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dtg_show.Rows[e.RowIndex];
            //    _chucVu = qLchucVuServices.GetchucVuFromDB().FirstOrDefault(x => x.maChucVu == Convert.ToInt32(row.Cells[0].Value));
            //    tb_tencv.Text = row.Cells[1].Value.ToString();
            //    //rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
            //    //rb_KHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            //}
        }

        private void dtg_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_chucVu == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
            else
            {
                if (_chucVu.tenCV == tb_tencv.Text || (_chucVu.tenCV != tb_tencv.Text && qLchucVuServices.GetchucVuFromDB().FirstOrDefault(x => x.tenCV == tb_tencv.Text) == null))
                {
                    _chucVu.tenCV = tb_tencv.Text;
                    qLchucVuServices.UpdateChucVu(_chucVu);
                    MessageBox.Show("Cập nhật thành công");
                    load();
                    tb_tencv.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên chức vụ đã tồn tại");
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //chucVu accchucvu = qLchucVuServices.GetchucVuFromDB().FirstOrDefault(p => p.maChucVu == tb_macv.Text);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (tb_tencv.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            //else if (accchucvu != null)
            //{
            //    MessageBox.Show("Mã chức vụ đã tồn tại");
            //    tb_macv.Text = "";
            //}
            else if (dialogResult == DialogResult.Yes)
            {
                chucVu chucVu = new chucVu();
                {
                    chucVu.tenCV = tb_tencv.Text;
                }
                qLchucVuServices.addChucVu(chucVu);
                load();
            }
            else
            {
                MessageBox.Show("bạn đã hủy thêm");
            }
        }
        public void Rs()
        {
            tb_tencv.Text = "";
            
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            Rs();
        }
    }
}

