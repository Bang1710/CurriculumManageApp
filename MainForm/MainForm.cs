using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainForm
{
    public partial class MainForm : Form
    {
        KhoaBLL khoaBLL = new KhoaBLL();
        GiaoVienBLL giaovienBLL = new GiaoVienBLL();
        ChuongTrinhBLL chuongtrinhBLL = new ChuongTrinhBLL();
        MonHocBLL monhocBLL = new MonHocBLL();
        ChuongTrinhMonHocBLL ctmhBLL = new ChuongTrinhMonHocBLL();
        DamNhiemMonBLL dnmBLL = new DamNhiemMonBLL();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpControlLoadingForm();
            CustomdatagirdviewMenu();

            // KHOA
            //khoaBLL = new KhoaBLL();
            turnOffEditModeKhoa();
            LoadDataKhoaGirdView();
            LoadDataKhoaCombobox();

            //GIÁO VIÊN
            //GiaoVienBLL giaovienBLL = new GiaoVienBLL();
            turnOffEditModeGiaoVien();
            LoadDataGiaoVienGridview();
            LoadDataGiaoVienCombobox();

            //CHƯƠNG TRÌNH
            turnOffEditModeChuongTrinh();
            LoadDataChuongTrinhCombobox();
            //LoadDataGiangVien_ChuongTrinhCombobox(cbKhoa_ChuongTrinh.SelectedValue.ToString());
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
                    //    LoadDataKhoaGirdView();
                    //    LoadDataKhoaCombobox();
                    //}
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
                        LoadDataGiaoVienCombobox();
                        LoadDataChuongTrinhCombobox();
                        resetDataKhoa();
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
                        MessageBox.Show("Không thể xóa khoa này");
                        resetDataKhoa();
                    } else
                    {
                        if (khoaBLL.DeleteKhoa(makhoa))
                        {
                            MessageBox.Show("Xóa thông tin khoa thành công !");
                            LoadDataKhoaGirdView();
                            LoadDataKhoaCombobox();
                            LoadDataGiaoVienCombobox();
                            LoadDataChuongTrinhCombobox();
                            resetDataKhoa();
                        }
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
                        LoadDataKhoaCombobox();

                        LoadDataGiaoVienCombobox();
                        LoadDataGiaoVienGridview();

                        LoadDataChuongTrinhCombobox();
                        LoadDataChuongTrinhGridview();
                        
                        resetDataKhoa();
                        resetDataCombobox();
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
            //ListKhoa.ClearSelection();
        }

        public void LoadDataKhoaCombobox()
        {
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
                        resetDataKhoa();
                        //LoadDataKhoaCombobox();
                    } else
                    {
                        var khoalq = khoaBLL.getListKhoa().Where(k => k.MaKhoa == cbMaKhoa_Khoa.SelectedValue.ToString()).Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
                        cbMaKhoa_Khoa.SelectedIndex = -1;
                        ListKhoa.DataSource = khoalq;
                        cbMaKhoa_Khoa.Text = "";
                        ListKhoa.ClearSelection();
                        MessageBox.Show("Đã tìm kiếm thành công !");
                        resetDataKhoa();
                    }
                }
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
                MessageBox.Show("Không có giáo viên nào thuộc khoa này");
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
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID");
                return false;
            }

            if (mgv.Length - 1 >= 10)
            {
                MessageBox.Show("Chiều dài ID không được quá 10 ký tự, hãy nhập lại giá trị ID");
                return false;
            }

            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Tên giáo viên không được bỏ trống, hãy nhập giá trị tên giáo viên");
                return false;
            }

            if (hoten.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên khoa không được quá 50 ký tự, hãy nhập lại giá trị khoa");
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa trực thuộc cho giáo viên mà bạn cần thêm !");
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
                        LoadDataChuongTrinhCombobox();
                        resetDataGiaoVien();
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
                MessageBox.Show("Hãy chọn khoa cần tìm !");
                cbMaKhoa_GiaoVien.SelectedIndex = -1;
                LoadDataGiaoVienGridview();
            }
            else if (cbMaKhoa_GiaoVien.Text != "")
            {
                string value = cbMaKhoa_GiaoVien.SelectedValue.ToString().Trim();
                cbMaKhoa_GiaoVien.SelectedIndex = -1;
                LoadDataGiaoVienGridviewSearch(value);
                MessageBox.Show("Đã tìm kiếm thành công !");
                resetDataGiaoVien();
                resetDataCombobox();
            }
        }

        public bool checkDataDeletGiaoVien(string mgv)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                MessageBox.Show("Hãy chọn giáo viên mà bạn cần xóa !");
                return false;
            }
            return true;
        }

        private void btnDelete_GiaoVien_Click(object sender, EventArgs e)
        {
            var magv = txtID_GiaoVien.Text.ToString().Trim();
            var hoten = txtHoTen_GiaoVien.Text.ToString().Trim();
            //var makhoaText = cbKhoa_GiaoVien.Text.ToString().Trim();
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
                            MessageBox.Show("Không thể xóa giáo viên này này");
                            resetDataGiaoVien();
                        }
                        else
                        {
                            if (giaovienBLL.DeleteGiaoVien(magv))
                            {
                                MessageBox.Show("Xóa thông tin giáo viên thành công !");
                                LoadDataGiaoVienGridview();
                                LoadDataChuongTrinhCombobox();
                                resetDataGiaoVien();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa");
                }
            }

        }

        public bool checkDataEditGiaoVien(string magv, string hoten, string makhoa)
        {
            if (string.IsNullOrEmpty(magv))
            {
                MessageBox.Show("Hãy chọn giáo viên mà bạn cần muốn chỉnh sửa !");
                return false;
            }

            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Tên giáo viên không được bỏ trống, hãy nhập giá trị tên giáo viên cần chỉnh sửa !");
                return false;
            }

            if (hoten.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên giáo viên không được quá 50 ký tự, hãy nhập lại giá trị tên giáo viên cần chỉnh sửa");
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa trực thuộc cho giáo viên mà bạn cần chỉnh sửa !");
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
                        MessageBox.Show("Lưu thay đổi thành công !");
                        LoadDataGiaoVienGridview();
                        LoadDataChuongTrinhGridview();
                        LoadDataChuongTrinhCombobox();
                        resetDataGiaoVien();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.");
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
            LoadDataGiangVien_ChuongTrinhCombobox(cbKhoa_ChuongTrinh.SelectedValue.ToString());
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
                MessageBox.Show("Không có chương trình đào tạo nào thuộc khoa này");
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
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID");
                return false;
            }

            if (mact.Length - 1 >= 5)
            {
                MessageBox.Show("Chiều dài ID không được quá 5 ký tự, hãy nhập lại giá trị ID");
                return false;
            }

            if (string.IsNullOrEmpty(tenct))
            {
                MessageBox.Show("Tên chương trình đào tạo không được bỏ trống, hãy nhập giá trị tên chương trình đào tạo");
                return false;
            }

            if (tenct.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên chương trình đào tạo không được quá 50 ký tự, hãy nhập lại giá trị tên chương trình đào tạo");
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
                MessageBox.Show("Hãy chọn khoa phụ trách cho chương trình đào tạo này !");
                return false;
            }

            if (mgv == "")
            {
                MessageBox.Show("Hãy chọn giáo viên làm giáo đốc cho chương trình đào tạo này !");
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
                        MessageBox.Show("Thêm chương trình đào tạo thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadDataChuongTrinhGridview();
                        LoadDataComboboxCTDT_CTMH();
                        LoadDataComboboxSearchCTDT_CTMH();
                        resetDataChuongTrinh();
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
                MessageBox.Show("Hãy chọn chương trình mà bạn cần xóa");
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
                            MessageBox.Show("Không thể xóa chương trình đào tạo này");
                            resetDataChuongTrinh();
                        }
                        else
                        {
                            if (chuongtrinhBLL.DeleteChuongTrinh(mact))
                            {
                                MessageBox.Show("Xóa thông tin chương trình đào tạo thành công !");
                                LoadDataChuongTrinhGridview();
                                LoadDataComboboxCTDT_CTMH();
                                LoadDataComboboxSearchCTDT_CTMH();
                                resetDataChuongTrinh();
                            }
                        }

                    }
                } else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa");
                }
            }

        }

        public bool CheckDataEditChuongtrinh(string mact, string tenct, string mabh, string makhoa, string mgv)
        {
            if (string.IsNullOrEmpty(mact))
            {
                MessageBox.Show("Hãy chọn chương trình đào tạo mà bạn muốn chỉnh sửa !");
                return false;
            }

            if (string.IsNullOrEmpty(tenct))
            {
                MessageBox.Show("Tên chương trình đào tạo không được bỏ trống, hãy nhập giá trị tên chương trình đào tạo");
                return false;
            }

            if (tenct.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên chương trình đào tạo không được quá 50 ký tự, hãy nhập lại giá trị tên chương trình đào tạo");
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
                MessageBox.Show("Hãy chọn khoa phụ trách cho chương trình đào tạo này !");
                return false;
            }

            if (mgv == "")
            {
                MessageBox.Show("Hãy chọn giáo viên làm giáo đốc cho chương trình đào tạo này !");
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
                        MessageBox.Show("Lưu thay đổi thành công !");
                        LoadDataChuongTrinhGridview();

                        LoadDataComboboxCTDT_CTMH();
                        LoadDataComboboxSearchCTDT_CTMH();
                        LoadDataCTMHDatagirdview();
                        resetDataChuongTrinh();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.");
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
                MessageBox.Show("Hãy chọn khoa cần tìm !");
                cbMaKhoa_ChuongTrinh.SelectedIndex = -1;
                LoadDataChuongTrinhGridview();
            }
            else if (cbMaKhoa_ChuongTrinh.Text != "")
            {
                string value = cbMaKhoa_ChuongTrinh.SelectedValue.ToString().Trim();
                cbMaKhoa_ChuongTrinh.SelectedIndex = -1;
                LoadDataChuongTrinhGridviewSearch(value);
                MessageBox.Show("Đã tìm kiếm thành công !");
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
                MessageBox.Show("ID không được bỏ trống, hãy nhập giá trị ID");
                return false;
            }

            if (mamh.Length - 1 >= 5)
            {
                MessageBox.Show("Chiều dài ID không được quá 5 ký tự, hãy nhập lại giá trị ID");
                return false;
            }

            if (string.IsNullOrEmpty(tenmh))
            {
                MessageBox.Show("Tên môn học không được bỏ trống, hãy nhập giá trị tên môn học");
                return false;
            }

            if (tenmh.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên môn học không được quá 50 ký tự, hãy nhập lại giá trị tên môn học");
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa phụ trách cho môn học mà bạn cần thêm !");
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
                        LoadDataComboboxMH_CTMH();
                        resetDataMonHoc();
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
                MessageBox.Show("Hãy chọn môn học mà bạn muốn xóa");
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
                            MessageBox.Show("Không thể xóa môn học này");
                            resetDataMonHoc();
                        }
                        else
                        {
                            if (monhocBLL.DeleteMonHoc(mamh))
                            {
                                MessageBox.Show("Xóa thông tin môn học thành công !");
                                LoadDataMonHocGridview();
                                LoadDataComboboxMH_CTMH();
                                resetDataMonHoc();
                            }
                        }

                    }
                } else
                {
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa");
                }
            }

        }

        public bool checkDataEditMonHoc(string mamh, string ten, string makhoa)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn môn học mà bạn muốn chỉnh sửa !");
                return false;
            }

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên môn học không được bỏ trống, hãy nhập giá trị tên môn học");
                return false;
            }

            if (ten.Length - 1 >= 50)
            {
                MessageBox.Show("Chiều dài tên môn học không được quá 50 ký tự, hãy nhập lại giá trị tên môn học");
                return false;
            }

            if (makhoa == "")
            {
                MessageBox.Show("Hãy chọn khoa phụ trách cho môn học này !");
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
                        MessageBox.Show("Lưu thay đổi thành công !");
                        LoadDataMonHocGridview();
                        LoadDataComboboxMH_CTMH();
                        LoadDataCTMHDatagirdview();
                        resetDataMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.");
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
                MessageBox.Show("Không có chương trình đào tạo nào thuộc khoa này");
            }
        }

        private void searchBoxMonHoc_Click(object sender, EventArgs e)
        {
            if (cbMaKhoa_MonHoc.Text == "")
            {
                MessageBox.Show("Hãy chọn khoa cần tìm !");
                cbMaKhoa_MonHoc.SelectedIndex = -1;
                LoadDataMonHocGridview();
            }
            else if (cbMaKhoa_MonHoc.Text != "")
            {
                string value = cbMaKhoa_MonHoc.SelectedValue.ToString().Trim();
                cbMaKhoa_MonHoc.SelectedIndex = -1;
                LoadDataMonHocGridviewSearch(value);
                MessageBox.Show("Đã tìm kiếm thành công !");
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
            //cbMH_CTMH.BackColor = Color.White;
            //cbCTDT_CTMH.BackColor = Color.White;

            btnEditMode_MonHoc.ForeColor = Color.Black;
            resetDataCTMH();
        }

        public void turnONEditModeCTMH()
        {
            btnEditMode_ChuongTrinhMonHoc.Text = "ON";
            btnAdd_CTMH.Visible = false;
            btnDelete_CTMH.Visible = true;
            btnSave_CTMH.Visible = true;

            cbCTDT_CTMH.Enabled = false;
            cbMH_CTMH.BackColor = Color.LightGray;
            cbMH_CTMH.Enabled = false;
            cbMH_CTMH.BackColor = Color.LightGray;


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
        }

        public bool checkDataAddCTMH(string mactdt, string mamh)
        {
            if (string.IsNullOrEmpty(mactdt)) {
                MessageBox.Show("Hãy chọn giá trị chương trình đào tạo !");
                return false; 
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn giá trị môn học mà bạn muốn đăng ký cho chương trình đào tạo trên !");
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
                    MessageBox.Show("Chương trình học môn này đã được đăng ký, hãy thử đăng ký lại !");
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
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn xóa !");
                return false;
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn xóa !");
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
                            MessageBox.Show("Không thể xóa chương trình học môn này, vì đã được phân công cho giáo viên đảm nhiệm !");
                            resetDataCTMH();
                        }
                        else
                        {
                            if (ctmhBLL.DeleteCTMH(mactdt, mamh))
                            {
                                MessageBox.Show("Xóa thông tin chương trình môn học thành công !");
                                LoadDataCTMHDatagirdview();
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
                    MessageBox.Show("Thông tin đã có sự thay đổi, người dùng hãy thực hiện thao tác lưu trước khi xóa");
                }
            }
        }

        public bool checkDataEditCTMH(string mactdt, string mamh)
        {
            if (string.IsNullOrEmpty(mactdt))
            {
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn chỉnh sửa !");
                return false;
            }

            if (string.IsNullOrEmpty(mamh))
            {
                MessageBox.Show("Hãy chọn chương trình học môn mà bạn muốn chỉnh sửa !");
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
                        MessageBox.Show("Lưu thay đổi thành công !");
                        LoadDataCTMHDatagirdview();
                        resetDataCTMH();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thay đổi không thành công ! Hãy thử lại.");
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
    }

    

}
