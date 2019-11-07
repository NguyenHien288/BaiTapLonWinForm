using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            string input = txtSach.Text;

            if (cbxSach.SelectedIndex == 0)
            {
                Database dtBase = new Database();
                string sqlString =
                    "select DMSach.MaSach, DMSach.TenSach, NXB.TenNXB, DMSach.NamXB, DMSach.KhoSach, " +
                    " DMSach.LanTaiBan, TheLoai.TenTheLoai, NgonNgu.TenNgonNgu, DMSach.SoTrang," +
                    " DMSach.TomTatND, DMSach.SoLuong, DMSach.DoGiaThue " +
                    " from (((DMSach inner join NXB on DMSach.MaNXB = NXB.MaNXB) " +
                    " inner join TheLoai on DMSach.MaTheLoai = TheLoai.MaTheLoai) " +
                    " inner join NgonNgu on DMSach.MaNgonNgu = NgonNgu.MaNgonNgu) " +
                    " where DMSach.TenSach = N'" + input + "'; "; ;
                dgvSearch.DataSource = dtBase.DocBang(sqlString);
            }
            if (cbxSach.SelectedIndex == 1)
            {
                Database dtBase = new Database();
                string sqlString =
                    "select DMSach.MaSach, DMSach.TenSach, NXB.TenNXB, DMSach.NamXB, DMSach.KhoSach, " +
                    " DMSach.LanTaiBan, TheLoai.TenTheLoai, NgonNgu.TenNgonNgu, DMSach.SoTrang," +
                    " DMSach.TomTatND, DMSach.SoLuong, DMSach.DoGiaThue " +
                    " from (((DMSach inner join NXB on DMSach.MaNXB = NXB.MaNXB) " +
                    " inner join TheLoai on DMSach.MaTheLoai = TheLoai.MaTheLoai) " +
                    " inner join NgonNgu on DMSach.MaNgonNgu = NgonNgu.MaNgonNgu) " +
                    " where TheLoai.TenTheLoai = N'" + input + "'; ";
                dgvSearch.DataSource = dtBase.DocBang(sqlString);
            }
            if (cbxSach.SelectedIndex == 2)
            {
                Database dtBase = new Database();
                string sqlString =
                    "select DMSach.MaSach, DMSach.TenSach, NXB.TenNXB, DMSach.NamXB, DMSach.KhoSach, " +
                    " DMSach.LanTaiBan, TheLoai.TenTheLoai, NgonNgu.TenNgonNgu, DMSach.SoTrang," +
                    " DMSach.TomTatND, DMSach.SoLuong, DMSach.DoGiaThue " +
                    " from (((DMSach inner join NXB on DMSach.MaNXB = NXB.MaNXB) " +
                    " inner join TheLoai on DMSach.MaTheLoai = TheLoai.MaTheLoai) " +
                    " inner join NgonNgu on DMSach.MaNgonNgu = NgonNgu.MaNgonNgu) " +
                    " where NXB.TenNXB = N'" + input + "'; ";
                dgvSearch.DataSource = dtBase.DocBang(sqlString);
            }
        }

        private void btnTimThuThu_Click(object sender, EventArgs e)
        {
            string input = txtThuThu.Text;

            if (cbxThuThu.SelectedIndex == 0)
            {
                Database dtBase = new Database();
                string sqlString = "select * from ThuThu where TenThuThu = N'" + input + "'; ";
                dgvSearch.DataSource = dtBase.DocBang(sqlString);
            }
            if (cbxThuThu.SelectedIndex == 1)
            {
                Database dtBase = new Database();
                string sqlString =
                    " select ThuThu.MaThuThu, ThuThu.TenThuThu, ThuThu.DiaChi, ThuThu.DienThoaiCD, ThuThu.DienThoaiDD, ThuThu.MaQue"
                    + " from (ThuThu"
                    + " inner join HoSoMuon on HoSoMuon.MaThuThu = ThuThu.MaThuThu)"
                    + " where HoSoMuon.MaHSM = N'" + input + "';";

                dgvSearch.DataSource = dtBase.DocBang(sqlString);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSach.SelectedIndex = 0;
            cbxThuThu.SelectedIndex = 0;
        }

        private void txtSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTimSach.PerformClick();

            }
        }

        private void txtThuThu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTimThuThu.PerformClick();

            }
        }
    }
}
