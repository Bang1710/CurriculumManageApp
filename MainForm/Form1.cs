using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        KhoaBLL khoaBLL;
        GiaoVienBLL giaovienBLL;
        public Form1()
        {
            InitializeComponent();
            khoaBLL = new KhoaBLL();
            giaovienBLL = new GiaoVienBLL();
            Custom();
            
        }

        public void Custom()
        {
            ListKhoa.ColumnHeadersHeight = 40; // set chiều cao của header row là 40
            ListGV.ColumnHeadersHeight = 40; // set chiều cao của header row là 40


            ListKhoa.RowTemplate.Height = 40; // set chiều cao của row là 40
            ListGV.RowTemplate.Height = 40; // set chiều cao của row là 40
                                            //BindingData();

            btnEditMode.BackColor = Color.Gray;
            btnEditMode.ForeColor = Color.Black;


            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        //public void BindingData()
        //{

        //    var listGiangVien = giaovienBLL.getListGiaoVien();
        //    var giaoviens = listGiangVien.Where(x => x.MaKhoa == x.Khoa.MaKhoa).Select(x => new { x.MaGiaoVien, x.HoTen, x.Khoa.TenKhoa }).ToList();
        //    txtID.DataBindings.Clear();
        //    txtHoTen.DataBindings.Clear();
        //    cbKhoa.DataBindings.Clear();
        //    txtID.DataBindings.Add("Text",giaoviens, "MaGiaoVien");
        //    txtHoTen.DataBindings.Add("Text",giaoviens, "HoTen");
        //    cbKhoa.DataBindings.Add("Text",giaoviens, "TenKhoa");
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataKhoa();
            LoadDataGiaoVien();
        }

        public void LoadDataKhoa()
        {
            ListKhoa.DataSource = khoaBLL.getListKhoa();
            cbKhoa.DataSource = khoaBLL.getListKhoa();
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.Text = "";
        }


        public void LoadDataGiaoVien()
        {
            var giaoviens = giaovienBLL.getListGiaoVien().Where(x => x.MaKhoa == x.Khoa.MaKhoa).Select(x => new { x.MaGiaoVien, x.HoTen, x.Khoa.TenKhoa }).ToList();
            ListGV.DataSource = giaoviens;
        }

        public bool CheckData(string magv, string hoten, string makhoa) // doing
        {

            var listGiangVien = giaovienBLL.getListGiaoVien();
            var giaoviens = listGiangVien.Where(x => x.MaGiaoVien == magv).FirstOrDefault();
            if (string.IsNullOrEmpty(magv) || magv.Length > 11)
            {
                MessageBox.Show("ID không hợp lệ, dữ liệu không được bỏ trống và chiều dài khoogn quá 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (giaoviens != null)
            {
                MessageBox.Show("ID đã tồn tại, hãy nhập lại ID khác !");
                return false;
            }

            return true;
        }

        public void ClearData()
        {
            txtID.Text = "";
            txtHoTen.Text = "";
            cbKhoa.Text = "";
        }

        private void btnAddGiangVien_Click(object sender, EventArgs e) // done
        {
            var magv = txtID.Text.ToString().Trim();
            var hoten = txtHoTen.Text.ToString().Trim();   
            var makhoa = cbKhoa.SelectedValue.ToString().Trim();

            if (CheckData(magv, hoten, makhoa))
            {
                var giaovien = new GiaoVien()
                {
                    MaGiaoVien = magv,
                    HoTen = hoten,
                    MaKhoa = makhoa,
                };

                giaovienBLL.AddGiangVien(giaovien);
                LoadDataGiaoVien();
            } else
            {
                MessageBox.Show("thêm giảng viên không thành công");
            }

        }

        private void ListGV_CellClick(object sender, DataGridViewCellEventArgs e) // done
        {
            int index = e.RowIndex;
            ClearData();
            if (btnEditMode.Text == "ON")
            {
                if (index >= 0 && index < ListGV.Rows.Count - 1)
                {
                    txtID.Text = ListGV.Rows[index].Cells["MaGiangVien_GV"].Value.ToString();
                    txtHoTen.Text = ListGV.Rows[index].Cells["TenGiangVien_GV"].Value.ToString();
                    cbKhoa.Text = ListGV.Rows[index].Cells["TenKhoa_GV"].Value.ToString();
                }
            }
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            if (btnEditMode.Text == "ON")
            {
                btnEditMode.Text = "OFF";

                btnEditMode.BackColor = Color.Gray;
                btnEditMode.ForeColor = Color.Black;
                
                btnAdd.Enabled = true;

                btnSave.Enabled = false;
                btnDelete.Enabled = false;

                txtID.Enabled = true;

                ClearData();
            }
            else if(btnEditMode.Text == "OFF")
            {
                btnEditMode.Text = "ON";

                btnEditMode.BackColor = Color.Green;
                btnEditMode.ForeColor = Color.White;

                btnAdd.Enabled = false;

                btnSave.Enabled = true;
                btnDelete.Enabled = true;

                txtID.Enabled = false;
                txtID.BorderStyle = BorderStyle.FixedSingle;

                ClearData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var magv = txtID.Text.ToString().Trim();
            var hoten = txtHoTen.Text.ToString().Trim();
            var makhoa = cbKhoa.SelectedValue.ToString().Trim();

            var listGiaoVien = giaovienBLL.getListGiaoVien();
            var gv = listGiaoVien.Where(g => g.MaGiaoVien == magv && g.HoTen == hoten && g.Khoa.MaKhoa == makhoa).FirstOrDefault();


            if(gv != null)
            {
                MessageBox.Show("Thông tin chưa chỉnh sửa, không cho phép lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                giaovienBLL.EditGiangVien(magv, hoten, makhoa);
                LoadDataGiaoVien();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var magv = txtID.Text.ToString().Trim();
            var hoten = txtHoTen.Text.ToString().Trim();
            var makhoa = cbKhoa.SelectedValue.ToString().Trim();

            var listGiaoVien = giaovienBLL.getListGiaoVien();
            var gv = listGiaoVien.Where(g => g.MaGiaoVien == magv && g.HoTen == hoten && g.Khoa.MaKhoa == makhoa).FirstOrDefault();
            if(gv != null)
            {
                if (giaovienBLL.DeleteGiaoVien(magv))
                {
                    LoadDataGiaoVien();
                } else
                {
                    MessageBox.Show("Không cho phép xóa, vì dữ liệu liên quan đến các đối tượng khác");
                }

            } else
            {
                MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa");
            }
        }

        private void ListGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



