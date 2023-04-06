using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainForm
{
    public partial class FrmMenu : Form
    {
        KhoaBLL khoaBLL = new KhoaBLL();
        GiaoVienBLL giaovienBLL = new GiaoVienBLL();
        ChuongTrinhBLL chuongtrinhBLL = new ChuongTrinhBLL();
        MonHocBLL monhocBLL = new MonHocBLL();
        ChuongTrinhMonHocBLL ctmhBLL = new ChuongTrinhMonHocBLL();
        DamNhiemMonBLL dnmBLL = new DamNhiemMonBLL();
        KhoaHocBLL khoahocBLL = new KhoaHocBLL();
        ChiTietKhoaHocBLL ctkhBLL = new ChiTietKhoaHocBLL();
        AccountsBLL accountsBLL = new AccountsBLL();

        public string tendn;
        public string ps;
        public string displayname;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpControlLoadingForm();
            CustomdatagirdviewMenu();
            ShowInforUser();

            // KHOA
            turnOffEditModeKhoa();
            LoadDataKhoaGirdView();
            LoadDataKhoaCombobox();

            //GIÁO VIÊN
            turnOffEditModeGiaoVien();
            LoadDataGiaoVienGridview();
            LoadDataGiaoVienCombobox();

            //CHƯƠNG TRÌNH
            turnOffEditModeChuongTrinh();
            LoadDataChuongTrinhCombobox();
            LoadDataChuongTrinhGridview();

            // MÔN HỌC
            turnOffEditModeMonHoc();
            LoadDataKhoa_MonHocComboBox();
            LoadDataMonHocGridview();

            //CHƯƠNG TRÌNH HỌC MÔN
            turnOffEditModeCTMH();
            LoadDataComboboxCTDT_CTMH();
            LoadDataComboboxMH_CTMH();
            LoadDataComboboxSearchCTDT_CTMH();
            LoadDataCTMHDatagirdview();

            //PHỤ TRÁCH MÔN HỌC
            turnOffEditModePTMH();
            LoadDataCTDT_PTMH();
            LoadDataGVSearch_PTMH();
            LoadDataPTMHGridview();

            //KHÓA HỌC
            turnOffEditModeKH();
            LoadDataCTDT_KhoaHoc();
            LoadDataCTDTSearch_KhoaHoc();
            LoadDataGirdviewKhoaHoc();

            //CHI TIẾT KHÓA HỌC
            turnOffEditModeCTKH();
            LoadDataKhoaHoc_CTKH();
            LoadDataKhoaHocSearch_CTKH();
            LoadDataGridviewCTKH();
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
            row1.Cells[0].Value = "Thông báo nộp chứng chỉ tiếng Anh quốc tế";
            row1.Cells[1].Value = " Văn Bang";
            row1.Cells[2].Value = DateTime.Today.ToString("dd/MM/yyyy"); 

            // Thêm dòng vào DataGridView
            dataGridView11.Rows.Add(row1);

            // Tạo dòng thứ hai và thêm vào DataGridView
            DataGridViewRow row2 = new DataGridViewRow();
            row2.CreateCells(dataGridView11);
            row2.Cells[0].Value = "Đăng ký học phần bổ sung vào TKB Khóa 47";
            row2.Cells[1].Value = "Duy Đạt";
            row2.Cells[2].Value = DateTime.Today.ToString("dd/MM/yyyy");
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
                    break;
                }
            }
        }

        public void resetDataCombobox()
        {
            cbMaKhoa_Khoa.SelectedIndex = -1;
            cbMaKhoa_GiaoVien.SelectedIndex = -1;
            cbMaKhoa_ChuongTrinh.SelectedIndex = -1;
            cbMaKhoa_MonHoc.SelectedIndex = -1;
        }

        public void ShowInforUser()
        {
            var ac = accountsBLL.getListAccounts().Select(a => new { a.UserName, a.Password, a.DisplayName }).Where(a => a.UserName == tendn && a.Password == ps).FirstOrDefault();
            lbDisplayName.Text = ac.DisplayName;
            lbdatetime.Text = DateTime.Today.ToString("dd/MM/yyyy"); ;
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát khỏi màn hình làm việc này không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        // -------------------------CHỨC NĂNG TAB QUẢN LÝ KHOA---------------------------------------------------
        public void turnOffEditModeKhoa()
        {
            btnEditMode_Khoa.Text = "OFF";
            btnAdd_Khoa.Visible = true;
            btnDelete_Khoa.Visible = false;
            btnSave_Khoa.Visible = false;

            txtID_Khoa.Enabled = true;
            txtID_Khoa.BackColor = Color.White;
            btnEditMode_Khoa.ForeColor = Color.Black;

            resetDataKhoa();
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

            resetDataKhoa();
        }

        public void resetDataKhoa()
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
            var khoaID = listKhoa.Where(k => k.MaKhoa.Equals(makhoa, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            if (khoaID != null)
            {
                MessageBox.Show("ID đã tồn tại, hãy nhập lại giá trị ID khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(makhoa))
            {
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (makhoa.Length - 1 >= 10)
            {
                MessageBox.Show("Chiều dài ID không được quá 10 ký tự, hãy nhập lại giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(tenkhoa))
            {
                MessageBox.Show("Tên khoa không được bỏ trống, hãy nhập giá trị khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tenkhoa.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khoa không được quá 50 ký tự, hãy nhập lại giá trị khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        LoadDataGiaoVienCombobox();
                        LoadDataChuongTrinhCombobox();
                        LoadDataKhoa_MonHocComboBox();
                        resetDataKhoa();
                    } else
                    {
                        MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (string.IsNullOrEmpty(makhoa))
            {
                MessageBox.Show("Hãy chọn thông tin khoa mà bạn muốn xóa !", "Thông báo");
            } else if (khoaExist != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin khoa này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    var kh = listkhoa.Where(k => k.MaKhoa == makhoa).FirstOrDefault();
                    if (kh.GiaoViens.Any())
                    {
                        MessageBox.Show("Không thể xóa khoa này, vì có bản ghi liên quan đến thông tin của khoa này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetDataKhoa();
                    } else
                    {
                        if (khoaBLL.DeleteKhoa(makhoa))
                        {
                            MessageBox.Show("Xóa thông tin khoa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataKhoaGirdView();
                            LoadDataKhoaCombobox();
                            resetDataKhoa();

                            LoadDataGiaoVienCombobox();

                            LoadDataChuongTrinhCombobox();

                            LoadDataKhoa_MonHocComboBox();

                        }
                    }
                }
            } else
            {
                MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool checkDataEditKhoa(string makhoa, string tenkhoa)
        {
            if (string.IsNullOrEmpty(makhoa))
            {
                MessageBox.Show("Hãy chọn khoa mà bạn cần muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(tenkhoa))
            {
                MessageBox.Show("Tên khoa không được bỏ trống, hãy nhập giá trị tên khoa cần chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tenkhoa.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khoa không được quá 50 ký tự, hãy nhập lại giá trị khoa cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        MessageBox.Show("Lưu thay đổi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataKhoaGirdView();
                        LoadDataKhoaCombobox();

                        LoadDataGiaoVienCombobox();
                        LoadDataGiaoVienGridview();

                        LoadDataChuongTrinhCombobox();
                        LoadDataChuongTrinhGridview();

                        LoadDataKhoa_MonHocComboBox();
                        LoadDataMonHocGridview();
                        
                        resetDataKhoa();
                        resetDataCombobox();
                    } else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // tabkhoa
            var khoas = khoaBLL.getListKhoa().Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
            cbMaKhoa_Khoa.DataSource = khoas;
            cbMaKhoa_Khoa.DisplayMember = "MaKhoa";
            cbMaKhoa_Khoa.ValueMember = "MaKhoa";
            cbMaKhoa_Khoa.SelectedIndex = -1;

            // tab giáo viên
            cbMaKhoa_GiaoVien.DataSource = khoas;
            cbMaKhoa_GiaoVien.DisplayMember = "TenKhoa";
            cbMaKhoa_GiaoVien.ValueMember = "MaKhoa";
            cbMaKhoa_GiaoVien.SelectedIndex = -1;

            //tab chương trình đào tạo
            cbMaKhoa_ChuongTrinh.DataSource = khoas;
            cbMaKhoa_ChuongTrinh.DisplayMember = "TenKhoa";
            cbMaKhoa_ChuongTrinh.ValueMember = "MaKhoa";
            cbMaKhoa_ChuongTrinh.SelectedIndex = -1;

            //tab môn học
            cbMaKhoa_MonHoc.DataSource = khoas;
            cbMaKhoa_MonHoc.DisplayMember = "TenKhoa";
            cbMaKhoa_MonHoc.ValueMember = "MaKhoa";
            cbMaKhoa_MonHoc.SelectedIndex = -1;
        }

        private void ListKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModeKhoa();
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
            if (cbMaKhoa_Khoa.Text == "")
            {
                MessageBox.Show("Hãy chọn mã khoa cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataKhoaGirdView();
            }
            else if (cbMaKhoa_Khoa.Text != "")
            {
                var khoalq = khoaBLL.getListKhoa().Where(k => k.MaKhoa == cbMaKhoa_Khoa.SelectedValue.ToString()).Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
                resetDataCombobox();
                ListKhoa.DataSource = khoalq;
                ListKhoa.ClearSelection();
                MessageBox.Show("Đã tìm kiếm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetDataKhoa();
            }
        }



        //---------------------------CHỨC NĂNG TAB QUẢN LÝ GIÁO VIÊN-------------------------------------------

        public void turnOffEditModeGiaoVien()
        {
            btnEditMode_GiaoVien.Text = "OFF";
            btnAdd_GiaoVien.Visible = true;
            btnDelete_GiaoVien.Visible = false;
            btnSave_GiaoVien.Visible = false;

            txtID_GiaoVien.Enabled = true;
            txtID_GiaoVien.BackColor = Color.White;
            btnEditMode_GiaoVien.ForeColor = Color.Black;

            resetDataGiaoVien();
        }

        public void turnONEditModeGiaoVien()
        {
            btnEditMode_GiaoVien.Text = "ON";
            btnAdd_GiaoVien.Visible = false;
            btnDelete_GiaoVien.Visible = true;
            btnSave_GiaoVien.Visible = true;

            txtID_GiaoVien.Enabled = false;
            txtID_GiaoVien.BackColor = Color.LightGray;
            btnEditMode_GiaoVien.ForeColor = Color.White;

            resetDataGiaoVien();
        }

        public void resetDataGiaoVien()
        {
            txtID_GiaoVien.Text = "";
            txtHoTen_GiaoVien.Text = "";
            cbKhoa_GiaoVien.Text = "";
            cbKhoa_GiaoVien.SelectedIndex = -1;
        }

        private void btnEditMode_GiaoVien_Click(object sender, EventArgs e)
        {
            if (btnEditMode_GiaoVien.Text == "ON")
            {
                turnOffEditModeGiaoVien();
            } else if (btnEditMode_GiaoVien.Text == "OFF")
            {
                turnONEditModeGiaoVien();
            }
        }

        public void LoadDataGiaoVienGridview()
        {
            var query = from gv in giaovienBLL.getListGiaoVien()
                        join khoa in khoaBLL.getListKhoa() on gv.MaKhoa equals khoa.MaKhoa
                        select new
                        {
                            gv.MaGiaoVien,
                            gv.HoTen,
                            khoa.TenKhoa
                        };
            ListGiaoVien.DataSource = query.ToList();
            ListGiaoVien.ClearSelection();
        }

        public void LoadDataGiaoVienGridviewSearch(string makhoa)
        {
            var query = from gv in giaovienBLL.getListGiaoVien()
                        join khoa in khoaBLL.getListKhoa() on gv.MaKhoa equals khoa.MaKhoa
                        where gv.MaKhoa == makhoa
                        select new
                        {
                            gv.MaGiaoVien,
                            gv.HoTen,
                            khoa.TenKhoa
                        };
            ListGiaoVien.DataSource = query.ToList();
            ListGiaoVien.ClearSelection();

            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Không có giáo viên nào thuộc khoa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public void LoadDataGiaoVienCombobox()
        {
            var khoas = khoaBLL.getListKhoa().Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
            cbKhoa_GiaoVien.DataSource = khoas;
            cbKhoa_GiaoVien.DisplayMember = "TenKhoa";
            cbKhoa_GiaoVien.ValueMember = "MaKhoa";
            cbKhoa_GiaoVien.SelectedIndex = -1;
        }

        public bool checkDataAddGiaoVien(string mgv, string hoten, string makhoa)
        {
            var listGiaoVien = giaovienBLL.getListGiaoVien();
            var gvID = listGiaoVien.Where(gv => gv.MaGiaoVien.Equals(mgv, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            if (gvID != null)
            {
                MessageBox.Show("ID đã tồn tại, hãy nhập lại giá trị ID khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mgv))
            {
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mgv.Length - 1 >= 10)
            {
                MessageBox.Show("Chiều dài ID không được quá 10 ký tự, hãy nhập lại giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Tên giáo viên không được bỏ trống, hãy nhập giá trị tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (hoten.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khoa không được quá 50 ký tự, hãy nhập lại giá trị khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa trực thuộc cho giáo viên mà bạn cần thêm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnAdd_GiaoVien_Click(object sender, EventArgs e)
        {
            var magv = txtID_GiaoVien.Text.ToString().Trim();
            var hoten = txtHoTen_GiaoVien.Text.ToString().Trim();
            string makhoa;
            string cbMaKhoaText = cbKhoa_GiaoVien.Text.ToString().Trim();
            if (checkDataAddGiaoVien(magv, hoten, cbMaKhoaText))
            {
                makhoa = cbKhoa_GiaoVien.SelectedValue.ToString().Trim();
                var giaovien = new GiaoVien()
                {
                    MaGiaoVien = magv,
                    HoTen = hoten,
                    MaKhoa = makhoa
                };
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm giáo viên này không", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (giaovienBLL.AddGiangVien(giaovien))
                    {
                        MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadDataGiaoVienGridview();
                        resetDataGiaoVien();

                        LoadDataChuongTrinhCombobox();

                        LoadDataGVSearch_PTMH();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void searchBoxGiaoVien_Click(object sender, EventArgs e)
        {
            if (cbMaKhoa_GiaoVien.Text == "")
            {
                MessageBox.Show("Hãy chọn khoa cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaKhoa_GiaoVien.SelectedIndex = -1;
                LoadDataGiaoVienGridview();
            }
            else if (cbMaKhoa_GiaoVien.Text != "")
            {
                string value = cbMaKhoa_GiaoVien.SelectedValue.ToString().Trim();
                cbMaKhoa_GiaoVien.SelectedIndex = -1;
                LoadDataGiaoVienGridviewSearch(value);
                MessageBox.Show("Đã tìm kiếm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetDataGiaoVien();
                resetDataCombobox();
            }
        }

        public bool checkDataDeletGiaoVien(string mgv)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                MessageBox.Show("Hãy chọn giáo viên mà bạn cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnDelete_GiaoVien_Click(object sender, EventArgs e)
        {
            var magv = txtID_GiaoVien.Text.ToString().Trim();
            var hoten = txtHoTen_GiaoVien.Text.ToString().Trim();
            string makhoa;

            if (checkDataDeletGiaoVien(magv))
            {
                makhoa = cbKhoa_GiaoVien.SelectedValue.ToString().Trim();
                var listGiaoVien = giaovienBLL.getListGiaoVien();
                var gvExist = listGiaoVien.Where(g => g.MaGiaoVien == magv && g.HoTen == hoten && g.MaKhoa == makhoa).FirstOrDefault();
                if (gvExist != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin giáo viên này không ?", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        var gv = listGiaoVien.Where(g => g.MaGiaoVien == magv).FirstOrDefault();
                        if (gv.ChuongTrinhs.Any())
                        {
                            MessageBox.Show("Không thể xóa giáo viên này này, vì có liên quan đến các bản ghi khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetDataGiaoVien();
                        }
                        else
                        {
                            if (giaovienBLL.DeleteGiaoVien(magv))
                            {
                                MessageBox.Show("Xóa thông tin giáo viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataGiaoVienGridview();
                                LoadDataChuongTrinhCombobox();
                                LoadDataGVSearch_PTMH();
                                resetDataGiaoVien();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public bool checkDataEditGiaoVien(string magv, string hoten, string makhoa)
        {
            if (string.IsNullOrEmpty(magv))
            {
                MessageBox.Show("Hãy chọn giáo viên mà bạn cần muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Tên giáo viên không được bỏ trống, hãy nhập giá trị tên giáo viên cần chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (hoten.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên giáo viên không được quá 50 ký tự, hãy nhập lại giá trị tên giáo viên cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa trực thuộc cho giáo viên mà bạn cần chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnSave_GiaoVien_Click(object sender, EventArgs e)
        {
            var magv = txtID_GiaoVien.Text.ToString().Trim();
            var hoten = txtHoTen_GiaoVien.Text.ToString().Trim();
            var makhoaText = cbKhoa_GiaoVien.Text;
            string makhoa;
            
            if (checkDataEditGiaoVien(magv, hoten, makhoaText))
            {
                makhoa = cbKhoa_GiaoVien.SelectedValue.ToString().Trim(); 
                var listGiaoVien = giaovienBLL.getListGiaoVien();
                var gvExist = listGiaoVien.Where(g => g.MaGiaoVien == magv && g.HoTen == hoten && g.MaKhoa == makhoa).FirstOrDefault(); 
                if (gvExist != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa giáo viên này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (giaovienBLL.EditGiangVien(magv, hoten, makhoa))
                    {
                        MessageBox.Show("Lưu thay đổi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGiaoVienGridview();
                        resetDataGiaoVien();

                        LoadDataChuongTrinhGridview();
                        LoadDataChuongTrinhCombobox();

                        LoadDataGVSearch_PTMH();
                        LoadDataPTMHGridview();

                        LoadDataGridviewCTKH();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cbMaKhoa_GiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGiaoVienGridview();
        }

        private void ListGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModeGiaoVien();
            if (btnEditMode_GiaoVien.Text == "ON")
            {
                if (index >= 0 && index < ListGiaoVien.Rows.Count)
                {
                    txtID_GiaoVien.Text = ListGiaoVien.Rows[index].Cells["MaGiaoVien_GiaoVien"].Value.ToString();
                    txtHoTen_GiaoVien.Text = ListGiaoVien.Rows[index].Cells["HoTen_GiaoVien"].Value.ToString();
                    cbKhoa_GiaoVien.Text = ListGiaoVien.Rows[index].Cells["TenKhoa_GiaoVien"].Value.ToString();
                }
            }
        }

        //------------------------------CHỨC NĂNG TAB QUẢN LÝ CHƯƠNG TRÌNH ----------------------------------------

        public void turnOffEditModeChuongTrinh()
        {
            btnEditMode_ChuongTrinh.Text = "OFF";
            btnAdd_ChuongTrinh.Visible = true;
            btnDelete_ChuongTrinh.Visible = false;
            btnSave_ChuongTrinh.Visible = false;

            txtID_ChuongTrinh.Enabled = true;
            txtID_ChuongTrinh.BackColor = Color.White;
            btnEditMode_ChuongTrinh.ForeColor = Color.Black;

            resetDataChuongTrinh();
        }

        public void turnONEditModeChuongTrinh()
        {
            btnEditMode_ChuongTrinh.Text = "ON";
            btnAdd_ChuongTrinh.Visible = false;
            btnDelete_ChuongTrinh.Visible = true;
            btnSave_ChuongTrinh.Visible = true;

            txtID_ChuongTrinh.Enabled = false;
            txtID_ChuongTrinh.BackColor = Color.LightGray;
            btnEditMode_ChuongTrinh.ForeColor = Color.White;

            resetDataChuongTrinh();
        }

        public void resetDataChuongTrinh()
        {
            txtID_ChuongTrinh.Text = "";
            txtTenChuongTrinh_ChuongTrinh.Text = "";
            txtBacHoc_ChuongTrinh.Text = "";
            cbKhoa_ChuongTrinh.SelectedIndex = -1;
            cbGiaoVien_ChuongTrinh.SelectedIndex = -1;
        }

        private void btnEditMode_ChuongTrinh_Click(object sender, EventArgs e)
        {
            if (btnEditMode_ChuongTrinh.Text == "ON")
            {
                turnOffEditModeChuongTrinh();
            }
            else if (btnEditMode_ChuongTrinh.Text == "OFF")
            {
                turnONEditModeChuongTrinh();
            }
        }

        public void LoadDataChuongTrinhCombobox()
        {
            var khoas = khoaBLL.getListKhoa().Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
            cbKhoa_ChuongTrinh.DataSource = khoas;
            cbKhoa_ChuongTrinh.DisplayMember = "TenKhoa";
            cbKhoa_ChuongTrinh.ValueMember = "MaKhoa";
            cbKhoa_ChuongTrinh.SelectedIndex = -1;
        }

        public void LoadDataChuongTrinhGridview()
        {
            var query = from ct in chuongtrinhBLL.getListChuongTrinh()
                        join khoa in khoaBLL.getListKhoa() on ct.MaKhoa equals khoa.MaKhoa
                        join gv in giaovienBLL.getListGiaoVien() on ct.MaGiaoVien_GiamDocCT equals gv.MaGiaoVien
                        select new
                        {
                            ct.MaChuongTrinh,
                            ct.TenChuongTrinh,
                            ct.MaBacHoc,
                            khoa.TenKhoa,
                            gv.HoTen
                        };
            ListChuongTrinh.DataSource = query.ToList();
            ListChuongTrinh.ClearSelection();
        }

        public void LoadDataChuongTrinhGridviewSearch(string makhoa)
        {
            var query = from ct in chuongtrinhBLL.getListChuongTrinh()
                        join khoa in khoaBLL.getListKhoa() on ct.MaKhoa equals khoa.MaKhoa
                        join gv in giaovienBLL.getListGiaoVien() on ct.MaGiaoVien_GiamDocCT equals gv.MaGiaoVien
                        where ct.MaKhoa == makhoa
                        select new
                        {
                            ct.MaChuongTrinh,
                            ct.TenChuongTrinh,
                            ct.MaBacHoc,
                            khoa.TenKhoa,
                            gv.HoTen
                        };
            ListChuongTrinh.DataSource = query.ToList();
            ListChuongTrinh.ClearSelection();

            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Không có chương trình đào tạo nào thuộc khoa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LoadDataGiangVien_ChuongTrinhCombobox(string makhoa)
        {
            var query = from kh in khoaBLL.getListKhoa()
                        join gv in giaovienBLL.getListGiaoVien() on kh.MaKhoa equals gv.MaKhoa
                        where gv.MaKhoa == makhoa
                        select new
                        {
                            gv.MaGiaoVien,
                            gv.HoTen
                        };
            cbGiaoVien_ChuongTrinh.DataSource = query.ToList();
            cbGiaoVien_ChuongTrinh.DisplayMember = "HoTen";
            cbGiaoVien_ChuongTrinh.ValueMember = "MaGiaoVien";
            cbGiaoVien_ChuongTrinh.SelectedIndex = -1;
        }

        public bool CheckDataAddChuongTrinh(string mact, string tenct, string mabh, string makhoa, string mgv)
        {
            var listCTDT = chuongtrinhBLL.getListChuongTrinh();
            var ID_CT = listCTDT.Where(ct => ct.MaChuongTrinh.Equals(mact, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            if (ID_CT != null)
            {
                MessageBox.Show("ID đã tồn tại, hãy nhập lại giá trị ID khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mact))
            {
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mact.Length - 1 >= 5)
            {
                MessageBox.Show("Chiều dài ID không được quá 5 ký tự, hãy nhập lại giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(tenct))
            {
                MessageBox.Show("Tên chương trình đào tạo không được bỏ trống, hãy nhập giá trị tên chương trình đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tenct.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên chương trình đào tạo không được quá 50 ký tự, hãy nhập lại giá trị tên chương trình đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mabh))
            {
                MessageBox.Show("Bậc học không được bỏ trống, hãy nhập mã bậc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mabh.Length - 1 >= 2 )
            {
                MessageBox.Show("Chiều dài mã bậc học không được quá 2 ký tự, ví dụ mã bậc học là CD ( đại diện cho hệ cao đẳng ), hãy nhập lại giá trị mã bậc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa phụ trách cho chương trình đào tạo này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mgv == "")
            {
                MessageBox.Show("Hãy chọn giáo viên làm giáo đốc cho chương trình đào tạo này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnAdd_ChuongTrinh_Click(object sender, EventArgs e)
        {
            var mact = txtID_ChuongTrinh.Text.ToString().Trim();
            var tenct = txtTenChuongTrinh_ChuongTrinh.Text.ToString().Trim();
            var mabh = txtBacHoc_ChuongTrinh.Text.ToString().Trim();
            var cbMaKhoaText = cbKhoa_ChuongTrinh.Text.ToString().Trim();
            var cbMaGiaoVienText = cbGiaoVien_ChuongTrinh.Text.ToString().Trim();
            string makhoa;
            string magv;
            if (CheckDataAddChuongTrinh(mact, tenct, mabh, cbMaKhoaText, cbMaGiaoVienText))
            {
                makhoa = cbKhoa_ChuongTrinh.SelectedValue.ToString().Trim();
                magv = cbGiaoVien_ChuongTrinh.SelectedValue.ToString().Trim();
                var ct = new ChuongTrinh()
                {
                    MaChuongTrinh = mact,
                    TenChuongTrinh = tenct,
                    MaBacHoc = mabh,
                    MaKhoa = makhoa,
                    MaGiaoVien_GiamDocCT = magv,
                };
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm chương trình đào tạo này không", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (chuongtrinhBLL.AddChuongTrinh(ct))
                    {
                        MessageBox.Show("Thêm chương trình đào tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataChuongTrinhGridview();
                        resetDataChuongTrinh();

                        LoadDataComboboxCTDT_CTMH();
                        LoadDataComboboxSearchCTDT_CTMH();

                        LoadDataCTDT_PTMH();

                        LoadDataCTDT_KhoaHoc();
                        LoadDataCTDTSearch_KhoaHoc();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public bool checkDataDeleteChuongtrinh(string mct)
        {
            if(string.IsNullOrEmpty(mct))
            {
                MessageBox.Show("Hãy chọn chương trình mà bạn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnDelete_ChuongTrinh_Click(object sender, EventArgs e)
        {
            var mact = txtID_ChuongTrinh.Text.ToString().Trim();
            var tenct = txtTenChuongTrinh_ChuongTrinh.Text.ToString().Trim();
            var mabh = txtBacHoc_ChuongTrinh.Text.ToString().Trim();
            string makhoa;
            string magv;

            if (checkDataDeleteChuongtrinh(mact))
            {
                makhoa = cbKhoa_ChuongTrinh.SelectedValue.ToString().Trim();
                magv = cbGiaoVien_ChuongTrinh.SelectedValue.ToString().Trim();
                var listchuongtrinh = chuongtrinhBLL.getListChuongTrinh();
                var ctExist = listchuongtrinh.Where(c => c.MaChuongTrinh == mact && c.TenChuongTrinh == tenct && c.MaBacHoc == mabh && c.MaKhoa == makhoa && c.MaGiaoVien_GiamDocCT == magv).FirstOrDefault();
                if (ctExist != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin chương trình đào tạo này không ?", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        var ct = listchuongtrinh.Where(c => c.MaChuongTrinh == mact).FirstOrDefault();
                        if (ct.ChuongTrinhMonHocs.Any())
                        {
                            MessageBox.Show("Không thể xóa chương trình đào tạo này, vì ảnh hưởng đến các bản ghi có liên quan", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetDataChuongTrinh();
                        }
                        else
                        {
                            if (chuongtrinhBLL.DeleteChuongTrinh(mact))
                            {
                                MessageBox.Show("Xóa thông tin chương trình đào tạo thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataChuongTrinhGridview();
                                resetDataChuongTrinh();

                                LoadDataComboboxCTDT_CTMH();
                                LoadDataComboboxSearchCTDT_CTMH();

                                LoadDataCTDT_PTMH();

                                LoadDataCTDT_KhoaHoc();
                                LoadDataCTDTSearch_KhoaHoc();

                            }
                        }

                    }
                } else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public bool CheckDataEditChuongtrinh(string mact, string tenct, string mabh, string makhoa, string mgv)
        {
            if (string.IsNullOrEmpty(mact))
            {
                MessageBox.Show("Hãy chọn chương trình đào tạo mà bạn muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(tenct))
            {
                MessageBox.Show("Tên chương trình đào tạo không được bỏ trống, hãy nhập giá trị tên chương trình đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tenct.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên chương trình đào tạo không được quá 50 ký tự, hãy nhập lại giá trị tên chương trình đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mabh))
            {
                MessageBox.Show("Bậc học không được bỏ trống, hãy nhập mã bậc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mabh.Length - 1 >= 2)
            {
                MessageBox.Show("Chiều dài mã bậc học không được quá 2 ký tự, ví dụ mã bậc học là CD (đại diện cho hệ cao đẳng), hãy nhập lại giá trị mã bậc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa phụ trách cho chương trình đào tạo này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mgv == "")
            {
                MessageBox.Show("Hãy chọn giáo viên làm giáo đốc cho chương trình đào tạo này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnSave_ChuongTrinh_Click(object sender, EventArgs e)
        {
            var mact = txtID_ChuongTrinh.Text.ToString().Trim();
            var tenct = txtTenChuongTrinh_ChuongTrinh.Text.ToString().Trim();
            var mabh = txtBacHoc_ChuongTrinh.Text.ToString().Trim();
            var makhoaText = cbKhoa_ChuongTrinh.Text;
            var magvText = cbGiaoVien_ChuongTrinh.Text;
            string makhoa;
            string magv;

            if (CheckDataEditChuongtrinh(mact, tenct, mabh, makhoaText, magvText))
            {
                makhoa = cbKhoa_ChuongTrinh.SelectedValue.ToString().Trim();
                magv = cbGiaoVien_ChuongTrinh.SelectedValue.ToString().Trim();
                var listchuongtrinh = chuongtrinhBLL.getListChuongTrinh();
                var ctExist = listchuongtrinh.Where(c => c.MaChuongTrinh == mact && c.TenChuongTrinh == tenct && c.MaBacHoc == mabh && c.MaKhoa == makhoa && c.MaGiaoVien_GiamDocCT == magv).FirstOrDefault();
                if (ctExist != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa chương trình đào tạo này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (chuongtrinhBLL.EditChuongTrinh(mact, tenct, mabh, makhoa, magv))
                    {
                        MessageBox.Show("Lưu thay đổi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataChuongTrinhGridview();
                        resetDataChuongTrinh();

                        LoadDataComboboxCTDT_CTMH();
                        LoadDataComboboxSearchCTDT_CTMH();
                        LoadDataCTMHDatagirdview();

                        LoadDataCTDT_PTMH();
                        LoadDataPTMHGridview();

                        LoadDataCTDT_KhoaHoc();
                        LoadDataCTDTSearch_KhoaHoc();
                        LoadDataGirdviewKhoaHoc();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ListChuongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModeChuongTrinh();
            if (btnEditMode_ChuongTrinh.Text == "ON")
            {
                if (index >= 0 && index < ListChuongTrinh.Rows.Count)
                {
                    txtID_ChuongTrinh.Text = ListChuongTrinh.Rows[index].Cells["MaChuongTrinh_CT"].Value.ToString();
                    txtTenChuongTrinh_ChuongTrinh.Text = ListChuongTrinh.Rows[index].Cells["TenChuongTrinh_CT"].Value.ToString();
                    txtBacHoc_ChuongTrinh.Text = ListChuongTrinh.Rows[index].Cells["MaBacHoc_CT"].Value.ToString();
                    cbKhoa_ChuongTrinh.Text = ListChuongTrinh.Rows[index].Cells["TenKhoa_CT"].Value.ToString();
                    cbGiaoVien_ChuongTrinh.Text = ListChuongTrinh.Rows[index].Cells["GiamDoc_CT"].Value.ToString();
                }
            }
        }

        private void searchBoxChuongTrinh_Click(object sender, EventArgs e)
        {
            if (cbMaKhoa_ChuongTrinh.Text == "")
            {
                MessageBox.Show("Hãy chọn khoa cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaKhoa_ChuongTrinh.SelectedIndex = -1;
                LoadDataChuongTrinhGridview();
            }
            else if (cbMaKhoa_ChuongTrinh.Text != "")
            {
                string value = cbMaKhoa_ChuongTrinh.SelectedValue.ToString().Trim();
                cbMaKhoa_ChuongTrinh.SelectedIndex = -1;
                LoadDataChuongTrinhGridviewSearch(value);
                MessageBox.Show("Đã tìm kiếm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetDataCombobox();
                resetDataChuongTrinh();
            }
        }

        private void cbKhoa_ChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa_ChuongTrinh.Text != "")
            {
                LoadDataGiangVien_ChuongTrinhCombobox(cbKhoa_ChuongTrinh.SelectedValue.ToString());
            }
        }

        private void cbMaKhoa_ChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataChuongTrinhGridview();
        }


        //-----------------------------------------CHỨC NĂNG TAB QUẢN LÝ MÔN HỌC ------------------------------------------------------

        public void turnOffEditModeMonHoc()
        {
            btnEditMode_MonHoc.Text = "OFF";
            btnAdd_MonHoc.Visible = true;
            btnDelete_MonHoc.Visible = false;
            btnSave_MonHoc.Visible = false;

            txtID_MonHoc.Enabled = true;
            txtID_MonHoc.BackColor = Color.White;
            btnEditMode_MonHoc.ForeColor = Color.Black;
            //cbKhoa_MonHoc.SelectedIndex = 0;

            resetDataMonHoc();
        }

        public void turnONEditModeMonHoc()
        {
            btnEditMode_MonHoc.Text = "ON";
            btnAdd_MonHoc.Visible = false;
            btnDelete_MonHoc.Visible = true;
            btnSave_MonHoc.Visible = true;

            txtID_MonHoc.Enabled = false;
            txtID_MonHoc.BackColor = Color.LightGray;
            btnEditMode_MonHoc.ForeColor = Color.White;

            //cbKhoa_MonHoc.SelectedIndex = -1;
            numSoTinChi_MonHoc.TabStop = false;

            resetDataMonHoc();
        }

        public void resetDataMonHoc()
        {
            txtID_MonHoc.Text = "";
            txtTenMonHoc_MonHoc.Text = "";
            numSoTinChi_MonHoc.Value = 1;
            cbKhoa_MonHoc.SelectedIndex = -1;
        }

        private void btnEditMode_MonHoc_Click_1(object sender, EventArgs e)
        {
            if (btnEditMode_MonHoc.Text == "ON")
            {
                turnOffEditModeMonHoc();
            }
            else if (btnEditMode_MonHoc.Text == "OFF")
            {
                turnONEditModeMonHoc();
            }
        }

        public void LoadDataKhoa_MonHocComboBox()
        {
            var khoas = khoaBLL.getListKhoa().Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
            cbKhoa_MonHoc.DataSource = khoas;
            cbKhoa_MonHoc.DisplayMember = "TenKhoa";
            cbKhoa_MonHoc.ValueMember = "MaKhoa";
            cbKhoa_MonHoc.SelectedIndex = -1;
        }

        public void LoadDataMonHocGridview()
        {
            var query = from mh in monhocBLL.getListMonHoc()
                        join khoa in khoaBLL.getListKhoa() on mh.MaKhoa equals khoa.MaKhoa
                        select new
                        {
                            mh.MaMonHoc,
                            mh.TenMonHoc,
                            mh.SoTinChi,
                            khoa.TenKhoa,
                        };
            ListMonHoc.DataSource = query.ToList();
            ListMonHoc.ClearSelection();
        }

        public bool checkDataAddMonHoc(string mamh, string tenmh, int stc, string makhoa)
        {
            var listMH = monhocBLL.getListMonHoc();
            var ID_MH = listMH.Where(mh => mh.MaMonHoc.Equals(mamh, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            if (ID_MH != null)
            {
                MessageBox.Show("ID đã tồn tại, hãy nhập lại giá trị ID khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mamh.Length - 1 >= 5)
            {
                MessageBox.Show("Chiều dài ID không được quá 5 ký tự, hãy nhập lại giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(tenmh))
            {
                MessageBox.Show("Tên môn học không được bỏ trống, hãy nhập giá trị tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tenmh.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên môn học không được quá 50 ký tự, hãy nhập lại giá trị tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa phụ trách cho môn học mà bạn cần thêm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnAdd_MonHoc_Click(object sender, EventArgs e)
        {
            var mamh = txtID_MonHoc.Text.ToString().Trim();
            var tenmh = txtTenMonHoc_MonHoc.Text.ToString().Trim();
            int stc = (int)numSoTinChi_MonHoc.Value;
            var makhoaText = cbKhoa_MonHoc.Text;
            string makhoa;

            if (checkDataAddMonHoc(mamh, tenmh, stc, makhoaText))
            {
                makhoa = cbKhoa_MonHoc.SelectedValue.ToString().Trim();
                var mh = new MonHoc()
                {
                    MaMonHoc = mamh,
                    TenMonHoc = tenmh,
                    MaKhoa = makhoa,
                    SoTinChi = stc,
                };
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm môn học này không", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (monhocBLL.AddMonHoc(mh))
                    {
                        MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadDataMonHocGridview();
                        resetDataMonHoc();

                        LoadDataComboboxMH_CTMH();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        public bool checkDeleteMonHoc(string mamh)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn môn học mà bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnDelete_MonHoc_Click(object sender, EventArgs e)
        {
            var mamh = txtID_MonHoc.Text.ToString().Trim();
            var tenmh = txtTenMonHoc_MonHoc.Text.ToString().Trim();
            int stc = (int)numSoTinChi_MonHoc.Value;
            string makhoa;

            if (checkDeleteMonHoc(mamh))
            {
                makhoa = cbKhoa_MonHoc.SelectedValue.ToString().Trim();
                var listmonhoc = monhocBLL.getListMonHoc();
                var mhExist = listmonhoc.Where(m => m.MaMonHoc == mamh && m.TenMonHoc == tenmh && m.SoTinChi == stc && m.MaKhoa == makhoa).FirstOrDefault();
                if (mhExist != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin môn học này không ?", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        var mh = listmonhoc.Where(m => m.MaMonHoc == mamh).FirstOrDefault();
                        if (mh.ChuongTrinhMonHocs.Any())
                        {
                            MessageBox.Show("Không thể xóa môn học này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetDataMonHoc();
                        }
                        else
                        {
                            if (monhocBLL.DeleteMonHoc(mamh))
                            {
                                MessageBox.Show("Xóa thông tin môn học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataMonHocGridview();
                                resetDataMonHoc();

                                LoadDataComboboxMH_CTMH();
                            }
                        }

                    }
                } else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public bool checkDataEditMonHoc(string mamh, string ten, string makhoa)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn môn học mà bạn muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên môn học không được bỏ trống, hãy nhập giá trị tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (ten.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên môn học không được quá 50 ký tự, hãy nhập lại giá trị tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa phụ trách cho môn học này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnSave_MonHoc_Click(object sender, EventArgs e)
        {
            var mamh = txtID_MonHoc.Text.ToString().Trim();
            var tenmh = txtTenMonHoc_MonHoc.Text.ToString().Trim();
            int stc = (int)numSoTinChi_MonHoc.Value;
            var makhoaText = cbKhoa_MonHoc.Text;
            string makhoa;

            if (checkDataEditMonHoc(mamh, tenmh, makhoaText))
            {
                makhoa = cbKhoa_MonHoc.SelectedValue.ToString().Trim();
                var listmonhoc = monhocBLL.getListMonHoc();
                var mhExist = listmonhoc.Where(m => m.MaMonHoc == mamh &&  m.TenMonHoc == tenmh && m.SoTinChi == stc && m.MaKhoa == makhoa).FirstOrDefault();
                if (mhExist != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa môn học này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (monhocBLL.EditMonHoc(mamh, tenmh, stc, makhoa))
                    {
                        MessageBox.Show("Lưu thay đổi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataMonHocGridview();
                        resetDataMonHoc();

                        LoadDataComboboxMH_CTMH();
                        LoadDataCTMHDatagirdview();

                        LoadDataPTMHGridview();

                        LoadDataGridviewCTKH();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        public void LoadDataMonHocGridviewSearch(string makhoa)
        {
            var query = from mh in monhocBLL.getListMonHoc()
                        join khoa in khoaBLL.getListKhoa() on mh.MaKhoa equals khoa.MaKhoa
                        where mh.MaKhoa == makhoa
                        select new
                        {
                            mh.MaMonHoc,
                            mh.TenMonHoc,
                            mh.SoTinChi,
                            khoa.TenKhoa,
                        };
            ListMonHoc.DataSource = query.ToList();
            ListMonHoc.ClearSelection();

            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Không có môn học nào nào thuộc khoa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchBoxMonHoc_Click(object sender, EventArgs e)
        {
            if (cbMaKhoa_MonHoc.Text == "")
            {
                MessageBox.Show("Hãy chọn khoa cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaKhoa_MonHoc.SelectedIndex = -1;
                LoadDataMonHocGridview();
            }
            else if (cbMaKhoa_MonHoc.Text != "")
            {
                string value = cbMaKhoa_MonHoc.SelectedValue.ToString().Trim();
                cbMaKhoa_MonHoc.SelectedIndex = -1;
                LoadDataMonHocGridviewSearch(value);
                MessageBox.Show("Đã tìm kiếm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetDataMonHoc();
                resetDataCombobox();
            }
        }

        private void ListMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModeMonHoc();
            if (btnEditMode_MonHoc.Text == "ON")
            {
                if (index >= 0 && index < ListMonHoc.Rows.Count)
                {
                    txtID_MonHoc.Text = ListMonHoc.Rows[index].Cells["MaMonHoc_MH"].Value.ToString();
                    txtTenMonHoc_MonHoc.Text = ListMonHoc.Rows[index].Cells["TenMonHoc_MH"].Value.ToString();
                    numSoTinChi_MonHoc.Value = (int)ListMonHoc.Rows[index].Cells["SoTinChi_MH"].Value;
                    cbKhoa_MonHoc.Text = ListMonHoc.Rows[index].Cells["TenKhoa_MH"].Value.ToString();
                }
            }
        }

        private void cbMaKhoa_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataMonHocGridview();
        }


        //--------------------------------CHỨC NĂNG TAB CHƯƠNG TRÌNH HỌC MÔN -----------------------------------------

        public void turnOffEditModeCTMH()
        {
            btnEditMode_ChuongTrinhMonHoc.Text = "OFF";
            btnAdd_CTMH.Visible = true;
            btnDelete_CTMH.Visible = false;
            btnSave_CTMH.Visible = false;

            cbCTDT_CTMH.Enabled = true;
            cbMH_CTMH.Enabled = true;
            cbMH_CTMH.BackColor = Color.White;
            cbCTDT_CTMH.BackColor = Color.White;

            btnEditMode_MonHoc.ForeColor = Color.Black;
            resetDataCTMH();
        }

        public void turnONEditModeCTMH()
        {
            btnEditMode_ChuongTrinhMonHoc.Text = "ON";
            btnAdd_CTMH.Visible = false;
            btnDelete_CTMH.Visible = true;
            btnSave_CTMH.Visible = true;

            cbMH_CTMH.BackColor = Color.Gray;
            cbCTDT_CTMH.BackColor = Color.Gray;
            cbCTDT_CTMH.Enabled = false;
            cbMH_CTMH.Enabled = false;


            btnEditMode_ChuongTrinhMonHoc.ForeColor = Color.White;
            resetDataCTMH();
        }

        public void resetDataCTMH()
        {
            cbCTDT_CTMH.SelectedIndex = -1;
            cbMH_CTMH.SelectedIndex = -1;
            numHocKy_CTMH.Value = 1;
        }

        private void btnEditMode_ChuongTrinhMonHoc_Click(object sender, EventArgs e)
        {
            if (btnEditMode_ChuongTrinhMonHoc.Text == "ON")
            {
                turnOffEditModeCTMH();
            }
            else if (btnEditMode_ChuongTrinhMonHoc.Text == "OFF")
            {
                turnONEditModeCTMH();
            }
        }

        public void LoadDataComboboxCTDT_CTMH()
        {
            var ctdt = chuongtrinhBLL.getListChuongTrinh().Select(c => new { c.MaChuongTrinh, c.TenChuongTrinh }).ToList();
            cbCTDT_CTMH.DataSource = ctdt;
            cbCTDT_CTMH.DisplayMember = "TenChuongTrinh";
            cbCTDT_CTMH.ValueMember = "MaChuongTrinh";
            cbCTDT_CTMH.SelectedIndex = -1;
        }

        public void LoadDataComboboxSearchCTDT_CTMH()
        {
            var ctdt = chuongtrinhBLL.getListChuongTrinh().Select(c => new { c.MaChuongTrinh, c.TenChuongTrinh }).ToList();
            CbSearchCTDT_CTMH .DataSource = ctdt;
            CbSearchCTDT_CTMH.DisplayMember = "TenChuongTrinh";
            CbSearchCTDT_CTMH.ValueMember = "MaChuongTrinh";
            CbSearchCTDT_CTMH.SelectedIndex = -1;
        }

        public void LoadDataComboboxMH_CTMH()
        {
            var monhocs = monhocBLL.getListMonHoc().Select(m => new { m.MaMonHoc, m.TenMonHoc }).ToList();
            cbMH_CTMH.DataSource = monhocs;
            cbMH_CTMH.DisplayMember = "TenMonHoc";
            cbMH_CTMH.ValueMember = "MaMonHoc";
            cbMH_CTMH.SelectedIndex = -1;
        }

        public void LoadDataCTMHDatagirdview()
        {
            var query = from ctmh in ctmhBLL.getListCTMH()
                        join ctdt in chuongtrinhBLL.getListChuongTrinh() on ctmh.MaChuongTrinh equals ctdt.MaChuongTrinh
                        join mh in monhocBLL.getListMonHoc() on ctmh.MaMonHoc equals mh.MaMonHoc
                        select new
                        {
                           ctdt.TenChuongTrinh,
                           mh.TenMonHoc,
                           ctmh.HocKy

                        };
            ListCTMH.DataSource = query.ToList();
            ListCTMH.ClearSelection();
        }

        public void LoadDataCTMHDataGridview_Search(string mactdt)
        {
            var query = from ctmh in ctmhBLL.getListCTMH()
                        join ctdt in chuongtrinhBLL.getListChuongTrinh() on ctmh.MaChuongTrinh equals ctdt.MaChuongTrinh
                        join mh in monhocBLL.getListMonHoc() on ctmh.MaMonHoc equals mh.MaMonHoc
                        where ctmh.MaChuongTrinh == mactdt
                        select new
                        {
                            ctdt.TenChuongTrinh,
                            mh.TenMonHoc,
                            ctmh.HocKy

                        };
            ListCTMH.DataSource = query.ToList();
            ListCTMH.ClearSelection();
            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Không có chương trình học môn nào thuộc chương trình đào tạo này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool checkDataAddCTMH(string mactdt, string mamh)
        {
            if (string.IsNullOrEmpty(mactdt)) {
                MessageBox.Show("Hãy chọn giá trị chương trình đào tạo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; 
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn giá trị môn học mà bạn muốn đăng ký cho chương trình đào tạo trên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnAdd_CTMH_Click(object sender, EventArgs e)
        {
            var mactdtText = cbCTDT_CTMH.Text;
            var mamhText = cbMH_CTMH.Text;
            int hocky = (int)numHocKy_CTMH.Value;
            string mactdt;
            string mamh;            

            if (checkDataAddCTMH(mactdtText, mamhText))
            {
                mactdt = cbCTDT_CTMH.SelectedValue.ToString().Trim();
                mamh = cbMH_CTMH.SelectedValue.ToString().Trim();

                var listctmh = ctmhBLL.getListCTMH().Where(c => c.MaChuongTrinh == mactdt && c.MaMonHoc == mamh).SingleOrDefault();

                if (listctmh != null)
                {
                    MessageBox.Show("Chương trình học môn này đã được đăng ký, hãy thử đăng ký lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    var ctmh = new ChuongTrinhMonHoc()
                    {
                        MaChuongTrinh = mactdt,
                        MaMonHoc = mamh,
                        HocKy = hocky,
                    };
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm chương trình học môn này không", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        if (ctmhBLL.AddCTMH(ctmh))
                        {
                            MessageBox.Show("Thêm chương trình học môn thành công", "Thông báo", MessageBoxButtons.OK);
                            LoadDataCTMHDatagirdview();
                            LoadDataMH_PTMH(mactdt);
                            resetDataCTMH();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }

        public bool checkDataDeleteCTMH(string mactdt, string mamh)
        {
            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnDelete_CTMH_Click(object sender, EventArgs e)
        {
            var mactdtText = cbCTDT_CTMH.Text;
            var mamhText = cbMH_CTMH.Text;
            int hocky = (int)numHocKy_CTMH.Value;
            string mactdt;
            string mamh;

            if (checkDataDeleteCTMH(mactdtText, mamhText))
            {
                mactdt = cbCTDT_CTMH.SelectedValue.ToString().Trim();
                mamh = cbMH_CTMH.SelectedValue.ToString().Trim();

                var ctmhExist = ctmhBLL.getListCTMH().Where(c => c.MaChuongTrinh == mactdt && c.MaMonHoc == mamh && c.HocKy == hocky).FirstOrDefault();
                if (ctmhExist != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin chương trình học môn này không ?", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        var dnm = dnmBLL.getListDamNhiemMon().Where(d => d.MaChuongTrinh == mactdt && d.MaMonHoc == mamh).FirstOrDefault();
                        if (dnm != null)
                        {
                            MessageBox.Show("Không thể xóa chương trình học môn này, vì đã được phân công cho giáo viên đảm nhiệm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetDataCTMH();
                        }
                        else
                        {
                            if (ctmhBLL.DeleteCTMH(mactdt, mamh))
                            {
                                MessageBox.Show("Xóa thông tin chương trình môn học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataCTMHDatagirdview();
                                LoadDataMH_PTMH(mactdt);
                                resetDataCTMH();
                            } else
                            {
                                MessageBox.Show("Error");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool checkDataEditCTMH(string mactdt, string mamh)
        {
            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnSave_CTMH_Click(object sender, EventArgs e)
        {
            var mactdtText = cbCTDT_CTMH.Text;
            var mamhText = cbMH_CTMH.Text;
            int hocky = (int)numHocKy_CTMH.Value;
            string mactdt;
            string mamh;

            if (checkDataEditCTMH(mamhText,mamhText))
            {
                mactdt = cbCTDT_CTMH.SelectedValue.ToString().Trim();
                mamh = cbMH_CTMH.SelectedValue.ToString().Trim();

                var listctmh = ctmhBLL.getListCTMH().Where(c => c.MaChuongTrinh == mactdt && c.MaMonHoc == mamh && c.HocKy == hocky).SingleOrDefault();
                if (listctmh != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa chương trình học môn này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (ctmhBLL.EditCTMH(mactdt, mamh, hocky))
                    {
                        MessageBox.Show("Lưu thay đổi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataCTMHDatagirdview();
                        resetDataCTMH();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void seachBoxCTMH_Click(object sender, EventArgs e)
        {
            if (CbSearchCTDT_CTMH.Text == "")
            {
                MessageBox.Show("Hãy chọn chương trình đào tạo cần tìm !");
                CbSearchCTDT_CTMH.SelectedIndex = -1;
                LoadDataCTMHDatagirdview();
            }
            else if (CbSearchCTDT_CTMH.Text != "")
            {
                string value = CbSearchCTDT_CTMH.SelectedValue.ToString().Trim();
                CbSearchCTDT_CTMH.SelectedIndex = -1;
                LoadDataCTMHDataGridview_Search(value);
                MessageBox.Show("Đã tìm kiếm thành công !");
                CbSearchCTDT_CTMH.SelectedIndex = -1;
            }
        }

        private void CbSearchCTDT_CTMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataCTMHDatagirdview();
        }

        private void ListCTMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModeCTMH();
            if (btnEditMode_ChuongTrinhMonHoc.Text == "ON")
            {
                if (index >= 0 && index < ListCTMH.Rows.Count)
                {
                    cbCTDT_CTMH.Text = ListCTMH.Rows[index].Cells["TenChuongTrinh_CTMH"].Value.ToString();
                    cbMH_CTMH.Text = ListCTMH.Rows[index].Cells["TenMonHoc_CTMH"].Value.ToString();
                    numHocKy_CTMH.Value = (int)ListCTMH.Rows[index].Cells["HocKy_CTMH"].Value;
                }
            }
        }

        // -------------------------------------------------------CHỨC NĂNG TAB ĐẢM NHIỆM MÔN---------------------------------

        public void turnOffEditModePTMH()
        {
            btnEditMode_PTMH.Text = "OFF";
            btnAdd_PTMH.Visible = true;
            btnDelete_PTMH.Visible = false;
            btnSave_PTMH.Visible = false;

            cbCTDT_PTMH.Enabled = true;
            cbMH_PTMH.Enabled = true;
            cbGV_PTMH.Enabled = true;

            ckDamNhiemChinh.Checked = false;

            btnEditMode_PTMH.ForeColor = Color.Black;
            resetDataPTMH();
        }

        public void turnONEditModePTMH()
        {
            btnEditMode_PTMH.Text = "ON";
            btnAdd_PTMH.Visible = false;
            btnDelete_PTMH.Visible = true;
            btnSave_PTMH.Visible = true;

            cbCTDT_PTMH.Enabled = false;
            cbMH_PTMH.Enabled = false;
            cbGV_PTMH.Enabled = false;
            btnEditMode_PTMH.ForeColor = Color.White;

            resetDataPTMH();
        }

        public void resetDataPTMH()
        {
            cbCTDT_PTMH.SelectedIndex = -1;
            cbGV_PTMH.SelectedIndex = -1;
            cbMH_PTMH.SelectedIndex = -1;
            ckDamNhiemChinh.Checked = false;
        }

        private void btnEditMode_PhuTrachMonHoc_Click(object sender, EventArgs e)
        {
            if (btnEditMode_PTMH.Text == "ON")
            {
                turnOffEditModePTMH();
            }
            else if (btnEditMode_PTMH.Text == "OFF")
            {
                turnONEditModePTMH();
            }
        }

        public void LoadDataCTDT_PTMH()
        {
            var ctdt = chuongtrinhBLL.getListChuongTrinh().Select(c => new { c.MaChuongTrinh, c.TenChuongTrinh }).ToList();
            cbCTDT_PTMH.DataSource = ctdt;
            cbCTDT_PTMH.DisplayMember = "TenChuongTrinh";
            cbCTDT_PTMH.ValueMember = "MaChuongTrinh";
            cbCTDT_PTMH.SelectedIndex = -1;
        }

        public void LoadDataMH_PTMH(string mactdt)
        {
            var query = from kh in ctmhBLL.getListCTMH()
                        join ct in chuongtrinhBLL.getListChuongTrinh() on kh.MaChuongTrinh equals ct.MaChuongTrinh
                        join mh in monhocBLL.getListMonHoc() on kh.MaMonHoc equals mh.MaMonHoc
                        where kh.MaChuongTrinh == mactdt
                        select new
                        {
                            mh.MaMonHoc,
                            mh.TenMonHoc
                        };
            cbMH_PTMH.DataSource = query.ToList();
            cbMH_PTMH.DisplayMember = "TenMonHoc";
            cbMH_PTMH.ValueMember = "MaMonHoc";
            cbMH_PTMH.SelectedIndex = -1;
        }

        public void LoadDataGV_PTMH(string mamh)
        {
            var query = from mh in monhocBLL.getListMonHoc()
                        join kh in khoaBLL.getListKhoa() on mh.MaKhoa equals kh.MaKhoa
                        join gv in giaovienBLL.getListGiaoVien() on kh.MaKhoa equals gv.MaKhoa
                        where mh.MaMonHoc == mamh
                        select new
                        {
                            gv.MaGiaoVien,
                            gv.HoTen
                        };
            cbGV_PTMH.DataSource = query.ToList();
            cbGV_PTMH.DisplayMember = "HoTen";
            cbGV_PTMH.ValueMember = "MaGiaoVien";
            cbGV_PTMH.SelectedIndex = -1;

        }

        public void LoadDataGVSearch_PTMH()
        {
            var query = from gv in giaovienBLL.getListGiaoVien()
                        select new
                        {
                            gv.MaGiaoVien,
                            gv.HoTen
                        };
            cbGiaoVien_Search.DataSource = query.ToList();
            cbGiaoVien_Search.DisplayMember = "HoTen";
            cbGiaoVien_Search.ValueMember = "MaGiaoVien";
            cbGiaoVien_Search.SelectedIndex = -1;
        }

        public void LoadDataPTMHGridview()
        {
            var query = from ptmh in dnmBLL.getListDamNhiemMon()
                        join ctdt in chuongtrinhBLL.getListChuongTrinh() on ptmh.MaChuongTrinh equals ctdt.MaChuongTrinh
                        join mh in monhocBLL.getListMonHoc() on ptmh.MaMonHoc equals mh.MaMonHoc
                        join gv in giaovienBLL.getListGiaoVien() on ptmh.MaGiaoVien equals gv.MaGiaoVien
                        select new {
                            ctdt.TenChuongTrinh,
                            mh.TenMonHoc,
                            gv.HoTen,
                            ptmh.CoLaDamNhiemChinh
                        };
            ListPTMH.DataSource = query.ToList();
            ListPTMH.ClearSelection();
        }

        public void LoadDataPTMHGridviewSearch(string magv)
        {
            var query = from ptmh in dnmBLL.getListDamNhiemMon()
                        join ctdt in chuongtrinhBLL.getListChuongTrinh() on ptmh.MaChuongTrinh equals ctdt.MaChuongTrinh
                        join mh in monhocBLL.getListMonHoc() on ptmh.MaMonHoc equals mh.MaMonHoc
                        join gv in giaovienBLL.getListGiaoVien() on ptmh.MaGiaoVien equals gv.MaGiaoVien
                        where ptmh.MaGiaoVien == magv
                        select new
                        {
                            ctdt.TenChuongTrinh,
                            mh.TenMonHoc,
                            gv.HoTen,
                            ptmh.CoLaDamNhiemChinh
                        };
            ListPTMH.DataSource = query.ToList();
            ListPTMH.ClearSelection();
            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Không có phụ trách môn học nào được giáo viên này đảm nhiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool checkDataAddPTMH(string mactdt, string mamh, string mgv)
        {
            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn giá trị chương trình đào tạo, giá trị này không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn giá trị môn học, giá trị này không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mgv))
            {
                MessageBox.Show("Hãy chọn giá trị tên giáo viên đảm nhiệm cho môn học trên, giá trị này không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnAdd_PTMH_Click(object sender, EventArgs e)
        {
            var mactdtText = cbCTDT_PTMH.Text;
            var mamhText = cbMH_PTMH.Text;
            var magvText = cbGV_PTMH.Text;
            bool dnc = ckDamNhiemChinh.Checked;

            string mactdt;
            string mamh;
            string magv;

            if (checkDataAddPTMH(mactdtText, mamhText, magvText))
            {
                mactdt = cbCTDT_PTMH.SelectedValue.ToString().Trim();
                mamh = cbMH_PTMH.SelectedValue.ToString().Trim();
                magv = cbGV_PTMH.SelectedValue.ToString().Trim();

                var ptmhExist = dnmBLL.getListDamNhiemMon().Where(d => d.MaChuongTrinh == mactdt && d.MaMonHoc == mamh && d.MaGiaoVien == magv).SingleOrDefault();
                var dncGV = dnmBLL.getListDamNhiemMon().Where(d => d.MaGiaoVien == magv && d.CoLaDamNhiemChinh == 1).GroupBy(d => d.MaMonHoc).ToList().Count();

                if (ptmhExist != null)
                {
                    MessageBox.Show("Phụ trách môn học này đã được đăng ký, hãy thử đăng ký lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!(dncGV >= 5 && dnc == true))
                {
                    int value = Convert.ToInt32(dnc);

                    var ptmh = new DamNhiemMon()
                    {
                        MaChuongTrinh = mactdt,
                        MaMonHoc = mamh,
                        MaGiaoVien = magv,
                        CoLaDamNhiemChinh = value
                    };

                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm phụ trách môn học này không", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        if (dnmBLL.AddDamNhiemMon(ptmh))
                        {
                            MessageBox.Show("Thêm phụ trách môn học thành công", "Thông báo", MessageBoxButtons.OK);
                            LoadDataPTMHGridview();
                            resetDataPTMH();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } else
                {
                    MessageBox.Show("Giáo viên này đã làm đảm nhiệm chính trên 5 môn học khác nhau, hãy đổi giáo viên khác làm đảm nhiệm chính hoặc không cho làm đảm nhiệm chính !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool checkDataDeletePTMH(string mactdt)
        {
            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn phụ trách mà bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnDelete_PTMH_Click(object sender, EventArgs e)
        {
            var mactdtText = cbCTDT_PTMH.Text;
            var mamhText = cbMH_PTMH.Text;
            var magvText = cbGV_PTMH.Text;
            bool dnc = ckDamNhiemChinh.Checked;

            string mactdt;
            string mamh;
            string magv;
            if (checkDataDeletePTMH(mactdtText))
            {
                int value = Convert.ToInt32(dnc);
                mactdt = cbCTDT_PTMH.SelectedValue.ToString().Trim();
                mamh = cbMH_PTMH.SelectedValue.ToString().Trim();
                magv = cbGV_PTMH.SelectedValue.ToString().Trim();

                var ptmhExist = dnmBLL.getListDamNhiemMon().Where(d => d.MaChuongTrinh == mactdt && d.MaMonHoc == mamh && d.MaGiaoVien == magv && d.CoLaDamNhiemChinh == value).SingleOrDefault();
                //var dncGV = dnmBLL.getListDamNhiemMon().Where(d => d.MaGiaoVien == magv).ToList().Count();
                if (ptmhExist != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin phụ trách môn học này không ?", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        var ctkh = ctkhBLL.getListChiTietKhoaHoc().Where(c => c.MaGiaoVien_day == magv && c.MaMonHoc == mamh).FirstOrDefault();
                        if (ctkh != null)
                        {
                            MessageBox.Show("Không thể xóa phụ trách môn học này này, vì đã được phân công trong chi tiết khóa học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetDataPTMH();
                        }
                        else
                        {
                            if (dnmBLL.DeleteDamNhiemMon(mactdt, mamh, magv))
                            {
                                MessageBox.Show("Xóa thông tin phụ trách môn học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataPTMHGridview();
                                resetDataPTMH();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void searchBoxPTMH_Click(object sender, EventArgs e)
        {
            if (cbGiaoVien_Search.Text == "")
            {
                MessageBox.Show("Hãy chọn giáo viên mà bạn cần tìm !");
                cbGiaoVien_Search.SelectedIndex = -1;
                LoadDataPTMHGridview();
            }
            else if (cbGiaoVien_Search.Text != "")
            {
                string value = cbGiaoVien_Search.SelectedValue.ToString().Trim();
                cbGiaoVien_Search.SelectedIndex = -1;
                LoadDataPTMHGridviewSearch(value);
                ListPTMH.ClearSelection();
                MessageBox.Show("Đã tìm kiếm thành công !");
                cbGiaoVien_Search.SelectedIndex = -1;
            }
        }

        public bool checkDataEditPTMH(string mactdt)
        {
            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn phụ trách môn học mà bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnSave_PTMH_Click(object sender, EventArgs e)
        {
            var mactdtText = cbCTDT_PTMH.Text;
            var mamhText = cbMH_PTMH.Text;
            var magvText = cbGV_PTMH.Text;
            bool dnc = ckDamNhiemChinh.Checked;

            string mactdt;
            string mamh;
            string magv; 

            if (checkDataEditPTMH(mamhText))
            {
                int value = Convert.ToInt32(dnc);
                mactdt = cbCTDT_PTMH.SelectedValue.ToString().Trim();
                mamh = cbMH_PTMH.SelectedValue.ToString().Trim();
                magv = cbGV_PTMH.SelectedValue.ToString().Trim();

                var dncGV = dnmBLL.getListDamNhiemMon().Where(d => d.MaGiaoVien == magv && d.CoLaDamNhiemChinh == 1).ToList().Count();
                //MessageBox.Show(dncGV.ToString());
                var ptmhExist = dnmBLL.getListDamNhiemMon().Where(d => d.MaChuongTrinh == mactdt && d.MaMonHoc == mamh && d.MaGiaoVien == magv && d.CoLaDamNhiemChinh == value).SingleOrDefault();
                if (ptmhExist != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!(dncGV >= 5 && dnc == true))
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn chỉnh sửa thông tin phụ trách môn học này không", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        if (dnmBLL.EditDamNhiemMon(mactdt, mamh, magv, value))
                        {
                            MessageBox.Show("Chỉnh sửa thông tin phụ trách môn học thành công", "Thông báo", MessageBoxButtons.OK);
                            LoadDataPTMHGridview();
                            resetDataPTMH();
                        }
                        else
                        {
                            MessageBox.Show("Lưu không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Giáo viên này đã làm đảm nhiệm chính trên 5 môn học khác nhau, hãy đổi giáo viên khác làm đảm nhiệm chính hoặc không cho làm đảm nhiệm chính !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbGiaoVien_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataPTMHGridview();
        }

        private void cbCTDT_PTMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCTDT_PTMH.Text != "")
            {
                LoadDataMH_PTMH(cbCTDT_PTMH.SelectedValue.ToString().Trim());
            }
        }

        private void cbMH_PTMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMH_PTMH.Text != "")
            {
                LoadDataGV_PTMH(cbMH_PTMH.SelectedValue.ToString().Trim());
            }
        }

        private void ListPTMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModePTMH();
            if (btnEditMode_PTMH.Text == "ON")
            {
                if (index >= 0 && index < ListPTMH.Rows.Count)
                {
                    cbCTDT_PTMH.Text = ListPTMH.Rows[index].Cells["TenChuongTrinh_PTMH"].Value.ToString().Trim();
                    LoadDataMH_PTMH(cbCTDT_PTMH.SelectedValue.ToString().Trim());
                    cbMH_PTMH.Text = ListPTMH.Rows[index].Cells["TenMonHoc_PTMH"].Value.ToString().Trim();
                    LoadDataGV_PTMH(cbMH_PTMH.SelectedValue.ToString().Trim());
                    
                    cbGV_PTMH.Text = ListPTMH.Rows[index].Cells["HoTen_PTMH"].Value.ToString().Trim();
                    int dnc = (int)ListPTMH.Rows[index].Cells["CoLaDamNhiemChinh"].Value;
                    if (dnc == 0)
                    {
                        ckDamNhiemChinh.Checked = false;
                    } else
                    {
                        ckDamNhiemChinh.Checked = true;
                    }
                }
            }
        }

        private void ListPTMH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ListPTMH.Columns[e.ColumnIndex].Name == "CoLaDamNhiemChinh" && e.Value != null)
            {
                int value = (int)e.Value;

                if (value == 0)
                {
                    e.Value = "Không";
                    e.FormattingApplied = true;
                }
                else if (value == 1)
                {
                    e.Value = "Có";
                    e.FormattingApplied = true;
                }
            }

        }

        //----------------------------------------CHỨC NĂNG QUẢN LÝ KHÓA HỌC---------------------------------------------------------
        public void turnOffEditModeKH()
        {
            btnEditMode_KhoaHoc.Text = "OFF";
            btnAdd_KhoaHoc.Visible = true;
            btnDelete_KhoaHoc.Visible = false;
            btnSave_KhoaHoc.Visible = false;

            txtID_KhoaHoc.Enabled = true;
            txtID_KhoaHoc.BackColor = Color.White;

            btnEditMode_KhoaHoc.ForeColor = Color.Black;
            resetDataKH();
        }

        public void turnONEditModeKH()
        {
            btnEditMode_KhoaHoc.Text = "ON";
            btnAdd_KhoaHoc.Visible = false;
            btnDelete_KhoaHoc.Visible = true;
            btnSave_KhoaHoc.Visible = true;

            txtID_KhoaHoc.Enabled = false;
            txtID_KhoaHoc.BackColor = Color.LightGray;

            btnEditMode_KhoaHoc.ForeColor = Color.White;

            resetDataKH();
        }

        public void resetDataKH()
        {
            txtID_KhoaHoc.Text = "";
            txtTenKhoaHoc_KhoaHoc.Text = "";
            numNamBatDau.Value = (int)2020;
            numNamKetThuc.Value = (int)2024;
            cbCTDT_KhoaHoc.SelectedIndex = -1;
        }

        private void btnEditMode_KhoaHoc_Click(object sender, EventArgs e)
        {
            if (btnEditMode_KhoaHoc.Text == "ON")
            {
                turnOffEditModeKH();
            }
            else if (btnEditMode_KhoaHoc.Text == "OFF")
            {
                turnONEditModeKH();
            }
        }

        public void LoadDataCTDT_KhoaHoc()
        {
            var ctdts = chuongtrinhBLL.getListChuongTrinh();
            var list = ctdts.Select(c => new
            {
                c.MaChuongTrinh,
                c.TenChuongTrinh
            });
            cbCTDT_KhoaHoc.DataSource = list.ToList();
            cbCTDT_KhoaHoc.DisplayMember = "TenChuongTrinh";
            cbCTDT_KhoaHoc.ValueMember = "MaChuongTrinh";
            cbCTDT_KhoaHoc.SelectedIndex = -1;
        }

        public void LoadDataCTDTSearch_KhoaHoc()
        {
            var ctdts = chuongtrinhBLL.getListChuongTrinh();
            var list = ctdts.Select(c => new
            {
                c.MaChuongTrinh,
                c.TenChuongTrinh
            });
            cbCTDTSearch_KhoaHoc.DataSource = list.ToList();
            cbCTDTSearch_KhoaHoc.DisplayMember = "TenChuongTrinh";
            cbCTDTSearch_KhoaHoc.ValueMember = "MaChuongTrinh";
            cbCTDTSearch_KhoaHoc.SelectedIndex = -1;
        }

        public void LoadDataGirdviewKhoaHoc()
        {
            var query = from kh in khoahocBLL.getListKhoaHoc()
                        join ctdt in chuongtrinhBLL.getListChuongTrinh() on kh.MaChuongTrinh equals ctdt.MaChuongTrinh
                        select new
                        {
                            kh.MaKhoaHoc,
                            kh.TenKhoaHoc,
                            kh.NamBatDau,
                            kh.NamKetThuc,
                            ctdt.TenChuongTrinh
                        };
            ListKhoaHoc.DataSource = query.ToList();
            ListKhoaHoc.ClearSelection();
        }

        public void LoadDataGirdviewKhoaHocSearch(string mactdt)
        {
            var query = from kh in khoahocBLL.getListKhoaHoc()
                        join ctdt in chuongtrinhBLL.getListChuongTrinh() on kh.MaChuongTrinh equals ctdt.MaChuongTrinh
                        where kh.MaChuongTrinh == mactdt
                        select new
                        {
                            kh.MaKhoaHoc,
                            kh.TenKhoaHoc,
                            kh.NamBatDau,
                            kh.NamKetThuc,
                            ctdt.TenChuongTrinh
                        };
            ListKhoaHoc.DataSource = query.ToList();
            ListKhoaHoc.ClearSelection();

            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Không có khóa học nào trong chương trình đào tạo này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbCTDTSearch_KhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGirdviewKhoaHoc();
        }

        private void SearchBox_KhoaHoc_Click(object sender, EventArgs e)
        {
            if (cbCTDTSearch_KhoaHoc.Text == "")
            {
                MessageBox.Show("Hãy chọn chương trình đào tạo cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCTDTSearch_KhoaHoc.SelectedIndex = -1;
                LoadDataGirdviewKhoaHoc();
                ListKhoaHoc.ClearSelection();
            }
            else if (cbCTDTSearch_KhoaHoc.Text != "")
            {
                string value = cbCTDTSearch_KhoaHoc.SelectedValue.ToString().Trim();
                cbCTDTSearch_KhoaHoc.SelectedIndex = -1;
                LoadDataGirdviewKhoaHocSearch(value);
                ListKhoaHoc.ClearSelection();
                MessageBox.Show("Đã tìm kiếm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool checkDataAddKhoaHoc(string id, string ten, int nambatdau, int namketthuc, string mactdt)
        {
            var listkhoahoc = khoahocBLL.getListKhoaHoc();
            var ID_KhoaHoc = listkhoahoc.Where(k => k.MaKhoaHoc.Equals(id, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            if (ID_KhoaHoc != null)
            {
                MessageBox.Show("ID đã tồn tại, hãy nhập lại giá trị ID khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (id.Length - 1 >= 10)
            {
                MessageBox.Show("Chiều dài ID không được quá 10 ký tự, hãy nhập lại giá trị ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên khóa học không được bỏ trống, hãy nhập giá trị tên khóa học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (ten.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khóa học không được quá 50 ký tự, hãy nhập lại giá trị tên khóa học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn chương trình đào tạo cho khóa học này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (nambatdau >= namketthuc)
            {
                MessageBox.Show("Năm bắt đầu phải nhỏ hơn năm kết thúc!, hãy nhập lại giá trị !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (namketthuc < nambatdau + 2)
            {
                MessageBox.Show("Khóa học có khoảng thời gian ít nhất là 2 năm, hãy nhập lại giá trị !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnAdd_KhoaHoc_Click(object sender, EventArgs e)
        {
            var makhoahoc = txtID_KhoaHoc.Text.ToString().Trim();
            var tenkhoahoc = txtTenKhoaHoc_KhoaHoc.Text.ToString().Trim();
            int nambatdau = (int)numNamBatDau.Value;
            int namketthuc = (int)numNamKetThuc.Value;
            string cbCTDTText = cbCTDT_KhoaHoc.Text.ToString().Trim();
            string mactdt;
            if (checkDataAddKhoaHoc(makhoahoc, tenkhoahoc, nambatdau, namketthuc, cbCTDTText))
            {
                mactdt = cbCTDT_KhoaHoc.SelectedValue.ToString().Trim();
                var kh = new KhoaHoc()
                {
                    MaKhoaHoc = makhoahoc,
                    TenKhoaHoc = tenkhoahoc,
                    NamBatDau = nambatdau,
                    NamKetThuc = namketthuc,
                    MaChuongTrinh = mactdt,
                };
                
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm khóa học này không", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (khoahocBLL.AddKhoaHoc(kh))
                    {
                        MessageBox.Show("Thêm Khóa học thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadDataGirdviewKhoaHoc();
                        resetDataKH();

                        LoadDataCTDT_KhoaHoc();
                        LoadDataCTDTSearch_KhoaHoc();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public bool DeleteKhoaHoc(string makhoahoc)
        {
            if (string.IsNullOrEmpty(makhoahoc))
            {
                MessageBox.Show("Hãy chọn khóa học mà bạn muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnDelete_KhoaHoc_Click(object sender, EventArgs e)
        {
            var makhoahoc = txtID_KhoaHoc.Text.ToString().Trim();
            var tenkhoahoc = txtTenKhoaHoc_KhoaHoc.Text.ToString().Trim();
            int nambatdau = (int)numNamBatDau.Value;
            int namketthuc = (int)numNamKetThuc.Value;
            string cbCTDTText = cbCTDT_KhoaHoc.Text.ToString().Trim();
            string mactdt;

            if (checkDeleteMonHoc(makhoahoc))
            {
                mactdt = cbCTDT_KhoaHoc.SelectedValue.ToString().Trim();
                var khExist = khoahocBLL.getListKhoaHoc().Where(k => k.MaKhoaHoc == makhoahoc && k.TenKhoaHoc == tenkhoahoc && k.NamBatDau == nambatdau && k.NamKetThuc == namketthuc && k.MaChuongTrinh == mactdt).FirstOrDefault();
                if (khExist != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin khóa học này không ?", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        var listkhoahoc = khoahocBLL.getListKhoaHoc().Where(k => k.MaKhoaHoc == makhoahoc).FirstOrDefault();
                        if (listkhoahoc.KhoaHocMons.Any())
                        {
                            MessageBox.Show("Không thể xóa khóa học này, vì ảnh hưởng đến các bản ghi của chi tiết khóa học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetDataKH();
                        }
                        else
                        {
                            if (khoahocBLL.DeleteKhoaHoc(makhoahoc))
                            {
                                MessageBox.Show("Xóa thông tin khóa học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataGirdviewKhoaHoc();
                                resetDataKH();

                                LoadDataCTDT_KhoaHoc();
                                LoadDataCTDTSearch_KhoaHoc();
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool checkDataEditKhoaHoc(string makhoahoc, string tenkhoahoc, int nambatdau, int namketthuc, string mactdt)
        {
            if (string.IsNullOrEmpty(makhoahoc))
            {
                MessageBox.Show("Hãy chọn khóa học mà bạn muốn chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(tenkhoahoc))
            {
                MessageBox.Show("Tên khóa học không được bỏ trống, hãy nhập giá trị tên khóa học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tenkhoahoc.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khóa học không được quá 50 ký tự, hãy nhập lại giá trị tên khóa học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn chương trình đào tạo cho khóa học này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (nambatdau >= namketthuc)
            {
                MessageBox.Show("Năm bắt đầu phải nhỏ hơn năm kết thúc!, hãy nhập lại giá trị !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (namketthuc < nambatdau + 2)
            {
                MessageBox.Show("Khóa học có khoảng thời gian ít nhất là 2 năm, hãy nhập lại giá trị !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnSave_KhoaHoc_Click(object sender, EventArgs e)
        {
            var makhoahoc = txtID_KhoaHoc.Text.ToString().Trim();
            var tenkhoahoc = txtTenKhoaHoc_KhoaHoc.Text.ToString().Trim();
            int nambatdau = (int)numNamBatDau.Value;
            int namketthuc = (int)numNamKetThuc.Value;
            string cbCTDTText = cbCTDT_KhoaHoc.Text.ToString().Trim();
            string mactdt;

            if (checkDataEditKhoaHoc(makhoahoc, tenkhoahoc, nambatdau, namketthuc, cbCTDTText))
            {
                mactdt = cbCTDT_KhoaHoc.SelectedValue.ToString().Trim();
                var khExist = khoahocBLL.getListKhoaHoc().Where(k => k.MaKhoaHoc == makhoahoc && k.TenKhoaHoc == tenkhoahoc && k.NamBatDau == nambatdau && k.NamKetThuc == namketthuc && k.MaChuongTrinh == mactdt).FirstOrDefault();
                if (khExist != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa Khóa học này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (khoahocBLL.EditKhoaHoc(makhoahoc, tenkhoahoc, nambatdau, namketthuc, mactdt))
                    {
                        MessageBox.Show("Lưu thay đổi thành công !");
                        LoadDataGirdviewKhoaHoc();
                        resetDataKH();

                        LoadDataCTDT_KhoaHoc();
                        LoadDataCTDTSearch_KhoaHoc();
                        LoadDataGridviewCTKH();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ListKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModeKH();
            if (btnEditMode_KhoaHoc.Text == "ON")
            {
                if (index >= 0 && index < ListKhoaHoc.Rows.Count)
                {
                    txtID_KhoaHoc.Text = ListKhoaHoc.Rows[index].Cells["MaKhoaHoc_KH"].Value.ToString();
                    txtTenKhoaHoc_KhoaHoc.Text = ListKhoaHoc.Rows[index].Cells["TenKhoaHoc_KH"].Value.ToString();
                    numNamBatDau.Value = (int)ListKhoaHoc.Rows[index].Cells["NamBatDaU"].Value;
                    numNamKetThuc.Value = (int)ListKhoaHoc.Rows[index].Cells["NamKetThuc"].Value;
                    cbCTDT_KhoaHoc.Text = ListKhoaHoc.Rows[index].Cells["TenChuongTrinh_KH"].Value.ToString();
                }
            }
        }

        //--------------------------------------------CHỨC NĂNG CHI TIẾT KHÓA HỌC ---------------------------------------------

        public void turnOffEditModeCTKH()
        {
            btnEditMode_ChiTietKhoaHoc.Text = "OFF";
            btnAdd_CTKH.Visible = true;
            btnDelete_CTKH.Visible = false;
            btnSave_CTKH.Visible = false;

            cbKhoaHoc_CTKH.Enabled = true;
            cbMH_CTKH.Enabled = true;
            cbGV_CTKH.Enabled = true;

            btnEditMode_ChiTietKhoaHoc.ForeColor = Color.Black;
            resetDataCTKH();
        }

        public void turnONEditModeCTKH()
        {
            btnEditMode_ChiTietKhoaHoc.Text = "ON";
            btnAdd_CTKH.Visible = false;
            btnDelete_CTKH.Visible = true;
            btnSave_CTKH.Visible = true;

            cbKhoaHoc_CTKH.Enabled = false;
            cbMH_CTKH.Enabled = false;
            cbGV_CTKH.Enabled = false;

            btnEditMode_ChiTietKhoaHoc.ForeColor = Color.White;

            resetDataCTKH();
        }

        public void resetDataCTKH()
        {
            cbKhoaHoc_CTKH.SelectedIndex = -1;
            cbMH_CTKH.SelectedIndex = -1;
            cbGV_CTKH.SelectedIndex = -1;
            txtMaPhong.Text = "";
            cbThoiGian.SelectedIndex = -1;
        }

        private void btnEditMode_ChiTietKhoaHoc_Click(object sender, EventArgs e)
        {
            if (btnEditMode_ChiTietKhoaHoc.Text == "ON")
            {
                turnOffEditModeCTKH();
            }
            else if (btnEditMode_ChiTietKhoaHoc.Text == "OFF")
            {
                turnONEditModeCTKH();
            }
        }

        public void LoadDataKhoaHoc_CTKH()
        {
            var query = from kh in khoahocBLL.getListKhoaHoc()
                        select new
                        {
                            kh.MaKhoaHoc,
                            kh.TenKhoaHoc
                        };
            cbKhoaHoc_CTKH.DataSource = query.ToList();
            cbKhoaHoc_CTKH.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc_CTKH.ValueMember = "MaKhoaHoc";
            cbKhoaHoc_CTKH.SelectedIndex = -1;
        }

        public void LoadDataMH_CTKH(string makhoahoc)
        {
            var query = from kh in khoahocBLL.getListKhoaHoc()
                        join ct in chuongtrinhBLL.getListChuongTrinh() on kh.MaChuongTrinh equals ct.MaChuongTrinh
                        join damnhiemmon in dnmBLL.getListDamNhiemMon() on ct.MaChuongTrinh equals damnhiemmon.MaChuongTrinh
                        join mh in monhocBLL.getListMonHoc() on damnhiemmon.MaMonHoc equals mh.MaMonHoc
                        where kh.MaKhoaHoc == makhoahoc
                        select new
                        {
                            mh.MaMonHoc,
                            mh.TenMonHoc
                        };
            cbMH_CTKH.DataSource = query.Distinct().ToList();
            cbMH_CTKH.DisplayMember = "TenMonHoc";
            cbMH_CTKH.ValueMember = "MaMonHoc";
            cbMH_CTKH.SelectedIndex = -1;
        }

        public void LoadDataGV_CTKH(string mamh)
        {
            var query = from mh in monhocBLL.getListMonHoc()
                        join dnm in dnmBLL.getListDamNhiemMon() on mh.MaMonHoc equals dnm.MaMonHoc
                        join gv in giaovienBLL.getListGiaoVien() on dnm.MaGiaoVien equals gv.MaGiaoVien
                        where mh.MaMonHoc == mamh
                        select new
                        {
                            gv.MaGiaoVien,
                            gv.HoTen
                        };
            cbGV_CTKH.DataSource = query.Distinct().ToList();
            cbGV_CTKH.DisplayMember = "HoTen";
            cbGV_CTKH.ValueMember = "MaGiaoVien";
            cbGV_CTKH.SelectedIndex = -1;
        }

        private void cbKhoaHoc_CTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoaHoc_CTKH.Text != "")
            {
                LoadDataMH_CTKH(cbKhoaHoc_CTKH.SelectedValue.ToString().Trim());
            }
        }

        private void cbMH_CTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMH_CTKH.Text != "")
            {
                LoadDataGV_CTKH(cbMH_CTKH.SelectedValue.ToString().Trim());
            }
        }

        public void LoadDataKhoaHocSearch_CTKH()
        {

            var query = from kh in khoahocBLL.getListKhoaHoc()
                        select new
                        {
                            kh.MaKhoaHoc,
                            kh.TenKhoaHoc
                        };
            cbKhoaHoc_Search_CTKH .DataSource = query.ToList();
            cbKhoaHoc_Search_CTKH.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc_Search_CTKH.ValueMember = "MaKhoaHoc";
            cbKhoaHoc_Search_CTKH.SelectedIndex = -1;

        }

        public void LoadDataGridviewCTKH()
        {
            var query = from ctkh in ctkhBLL.getListChiTietKhoaHoc()
                        join kh in khoahocBLL.getListKhoaHoc() on ctkh.MaKhoaHoc equals kh.MaKhoaHoc
                        join mh in monhocBLL.getListMonHoc() on ctkh.MaMonHoc equals mh.MaMonHoc
                        join gv in giaovienBLL.getListGiaoVien() on ctkh.MaGiaoVien_day equals gv.MaGiaoVien
                        select new
                        {
                            kh.TenKhoaHoc,
                            mh.TenMonHoc,
                            gv.HoTen,
                            ctkh.MaThu,
                            ctkh.MaPhong
                        };
            ListCTKH.DataSource = query.ToList();
        }

        public void LoadDataGridviewCTKH_Search(string makhoahoc)
        {
            var query = from ctkh in ctkhBLL.getListChiTietKhoaHoc()
                        join kh in khoahocBLL.getListKhoaHoc() on ctkh.MaKhoaHoc equals kh.MaKhoaHoc
                        join mh in monhocBLL.getListMonHoc() on ctkh.MaMonHoc equals mh.MaMonHoc
                        join gv in giaovienBLL.getListGiaoVien() on ctkh.MaGiaoVien_day equals gv.MaGiaoVien
                        where ctkh.MaKhoaHoc == makhoahoc
                        select new
                        {
                            kh.TenKhoaHoc,
                            mh.TenMonHoc,
                            gv.HoTen,
                            ctkh.MaThu,
                            ctkh.MaPhong
                        };
            ListCTKH.DataSource = query.ToList();

            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Không có chi tiết khóa học nào thuộc khóa học này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool checkDataAddCTKH(string makhoahoc, string mamh, string magv, string maphong, string mathu)
        {

            if (string.IsNullOrEmpty(makhoahoc))
            {
                MessageBox.Show("Giá trị khóa học không được bỏ trống, hãy chọn giá trị khóa học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Giá trị môn học không được bỏ trống, hãy chọn giá trị môn học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(magv))
            {
                MessageBox.Show("Giá trị giáo viên không được bỏ trống, hãy chọn giá trị giáo viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Giá trị phòng học không được bỏ trống, hãy chọn giá trị phòng học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (maphong.Length - 1 > 10)
            {
                MessageBox.Show("Chiều dài ký tự phòng học không được quá 10 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mathu))
            {
                MessageBox.Show("Giá trị thời gian không được bỏ trống, hãy chọn giá trị thời gian cho chi tiết khóa học này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            var listctkh = ctkhBLL.getListChiTietKhoaHoc().Where(c => c.MaKhoaHoc == makhoahoc && c.MaMonHoc == mamh && c.MaGiaoVien_day == magv).FirstOrDefault();

            if (listctkh != null)
            {
                MessageBox.Show("Chi tiết khóa học này đã được đăng ký, hãy đăng ký lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public int getNamBatDau(string makhoahoc)
        {
            var query = from ctkh in ctkhBLL.getListChiTietKhoaHoc()
                        join kh in khoahocBLL.getListKhoaHoc() on ctkh.MaKhoaHoc equals kh.MaKhoaHoc
                        where ctkh.MaKhoaHoc == makhoahoc
                        select kh.NamBatDau;
            var value = query.FirstOrDefault();
            return value;
        }

        public int getNamBatDauInput(string makhoahoc)
        {
            var query = from kh in khoahocBLL.getListKhoaHoc()
                        where kh.MaKhoaHoc == makhoahoc
                        select kh.NamBatDau;
            var value = query.FirstOrDefault();
            return value;
        }

        public string getMaChuongTrinh(string makhoahoc)
        {
            var query = from ctkh in ctkhBLL.getListChiTietKhoaHoc()
                        join kh in khoahocBLL.getListKhoaHoc() on ctkh.MaKhoaHoc equals kh.MaKhoaHoc
                        where ctkh.MaKhoaHoc == makhoahoc
                        select kh.MaChuongTrinh;
            var value = query.FirstOrDefault();
            return value;
        }

        public string getMaChuongTrinhInput(string makhoahoc)
        {
            var query = from kh in khoahocBLL.getListKhoaHoc()
                        where kh.MaKhoaHoc == makhoahoc
                        select kh.MaChuongTrinh;
            var value = query.FirstOrDefault();
            return value;
        }

        public int getHocKy(string mact, string mamh)
        {
            var query = from ctmh in ctmhBLL.getListCTMH()
                  where ctmh.MaMonHoc == mamh && ctmh.MaChuongTrinh == mact
                  select ctmh.HocKy;
            var value = query.FirstOrDefault();
            return value;
        }

        public IList<KhoaHocMon> getListCTKHequals(string magv, string mathu)
        {
            var query = from ctkh in ctkhBLL.getListChiTietKhoaHoc()
                        where ctkh.MaGiaoVien_day == magv && ctkh.MaThu == mathu
                        select ctkh;
            return query.ToList();
        }

        public bool checkThoiGianGiangDay(string makhoahoc, string mamh, string magv, string maphong, string thu)
        {
            //Dùng để debug
            //MessageBox.Show(makhoahoc);
            //MessageBox.Show(mamh);
            //MessageBox.Show(magv);

            int nambatdau = getNamBatDauInput(makhoahoc);
            //Hiển thị năm bắt đầu của chi tiết khóa học đang thêm
            //MessageBox.Show(nambatdau.ToString());

            string mact = getMaChuongTrinhInput(makhoahoc);
            //Hiển thị chương trình của chi tiết khóa học đang thêm
            //MessageBox.Show(mact);

            int hocky = getHocKy(mact, mamh);
            //Hiển thị học kỳ của môn học mà giảng viên đó đang phụ trách cho chi tiết khóa học này
            //MessageBox.Show(hocky.ToString());

            var ctkhGeneral = getListCTKHequals(magv, thu);

            foreach (var item in ctkhGeneral)
            {
                var mamhKH = item.MaMonHoc;
                int itemNamBatDau = getNamBatDau(item.MaKhoaHoc);
                //MessageBox.Show(itemNamBatDau.ToString());
                string itemMCT = getMaChuongTrinh(item.MaKhoaHoc);
                //MessageBox.Show(itemMCT);
                int itemhocky = getHocKy(itemMCT, mamhKH);
                //MessageBox.Show(itemhocky.ToString());

                if (itemNamBatDau == nambatdau && itemhocky == hocky)
                {
                    MessageBox.Show($"Thời gian giảng dạy của giáo viên này đã bị trùng với {item.KhoaHoc.TenKhoaHoc} tại thời điểm {maphong} lúc {thu} ");
                    return false;
                }
                else if (itemNamBatDau > nambatdau)
                {
                    switch (itemNamBatDau - nambatdau)
                    {
                        case 1:
                            if (itemhocky - hocky == 2)
                            {
                                MessageBox.Show($"Thời gian giảng dạy của giáo viên này đã bị trùng với {item.KhoaHoc.TenKhoaHoc} tại thời điểm {maphong} lúc {thu} ");
                                return false;
                            }
                            break;
                        case 2:
                            if (itemhocky - hocky == 4)
                            {
                                MessageBox.Show($"Thời gian giảng dạy của giáo viên này đã bị trùng với {item.KhoaHoc.TenKhoaHoc} tại thời điểm {maphong} lúc {thu} ");
                                return false;
                            }
                            break;
                        case 3:
                            if (itemhocky - hocky == 6)
                            {
                                MessageBox.Show($"Thời gian giảng dạy của giáo viên này đã bị trùng với {item.KhoaHoc.TenKhoaHoc} tại thời điểm {maphong} lúc {thu} ");
                                return false;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (itemNamBatDau < nambatdau)
                {
                    switch (nambatdau - itemNamBatDau)
                    {
                        case 1:
                            if (hocky - itemhocky == 2)
                            {
                                MessageBox.Show($"Thời gian giảng dạy của giáo viên này đã bị trùng với {item.KhoaHoc.TenKhoaHoc} tại thời điểm {maphong} lúc {thu} ");
                                return false;
                            }
                            break;
                        case 2:
                            if (hocky - itemhocky == 4)
                            {
                                MessageBox.Show($"Thời gian giảng dạy của giáo viên này đã bị trùng với {item.KhoaHoc.TenKhoaHoc} tại thời điểm {maphong} lúc {thu} ");
                                return false;
                            }
                            break;
                        case 3:
                            if (hocky - itemhocky == 6)
                            {
                                MessageBox.Show($"Thời gian giảng dạy của giáo viên này đã bị trùng với {item.KhoaHoc.TenKhoaHoc} tại thời điểm {maphong} lúc {thu} ");
                                return false;
                            }
                            break;
                        default:
                            break;
                    }
                }

            }
            return true;
        }

        private void btnAdd_CTKH_Click(object sender, EventArgs e)
        {
            var makhoahocText = cbKhoaHoc_CTKH.Text;
            var mamhText = cbMH_CTKH.Text;
            var magvText = cbGV_CTKH.Text;
            var maphong = txtMaPhong.Text;
            var thu = cbThoiGian.Text;


            if (checkDataAddCTKH(makhoahocText, mamhText, magvText, maphong, thu))
            {
                string makhoahoc = cbKhoaHoc_CTKH.SelectedValue.ToString().Trim();
                string mamh = cbMH_CTKH.SelectedValue.ToString().Trim();
                string magv = cbGV_CTKH.SelectedValue.ToString().Trim();
                if (checkThoiGianGiangDay(makhoahoc, mamh, magv, maphong, thu))
                {
                    var chitietkhpahoc = new KhoaHocMon()
                    {
                        MaKhoaHoc = makhoahoc,
                        MaMonHoc = mamh,
                        MaGiaoVien_day = magv,
                        MaPhong = maphong,
                        MaThu = thu
                    };

                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm chi tiết khóa học này không", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        if (ctkhBLL.AddChiTietKhoaHoc(chitietkhpahoc))
                        {
                            MessageBox.Show("Thêm chi tiết Khóa học thành công", "Thông báo", MessageBoxButtons.OK);
                            LoadDataGridviewCTKH();
                            resetDataCTKH();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công ! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }


            }
        }

        public bool checkDataDeleteCTKH(string makhoahoc) 
        {
            if (string.IsNullOrEmpty(makhoahoc))
            {
                MessageBox.Show("Hãy chọn chi tiết khóa học mà bạn muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnDelete_CTKH_Click(object sender, EventArgs e)
        {
            var makhoahocText = cbKhoaHoc_CTKH.Text;
            var mamhText = cbMH_CTKH.Text;
            var magvText = cbGV_CTKH.Text;
            var maphong = txtMaPhong.Text;
            var thu = cbThoiGian.Text;

            if (checkDataDeleteCTKH(makhoahocText))
            {
                string makhoahoc = cbKhoaHoc_CTKH.SelectedValue.ToString().Trim();
                string mamh = cbMH_CTKH.SelectedValue.ToString().Trim();
                string magv = cbGV_CTKH.SelectedValue.ToString().Trim();
                var ctkhExist = ctkhBLL.getListChiTietKhoaHoc().Where(k => k.MaKhoaHoc == makhoahoc && k.MaMonHoc == mamh && k.MaGiaoVien_day == magv && k.MaThu == thu && k.MaPhong == maphong).FirstOrDefault();
                if (ctkhExist != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa thông tin chi tiết khóa học này không ?", "Thông báo", MessageBoxButtons.YesNo))
                    {
                        
                        if (ctkhBLL.DeleteChiTietKhoaHoc(makhoahoc, mamh, magv))
                        {
                            MessageBox.Show("Xóa thông tin chi tiết khóa học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridviewCTKH();
                            resetDataCTKH();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool checkDataEditCTKH(string makhoahoc, string maphong, string mathu)
        {
            if (string.IsNullOrEmpty(makhoahoc))
            {
                MessageBox.Show("Hãy chọn giá trị chi tiết khóa học mà bạn cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Giá trị phòng học không được bỏ trống, hãy chọn giá trị phòng học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (maphong.Length - 1 > 10)
            {
                MessageBox.Show("Chiều dài ký tự phòng học không được quá 10 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(mathu))
            {
                MessageBox.Show("Giá trị thời gian không được bỏ trống, hãy chọn giá trị thời gian cho chi tiết khóa học này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnSave_CTKH_Click(object sender, EventArgs e)
        {
            var makhoahocText = cbKhoaHoc_CTKH.Text;
            var mamhText = cbMH_CTKH.Text;
            var magvText = cbGV_CTKH.Text;
            var maphong = txtMaPhong.Text;
            var thu = cbThoiGian.Text;

            if (checkDataEditCTKH(makhoahocText, maphong, thu))
            {
                string makhoahoc = cbKhoaHoc_CTKH.SelectedValue.ToString().Trim();
                string mamh = cbMH_CTKH.SelectedValue.ToString().Trim();
                string magv = cbGV_CTKH.SelectedValue.ToString().Trim();
                var ctkhExist = ctkhBLL.getListChiTietKhoaHoc().Where(k => k.MaKhoaHoc == makhoahoc && k.MaMonHoc == mamh && k.MaGiaoVien_day == magv && k.MaThu == thu && k.MaPhong == maphong).FirstOrDefault();
                if (ctkhExist != null)
                {
                    MessageBox.Show("Thông tin chưa chỉnh sữa, hãy thực hiện chỉnh sửa trước khi lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa chi tiết Khóa học này không ?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    if (checkThoiGianGiangDay(makhoahoc, mamh, magv, maphong, thu))
                    {
                        if (ctkhBLL.EditChiTietKhoaHoc(makhoahoc, mamh, magv, maphong, thu))
                        {
                            MessageBox.Show("Lưu thay đổi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridviewCTKH();
                            resetDataCTKH();
                        }
                        else
                        {
                            MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void cbKhoaHoc_Search_CTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridviewCTKH();
        }

        private void searchBox_CTKH_Click(object sender, EventArgs e)
        {
            if (cbKhoaHoc_Search_CTKH.Text == "")
            {
                MessageBox.Show("Hãy chọn khóa học cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbKhoaHoc_Search_CTKH.SelectedIndex = -1;
                LoadDataGridviewCTKH();
                ListCTKH.ClearSelection();
            }
            else if (cbKhoaHoc_Search_CTKH.Text != "")
            {
                string value = cbKhoaHoc_Search_CTKH.SelectedValue.ToString().Trim();
                cbKhoaHoc_Search_CTKH.SelectedIndex = -1;
                LoadDataGridviewCTKH_Search(value);
                ListCTKH.ClearSelection();
                MessageBox.Show("Đã tìm kiếm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListCTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            turnONEditModeCTKH();
            if (btnEditMode_ChiTietKhoaHoc.Text == "ON")
            {
                if (index >= 0 && index < ListCTKH.Rows.Count)
                {
                    cbKhoaHoc_CTKH.Text = ListCTKH.Rows[index].Cells["TenKhoaHoc_CTKH"].Value.ToString();
                    LoadDataMH_CTKH(cbKhoaHoc_CTKH.SelectedValue.ToString().Trim());
                    cbMH_CTKH.Text = ListCTKH.Rows[index].Cells["TenMonHoc_CTKH"].Value.ToString();
                    LoadDataGV_CTKH(cbMH_CTKH.SelectedValue.ToString().Trim());
                    cbGV_CTKH.Text = ListCTKH.Rows[index].Cells["HoTen_CTKH"].Value.ToString();
                    txtMaPhong.Text = ListCTKH.Rows[index].Cells["MaPhong_CTKH"].Value.ToString();
                    cbThoiGian.Text = ListCTKH.Rows[index].Cells["MaThu_CTKH"].Value.ToString();

                    string mamh = cbMH_CTKH.SelectedValue.ToString().Trim();

                    int nambatdau = getNamBatDau(cbKhoaHoc_CTKH.SelectedValue.ToString().Trim());
                    //MessageBox.Show(nambatdau.ToString());

                    string mact = getMaChuongTrinh(cbKhoaHoc_CTKH.SelectedValue.ToString().Trim());
                    //MessageBox.Show(mact);

                    int hocky = getHocKy(mact, mamh);
                    //MessageBox.Show(hocky.ToString());

                }
            }
        }

    }

    

}
