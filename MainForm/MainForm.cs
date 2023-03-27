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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainForm
{
    public partial class MainForm : Form
    {
        KhoaBLL khoaBLL;

        public MainForm()
        {
            InitializeComponent();

            SetUpControlLoadingForm();
            CustomdatagirdviewMenu();

            // KHOA
            turnOffEditModeKhoa();
            khoaBLL = new KhoaBLL();
            LoadDataKhoaGirdView();
            LoadDataKhoaCombobox();
        }

        //---------------------------Set up general------------------------------------

        public void SetUpControlLoadingForm()
        {
            // Không chọn node nào khi form load lên
            TreeMenu.SelectedNode = null;
            // Khi load lên tabcontrol sẽ bị ẩn đi
            tabFunction.Visible = false;
            // Picture box quay về cũng bị ẩn đi
            backPage.Visible = false;
        }

        public void CustomdatagirdviewMenu()
        {
            // Tạo đối tượng DataGridViewRow mới
            DataGridViewRow row1 = new DataGridViewRow();
            row1.CreateCells(dataGridView11);

            // Thiết lập giá trị cho các ô trong dòng
            row1.Cells[0].Value = "Bản tin 01";
            row1.Cells[1].Value = " Văn Bang";
            row1.Cells[2].Value = DateTime.Now.ToString();

            // Thêm dòng vào DataGridView
            dataGridView11.Rows.Add(row1);

            // Tạo dòng thứ hai và thêm vào DataGridView
            DataGridViewRow row2 = new DataGridViewRow();
            row2.CreateCells(dataGridView11);
            row2.Cells[0].Value = "Bản tin 02";
            row2.Cells[1].Value = "Duy Đạt";
            row2.Cells[2].Value = DateTime.Now.ToString();
            dataGridView11.Rows.Add(row2);
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            tabFunction.Visible = false;
            TreeMenu.TabStop = false;
            TreeMenu.SelectedNode = null;
            backPage.Visible = false;
            panel32.Visible = true;
        }

        private void TreeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeName = e.Node.Name;
            // tabcontrol và picturebox quay về hiển trở lại khi ta chọn một node bất kì, đồng thời hiển thị tab tương ứng
            tabFunction.Visible = true;
            backPage.Visible = true;

            // Khi tabcontrol hiển trở lại thì Menu bản tin bị ẩn đi
            panel32.Visible = false;

            // Thiết lập tab được chọn bằng tên nút
            foreach (TabPage tabPage in tabFunction.TabPages)
            {
                if (tabPage.Text == nodeName)
                {
                    tabFunction.SelectedTab = tabPage;
                    //if (tabPage.Text == "Khoa")
                    //{
                    //    //MessageBox.Show("Hello ");
                    //}
                    break;
                }
            }
        }



        // -------------------------Chức năng tab quản lý Khoa-------------------------------
        public void turnOffEditModeKhoa()
        {
            btnEditMode_Khoa.Text = "OFF";
            btnAdd_Khoa.Visible = true;
            btnDelete_Khoa.Visible = false;
            btnSave_Khoa.Visible = false;

            txtID_Khoa.Enabled = true;
            txtID_Khoa.BackColor = Color.White;
            btnEditMode_Khoa.ForeColor = Color.Black;

            clearDataKhoa();
        }

        public void turnONEditModeKhoa()
        {
            btnEditMode_Khoa.Text = "ON";
            btnAdd_Khoa.Visible = false;
            btnDelete_Khoa.Visible = true;
            btnSave_Khoa.Visible = true;

            txtID_Khoa.Enabled = false;
            txtID_Khoa.BackColor = Color.LightGray;
            btnEditMode_Khoa.ForeColor = Color.White;

            clearDataKhoa();
        }

        public void clearDataKhoa()
        {
            txtID_Khoa.Text = "";
            txtTenKhoa_Khoa.Text = "";
        }

        private void btnEditMode_Khoa_Click(object sender, EventArgs e)
        {
            if (btnEditMode_Khoa.Text == "ON")
            {
                turnOffEditModeKhoa();
            } else if (btnEditMode_Khoa.Text == "OFF")
            {
                turnONEditModeKhoa();
            }
        }

        public bool checkDataAddKhoa(string makhoa, string tenkhoa)
        {
            var listKhoa = khoaBLL.getListKhoa();
            var khoaID = listKhoa.Where(k => k.MaKhoa == makhoa).FirstOrDefault();

            if (khoaID != null)
            {
                MessageBox.Show("ID đã tồn tại, hãy nhập lại giá trị ID khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(makhoa))
            {
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID");
                return false;
            }

            if (makhoa.Length - 1 >= 10)
            {
                MessageBox.Show("Chiều dài ID không được quá 10 ký tự, hãy nhập lại giá trị ID");
                return false;
            }

            if (string.IsNullOrEmpty(tenkhoa))
            {
                MessageBox.Show("Tên khoa không được bỏ trống, hãy nhập giá trị khoa");
                return false;
            }

            if (tenkhoa.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khoa không được quá 50 ký tự, hãy nhập lại giá trị khoa");
                return false;
            }

            return true;

        }

        private void btnAdd_Khoa_Click(object sender, EventArgs e)
        {
            var makhoa = txtID_Khoa.Text.ToString().Trim();
            var tenkhoa = txtTenKhoa_Khoa.Text.ToString().Trim();

            if(checkDataAddKhoa(makhoa, tenkhoa))
            {
                var khoa = new Khoa()
                {
                    MaKhoa = makhoa,
                    TenKhoa = tenkhoa,
                };
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm khoa này", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (khoaBLL.AddKhoa(khoa))
                    {
                        MessageBox.Show("Thêm khoa thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadDataKhoaGirdView();
                        LoadDataKhoaCombobox();
                        clearDataKhoa();
                    } else
                    {
                        MessageBox.Show("Thêm không thành công ! Hãy thử lại");
                    }
                }
            }

        }

        private void btnDelete_Khoa_Click(object sender, EventArgs e)
        {
            var makhoa = txtID_Khoa.Text.ToString().Trim();
            var tenkhoa = txtTenKhoa_Khoa.Text.ToString().Trim();
            var listkhoa = khoaBLL.getListKhoa();
            var khoaExist = listkhoa.Where(k => k.MaKhoa == makhoa && k.TenKhoa == tenkhoa).FirstOrDefault();

            if (khoaExist != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin khoa này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (khoaBLL.DeleteKhoa(makhoa))
                    {
                        MessageBox.Show("Xóa thông tin khoa thành công !");
                        LoadDataKhoaGirdView();
                        LoadDataKhoaCombobox();
                        clearDataKhoa();
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu này không thể xóa, vì dữ liệu liên quan đến các đối tượng khác");
                    }
                }
            } else
            {
                MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa");
            }
        }

        public bool checkDataEditKhoa(string makhoa, string tenkhoa)
        {
            if (string.IsNullOrEmpty(makhoa))
            {
                MessageBox.Show("Hãy chọn khoa mà bạn cần muốn chỉnh sửa !");
                return false;
            }

            if (string.IsNullOrEmpty(tenkhoa))
            {
                MessageBox.Show("Tên khoa không được bỏ trống, hãy nhập giá trị tên khoa cần chỉnh sửa !");
                return false;
            }

            if (tenkhoa.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khoa không được quá 50 ký tự, hãy nhập lại giá trị khoa cần chỉnh sửa");
                return false;
            }

            return true;

        }

        private void btnSave_Khoa_Click(object sender, EventArgs e)
        {
            var makhoa = txtID_Khoa.Text.ToString().Trim();
            var tenkhoa = txtTenKhoa_Khoa.Text.ToString().Trim();
            var listkhoa = khoaBLL.getListKhoa();
            var khoaExist = listkhoa.Where(k => k.MaKhoa == makhoa && k.TenKhoa == tenkhoa).FirstOrDefault();

            if (checkDataEditKhoa(makhoa, tenkhoa))
            {
                if (khoaExist != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa khoa này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (khoaBLL.EditKhoa(makhoa, tenkhoa))
                    {
                        MessageBox.Show("Lưu thay đổi thành công !");
                        LoadDataKhoaGirdView();
                        clearDataKhoa();
                    } else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.");
                    }
                }
            }
        }

        public void LoadDataKhoaGirdView()
        {
            var khoas = khoaBLL.getListKhoa().Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
            ListKhoa.DataSource = khoas;
        }

        public void LoadDataKhoaCombobox()
        {
            var khoas = khoaBLL.getListKhoa().Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
            cbMaKhoa_Khoa.DataSource = khoas;
            cbMaKhoa_Khoa.DisplayMember = "MaKhoa";
            cbMaKhoa_Khoa.ValueMember = "MaKhoa";
            cbMaKhoa_Khoa.SelectedIndex = -1;

        }

        private void ListKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            clearDataKhoa();
            if (btnEditMode_Khoa.Text == "ON")
            {
                if (index >= 0 && index < ListKhoa.Rows.Count)
                {
                    txtID_Khoa.Text = ListKhoa.Rows[index].Cells["ID_Khoa"].Value.ToString();
                    txtTenKhoa_Khoa.Text = ListKhoa.Rows[index].Cells["TenKhoa_Khoa"].Value.ToString();
                }
            }
        }

        private void cbMaKhoa_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataKhoaGirdView();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            //string value = cbMaKhoa_Khoa.SelectedValue.ToString();
            if (cbMaKhoa_Khoa.Text == "")
            {
                MessageBox.Show("Hãy chọn mã khoa cần tìm !");
                LoadDataKhoaGirdView();
            }
            else if (cbMaKhoa_Khoa.Text != "")
            {
                string value = cbMaKhoa_Khoa.Text.ToString().Trim();
                var khoas = khoaBLL.getListKhoa().Where(k => k.MaKhoa == value).Select(k => new { k.MaKhoa, k.TenKhoa }).FirstOrDefault();
                if (khoas == null)
                {
                    MessageBox.Show("Tìm kiếm không thành công !, không tồn tại mã khoa, hãy chọn giá trị khác !");
                }
                else
                {
                    if (cbMaKhoa_Khoa.SelectedValue == null)
                    {
                        var khoalq = khoaBLL.getListKhoa().Where(k => k.MaKhoa == cbMaKhoa_Khoa.Text.ToString().Trim()).Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
                        ListKhoa.DataSource = khoalq;
                        cbMaKhoa_Khoa.Text = "";
                        MessageBox.Show("Đã tìm kiếm thành công !");
                        clearDataKhoa();
                    } else
                    {
                        var khoalq = khoaBLL.getListKhoa().Where(k => k.MaKhoa == cbMaKhoa_Khoa.SelectedValue.ToString()).Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
                        ListKhoa.DataSource = khoalq;
                        cbMaKhoa_Khoa.Text = "";
                        MessageBox.Show("Đã tìm kiếm thành công !");
                        clearDataKhoa();
                    }
                }
            }
        }
    }
}
