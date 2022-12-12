using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using AForge.Video.DirectShow;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View.FromSanPham
{
    public partial class FrmSanPhamChiTiet : Form
    {
        IQLhangSXServices _QLhangServices;
        IQLmauSacServices _qLmauSacServices;
        IQLsizeServices _qLsizeServices;
        IQLsanPhamChiTietServices _qLsanPhamCTServices;
        IQLsanPhamServices _qLsanPhamServices;
        public sanPhamChiTiet _sanPhamCT;
        public string Avatar = "";
        public FrmSanPhamChiTiet()
        {
            _qLsizeServices = new QLsizeServices();
            _qLmauSacServices = new QLmauSacServices();
            _QLhangServices = new QLhangSXServices();
            _qLsanPhamCTServices = new QLsanPhamChiTietServices();
            _qLsanPhamServices= new QLsanPhamServices();
            _sanPhamCT = new sanPhamChiTiet();
            InitializeComponent();
            rb_con.Checked = true;
            LoadNhaSanXuat();
            LoadMauSac();
            LoadSize();
            loadDuLieu();
            LoadloaiHang();

        }
        public void LoadNhaSanXuat()
        {
            var nsx = _QLhangServices.GetHangSXFromDB().Where(x => x.trangThai == true);
            foreach (var item in nsx)
            {
                cb_NSX.Items.Add(item.tenHangSX.ToString());
            }
            cb_NSX.SelectedIndex = 0;
        }
        public void LoadMauSac()
        {
            var mau = _qLmauSacServices.GetMauSacFromDB().Where(x => x.trangThai == true);
            foreach (var item in mau)
            {
                cb_Mau.Items.Add(item.tenMau.ToString());
            }
            cb_Mau.SelectedIndex = 0;
        }
        public void LoadSize()
        {
            //cb_size.Items.Clear();
            //cb_size.Items.Add("..");
            var size = _qLsizeServices.GetSizeFromDB().Where(x => x.trangThai == true);
            foreach (var item in size)
            {
                cb_size.Items.Add(item.SiZe.ToString());
            }
            cb_size.SelectedIndex = 0;
        }
        public void LoadloaiHang()
        {
            var loaiH = _qLsanPhamServices.GetsanPhamFromDB().Where(x => x.trangThai == true);
            foreach (var item in loaiH)
            {
                cbb_loaiHang.Items.Add(item.tenLoaiHang);
            }
            cbb_loaiHang.SelectedIndex = 0;
        }
        public void loadDuLieu()
        {
            dtgv_sanPham.Rows.Clear();
            foreach (var item in _qLsanPhamCTServices.getViewSanPhamCT())
            {
                dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet,item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.SanPhamChiTiets.Gianhap, item.SanPhamChiTiets.Giaban, item.SanPhamChiTiets.Soluong,item.mauSacs.tenMau, item.sizes.SiZe,item.hangSXs.tenHangSX, item.sanPhams.tenLoaiHang,
                    item.SanPhamChiTiets.Trangthai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void ptb_linkAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (ptb_linkAnh.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi ảnh ko?",
                    "...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        Avatar = op.FileName;
                        ptb_linkAnh.Image = Image.FromFile(op.FileName);
                        ptb_linkAnh.SizeMode = PictureBoxSizeMode.StretchImage; 
                        MessageBox.Show(op.FileName);
                    }
                }
            }
            if (ptb_linkAnh.Image == null)
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Avatar = op.FileName;
                    ptb_linkAnh.Image = Image.FromFile(op.FileName);
                    ptb_linkAnh.SizeMode = PictureBoxSizeMode.CenterImage;
                    MessageBox.Show(op.FileName);
                }
            }
        }
        private bool checkValidate()
        {
            if ( tbt_ten.Text.Trim() == "" || tbt_giaNhap.Text.Trim() == "" 
                || tbt_giaBan.Text.Trim() == "" || tbt_soLuong.Text.Trim() == "" || cb_Mau.Text.Trim() =="" 
                || cb_size.Text.Trim() == ""|| cb_NSX.Text.Trim() =="" || cbb_loaiHang.Text.Trim() == "") return false;
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            sanPhamChiTiet masp = _qLsanPhamCTServices.GetSanPhamCTTFromDB().FirstOrDefault
            (p => p.maSP == tbt_maSP.Text);
            //sanPhamChiTiet tsp = _qLsanPhamCTServices.GetSanPhamCTTFromDB().FirstOrDefault
            //(p => p.TenSP == tbt_ten.Text);
            string number = tbt_giaBan.Text;
            number = tbt_giaNhap.Text;
            number = tbt_soLuong.Text;
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            Match match = regex.Match(number);
            if (!match.Success)
            {
                MessageBox.Show("Số lượng, đơn giá nhập hoặc đơn giá bán không hợp lệ");
            }
            else if (masp != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
                tbt_maSP.Text = "";
            }
            //else if (tsp != null)
            //{
            //    MessageBox.Show("Tên sản phẩm đã tồn tại");
            //    tbt_ten.Text = "";
            //}
            else if (checkValidate() == false)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (float.Parse(tbt_giaNhap.Text) > float.Parse(tbt_giaBan.Text))
            {
                MessageBox.Show("Giá bán phải cao hơn giá nhập");
            }
            else if (Avatar == "")
            {
                MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm");
            }
            else
            {
                sanPhamChiTiet sp = new sanPhamChiTiet()
                {
                    maSP = tbt_maSP.Text,
                    TenSP = tbt_ten.Text,
                    Gianhap = float.Parse(tbt_giaNhap.Text),
                    Giaban = float.Parse(tbt_giaBan.Text),
                    Soluong = Convert.ToInt32(tbt_soLuong.Text),
                    IDMauSac = _qLmauSacServices.GetMauSacFromDB()[cb_Mau.SelectedIndex].IDMauSac,
                    IDSize = _qLsizeServices.GetSizeFromDB()[cb_size.SelectedIndex].IDSize,
                    IDHangSX = _QLhangServices.GetHangSXFromDB()[cb_NSX.SelectedIndex].IDHangSX,
                    IDsanPham = _QLhangServices.GetHangSXFromDB()[cbb_loaiHang.SelectedIndex].IDHangSX,
                    Trangthai = rb_con.Checked,
                    linkAnh = Avatar
                };
                
                _qLsanPhamCTServices.addsanPham(sp);
                MessageBox.Show("Thêm sản phẩm thành công");
                loadDuLieu();

            }
        }

        private void dtgv_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_sanPham.Rows[e.RowIndex];
                tbt_maSP.Text = row.Cells[1].Value.ToString();
                tbt_ten.Text = row.Cells[2].Value.ToString();
                tbt_giaNhap.Text = row.Cells[3].Value.ToString();
                tbt_giaBan.Text = row.Cells[4].Value.ToString();
                tbt_soLuong.Text = row.Cells[5].Value.ToString();
                cb_Mau.Text = row.Cells[6].Value.ToString();
                cb_size.Text = row.Cells[7].Value.ToString();
                cb_NSX.Text = row.Cells[8].Value.ToString();
                cbb_loaiHang.Text = row.Cells[9].Value.ToString();
                rb_con.Checked = row.Cells[10].Value.ToString() == "Còn hàng" ? true : false;
                rb_het.Checked = row.Cells[10].Value.ToString() == "Hết hàng" ? true : false;
                var data = _qLsanPhamCTServices.GetSanPhamCTTFromDB().FirstOrDefault(p => p.maSP.ToString() == row.Cells[1].Value.ToString());
                //Image image = Image.FromFile(laylinkanh);
                //Avatar = laylinkanh;
                //ptb_linkAnh.Image = image;
                ptb_linkAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                if (data.linkAnh != null && File.Exists(data.linkAnh))
                {
                    ptb_linkAnh.Image = Image.FromFile(data.linkAnh);
                    ptb_linkAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    Avatar = data.linkAnh;
                }
                else
                {
                    ptb_linkAnh.Image = null;
                }
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            var update = _qLsanPhamCTServices.GetSanPhamCTTFromDB().FirstOrDefault(p => p.maSP == tbt_maSP.Text);
            if (update == null)
            {
                MessageBox.Show("Vui lòng nhập đúng mã sản phẩm");
            }
            else
            {
                //var tensp = _qLsanPhamCTServices.GetSanPhamCTTFromDB().FirstOrDefault(p => p.TenSP == tbt_ten.Text);

                if (checkValidate() == false)
                {
                    MessageBox.Show("Không được để trống các trường");
                }
                //else if ( tensp != null)
                //{
                //    MessageBox.Show("Tên sản phẩm đã tồn tại");
                //}
                else if (Convert.ToDecimal(tbt_giaNhap.Text) > Convert.ToDecimal(tbt_giaBan.Text))
                {
                    MessageBox.Show("Giá bán phải cao hơn giá nhập");
                }
                else if (Avatar == "")
                {
                    MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm");
                }
                else
                {
                    update.TenSP = tbt_ten.Text;
                    update.Gianhap = float.Parse(tbt_giaNhap.Text);
                    update.Giaban = float.Parse(tbt_giaBan.Text);
                    update.Soluong = Convert.ToInt32(tbt_soLuong.Text);
                    update.IDMauSac = _qLmauSacServices.GetMauSacFromDB()[cb_Mau.SelectedIndex].IDMauSac;
                    update.IDSize = _qLsizeServices.GetSizeFromDB()[cb_size.SelectedIndex].IDSize;
                    update.IDHangSX = _QLhangServices.GetHangSXFromDB()[cb_NSX.SelectedIndex].IDHangSX;
                    update.IDsanPham = _QLhangServices.GetHangSXFromDB()[cbb_loaiHang.SelectedIndex].IDHangSX;
                    update.Trangthai = rb_con.Checked == true ? true : false;
                    update.linkAnh = Avatar;
                    _qLsanPhamCTServices.UpdateSanPham(update);
                    MessageBox.Show("Cập nhật sản phẩm thành công");
                    loadDuLieu();
                    
                }
            }
        }

        private void tbt_timKiem_TextChanged(object sender, EventArgs e)
        {
            dtgv_sanPham.Rows.Clear();
            foreach (var item in _qLsanPhamCTServices.getViewSanPhamCT().Where(x => x.SanPhamChiTiets.maSP.ToLower().Contains(tbt_timKiem.Text.ToLower()) || x.SanPhamChiTiets.TenSP.ToLower().Contains(tbt_timKiem.Text) 
            || x.mauSacs.tenMau.ToLower().Contains(tbt_timKiem.Text) || x.hangSXs.tenHangSX.ToLower().Contains(tbt_timKiem.Text) 
            || x.sizes.SiZe.ToLower().Contains(tbt_timKiem.Text) || x.sanPhams.tenLoaiHang.ToLower().Contains(tbt_timKiem.Text) 
            || Convert.ToString(x.SanPhamChiTiets.IDsanPham).Contains(tbt_timKiem.Text)))
            {
                dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.SanPhamChiTiets.Gianhap, item.SanPhamChiTiets.Giaban, item.SanPhamChiTiets.Soluong, item.mauSacs.tenMau, item.sizes.SiZe, item.hangSXs.tenHangSX, item.sanPhams.tenLoaiHang,
                   item.SanPhamChiTiets.Trangthai == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void senderexcel(string path)
        {
            using (ExcelPackage p = new ExcelPackage())
            {
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = "Báo cáo thống kê";

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("sheet");

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[1];

                // đặt tên cho sheet
                ws.Name = "sheet";
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";

                for (int i = 0; i < dtgv_sanPham.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = dtgv_sanPham.Columns[i].HeaderText;
                }
                for (int i = 0; i < dtgv_sanPham.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_sanPham.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = dtgv_sanPham.Rows[i].Cells[j].Value;
                    }
                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);

                /*excel.Application application = new excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dtgv_HDcho.Columns.Count; i++)
                {
                    application.Cells[1, i + 1] = dtgv_HDcho.Columns[i].HeaderText;
                }
                for (int i = 0; i < dtgv_HDcho.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_HDcho.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dtgv_HDcho.Rows[i].Cells[j].Value;
                    }
                }
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;*/
            };
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                try
                {
                    senderexcel(filePath);
                    MessageBox.Show("Xuất File Excel Thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xuất File Excel không  Thành công" + ex.Message);
                }
            }

        }
       
        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                try
                {
                    senderexcel(filePath);
                    MessageBox.Show("Xuất File Excel Thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xuất File Excel không  Thành công" + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ptb_linkAnh_Click_1(object sender, EventArgs e)
        {

        }
    }
}
