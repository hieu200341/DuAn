using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
namespace _3.GUI.View
{
    public partial class FrmQuenMk : Form
    {
        IQLnhanVienServices _services;
        
        public FrmQuenMk()
        {
            _services = new QLnhanVienServices();
            InitializeComponent();
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_email.Text))
            {
                FUNC.mailSupport mail = new FUNC.mailSupport("hungvdph27472@fpt.edu.vn", "nflpkokrnvqwlkqm");
                string new_pass = Guid.NewGuid().ToString().Substring(0,8);
                var taikhoan = _services.GetNhanVienFromDB().FirstOrDefault(c=>c.nhanViens.email == txt_email.Text);
                if(taikhoan!= null)
                {
                    mail.send(txt_email.Text,
                   "Yêu cầu lấy lại mật khẩu",
                   string.Format("đây là mật khẩu mới của bạn: {0}", new_pass));
                    taikhoan.nhanViens.matKhau = new_pass;
                    _services.UpdateNhanVien(taikhoan);                    
                    MessageBox.Show("Chúng tôi đã gửi mật khẩu tới email của bạn");
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show(txt_email.Text+" không tồn tại "  );
                }               
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email xác thực");
            }
            
        }        
        private void FrmQuenMk_Load(object sender, EventArgs e)
        {
            if(cb_check.Checked == false)
            {
                btn_send.Enabled = false;
            }           
        }

        private void cb_check_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_check.Checked == true)
            {
                btn_send.Enabled = true;
            }
            else
            {
                btn_send.Enabled = false;
            }
        }
    }
}
