using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3.GUI.View.BanHang
{
    public partial class FrmGioHang : Form
    {
<<<<<<< HEAD
        
        private IQLsanPhamServices _SanPham;
        private IQLhoaDonChiTietServices _hoaDonChiTiet;
        private IQLhoaDonServices _hoaDon;
        //private IQLnhanVienServices _employee;
        private IQLkhachHangServices _KhachHang;
        public List<ViewHoaDonCT> _lstViewHoaDon;
        public int pID;
        public khachHang KH;
        public int oID;
        public FrmGioHang()
        {
=======
        private IQLsanPhamServices _qLsanPhamServices;
        public FrmGioHang()
        {
            _qLsanPhamServices= new QLsanPhamServices();
>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3
            InitializeComponent();
            _SanPham = new QLsanPhamServices();
            _hoaDonChiTiet = new QLhoaDonChiTietServices();
            _hoaDon = new QLhoaDonServices();
            _KhachHang = new QLkhachHangServices();
            _lstViewHoaDon = new List<ViewHoaDonCT>();
            KH = new khachHang();
            oID = -1;

            LoadSanPham();
<<<<<<< HEAD
            loadHDcho();
=======
>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3
        }
        public void LoadSanPham()
        {
            dtgv_HDcho.Rows.Clear();
            foreach (var item in _SanPham.getViewSanPham())
            {
                dtgv_sanPham.Rows.Add(item.SanPhams.maSanPham, item.SanPhams.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhams.Giaban, item.hangSXs.tenHangSX, item.SanPhams.Soluong);
            }
        }
<<<<<<< HEAD
        public void loadGioHang()
        {
            dtgv_gioHang.Rows.Clear();
            foreach (var item in _lstViewHoaDon)
            {
                dtgv_gioHang.Rows.Add(item.ID, item.tenSanPham, item.soLuong, item.donGia);
            }
            TONGTIEN();
        }
        public void loadHDcho()
        {
            dtgv_HDcho.Rows.Clear();
            var hdCho = _hoaDon.GetHoaDonFromDB().Where(x => x.trangThai == false);
            foreach (var item in hdCho)
            {
                dtgv_HDcho.Rows.Add(item.IDHoaDon.ToString());
            }
        }
        public void addCart(int pID)
        {
            var p = _SanPham.getViewSanPham().FirstOrDefault(x => x.SanPhams.IDSanPham == pID);
            var data = _lstViewHoaDon.FirstOrDefault(x => x.ID == p.SanPhams.IDSanPham);
            if (data == null)
            {
                ViewHoaDonCT viewHDCT = new ViewHoaDonCT()
                {
                    ID = p.SanPhams.IDSanPham,
                    tenSanPham = p.SanPhams.TenSP,
                    donGia = p.SanPhams.Giaban,
                    soLuong = 1,
                    maSanPham = p.SanPhams.maSP
                };
                _lstViewHoaDon.Add(viewHDCT);
            }
            else
            {
                if (data.soLuong == p.SanPhams.Soluong)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
                else
                {
                    data.soLuong++;
                }
            }
            loadGioHang();
        }



        private void dtgv_gioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
                if (int.TryParse(dtgv_gioHang.Rows[r.Index].Cells[2].Value.ToString(), out int x))
                {
                    if (dtgv_gioHang.Rows[r.Index].Cells[2].Value != _lstViewHoaDon[r.Index].soLuong.ToString())
                    {
                        if (Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value) <= 0)
                        {
                            MessageBox.Show("Nhập sai số lượng");
                            dtgv_gioHang.Rows[r.Index].Cells[2].Value = _lstViewHoaDon[r.Index].soLuong;
                        }
                        else
                        {
                            var p = _SanPham.GetSanPhamFromDB().FirstOrDefault(x => x.IDSanPham == _lstViewHoaDon[r.Index].ID);
                            if (p.Soluong < Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value))
                            {
                                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                dtgv_gioHang.Rows[r.Index].Cells[2].Value = _lstViewHoaDon[r.Index].soLuong;
                            }
                            else
                            {
                                _lstViewHoaDon[r.Index].soLuong = Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value);
                                TONGTIEN();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai số lượng");
                    dtgv_gioHang.Rows[r.Index].Cells[3].Value = _lstViewHoaDon[r.Index].soLuong;
                }
            }
        }

        private void dtgv_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_sanPham.Rows[e.RowIndex];
                pID = Convert.ToInt32(r.Cells[0].Value.ToString());
                addCart(pID);
            }
        }

        private void dtgv_gioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
                pID = Convert.ToInt32(r.Cells[0].Value.ToString());
            }
        }

        private void tbt_maHD_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbt_maHD.Text, out int m))
            {
                hoaDon o = _hoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == Convert.ToInt32(tbt_maHD.Text) && x.trangThai == false);
                if (o != null)
                {
                    lbl_Tong.Text = o.tongTien.ToString();
                    var khach = _KhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == o.SDT_KH);
                    lbl_giamGia.Text = $"(Tối đa : {khach.diem})";
                }
                else
                {
                    lbl_Tong.Text = "0";
                    lbl_giamGia.Text = "Tối đa : 0";
                }
            }
        }

        private void btn_xoaSP_Click(object sender, EventArgs e)
        {
            if (_lstViewHoaDon.Any())
            {
                var item = _lstViewHoaDon.FirstOrDefault(x => x.ID == pID);
                _lstViewHoaDon.Remove(item);
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_xoaGioHang_Click(object sender, EventArgs e)
        {
            if (_lstViewHoaDon.Any())
            {
                _lstViewHoaDon = new List<ViewHoaDonCT>();
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            if (_lstViewHoaDon.Any())
            {
                float Tong = 0;
                foreach (var item in _lstViewHoaDon)
                {
                    Tong += item.donGia * item.soLuong;
                }
                KH = _KhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == tbt_SDT.Text);
                if (KH != null)
                {
                    hoaDon HD = new hoaDon()
                    {
                        IDNhanVien = 1,
                        SDT_KH = KH.SDT_KH,
                        ngayBan = DateTime.Now,
                        tongTien = Tong,
                        trangThai = false,
                        ghiChu = ""
                    };
                    _hoaDon.addHoaDon(HD);
                    foreach (var item in _lstViewHoaDon)
                    {
                        hoaDonChiTiet od = new hoaDonChiTiet()
                        {
                            IDHoaDon = HD.IDHoaDon,
                            IDSanPham = item.ID,
                            donGia = item.donGia,
                            Soluong = item.soLuong
                        };
                        _hoaDonChiTiet.addHoaDonChiTiet(od);
                        var p = _SanPham.GetSanPhamFromDB().FirstOrDefault(x => x.IDSanPham == item.ID);
                        p.Soluong -= item.soLuong;
                        _SanPham.UpdateSanPham(p);
                    }

                    tbt_maHD.Text = HD.IDHoaDon.ToString();
                    lbl_Tong.Text = HD.tongTien.ToString();
                    lbl_tongTien.Text = "";
                    MessageBox.Show($"Tạo hóa đơn thành công. ID: {HD.IDHoaDon}");
                    loadHDcho();
                    _lstViewHoaDon = new List<ViewHoaDonCT>();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_CapNhatHD_Click(object sender, EventArgs e)
        {
            if (oID != -1)
            {
                if (_lstViewHoaDon.Any())
                {
                    int Tien = 0;
                    KH = _KhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == tbt_SDT.Text);
                    if (KH != null)
                    {
                        var HD = _hoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == oID);
                        var HDCT = _hoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == oID);
                        foreach (var item in HDCT)
                        {
                            _hoaDonChiTiet.RemoveHoaDonChiTiet(item);
                        }


                        foreach (var item in _lstViewHoaDon)
                        {
                            hoaDonChiTiet hoaDonChi = new hoaDonChiTiet()
                            {
                                IDHoaDon = oID,
                                IDSanPham = item.ID,
                                donGia = item.donGia,
                                Soluong = item.soLuong
                            };
                            Tien += Convert.ToInt32(item.donGia * item.soLuong);
                            _hoaDonChiTiet.addHoaDonChiTiet(hoaDonChi);
                            var SP = _SanPham.GetSanPhamFromDB().FirstOrDefault(x => x.IDSanPham == item.ID);
                            SP.Soluong -= item.soLuong;
                            _SanPham.UpdateSanPham(SP);
                        }

                        HD.ngayBan = DateTime.Now;
                        HD.SDT_KH = KH.SDT_KH;
                        HD.tongTien = Tien;
                        _hoaDon.UpdateHoaDon(HD);

                        tbt_maHD.Text = oID.ToString();
                        lbl_Tong.Text = HD.ToString();
                        tbt_SDT.Text = "";
                        lbl_tongTien.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {oID}");
                        oID = -1;
                        loadHDcho();
                        dtgv_gioHang.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            }
        }

        private void dtgv_HDcho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_HDcho.Rows[e.RowIndex];
                oID = Convert.ToInt32(r.Cells[0].Value.ToString());
                tbt_maHD.Text = oID.ToString();

                var HDCT = _hoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == oID);
                var HD = _hoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == oID).SDT_KH;
                var KH = _KhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HD);
                tbt_SDT.Text = KH.SDT_KH;

                _lstViewHoaDon = new List<ViewHoaDonCT>();
                foreach (var item in HDCT)
                {
                    var SP = _SanPham.GetSanPhamFromDB().FirstOrDefault(x => x.IDSanPham == item.IDSanPham);

                    ViewHoaDonCT ViewHDCT = new ViewHoaDonCT()
                    {
                        ID = SP.IDSanPham,
                        tenSanPham = SP.TenSP,
                        donGia = SP.Giaban,
                        soLuong = HDCT.FirstOrDefault(x => x.IDSanPham == SP.IDSanPham).Soluong
                    };
                    _lstViewHoaDon.Add(ViewHDCT);

                    loadGioHang();
                }
            }
        }

        public void TONGTIEN()
        {
            if (_lstViewHoaDon != null)
            {
                int Tien = 0;
                foreach (var item in _lstViewHoaDon)
                {
                    Tien += Convert.ToInt32(item.donGia) * item.soLuong;
                }
                lbl_tongTien.Text = Tien.ToString();
            }
            else
            {
                lbl_tongTien.Text = "";
            }
        }

        public void loadTienThua()
        {
            if (!(tbt_tienKhachDua.Text == "" && tbt_giamGia.Text == ""))
            {
                if (tbt_giamGia.Text == "")
                {
                    if (float.TryParse(tbt_tienKhachDua.Text, out float x))
                    {
                        lbl_TienThua.Text = (float.Parse(tbt_tienKhachDua.Text) - float.Parse(lbl_Tong.Text)).ToString();
                    }
                }
                else
                {
                    if (float.TryParse(tbt_tienKhachDua.Text, out float x) && float.TryParse(tbt_giamGia.Text, out float y))
                    {
                        lbl_TienThua.Text = (float.Parse(tbt_tienKhachDua.Text) - float.Parse(lbl_Tong.Text) + float.Parse(tbt_giamGia.Text)).ToString();
                    }
                }
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            hoaDon HD = _hoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == Convert.ToInt32(tbt_maHD.Text) && x.trangThai == false);
            if (HD == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                lbl_tongTien.Text = "0";
            }
            else
            {
                var KhachH = _KhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HD.SDT_KH);
                int x;
                if (tbt_giamGia.Text == "" || Convert.ToInt32(lbl_TienThua.Text) < 0 || tbt_tienKhachDua.Text == "" || (!int.TryParse(tbt_giamGia.Text, out x) && tbt_giamGia.Text != "") || !int.TryParse(tbt_tienKhachDua.Text, out int y) || Convert.ToInt32(tbt_giamGia.Text) > Convert.ToInt32(lbl_tongTien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số tiền");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HD.trangThai = true;
                        _hoaDon.UpdateHoaDon(HD);
                        if (tbt_tienKhachDua.Text == "0" && float.Parse(tbt_giamGia.Text) > HD.tongTien)
                        {
                            lbl_TienThua.Text = "0";
                            KhachH.diem -= Convert.ToInt32(HD.tongTien);
                        }
                        else
                        {
                            if (tbt_giamGia.Text != "")
                            {
                                KhachH.diem = KhachH.diem + Convert.ToInt32(HD.tongTien / 100) - Convert.ToInt32(tbt_giamGia.Text);
                            }
                            else
                            {
                                KhachH.diem += Convert.ToInt32(HD.tongTien / 100);
                            }
                        }
                        _KhachHang.UpdateKhachHang(KhachH);
                        MessageBox.Show("Thanh toán thành công");
                        tbt_giamGia.Text = "";
                        tbt_tienKhachDua.Text = "";
                        lbl_tongTien.Text = "0";
                        lbl_TienThua.Text = "0";
                        tbt_ghiChu.Text = "";
                    }
                }
            }

        }

        private void tbt_tienKhachDua_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        private void tbt_giamGia_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        private void tbt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbt_SDT.Text, out int x))
            {
                KH = _KhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == tbt_SDT.Text);
                if (KH != null)
                {
                    lbl_tenKhach.Text = KH.TenKH;
                    lbl_Diem.Text = KH.diem.ToString();
                }
                else
                {
                    lbl_tenKhach.Text = "";
                    lbl_Diem.Text = "";
                }
            }
            else
            {
                lbl_tenKhach.Text = "";
                lbl_Diem.Text = "";
            }
        }
=======
>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3
    }
}
