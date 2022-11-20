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
using _2.BUS.ViewModel;

namespace _3.GUI.View
{
    public partial class FRChatLieu : Form
    { 
        IchatLieuServices _chatLieuServices;
        Guid _id;
        public FRChatLieu()
        {
            _chatLieuServices = new chatLieuServices();
            InitializeComponent();
            LoadDgrid();
        }
        private void LoadDgrid()
        {
            int stt = 1;
            dgrid_ht.ColumnCount = 4;
            dgrid_ht.Columns[0].Name = "STT";
            dgrid_ht.Columns[1].Name = "id";
            dgrid_ht.Columns[1].Visible = false;
            dgrid_ht.Columns[2].Name = "Ten chat lieu";
            dgrid_ht.Columns[3].Name = "trang thai";
            dgrid_ht.Rows.Clear();
            foreach( var c in _chatLieuServices.GetAll())
            {
                dgrid_ht.Rows.Add(stt++,c.IdChatLieu,c.tenCL,c.trangThai);
            }
        }
        private ChatLieuViews GetDBFromGui()
        {
           ChatLieuViews CL = new ChatLieuViews()
            {
                IdChatLieu = _id,
                tenCL = textBox1.Text,
            };
            return CL;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chatLieuServices.Add(GetDBFromGui()));
            LoadDgrid();
        }

        private void dgrid_ht_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
