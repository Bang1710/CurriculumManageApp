﻿namespace MainForm
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Khoa                                       ");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Giáo viên                               ");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Chương trình học môn ");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Phụ trách môn học       ");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Môn học  ▼                          ", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Chương trình đào tạo   ▼    ", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Chi tiết khóa học               ");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Khóa học   ▼                             ", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backPage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbdatetime = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TreeMenu = new System.Windows.Forms.TreeView();
            this.tabFunction = new System.Windows.Forms.TabControl();
            this.tabKhoa = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListKhoa = new System.Windows.Forms.DataGridView();
            this.ID_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbMaKhoa_Khoa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete_Khoa = new System.Windows.Forms.Button();
            this.btnAdd_Khoa = new System.Windows.Forms.Button();
            this.txtTenKhoa_Khoa = new System.Windows.Forms.TextBox();
            this.btnSave_Khoa = new System.Windows.Forms.Button();
            this.txtID_Khoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditMode_Khoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabGiaoVien = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ListGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGiaoVien_GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen_GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa_GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.searchBoxGiaoVien = new System.Windows.Forms.PictureBox();
            this.cbMaKhoa_GiaoVien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbKhoa_GiaoVien = new System.Windows.Forms.ComboBox();
            this.btnDelete_GiaoVien = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSave_GiaoVien = new System.Windows.Forms.Button();
            this.btnAdd_GiaoVien = new System.Windows.Forms.Button();
            this.txtHoTen_GiaoVien = new System.Windows.Forms.TextBox();
            this.txtID_GiaoVien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEditMode_GiaoVien = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabCTĐT = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ListChuongTrinh = new System.Windows.Forms.DataGridView();
            this.MaChuongTrinh_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuongTrinh_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBacHoc_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamDoc_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.searchBoxChuongTrinh = new System.Windows.Forms.PictureBox();
            this.cbMaKhoa_ChuongTrinh = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtTenChuongTrinh_ChuongTrinh = new System.Windows.Forms.TextBox();
            this.btnDelete_ChuongTrinh = new System.Windows.Forms.Button();
            this.cbGiaoVien_ChuongTrinh = new System.Windows.Forms.ComboBox();
            this.btnSave_ChuongTrinh = new System.Windows.Forms.Button();
            this.cbKhoa_ChuongTrinh = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnAdd_ChuongTrinh = new System.Windows.Forms.Button();
            this.txtBacHoc_ChuongTrinh = new System.Windows.Forms.TextBox();
            this.txtID_ChuongTrinh = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEditMode_ChuongTrinh = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tabMH = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ListMonHoc = new System.Windows.Forms.DataGridView();
            this.MaMonHoc_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.searchBoxMonHoc = new System.Windows.Forms.PictureBox();
            this.cbMaKhoa_MonHoc = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numSoTinChi_MonHoc = new System.Windows.Forms.NumericUpDown();
            this.btnDelete_MonHoc = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.cbKhoa_MonHoc = new System.Windows.Forms.ComboBox();
            this.btnSave_MonHoc = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.btnAdd_MonHoc = new System.Windows.Forms.Button();
            this.txtTenMonHoc_MonHoc = new System.Windows.Forms.TextBox();
            this.txtID_MonHoc = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.btnEditMode_MonHoc = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.tabCTMH = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.ListCTMH = new System.Windows.Forms.DataGridView();
            this.TenChuongTrinh_CTMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc_CTMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy_CTMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.seachBoxCTMH = new System.Windows.Forms.PictureBox();
            this.CbSearchCTDT_CTMH = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.numHocKy_CTMH = new System.Windows.Forms.NumericUpDown();
            this.btnDelete_CTMH = new System.Windows.Forms.Button();
            this.cbMH_CTMH = new System.Windows.Forms.ComboBox();
            this.cbCTDT_CTMH = new System.Windows.Forms.ComboBox();
            this.btnSave_CTMH = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.btnAdd_CTMH = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.btnEditMode_ChuongTrinhMonHoc = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.tabPTMH = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.ListPTMH = new System.Windows.Forms.DataGridView();
            this.TenMonHoc_PTMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuongTrinh_PTMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen_PTMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoLaDamNhiemChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.searchBoxPTMH = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.cbGiaoVien_Search = new System.Windows.Forms.ComboBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.ckDamNhiemChinh = new System.Windows.Forms.CheckBox();
            this.cbGV_PTMH = new System.Windows.Forms.ComboBox();
            this.btnDelete_PTMH = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.btnSave_PTMH = new System.Windows.Forms.Button();
            this.cbMH_PTMH = new System.Windows.Forms.ComboBox();
            this.cbCTDT_PTMH = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.btnAdd_PTMH = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.btnEditMode_PTMH = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.tabKH = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.ListKhoaHoc = new System.Windows.Forms.DataGridView();
            this.MaKhoaHoc_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaHoc_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuongTrinh_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamBatDaU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.SearchBox_KhoaHoc = new System.Windows.Forms.PictureBox();
            this.cbCTDTSearch_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.numNamKetThuc = new System.Windows.Forms.NumericUpDown();
            this.btnDelete_KhoaHoc = new System.Windows.Forms.Button();
            this.numNamBatDau = new System.Windows.Forms.NumericUpDown();
            this.label70 = new System.Windows.Forms.Label();
            this.btnSave_KhoaHoc = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.cbCTDT_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.btnAdd_KhoaHoc = new System.Windows.Forms.Button();
            this.txtTenKhoaHoc_KhoaHoc = new System.Windows.Forms.TextBox();
            this.txtID_KhoaHoc = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.btnEditMode_KhoaHoc = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.tabCTKH = new System.Windows.Forms.TabPage();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.ListCTKH = new System.Windows.Forms.DataGridView();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.searchBox_CTKH = new System.Windows.Forms.PictureBox();
            this.btnDelete_CTKH = new System.Windows.Forms.Button();
            this.cbKhoaHoc_Search_CTKH = new System.Windows.Forms.ComboBox();
            this.btnSave_CTKH = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label59 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            this.cbMH_CTKH = new System.Windows.Forms.ComboBox();
            this.cbGV_CTKH = new System.Windows.Forms.ComboBox();
            this.cbKhoaHoc_CTKH = new System.Windows.Forms.ComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.btnAdd_CTKH = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label64 = new System.Windows.Forms.Label();
            this.btnEditMode_ChiTietKhoaHoc = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.label74 = new System.Windows.Forms.Label();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nguoigui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaygui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaHoc_CTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc_CTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen_CTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong_CTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThu_CTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabFunction.SuspendLayout();
            this.tabKhoa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListKhoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabGiaoVien.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGiaoVien)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxGiaoVien)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabCTĐT.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListChuongTrinh)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxChuongTrinh)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tabMH.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListMonHoc)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxMonHoc)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi_MonHoc)).BeginInit();
            this.panel17.SuspendLayout();
            this.tabCTMH.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCTMH)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seachBoxCTMH)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy_CTMH)).BeginInit();
            this.panel20.SuspendLayout();
            this.tabPTMH.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListPTMH)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxPTMH)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.groupBox18.SuspendLayout();
            this.panel23.SuspendLayout();
            this.tabKH.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListKhoaHoc)).BeginInit();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox_KhoaHoc)).BeginInit();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamBatDau)).BeginInit();
            this.panel26.SuspendLayout();
            this.tabCTKH.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCTKH)).BeginInit();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox_CTKH)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.backPage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 43);
            this.panel1.TabIndex = 0;
            // 
            // backPage
            // 
            this.backPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPage.Image = global::MainForm.Properties.Resources.OIP__2_;
            this.backPage.Location = new System.Drawing.Point(-1, 2);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(42, 37);
            this.backPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPage.TabIndex = 1;
            this.backPage.TabStop = false;
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbdatetime);
            this.panel2.Controls.Add(this.lbDisplayName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 124);
            this.panel2.TabIndex = 1;
            // 
            // lbdatetime
            // 
            this.lbdatetime.AutoSize = true;
            this.lbdatetime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatetime.Location = new System.Drawing.Point(86, 62);
            this.lbdatetime.Name = "lbdatetime";
            this.lbdatetime.Size = new System.Drawing.Size(108, 24);
            this.lbdatetime.TabIndex = 2;
            this.lbdatetime.Text = "23/03/2023";
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayName.Location = new System.Drawing.Point(86, 28);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(169, 24);
            this.lbDisplayName.TabIndex = 1;
            this.lbDisplayName.Text = "Nguyễn Lê Duy Đạt";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MainForm.Properties.Resources.R__6_;
            this.pictureBox2.Location = new System.Drawing.Point(11, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TreeMenu);
            this.panel3.Location = new System.Drawing.Point(0, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 814);
            this.panel3.TabIndex = 2;
            // 
            // TreeMenu
            // 
            this.TreeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.TreeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.TreeMenu.FullRowSelect = true;
            this.TreeMenu.Indent = 20;
            this.TreeMenu.ItemHeight = 50;
            this.TreeMenu.LineColor = System.Drawing.Color.White;
            this.TreeMenu.Location = new System.Drawing.Point(0, 0);
            this.TreeMenu.Name = "TreeMenu";
            treeNode9.Name = "Khoa";
            treeNode9.Text = "Khoa                                       ";
            treeNode10.Name = "Giáo viên";
            treeNode10.Text = "Giáo viên                               ";
            treeNode11.Name = "Chương trình học môn ";
            treeNode11.Text = "Chương trình học môn ";
            treeNode12.Name = "Phụ trách môn học";
            treeNode12.Text = "Phụ trách môn học       ";
            treeNode13.Name = "Môn học";
            treeNode13.Text = "Môn học  ▼                          ";
            treeNode14.Name = "Chương trình đào tạo";
            treeNode14.Text = "Chương trình đào tạo   ▼    ";
            treeNode15.Name = "Chi tiết khóa học";
            treeNode15.Text = "Chi tiết khóa học               ";
            treeNode16.Name = "Khóa học";
            treeNode16.Text = "Khóa học   ▼                             ";
            this.TreeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode14,
            treeNode16});
            this.TreeMenu.PathSeparator = "";
            this.TreeMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TreeMenu.ShowLines = false;
            this.TreeMenu.ShowPlusMinus = false;
            this.TreeMenu.ShowRootLines = false;
            this.TreeMenu.Size = new System.Drawing.Size(271, 812);
            this.TreeMenu.TabIndex = 0;
            this.TreeMenu.TabStop = false;
            this.TreeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMenu_AfterSelect);
            // 
            // tabFunction
            // 
            this.tabFunction.Controls.Add(this.tabKhoa);
            this.tabFunction.Controls.Add(this.tabGiaoVien);
            this.tabFunction.Controls.Add(this.tabCTĐT);
            this.tabFunction.Controls.Add(this.tabMH);
            this.tabFunction.Controls.Add(this.tabCTMH);
            this.tabFunction.Controls.Add(this.tabPTMH);
            this.tabFunction.Controls.Add(this.tabKH);
            this.tabFunction.Controls.Add(this.tabCTKH);
            this.tabFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabFunction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabFunction.ItemSize = new System.Drawing.Size(72, 50);
            this.tabFunction.Location = new System.Drawing.Point(274, 165);
            this.tabFunction.Name = "tabFunction";
            this.tabFunction.SelectedIndex = 0;
            this.tabFunction.Size = new System.Drawing.Size(1074, 867);
            this.tabFunction.TabIndex = 4;
            // 
            // tabKhoa
            // 
            this.tabKhoa.BackColor = System.Drawing.Color.White;
            this.tabKhoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabKhoa.Controls.Add(this.groupBox3);
            this.tabKhoa.Controls.Add(this.groupBox2);
            this.tabKhoa.Controls.Add(this.panel8);
            this.tabKhoa.Controls.Add(this.panel7);
            this.tabKhoa.Controls.Add(this.groupBox1);
            this.tabKhoa.Controls.Add(this.panel6);
            this.tabKhoa.Location = new System.Drawing.Point(4, 54);
            this.tabKhoa.Name = "tabKhoa";
            this.tabKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoa.Size = new System.Drawing.Size(1066, 809);
            this.tabKhoa.TabIndex = 0;
            this.tabKhoa.Text = "Khoa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListKhoa);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1060, 433);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH KHOA";
            // 
            // ListKhoa
            // 
            this.ListKhoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListKhoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListKhoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListKhoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.ListKhoa.ColumnHeadersHeight = 50;
            this.ListKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Khoa,
            this.TenKhoa_Khoa});
            this.ListKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListKhoa.EnableHeadersVisualStyles = false;
            this.ListKhoa.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListKhoa.Location = new System.Drawing.Point(3, 32);
            this.ListKhoa.MultiSelect = false;
            this.ListKhoa.Name = "ListKhoa";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.ListKhoa.RowHeadersVisible = false;
            this.ListKhoa.RowHeadersWidth = 51;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.ListKhoa.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.ListKhoa.RowTemplate.Height = 50;
            this.ListKhoa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListKhoa.Size = new System.Drawing.Size(1054, 398);
            this.ListKhoa.TabIndex = 6;
            this.ListKhoa.TabStop = false;
            this.ListKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListKhoa_CellClick);
            // 
            // ID_Khoa
            // 
            this.ID_Khoa.DataPropertyName = "MaKhoa";
            this.ID_Khoa.HeaderText = "ID";
            this.ID_Khoa.MinimumWidth = 6;
            this.ID_Khoa.Name = "ID_Khoa";
            this.ID_Khoa.Width = 300;
            // 
            // TenKhoa_Khoa
            // 
            this.TenKhoa_Khoa.DataPropertyName = "TenKhoa";
            this.TenKhoa_Khoa.HeaderText = "Tên Khoa";
            this.TenKhoa_Khoa.MinimumWidth = 6;
            this.TenKhoa_Khoa.Name = "TenKhoa_Khoa";
            this.TenKhoa_Khoa.Width = 750;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.cbMaKhoa_Khoa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.pictureBox4.Location = new System.Drawing.Point(400, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // cbMaKhoa_Khoa
            // 
            this.cbMaKhoa_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhoa_Khoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhoa_Khoa.FormattingEnabled = true;
            this.cbMaKhoa_Khoa.Location = new System.Drawing.Point(179, 23);
            this.cbMaKhoa_Khoa.Name = "cbMaKhoa_Khoa";
            this.cbMaKhoa_Khoa.Size = new System.Drawing.Size(200, 36);
            this.cbMaKhoa_Khoa.TabIndex = 5;
            this.cbMaKhoa_Khoa.TabStop = false;
            this.cbMaKhoa_Khoa.SelectedIndexChanged += new System.EventHandler(this.cbMaKhoa_Khoa_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label10.Location = new System.Drawing.Point(28, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mã Khoa";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel8.Controls.Add(this.label8);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(-1, 236);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1063, 47);
            this.panel8.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tìm kiếm";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.label5);
            this.panel7.ForeColor = System.Drawing.SystemColors.Window;
            this.panel7.Location = new System.Drawing.Point(1, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1061, 50);
            this.panel7.TabIndex = 8;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox5.Location = new System.Drawing.Point(125, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thông tin";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox1.Controls.Add(this.btnDelete_Khoa);
            this.groupBox1.Controls.Add(this.btnAdd_Khoa);
            this.groupBox1.Controls.Add(this.txtTenKhoa_Khoa);
            this.groupBox1.Controls.Add(this.btnSave_Khoa);
            this.groupBox1.Controls.Add(this.txtID_Khoa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete_Khoa
            // 
            this.btnDelete_Khoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_Khoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_Khoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_Khoa.Location = new System.Drawing.Point(842, 84);
            this.btnDelete_Khoa.Name = "btnDelete_Khoa";
            this.btnDelete_Khoa.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_Khoa.TabIndex = 3;
            this.btnDelete_Khoa.Text = "Xóa";
            this.btnDelete_Khoa.UseVisualStyleBackColor = false;
            this.btnDelete_Khoa.Click += new System.EventHandler(this.btnDelete_Khoa_Click);
            // 
            // btnAdd_Khoa
            // 
            this.btnAdd_Khoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_Khoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_Khoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_Khoa.Location = new System.Drawing.Point(842, 84);
            this.btnAdd_Khoa.Name = "btnAdd_Khoa";
            this.btnAdd_Khoa.Size = new System.Drawing.Size(199, 36);
            this.btnAdd_Khoa.TabIndex = 2;
            this.btnAdd_Khoa.Text = "Thêm Khoa";
            this.btnAdd_Khoa.UseVisualStyleBackColor = false;
            this.btnAdd_Khoa.Click += new System.EventHandler(this.btnAdd_Khoa_Click);
            // 
            // txtTenKhoa_Khoa
            // 
            this.txtTenKhoa_Khoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa_Khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtTenKhoa_Khoa.Location = new System.Drawing.Point(662, 28);
            this.txtTenKhoa_Khoa.Name = "txtTenKhoa_Khoa";
            this.txtTenKhoa_Khoa.Size = new System.Drawing.Size(379, 36);
            this.txtTenKhoa_Khoa.TabIndex = 1;
            // 
            // btnSave_Khoa
            // 
            this.btnSave_Khoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_Khoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_Khoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_Khoa.Location = new System.Drawing.Point(962, 84);
            this.btnSave_Khoa.Name = "btnSave_Khoa";
            this.btnSave_Khoa.Size = new System.Drawing.Size(79, 36);
            this.btnSave_Khoa.TabIndex = 4;
            this.btnSave_Khoa.Text = "Lưu";
            this.btnSave_Khoa.UseVisualStyleBackColor = false;
            this.btnSave_Khoa.Click += new System.EventHandler(this.btnSave_Khoa_Click);
            // 
            // txtID_Khoa
            // 
            this.txtID_Khoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtID_Khoa.Location = new System.Drawing.Point(81, 28);
            this.txtID_Khoa.Name = "txtID_Khoa";
            this.txtID_Khoa.Size = new System.Drawing.Size(298, 36);
            this.txtID_Khoa.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label7.Location = new System.Drawing.Point(544, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(28, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.btnEditMode_Khoa);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1060, 47);
            this.panel6.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "KHOA";
            // 
            // btnEditMode_Khoa
            // 
            this.btnEditMode_Khoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_Khoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_Khoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_Khoa.ForeColor = System.Drawing.Color.Black;
            this.btnEditMode_Khoa.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_Khoa.Name = "btnEditMode_Khoa";
            this.btnEditMode_Khoa.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_Khoa.TabIndex = 5;
            this.btnEditMode_Khoa.Text = "OFF";
            this.btnEditMode_Khoa.UseVisualStyleBackColor = false;
            this.btnEditMode_Khoa.Click += new System.EventHandler(this.btnEditMode_Khoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(848, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "EDIT MODE";
            // 
            // tabGiaoVien
            // 
            this.tabGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabGiaoVien.Controls.Add(this.groupBox4);
            this.tabGiaoVien.Controls.Add(this.groupBox5);
            this.tabGiaoVien.Controls.Add(this.panel9);
            this.tabGiaoVien.Controls.Add(this.panel10);
            this.tabGiaoVien.Controls.Add(this.groupBox6);
            this.tabGiaoVien.Controls.Add(this.panel11);
            this.tabGiaoVien.Location = new System.Drawing.Point(4, 54);
            this.tabGiaoVien.Name = "tabGiaoVien";
            this.tabGiaoVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabGiaoVien.Size = new System.Drawing.Size(1066, 809);
            this.tabGiaoVien.TabIndex = 1;
            this.tabGiaoVien.Text = "Giáo viên";
            this.tabGiaoVien.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ListGiaoVien);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1060, 345);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // ListGiaoVien
            // 
            this.ListGiaoVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListGiaoVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListGiaoVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.ListGiaoVien.ColumnHeadersHeight = 50;
            this.ListGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien_GiaoVien,
            this.HoTen_GiaoVien,
            this.TenKhoa_GiaoVien});
            this.ListGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGiaoVien.EnableHeadersVisualStyles = false;
            this.ListGiaoVien.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListGiaoVien.Location = new System.Drawing.Point(3, 32);
            this.ListGiaoVien.MultiSelect = false;
            this.ListGiaoVien.Name = "ListGiaoVien";
            this.ListGiaoVien.RowHeadersVisible = false;
            this.ListGiaoVien.RowHeadersWidth = 51;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.ListGiaoVien.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.ListGiaoVien.RowTemplate.Height = 50;
            this.ListGiaoVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListGiaoVien.Size = new System.Drawing.Size(1054, 310);
            this.ListGiaoVien.TabIndex = 0;
            this.ListGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListGiaoVien_CellClick);
            // 
            // MaGiaoVien_GiaoVien
            // 
            this.MaGiaoVien_GiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien_GiaoVien.HeaderText = "ID";
            this.MaGiaoVien_GiaoVien.MinimumWidth = 6;
            this.MaGiaoVien_GiaoVien.Name = "MaGiaoVien_GiaoVien";
            this.MaGiaoVien_GiaoVien.Width = 150;
            // 
            // HoTen_GiaoVien
            // 
            this.HoTen_GiaoVien.DataPropertyName = "HoTen";
            this.HoTen_GiaoVien.HeaderText = "Họ và tên";
            this.HoTen_GiaoVien.MinimumWidth = 6;
            this.HoTen_GiaoVien.Name = "HoTen_GiaoVien";
            this.HoTen_GiaoVien.Width = 450;
            // 
            // TenKhoa_GiaoVien
            // 
            this.TenKhoa_GiaoVien.DataPropertyName = "TenKhoa";
            this.TenKhoa_GiaoVien.HeaderText = "Khoa trực thuộc";
            this.TenKhoa_GiaoVien.MinimumWidth = 6;
            this.TenKhoa_GiaoVien.Name = "TenKhoa_GiaoVien";
            this.TenKhoa_GiaoVien.Width = 450;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox5.Controls.Add(this.searchBoxGiaoVien);
            this.groupBox5.Controls.Add(this.cbMaKhoa_GiaoVien);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1062, 66);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // searchBoxGiaoVien
            // 
            this.searchBoxGiaoVien.BackColor = System.Drawing.Color.White;
            this.searchBoxGiaoVien.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.searchBoxGiaoVien.Location = new System.Drawing.Point(619, 18);
            this.searchBoxGiaoVien.Name = "searchBoxGiaoVien";
            this.searchBoxGiaoVien.Size = new System.Drawing.Size(38, 36);
            this.searchBoxGiaoVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBoxGiaoVien.TabIndex = 11;
            this.searchBoxGiaoVien.TabStop = false;
            this.searchBoxGiaoVien.Click += new System.EventHandler(this.searchBoxGiaoVien_Click);
            // 
            // cbMaKhoa_GiaoVien
            // 
            this.cbMaKhoa_GiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhoa_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhoa_GiaoVien.FormattingEnabled = true;
            this.cbMaKhoa_GiaoVien.Location = new System.Drawing.Point(206, 18);
            this.cbMaKhoa_GiaoVien.Name = "cbMaKhoa_GiaoVien";
            this.cbMaKhoa_GiaoVien.Size = new System.Drawing.Size(391, 36);
            this.cbMaKhoa_GiaoVien.TabIndex = 6;
            this.cbMaKhoa_GiaoVien.SelectedIndexChanged += new System.EventHandler(this.cbMaKhoa_GiaoVien_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label9.Location = new System.Drawing.Point(26, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Khoa trực thuộc";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel9.Controls.Add(this.label11);
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, 321);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1060, 47);
            this.panel9.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 31);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tìm kiếm";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel10.Controls.Add(this.pictureBox7);
            this.panel10.Controls.Add(this.label12);
            this.panel10.ForeColor = System.Drawing.SystemColors.Window;
            this.panel10.Location = new System.Drawing.Point(0, 55);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1063, 50);
            this.panel10.TabIndex = 14;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox7.Location = new System.Drawing.Point(125, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 31);
            this.label12.TabIndex = 6;
            this.label12.Text = "Thông tin";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox6.Controls.Add(this.cbKhoa_GiaoVien);
            this.groupBox6.Controls.Add(this.btnDelete_GiaoVien);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.btnSave_GiaoVien);
            this.groupBox6.Controls.Add(this.btnAdd_GiaoVien);
            this.groupBox6.Controls.Add(this.txtHoTen_GiaoVien);
            this.groupBox6.Controls.Add(this.txtID_GiaoVien);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1, 97);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1062, 227);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            // 
            // cbKhoa_GiaoVien
            // 
            this.cbKhoa_GiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa_GiaoVien.FormattingEnabled = true;
            this.cbKhoa_GiaoVien.Location = new System.Drawing.Point(662, 29);
            this.cbKhoa_GiaoVien.Name = "cbKhoa_GiaoVien";
            this.cbKhoa_GiaoVien.Size = new System.Drawing.Size(378, 36);
            this.cbKhoa_GiaoVien.TabIndex = 2;
            // 
            // btnDelete_GiaoVien
            // 
            this.btnDelete_GiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_GiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_GiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_GiaoVien.Location = new System.Drawing.Point(841, 162);
            this.btnDelete_GiaoVien.Name = "btnDelete_GiaoVien";
            this.btnDelete_GiaoVien.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_GiaoVien.TabIndex = 4;
            this.btnDelete_GiaoVien.Text = "Xóa";
            this.btnDelete_GiaoVien.UseVisualStyleBackColor = false;
            this.btnDelete_GiaoVien.Click += new System.EventHandler(this.btnDelete_GiaoVien_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label17.Location = new System.Drawing.Point(482, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 29);
            this.label17.TabIndex = 7;
            this.label17.Text = "Khoa trực thuộc";
            // 
            // btnSave_GiaoVien
            // 
            this.btnSave_GiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_GiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_GiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_GiaoVien.Location = new System.Drawing.Point(961, 162);
            this.btnSave_GiaoVien.Name = "btnSave_GiaoVien";
            this.btnSave_GiaoVien.Size = new System.Drawing.Size(79, 36);
            this.btnSave_GiaoVien.TabIndex = 5;
            this.btnSave_GiaoVien.Text = "Lưu";
            this.btnSave_GiaoVien.UseVisualStyleBackColor = false;
            this.btnSave_GiaoVien.Click += new System.EventHandler(this.btnSave_GiaoVien_Click);
            // 
            // btnAdd_GiaoVien
            // 
            this.btnAdd_GiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_GiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_GiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_GiaoVien.Location = new System.Drawing.Point(841, 162);
            this.btnAdd_GiaoVien.Name = "btnAdd_GiaoVien";
            this.btnAdd_GiaoVien.Size = new System.Drawing.Size(199, 36);
            this.btnAdd_GiaoVien.TabIndex = 3;
            this.btnAdd_GiaoVien.Text = "Thêm Giáo viên";
            this.btnAdd_GiaoVien.UseVisualStyleBackColor = false;
            this.btnAdd_GiaoVien.Click += new System.EventHandler(this.btnAdd_GiaoVien_Click);
            // 
            // txtHoTen_GiaoVien
            // 
            this.txtHoTen_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen_GiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtHoTen_GiaoVien.Location = new System.Drawing.Point(143, 112);
            this.txtHoTen_GiaoVien.Name = "txtHoTen_GiaoVien";
            this.txtHoTen_GiaoVien.Size = new System.Drawing.Size(298, 36);
            this.txtHoTen_GiaoVien.TabIndex = 1;
            // 
            // txtID_GiaoVien
            // 
            this.txtID_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_GiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtID_GiaoVien.Location = new System.Drawing.Point(143, 28);
            this.txtID_GiaoVien.Name = "txtID_GiaoVien";
            this.txtID_GiaoVien.Size = new System.Drawing.Size(298, 36);
            this.txtID_GiaoVien.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label13.Location = new System.Drawing.Point(25, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "Họ và tên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label14.Location = new System.Drawing.Point(91, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 29);
            this.label14.TabIndex = 3;
            this.label14.Text = "ID";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.btnEditMode_GiaoVien);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Location = new System.Drawing.Point(3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1060, 47);
            this.panel11.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 33);
            this.label15.TabIndex = 4;
            this.label15.Text = "GIÁO VIÊN";
            // 
            // btnEditMode_GiaoVien
            // 
            this.btnEditMode_GiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_GiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_GiaoVien.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_GiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnEditMode_GiaoVien.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_GiaoVien.Name = "btnEditMode_GiaoVien";
            this.btnEditMode_GiaoVien.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_GiaoVien.TabIndex = 5;
            this.btnEditMode_GiaoVien.Text = "OFF";
            this.btnEditMode_GiaoVien.UseVisualStyleBackColor = false;
            this.btnEditMode_GiaoVien.Click += new System.EventHandler(this.btnEditMode_GiaoVien_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(848, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 29);
            this.label16.TabIndex = 4;
            this.label16.Text = "EDIT MODE";
            // 
            // tabCTĐT
            // 
            this.tabCTĐT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCTĐT.Controls.Add(this.groupBox7);
            this.tabCTĐT.Controls.Add(this.groupBox8);
            this.tabCTĐT.Controls.Add(this.panel12);
            this.tabCTĐT.Controls.Add(this.panel13);
            this.tabCTĐT.Controls.Add(this.groupBox9);
            this.tabCTĐT.Controls.Add(this.panel14);
            this.tabCTĐT.Location = new System.Drawing.Point(4, 54);
            this.tabCTĐT.Name = "tabCTĐT";
            this.tabCTĐT.Padding = new System.Windows.Forms.Padding(3);
            this.tabCTĐT.Size = new System.Drawing.Size(1066, 809);
            this.tabCTĐT.TabIndex = 2;
            this.tabCTĐT.Text = "Chương trình đào tạo";
            this.tabCTĐT.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ListChuongTrinh);
            this.groupBox7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(4, 453);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1060, 350);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DANH SÁCH CHƯƠNG TRÌNH ĐÀO TẠO";
            // 
            // ListChuongTrinh
            // 
            this.ListChuongTrinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListChuongTrinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListChuongTrinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListChuongTrinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListChuongTrinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.ListChuongTrinh.ColumnHeadersHeight = 50;
            this.ListChuongTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuongTrinh_CT,
            this.TenChuongTrinh_CT,
            this.MaBacHoc_CT,
            this.TenKhoa_CT,
            this.GiamDoc_CT});
            this.ListChuongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListChuongTrinh.EnableHeadersVisualStyles = false;
            this.ListChuongTrinh.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListChuongTrinh.Location = new System.Drawing.Point(3, 32);
            this.ListChuongTrinh.MultiSelect = false;
            this.ListChuongTrinh.Name = "ListChuongTrinh";
            this.ListChuongTrinh.RowHeadersVisible = false;
            this.ListChuongTrinh.RowHeadersWidth = 51;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.ListChuongTrinh.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.ListChuongTrinh.RowTemplate.Height = 50;
            this.ListChuongTrinh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListChuongTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListChuongTrinh.Size = new System.Drawing.Size(1054, 315);
            this.ListChuongTrinh.TabIndex = 9;
            this.ListChuongTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListChuongTrinh_CellClick);
            // 
            // MaChuongTrinh_CT
            // 
            this.MaChuongTrinh_CT.DataPropertyName = "MaChuongTrinh";
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaChuongTrinh_CT.DefaultCellStyle = dataGridViewCellStyle27;
            this.MaChuongTrinh_CT.HeaderText = "ID";
            this.MaChuongTrinh_CT.MinimumWidth = 6;
            this.MaChuongTrinh_CT.Name = "MaChuongTrinh_CT";
            this.MaChuongTrinh_CT.Width = 85;
            // 
            // TenChuongTrinh_CT
            // 
            this.TenChuongTrinh_CT.DataPropertyName = "TenChuongTrinh";
            this.TenChuongTrinh_CT.HeaderText = "Tên chương trình";
            this.TenChuongTrinh_CT.MinimumWidth = 6;
            this.TenChuongTrinh_CT.Name = "TenChuongTrinh_CT";
            this.TenChuongTrinh_CT.Width = 280;
            // 
            // MaBacHoc_CT
            // 
            this.MaBacHoc_CT.DataPropertyName = "MaBacHoc";
            this.MaBacHoc_CT.HeaderText = "Bậc học";
            this.MaBacHoc_CT.MinimumWidth = 6;
            this.MaBacHoc_CT.Name = "MaBacHoc_CT";
            this.MaBacHoc_CT.Width = 125;
            // 
            // TenKhoa_CT
            // 
            this.TenKhoa_CT.DataPropertyName = "TenKhoa";
            this.TenKhoa_CT.HeaderText = "Khoa phụ trách";
            this.TenKhoa_CT.MinimumWidth = 6;
            this.TenKhoa_CT.Name = "TenKhoa_CT";
            this.TenKhoa_CT.Width = 330;
            // 
            // GiamDoc_CT
            // 
            this.GiamDoc_CT.DataPropertyName = "HoTen";
            this.GiamDoc_CT.HeaderText = "Giám đốc CT";
            this.GiamDoc_CT.MinimumWidth = 6;
            this.GiamDoc_CT.Name = "GiamDoc_CT";
            this.GiamDoc_CT.Width = 300;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox8.Controls.Add(this.searchBoxChuongTrinh);
            this.groupBox8.Controls.Add(this.cbMaKhoa_ChuongTrinh);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(1, 361);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1062, 66);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            // 
            // searchBoxChuongTrinh
            // 
            this.searchBoxChuongTrinh.BackColor = System.Drawing.Color.White;
            this.searchBoxChuongTrinh.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.searchBoxChuongTrinh.Location = new System.Drawing.Point(630, 21);
            this.searchBoxChuongTrinh.Name = "searchBoxChuongTrinh";
            this.searchBoxChuongTrinh.Size = new System.Drawing.Size(37, 36);
            this.searchBoxChuongTrinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBoxChuongTrinh.TabIndex = 11;
            this.searchBoxChuongTrinh.TabStop = false;
            this.searchBoxChuongTrinh.Click += new System.EventHandler(this.searchBoxChuongTrinh_Click);
            // 
            // cbMaKhoa_ChuongTrinh
            // 
            this.cbMaKhoa_ChuongTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhoa_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhoa_ChuongTrinh.FormattingEnabled = true;
            this.cbMaKhoa_ChuongTrinh.Location = new System.Drawing.Point(219, 21);
            this.cbMaKhoa_ChuongTrinh.Name = "cbMaKhoa_ChuongTrinh";
            this.cbMaKhoa_ChuongTrinh.Size = new System.Drawing.Size(379, 36);
            this.cbMaKhoa_ChuongTrinh.TabIndex = 8;
            this.cbMaKhoa_ChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.cbMaKhoa_ChuongTrinh_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label19.Location = new System.Drawing.Point(28, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 29);
            this.label19.TabIndex = 3;
            this.label19.Text = "Khoa phụ trách";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel12.Controls.Add(this.label20);
            this.panel12.ForeColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(0, 318);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1063, 47);
            this.panel12.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(5, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 31);
            this.label20.TabIndex = 7;
            this.label20.Text = "Tìm kiếm";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel13.Controls.Add(this.pictureBox9);
            this.panel13.Controls.Add(this.label21);
            this.panel13.ForeColor = System.Drawing.SystemColors.Window;
            this.panel13.Location = new System.Drawing.Point(-1, 55);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1065, 50);
            this.panel13.TabIndex = 20;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox9.Location = new System.Drawing.Point(125, 9);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(29, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 31);
            this.label21.TabIndex = 6;
            this.label21.Text = "Thông tin";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox9.Controls.Add(this.txtTenChuongTrinh_ChuongTrinh);
            this.groupBox9.Controls.Add(this.btnDelete_ChuongTrinh);
            this.groupBox9.Controls.Add(this.cbGiaoVien_ChuongTrinh);
            this.groupBox9.Controls.Add(this.btnSave_ChuongTrinh);
            this.groupBox9.Controls.Add(this.cbKhoa_ChuongTrinh);
            this.groupBox9.Controls.Add(this.label67);
            this.groupBox9.Controls.Add(this.label66);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.btnAdd_ChuongTrinh);
            this.groupBox9.Controls.Add(this.txtBacHoc_ChuongTrinh);
            this.groupBox9.Controls.Add(this.txtID_ChuongTrinh);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(2, 97);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1062, 224);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            // 
            // txtTenChuongTrinh_ChuongTrinh
            // 
            this.txtTenChuongTrinh_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuongTrinh_ChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtTenChuongTrinh_ChuongTrinh.Location = new System.Drawing.Point(672, 27);
            this.txtTenChuongTrinh_ChuongTrinh.Name = "txtTenChuongTrinh_ChuongTrinh";
            this.txtTenChuongTrinh_ChuongTrinh.Size = new System.Drawing.Size(368, 36);
            this.txtTenChuongTrinh_ChuongTrinh.TabIndex = 2;
            // 
            // btnDelete_ChuongTrinh
            // 
            this.btnDelete_ChuongTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_ChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_ChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_ChuongTrinh.Location = new System.Drawing.Point(842, 151);
            this.btnDelete_ChuongTrinh.Name = "btnDelete_ChuongTrinh";
            this.btnDelete_ChuongTrinh.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_ChuongTrinh.TabIndex = 6;
            this.btnDelete_ChuongTrinh.Text = "Xóa";
            this.btnDelete_ChuongTrinh.UseVisualStyleBackColor = false;
            this.btnDelete_ChuongTrinh.Click += new System.EventHandler(this.btnDelete_ChuongTrinh_Click);
            // 
            // cbGiaoVien_ChuongTrinh
            // 
            this.cbGiaoVien_ChuongTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiaoVien_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGiaoVien_ChuongTrinh.FormattingEnabled = true;
            this.cbGiaoVien_ChuongTrinh.Location = new System.Drawing.Point(167, 155);
            this.cbGiaoVien_ChuongTrinh.Name = "cbGiaoVien_ChuongTrinh";
            this.cbGiaoVien_ChuongTrinh.Size = new System.Drawing.Size(272, 36);
            this.cbGiaoVien_ChuongTrinh.TabIndex = 4;
            // 
            // btnSave_ChuongTrinh
            // 
            this.btnSave_ChuongTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_ChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_ChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_ChuongTrinh.Location = new System.Drawing.Point(962, 151);
            this.btnSave_ChuongTrinh.Name = "btnSave_ChuongTrinh";
            this.btnSave_ChuongTrinh.Size = new System.Drawing.Size(79, 36);
            this.btnSave_ChuongTrinh.TabIndex = 7;
            this.btnSave_ChuongTrinh.Text = "Lưu";
            this.btnSave_ChuongTrinh.UseVisualStyleBackColor = false;
            this.btnSave_ChuongTrinh.Click += new System.EventHandler(this.btnSave_ChuongTrinh_Click);
            // 
            // cbKhoa_ChuongTrinh
            // 
            this.cbKhoa_ChuongTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa_ChuongTrinh.FormattingEnabled = true;
            this.cbKhoa_ChuongTrinh.Location = new System.Drawing.Point(672, 88);
            this.cbKhoa_ChuongTrinh.Name = "cbKhoa_ChuongTrinh";
            this.cbKhoa_ChuongTrinh.Size = new System.Drawing.Size(368, 36);
            this.cbKhoa_ChuongTrinh.TabIndex = 3;
            this.cbKhoa_ChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_ChuongTrinh_SelectedIndexChanged);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label67.Location = new System.Drawing.Point(65, 88);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(89, 29);
            this.label67.TabIndex = 11;
            this.label67.Text = "Bậc học";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label66.Location = new System.Drawing.Point(23, 158);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(138, 29);
            this.label66.TabIndex = 10;
            this.label66.Text = "Giám đốc CT";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label22.Location = new System.Drawing.Point(481, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(185, 29);
            this.label22.TabIndex = 7;
            this.label22.Text = "Tên chương trình";
            // 
            // btnAdd_ChuongTrinh
            // 
            this.btnAdd_ChuongTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_ChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_ChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_ChuongTrinh.Location = new System.Drawing.Point(695, 151);
            this.btnAdd_ChuongTrinh.Name = "btnAdd_ChuongTrinh";
            this.btnAdd_ChuongTrinh.Size = new System.Drawing.Size(345, 36);
            this.btnAdd_ChuongTrinh.TabIndex = 5;
            this.btnAdd_ChuongTrinh.Text = "Thêm chương trình đào tạo";
            this.btnAdd_ChuongTrinh.UseVisualStyleBackColor = false;
            this.btnAdd_ChuongTrinh.Click += new System.EventHandler(this.btnAdd_ChuongTrinh_Click);
            // 
            // txtBacHoc_ChuongTrinh
            // 
            this.txtBacHoc_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacHoc_ChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtBacHoc_ChuongTrinh.Location = new System.Drawing.Point(169, 91);
            this.txtBacHoc_ChuongTrinh.Name = "txtBacHoc_ChuongTrinh";
            this.txtBacHoc_ChuongTrinh.Size = new System.Drawing.Size(272, 36);
            this.txtBacHoc_ChuongTrinh.TabIndex = 1;
            // 
            // txtID_ChuongTrinh
            // 
            this.txtID_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_ChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtID_ChuongTrinh.Location = new System.Drawing.Point(169, 28);
            this.txtID_ChuongTrinh.Name = "txtID_ChuongTrinh";
            this.txtID_ChuongTrinh.Size = new System.Drawing.Size(272, 36);
            this.txtID_ChuongTrinh.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label23.Location = new System.Drawing.Point(501, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(164, 29);
            this.label23.TabIndex = 4;
            this.label23.Text = "Khoa phụ trách";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label24.Location = new System.Drawing.Point(120, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 29);
            this.label24.TabIndex = 3;
            this.label24.Text = "ID";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label18);
            this.panel14.Controls.Add(this.btnEditMode_ChuongTrinh);
            this.panel14.Controls.Add(this.label25);
            this.panel14.Location = new System.Drawing.Point(4, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1060, 47);
            this.panel14.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(-1, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(305, 33);
            this.label18.TabIndex = 4;
            this.label18.Text = "CHƯƠNG TRÌNH ĐÀO TẠO";
            // 
            // btnEditMode_ChuongTrinh
            // 
            this.btnEditMode_ChuongTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_ChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_ChuongTrinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_ChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnEditMode_ChuongTrinh.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_ChuongTrinh.Name = "btnEditMode_ChuongTrinh";
            this.btnEditMode_ChuongTrinh.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_ChuongTrinh.TabIndex = 5;
            this.btnEditMode_ChuongTrinh.Text = "OFF";
            this.btnEditMode_ChuongTrinh.UseVisualStyleBackColor = false;
            this.btnEditMode_ChuongTrinh.Click += new System.EventHandler(this.btnEditMode_ChuongTrinh_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(848, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(127, 29);
            this.label25.TabIndex = 4;
            this.label25.Text = "EDIT MODE";
            // 
            // tabMH
            // 
            this.tabMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabMH.Controls.Add(this.groupBox10);
            this.tabMH.Controls.Add(this.groupBox11);
            this.tabMH.Controls.Add(this.panel15);
            this.tabMH.Controls.Add(this.panel16);
            this.tabMH.Controls.Add(this.groupBox12);
            this.tabMH.Controls.Add(this.panel17);
            this.tabMH.Location = new System.Drawing.Point(4, 54);
            this.tabMH.Name = "tabMH";
            this.tabMH.Padding = new System.Windows.Forms.Padding(3);
            this.tabMH.Size = new System.Drawing.Size(1066, 809);
            this.tabMH.TabIndex = 3;
            this.tabMH.Text = "Môn học";
            this.tabMH.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.ListMonHoc);
            this.groupBox10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(0, 450);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1060, 362);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "DANH SÁCH MÔN HỌC";
            // 
            // ListMonHoc
            // 
            this.ListMonHoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListMonHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListMonHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.ListMonHoc.ColumnHeadersHeight = 50;
            this.ListMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonHoc_MH,
            this.TenMonHoc_MH,
            this.SoTinChi_MH,
            this.TenKhoa_MH});
            this.ListMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListMonHoc.EnableHeadersVisualStyles = false;
            this.ListMonHoc.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListMonHoc.Location = new System.Drawing.Point(3, 32);
            this.ListMonHoc.MultiSelect = false;
            this.ListMonHoc.Name = "ListMonHoc";
            this.ListMonHoc.RowHeadersVisible = false;
            this.ListMonHoc.RowHeadersWidth = 51;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            this.ListMonHoc.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.ListMonHoc.RowTemplate.Height = 50;
            this.ListMonHoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListMonHoc.Size = new System.Drawing.Size(1054, 327);
            this.ListMonHoc.TabIndex = 7;
            this.ListMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListMonHoc_CellClick);
            // 
            // MaMonHoc_MH
            // 
            this.MaMonHoc_MH.DataPropertyName = "MaMonHoc";
            this.MaMonHoc_MH.HeaderText = "ID";
            this.MaMonHoc_MH.MinimumWidth = 6;
            this.MaMonHoc_MH.Name = "MaMonHoc_MH";
            this.MaMonHoc_MH.Width = 125;
            // 
            // TenMonHoc_MH
            // 
            this.TenMonHoc_MH.DataPropertyName = "TenMonHoc";
            this.TenMonHoc_MH.HeaderText = "Tên môn học";
            this.TenMonHoc_MH.MinimumWidth = 6;
            this.TenMonHoc_MH.Name = "TenMonHoc_MH";
            this.TenMonHoc_MH.Width = 330;
            // 
            // SoTinChi_MH
            // 
            this.SoTinChi_MH.DataPropertyName = "SoTinChi";
            this.SoTinChi_MH.HeaderText = "Số tín chỉ";
            this.SoTinChi_MH.MinimumWidth = 6;
            this.SoTinChi_MH.Name = "SoTinChi_MH";
            this.SoTinChi_MH.Width = 135;
            // 
            // TenKhoa_MH
            // 
            this.TenKhoa_MH.DataPropertyName = "TenKhoa";
            this.TenKhoa_MH.HeaderText = "Khoa phụ trách";
            this.TenKhoa_MH.MinimumWidth = 6;
            this.TenKhoa_MH.Name = "TenKhoa_MH";
            this.TenKhoa_MH.Width = 460;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox11.Controls.Add(this.searchBoxMonHoc);
            this.groupBox11.Controls.Add(this.cbMaKhoa_MonHoc);
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(1, 361);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1062, 66);
            this.groupBox11.TabIndex = 19;
            this.groupBox11.TabStop = false;
            // 
            // searchBoxMonHoc
            // 
            this.searchBoxMonHoc.BackColor = System.Drawing.Color.White;
            this.searchBoxMonHoc.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.searchBoxMonHoc.Location = new System.Drawing.Point(565, 22);
            this.searchBoxMonHoc.Name = "searchBoxMonHoc";
            this.searchBoxMonHoc.Size = new System.Drawing.Size(37, 38);
            this.searchBoxMonHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBoxMonHoc.TabIndex = 11;
            this.searchBoxMonHoc.TabStop = false;
            this.searchBoxMonHoc.Click += new System.EventHandler(this.searchBoxMonHoc_Click);
            // 
            // cbMaKhoa_MonHoc
            // 
            this.cbMaKhoa_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhoa_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhoa_MonHoc.FormattingEnabled = true;
            this.cbMaKhoa_MonHoc.Location = new System.Drawing.Point(191, 22);
            this.cbMaKhoa_MonHoc.Name = "cbMaKhoa_MonHoc";
            this.cbMaKhoa_MonHoc.Size = new System.Drawing.Size(352, 36);
            this.cbMaKhoa_MonHoc.TabIndex = 6;
            this.cbMaKhoa_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMaKhoa_MonHoc_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label27.Location = new System.Drawing.Point(6, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 29);
            this.label27.TabIndex = 3;
            this.label27.Text = "Khoa phụ trách";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel15.Controls.Add(this.label28);
            this.panel15.ForeColor = System.Drawing.Color.White;
            this.panel15.Location = new System.Drawing.Point(-1, 318);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1064, 47);
            this.panel15.TabIndex = 17;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(5, 6);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 31);
            this.label28.TabIndex = 7;
            this.label28.Text = "Tìm kiếm";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel16.Controls.Add(this.pictureBox11);
            this.panel16.Controls.Add(this.label29);
            this.panel16.ForeColor = System.Drawing.SystemColors.Window;
            this.panel16.Location = new System.Drawing.Point(0, 55);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1064, 50);
            this.panel16.TabIndex = 20;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox11.Location = new System.Drawing.Point(125, 9);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(29, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 7);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 31);
            this.label29.TabIndex = 6;
            this.label29.Text = "Thông tin";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox12.Controls.Add(this.numSoTinChi_MonHoc);
            this.groupBox12.Controls.Add(this.btnDelete_MonHoc);
            this.groupBox12.Controls.Add(this.label68);
            this.groupBox12.Controls.Add(this.cbKhoa_MonHoc);
            this.groupBox12.Controls.Add(this.btnSave_MonHoc);
            this.groupBox12.Controls.Add(this.label30);
            this.groupBox12.Controls.Add(this.btnAdd_MonHoc);
            this.groupBox12.Controls.Add(this.txtTenMonHoc_MonHoc);
            this.groupBox12.Controls.Add(this.txtID_MonHoc);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(2, 97);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1062, 224);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            // 
            // numSoTinChi_MonHoc
            // 
            this.numSoTinChi_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoTinChi_MonHoc.Location = new System.Drawing.Point(680, 89);
            this.numSoTinChi_MonHoc.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSoTinChi_MonHoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTinChi_MonHoc.Name = "numSoTinChi_MonHoc";
            this.numSoTinChi_MonHoc.Size = new System.Drawing.Size(107, 36);
            this.numSoTinChi_MonHoc.TabIndex = 12;
            this.numSoTinChi_MonHoc.TabStop = false;
            this.numSoTinChi_MonHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSoTinChi_MonHoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDelete_MonHoc
            // 
            this.btnDelete_MonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_MonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_MonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_MonHoc.Location = new System.Drawing.Point(841, 153);
            this.btnDelete_MonHoc.Name = "btnDelete_MonHoc";
            this.btnDelete_MonHoc.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_MonHoc.TabIndex = 4;
            this.btnDelete_MonHoc.Text = "Xóa";
            this.btnDelete_MonHoc.UseVisualStyleBackColor = false;
            this.btnDelete_MonHoc.Click += new System.EventHandler(this.btnDelete_MonHoc_Click);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label68.Location = new System.Drawing.Point(559, 92);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(103, 29);
            this.label68.TabIndex = 10;
            this.label68.Text = "Số tín chỉ";
            // 
            // cbKhoa_MonHoc
            // 
            this.cbKhoa_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa_MonHoc.FormattingEnabled = true;
            this.cbKhoa_MonHoc.Location = new System.Drawing.Point(680, 29);
            this.cbKhoa_MonHoc.Name = "cbKhoa_MonHoc";
            this.cbKhoa_MonHoc.Size = new System.Drawing.Size(360, 36);
            this.cbKhoa_MonHoc.TabIndex = 2;
            // 
            // btnSave_MonHoc
            // 
            this.btnSave_MonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_MonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_MonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_MonHoc.Location = new System.Drawing.Point(961, 153);
            this.btnSave_MonHoc.Name = "btnSave_MonHoc";
            this.btnSave_MonHoc.Size = new System.Drawing.Size(79, 36);
            this.btnSave_MonHoc.TabIndex = 5;
            this.btnSave_MonHoc.Text = "Lưu";
            this.btnSave_MonHoc.UseVisualStyleBackColor = false;
            this.btnSave_MonHoc.Click += new System.EventHandler(this.btnSave_MonHoc_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label30.Location = new System.Drawing.Point(510, 32);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(164, 29);
            this.label30.TabIndex = 7;
            this.label30.Text = "Khoa phụ trách";
            // 
            // btnAdd_MonHoc
            // 
            this.btnAdd_MonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_MonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_MonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_MonHoc.Location = new System.Drawing.Point(841, 153);
            this.btnAdd_MonHoc.Name = "btnAdd_MonHoc";
            this.btnAdd_MonHoc.Size = new System.Drawing.Size(199, 36);
            this.btnAdd_MonHoc.TabIndex = 3;
            this.btnAdd_MonHoc.Text = "Thêm môn học";
            this.btnAdd_MonHoc.UseVisualStyleBackColor = false;
            this.btnAdd_MonHoc.Click += new System.EventHandler(this.btnAdd_MonHoc_Click);
            // 
            // txtTenMonHoc_MonHoc
            // 
            this.txtTenMonHoc_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc_MonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtTenMonHoc_MonHoc.Location = new System.Drawing.Point(190, 88);
            this.txtTenMonHoc_MonHoc.Name = "txtTenMonHoc_MonHoc";
            this.txtTenMonHoc_MonHoc.Size = new System.Drawing.Size(282, 36);
            this.txtTenMonHoc_MonHoc.TabIndex = 1;
            // 
            // txtID_MonHoc
            // 
            this.txtID_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_MonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtID_MonHoc.Location = new System.Drawing.Point(190, 28);
            this.txtID_MonHoc.Name = "txtID_MonHoc";
            this.txtID_MonHoc.Size = new System.Drawing.Size(282, 36);
            this.txtID_MonHoc.TabIndex = 0;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label31.Location = new System.Drawing.Point(28, 91);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(140, 29);
            this.label31.TabIndex = 4;
            this.label31.Text = "Tên môn học";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label32.Location = new System.Drawing.Point(134, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 29);
            this.label32.TabIndex = 3;
            this.label32.Text = "ID";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label26);
            this.panel17.Controls.Add(this.btnEditMode_MonHoc);
            this.panel17.Controls.Add(this.label33);
            this.panel17.Location = new System.Drawing.Point(4, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1060, 47);
            this.panel17.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(2, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(130, 33);
            this.label26.TabIndex = 4;
            this.label26.Text = "MÔN HỌC";
            // 
            // btnEditMode_MonHoc
            // 
            this.btnEditMode_MonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_MonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_MonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_MonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnEditMode_MonHoc.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_MonHoc.Name = "btnEditMode_MonHoc";
            this.btnEditMode_MonHoc.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_MonHoc.TabIndex = 5;
            this.btnEditMode_MonHoc.Text = "OFF";
            this.btnEditMode_MonHoc.UseVisualStyleBackColor = false;
            this.btnEditMode_MonHoc.Click += new System.EventHandler(this.btnEditMode_MonHoc_Click_1);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(848, 6);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(127, 29);
            this.label33.TabIndex = 4;
            this.label33.Text = "EDIT MODE";
            // 
            // tabCTMH
            // 
            this.tabCTMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCTMH.Controls.Add(this.groupBox13);
            this.tabCTMH.Controls.Add(this.groupBox14);
            this.tabCTMH.Controls.Add(this.panel18);
            this.tabCTMH.Controls.Add(this.panel19);
            this.tabCTMH.Controls.Add(this.groupBox15);
            this.tabCTMH.Controls.Add(this.panel20);
            this.tabCTMH.Location = new System.Drawing.Point(4, 54);
            this.tabCTMH.Name = "tabCTMH";
            this.tabCTMH.Padding = new System.Windows.Forms.Padding(3);
            this.tabCTMH.Size = new System.Drawing.Size(1066, 809);
            this.tabCTMH.TabIndex = 4;
            this.tabCTMH.Text = "Chương trình học môn ";
            this.tabCTMH.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.ListCTMH);
            this.groupBox13.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(4, 452);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1060, 351);
            this.groupBox13.TabIndex = 21;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "DANH SÁCH CHƯƠNG TRÌNH HỌC MÔN";
            // 
            // ListCTMH
            // 
            this.ListCTMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListCTMH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListCTMH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListCTMH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCTMH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.ListCTMH.ColumnHeadersHeight = 50;
            this.ListCTMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenChuongTrinh_CTMH,
            this.TenMonHoc_CTMH,
            this.HocKy_CTMH});
            this.ListCTMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCTMH.EnableHeadersVisualStyles = false;
            this.ListCTMH.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListCTMH.Location = new System.Drawing.Point(3, 32);
            this.ListCTMH.MultiSelect = false;
            this.ListCTMH.Name = "ListCTMH";
            this.ListCTMH.RowHeadersVisible = false;
            this.ListCTMH.RowHeadersWidth = 51;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle32.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            this.ListCTMH.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.ListCTMH.RowTemplate.Height = 50;
            this.ListCTMH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListCTMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCTMH.Size = new System.Drawing.Size(1054, 316);
            this.ListCTMH.TabIndex = 7;
            this.ListCTMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCTMH_CellClick);
            // 
            // TenChuongTrinh_CTMH
            // 
            this.TenChuongTrinh_CTMH.DataPropertyName = "TenChuongTrinh";
            this.TenChuongTrinh_CTMH.HeaderText = "Chương trình đào tạo";
            this.TenChuongTrinh_CTMH.MinimumWidth = 6;
            this.TenChuongTrinh_CTMH.Name = "TenChuongTrinh_CTMH";
            this.TenChuongTrinh_CTMH.Width = 450;
            // 
            // TenMonHoc_CTMH
            // 
            this.TenMonHoc_CTMH.DataPropertyName = "TenMonHoc";
            this.TenMonHoc_CTMH.HeaderText = "Tên môn học";
            this.TenMonHoc_CTMH.MinimumWidth = 6;
            this.TenMonHoc_CTMH.Name = "TenMonHoc_CTMH";
            this.TenMonHoc_CTMH.Width = 450;
            // 
            // HocKy_CTMH
            // 
            this.HocKy_CTMH.DataPropertyName = "HocKy";
            this.HocKy_CTMH.HeaderText = "Học Kỳ";
            this.HocKy_CTMH.MinimumWidth = 6;
            this.HocKy_CTMH.Name = "HocKy_CTMH";
            this.HocKy_CTMH.Width = 150;
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox14.Controls.Add(this.seachBoxCTMH);
            this.groupBox14.Controls.Add(this.CbSearchCTDT_CTMH);
            this.groupBox14.Controls.Add(this.label35);
            this.groupBox14.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(1, 360);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1062, 66);
            this.groupBox14.TabIndex = 19;
            this.groupBox14.TabStop = false;
            // 
            // seachBoxCTMH
            // 
            this.seachBoxCTMH.BackColor = System.Drawing.Color.White;
            this.seachBoxCTMH.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.seachBoxCTMH.Location = new System.Drawing.Point(685, 17);
            this.seachBoxCTMH.Name = "seachBoxCTMH";
            this.seachBoxCTMH.Size = new System.Drawing.Size(38, 38);
            this.seachBoxCTMH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seachBoxCTMH.TabIndex = 11;
            this.seachBoxCTMH.TabStop = false;
            this.seachBoxCTMH.Click += new System.EventHandler(this.seachBoxCTMH_Click);
            // 
            // CbSearchCTDT_CTMH
            // 
            this.CbSearchCTDT_CTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSearchCTDT_CTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSearchCTDT_CTMH.FormattingEnabled = true;
            this.CbSearchCTDT_CTMH.Location = new System.Drawing.Point(265, 19);
            this.CbSearchCTDT_CTMH.Name = "CbSearchCTDT_CTMH";
            this.CbSearchCTDT_CTMH.Size = new System.Drawing.Size(401, 36);
            this.CbSearchCTDT_CTMH.TabIndex = 6;
            this.CbSearchCTDT_CTMH.SelectedIndexChanged += new System.EventHandler(this.CbSearchCTDT_CTMH_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label35.Location = new System.Drawing.Point(33, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(230, 29);
            this.label35.TabIndex = 3;
            this.label35.Text = "Chương trình đào tạo";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel18.Controls.Add(this.label36);
            this.panel18.ForeColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(3, 317);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1060, 47);
            this.panel18.TabIndex = 17;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(5, 6);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(109, 31);
            this.label36.TabIndex = 7;
            this.label36.Text = "Tìm kiếm";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel19.Controls.Add(this.pictureBox13);
            this.panel19.Controls.Add(this.label37);
            this.panel19.ForeColor = System.Drawing.SystemColors.Window;
            this.panel19.Location = new System.Drawing.Point(4, 55);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1060, 50);
            this.panel19.TabIndex = 20;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.White;
            this.pictureBox13.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox13.Location = new System.Drawing.Point(125, 9);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(29, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox13.TabIndex = 10;
            this.pictureBox13.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(6, 7);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(111, 31);
            this.label37.TabIndex = 6;
            this.label37.Text = "Thông tin";
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox15.Controls.Add(this.numHocKy_CTMH);
            this.groupBox15.Controls.Add(this.btnDelete_CTMH);
            this.groupBox15.Controls.Add(this.cbMH_CTMH);
            this.groupBox15.Controls.Add(this.cbCTDT_CTMH);
            this.groupBox15.Controls.Add(this.btnSave_CTMH);
            this.groupBox15.Controls.Add(this.label38);
            this.groupBox15.Controls.Add(this.btnAdd_CTMH);
            this.groupBox15.Controls.Add(this.label39);
            this.groupBox15.Controls.Add(this.label40);
            this.groupBox15.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(3, 97);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1061, 221);
            this.groupBox15.TabIndex = 18;
            this.groupBox15.TabStop = false;
            // 
            // numHocKy_CTMH
            // 
            this.numHocKy_CTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHocKy_CTMH.Location = new System.Drawing.Point(925, 31);
            this.numHocKy_CTMH.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numHocKy_CTMH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHocKy_CTMH.Name = "numHocKy_CTMH";
            this.numHocKy_CTMH.Size = new System.Drawing.Size(116, 36);
            this.numHocKy_CTMH.TabIndex = 2;
            this.numHocKy_CTMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHocKy_CTMH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDelete_CTMH
            // 
            this.btnDelete_CTMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_CTMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_CTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_CTMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_CTMH.Location = new System.Drawing.Point(842, 149);
            this.btnDelete_CTMH.Name = "btnDelete_CTMH";
            this.btnDelete_CTMH.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_CTMH.TabIndex = 4;
            this.btnDelete_CTMH.Text = "Xóa";
            this.btnDelete_CTMH.UseVisualStyleBackColor = false;
            this.btnDelete_CTMH.Click += new System.EventHandler(this.btnDelete_CTMH_Click);
            // 
            // cbMH_CTMH
            // 
            this.cbMH_CTMH.BackColor = System.Drawing.Color.White;
            this.cbMH_CTMH.DropDownHeight = 400;
            this.cbMH_CTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMH_CTMH.DropDownWidth = 350;
            this.cbMH_CTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMH_CTMH.FormattingEnabled = true;
            this.cbMH_CTMH.IntegralHeight = false;
            this.cbMH_CTMH.Location = new System.Drawing.Point(264, 101);
            this.cbMH_CTMH.Name = "cbMH_CTMH";
            this.cbMH_CTMH.Size = new System.Drawing.Size(400, 36);
            this.cbMH_CTMH.TabIndex = 1;
            // 
            // cbCTDT_CTMH
            // 
            this.cbCTDT_CTMH.BackColor = System.Drawing.Color.White;
            this.cbCTDT_CTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCTDT_CTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCTDT_CTMH.FormattingEnabled = true;
            this.cbCTDT_CTMH.Location = new System.Drawing.Point(264, 29);
            this.cbCTDT_CTMH.Name = "cbCTDT_CTMH";
            this.cbCTDT_CTMH.Size = new System.Drawing.Size(400, 36);
            this.cbCTDT_CTMH.TabIndex = 0;
            // 
            // btnSave_CTMH
            // 
            this.btnSave_CTMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_CTMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_CTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_CTMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_CTMH.Location = new System.Drawing.Point(962, 149);
            this.btnSave_CTMH.Name = "btnSave_CTMH";
            this.btnSave_CTMH.Size = new System.Drawing.Size(79, 36);
            this.btnSave_CTMH.TabIndex = 5;
            this.btnSave_CTMH.Text = "Lưu";
            this.btnSave_CTMH.UseVisualStyleBackColor = false;
            this.btnSave_CTMH.Click += new System.EventHandler(this.btnSave_CTMH_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label38.Location = new System.Drawing.Point(798, 33);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(79, 29);
            this.label38.TabIndex = 7;
            this.label38.Text = "Học kỳ";
            // 
            // btnAdd_CTMH
            // 
            this.btnAdd_CTMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_CTMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_CTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_CTMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_CTMH.Location = new System.Drawing.Point(716, 149);
            this.btnAdd_CTMH.Name = "btnAdd_CTMH";
            this.btnAdd_CTMH.Size = new System.Drawing.Size(325, 36);
            this.btnAdd_CTMH.TabIndex = 3;
            this.btnAdd_CTMH.Text = "Thêm chương trình học môn";
            this.btnAdd_CTMH.UseVisualStyleBackColor = false;
            this.btnAdd_CTMH.Click += new System.EventHandler(this.btnAdd_CTMH_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label39.Location = new System.Drawing.Point(109, 101);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(140, 29);
            this.label39.TabIndex = 4;
            this.label39.Text = "Tên môn học";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label40.Location = new System.Drawing.Point(28, 31);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(230, 29);
            this.label40.TabIndex = 3;
            this.label40.Text = "Chương trình đào tạo";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label34);
            this.panel20.Controls.Add(this.btnEditMode_ChuongTrinhMonHoc);
            this.panel20.Controls.Add(this.label41);
            this.panel20.Location = new System.Drawing.Point(4, 4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1060, 47);
            this.panel20.TabIndex = 16;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(5, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(319, 33);
            this.label34.TabIndex = 4;
            this.label34.Text = "CHƯƠNG TRÌNH HỌC MÔN";
            // 
            // btnEditMode_ChuongTrinhMonHoc
            // 
            this.btnEditMode_ChuongTrinhMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_ChuongTrinhMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_ChuongTrinhMonHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_ChuongTrinhMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnEditMode_ChuongTrinhMonHoc.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_ChuongTrinhMonHoc.Name = "btnEditMode_ChuongTrinhMonHoc";
            this.btnEditMode_ChuongTrinhMonHoc.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_ChuongTrinhMonHoc.TabIndex = 5;
            this.btnEditMode_ChuongTrinhMonHoc.Text = "OFF";
            this.btnEditMode_ChuongTrinhMonHoc.UseVisualStyleBackColor = false;
            this.btnEditMode_ChuongTrinhMonHoc.Click += new System.EventHandler(this.btnEditMode_ChuongTrinhMonHoc_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(848, 6);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(127, 29);
            this.label41.TabIndex = 4;
            this.label41.Text = "EDIT MODE";
            // 
            // tabPTMH
            // 
            this.tabPTMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPTMH.Controls.Add(this.groupBox16);
            this.tabPTMH.Controls.Add(this.groupBox17);
            this.tabPTMH.Controls.Add(this.panel21);
            this.tabPTMH.Controls.Add(this.panel22);
            this.tabPTMH.Controls.Add(this.groupBox18);
            this.tabPTMH.Controls.Add(this.panel23);
            this.tabPTMH.Location = new System.Drawing.Point(4, 54);
            this.tabPTMH.Name = "tabPTMH";
            this.tabPTMH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTMH.Size = new System.Drawing.Size(1066, 809);
            this.tabPTMH.TabIndex = 5;
            this.tabPTMH.Text = "Phụ trách môn học";
            this.tabPTMH.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.ListPTMH);
            this.groupBox16.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.Location = new System.Drawing.Point(4, 456);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(1060, 347);
            this.groupBox16.TabIndex = 21;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Danh sách giáo viên phụ trách môn học";
            // 
            // ListPTMH
            // 
            this.ListPTMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListPTMH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListPTMH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListPTMH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListPTMH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.ListPTMH.ColumnHeadersHeight = 50;
            this.ListPTMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonHoc_PTMH,
            this.TenChuongTrinh_PTMH,
            this.HoTen_PTMH,
            this.CoLaDamNhiemChinh});
            this.ListPTMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPTMH.EnableHeadersVisualStyles = false;
            this.ListPTMH.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListPTMH.Location = new System.Drawing.Point(3, 32);
            this.ListPTMH.MultiSelect = false;
            this.ListPTMH.Name = "ListPTMH";
            this.ListPTMH.RowHeadersVisible = false;
            this.ListPTMH.RowHeadersWidth = 51;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle34.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            this.ListPTMH.RowsDefaultCellStyle = dataGridViewCellStyle34;
            this.ListPTMH.RowTemplate.Height = 50;
            this.ListPTMH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListPTMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListPTMH.Size = new System.Drawing.Size(1054, 312);
            this.ListPTMH.TabIndex = 8;
            this.ListPTMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPTMH_CellClick);
            this.ListPTMH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListPTMH_CellFormatting);
            // 
            // TenMonHoc_PTMH
            // 
            this.TenMonHoc_PTMH.DataPropertyName = "TenMonHoc";
            this.TenMonHoc_PTMH.HeaderText = "Tên môn học";
            this.TenMonHoc_PTMH.MinimumWidth = 6;
            this.TenMonHoc_PTMH.Name = "TenMonHoc_PTMH";
            this.TenMonHoc_PTMH.Width = 250;
            // 
            // TenChuongTrinh_PTMH
            // 
            this.TenChuongTrinh_PTMH.DataPropertyName = "TenChuongTrinh";
            this.TenChuongTrinh_PTMH.HeaderText = "Chương trình đào tạo";
            this.TenChuongTrinh_PTMH.MinimumWidth = 6;
            this.TenChuongTrinh_PTMH.Name = "TenChuongTrinh_PTMH";
            this.TenChuongTrinh_PTMH.Width = 300;
            // 
            // HoTen_PTMH
            // 
            this.HoTen_PTMH.DataPropertyName = "HoTen";
            this.HoTen_PTMH.HeaderText = "Giáo viên đảm nhiệm";
            this.HoTen_PTMH.MinimumWidth = 6;
            this.HoTen_PTMH.Name = "HoTen_PTMH";
            this.HoTen_PTMH.Width = 280;
            // 
            // CoLaDamNhiemChinh
            // 
            this.CoLaDamNhiemChinh.DataPropertyName = "CoLaDamNhiemChinh";
            this.CoLaDamNhiemChinh.HeaderText = "Đảm nhiệm chính";
            this.CoLaDamNhiemChinh.MinimumWidth = 6;
            this.CoLaDamNhiemChinh.Name = "CoLaDamNhiemChinh";
            this.CoLaDamNhiemChinh.Width = 225;
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox17.Controls.Add(this.searchBoxPTMH);
            this.groupBox17.Controls.Add(this.label43);
            this.groupBox17.Controls.Add(this.cbGiaoVien_Search);
            this.groupBox17.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.Location = new System.Drawing.Point(1, 369);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1062, 66);
            this.groupBox17.TabIndex = 19;
            this.groupBox17.TabStop = false;
            // 
            // searchBoxPTMH
            // 
            this.searchBoxPTMH.BackColor = System.Drawing.Color.White;
            this.searchBoxPTMH.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.searchBoxPTMH.Location = new System.Drawing.Point(604, 24);
            this.searchBoxPTMH.Name = "searchBoxPTMH";
            this.searchBoxPTMH.Size = new System.Drawing.Size(34, 35);
            this.searchBoxPTMH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBoxPTMH.TabIndex = 11;
            this.searchBoxPTMH.TabStop = false;
            this.searchBoxPTMH.Click += new System.EventHandler(this.searchBoxPTMH_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label43.Location = new System.Drawing.Point(21, 24);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(226, 29);
            this.label43.TabIndex = 9;
            this.label43.Text = "Giáo viên đảm nhiệm";
            // 
            // cbGiaoVien_Search
            // 
            this.cbGiaoVien_Search.DropDownHeight = 400;
            this.cbGiaoVien_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiaoVien_Search.DropDownWidth = 350;
            this.cbGiaoVien_Search.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGiaoVien_Search.FormattingEnabled = true;
            this.cbGiaoVien_Search.IntegralHeight = false;
            this.cbGiaoVien_Search.Location = new System.Drawing.Point(255, 22);
            this.cbGiaoVien_Search.MaxLength = 8;
            this.cbGiaoVien_Search.Name = "cbGiaoVien_Search";
            this.cbGiaoVien_Search.Size = new System.Drawing.Size(326, 36);
            this.cbGiaoVien_Search.TabIndex = 7;
            this.cbGiaoVien_Search.SelectedIndexChanged += new System.EventHandler(this.cbGiaoVien_Search_SelectedIndexChanged);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel21.Controls.Add(this.label44);
            this.panel21.ForeColor = System.Drawing.Color.White;
            this.panel21.Location = new System.Drawing.Point(3, 326);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1060, 47);
            this.panel21.TabIndex = 17;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(5, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(109, 31);
            this.label44.TabIndex = 7;
            this.label44.Text = "Tìm kiếm";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel22.Controls.Add(this.pictureBox15);
            this.panel22.Controls.Add(this.label45);
            this.panel22.ForeColor = System.Drawing.SystemColors.Window;
            this.panel22.Location = new System.Drawing.Point(4, 55);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1060, 50);
            this.panel22.TabIndex = 20;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.White;
            this.pictureBox15.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox15.Location = new System.Drawing.Point(125, 9);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(29, 30);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox15.TabIndex = 10;
            this.pictureBox15.TabStop = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(6, 7);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(111, 31);
            this.label45.TabIndex = 6;
            this.label45.Text = "Thông tin";
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox18.Controls.Add(this.ckDamNhiemChinh);
            this.groupBox18.Controls.Add(this.cbGV_PTMH);
            this.groupBox18.Controls.Add(this.btnDelete_PTMH);
            this.groupBox18.Controls.Add(this.label48);
            this.groupBox18.Controls.Add(this.btnSave_PTMH);
            this.groupBox18.Controls.Add(this.cbMH_PTMH);
            this.groupBox18.Controls.Add(this.cbCTDT_PTMH);
            this.groupBox18.Controls.Add(this.label46);
            this.groupBox18.Controls.Add(this.label47);
            this.groupBox18.Controls.Add(this.btnAdd_PTMH);
            this.groupBox18.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox18.Location = new System.Drawing.Point(2, 97);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(1062, 230);
            this.groupBox18.TabIndex = 18;
            this.groupBox18.TabStop = false;
            // 
            // ckDamNhiemChinh
            // 
            this.ckDamNhiemChinh.AutoSize = true;
            this.ckDamNhiemChinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.ckDamNhiemChinh.Location = new System.Drawing.Point(766, 30);
            this.ckDamNhiemChinh.Name = "ckDamNhiemChinh";
            this.ckDamNhiemChinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckDamNhiemChinh.Size = new System.Drawing.Size(211, 33);
            this.ckDamNhiemChinh.TabIndex = 3;
            this.ckDamNhiemChinh.Text = "Đảm nhiệm chính";
            this.ckDamNhiemChinh.UseVisualStyleBackColor = true;
            // 
            // cbGV_PTMH
            // 
            this.cbGV_PTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGV_PTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGV_PTMH.FormattingEnabled = true;
            this.cbGV_PTMH.Location = new System.Drawing.Point(253, 141);
            this.cbGV_PTMH.Name = "cbGV_PTMH";
            this.cbGV_PTMH.Size = new System.Drawing.Size(384, 36);
            this.cbGV_PTMH.TabIndex = 2;
            // 
            // btnDelete_PTMH
            // 
            this.btnDelete_PTMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_PTMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_PTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_PTMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_PTMH.Location = new System.Drawing.Point(838, 141);
            this.btnDelete_PTMH.Name = "btnDelete_PTMH";
            this.btnDelete_PTMH.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_PTMH.TabIndex = 5;
            this.btnDelete_PTMH.Text = "Xóa";
            this.btnDelete_PTMH.UseVisualStyleBackColor = false;
            this.btnDelete_PTMH.Click += new System.EventHandler(this.btnDelete_PTMH_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label48.Location = new System.Drawing.Point(19, 144);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(226, 29);
            this.label48.TabIndex = 15;
            this.label48.Text = "Giáo viên đảm nhiệm";
            // 
            // btnSave_PTMH
            // 
            this.btnSave_PTMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_PTMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_PTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_PTMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_PTMH.Location = new System.Drawing.Point(958, 141);
            this.btnSave_PTMH.Name = "btnSave_PTMH";
            this.btnSave_PTMH.Size = new System.Drawing.Size(79, 36);
            this.btnSave_PTMH.TabIndex = 6;
            this.btnSave_PTMH.Text = "Lưu";
            this.btnSave_PTMH.UseVisualStyleBackColor = false;
            this.btnSave_PTMH.Click += new System.EventHandler(this.btnSave_PTMH_Click);
            // 
            // cbMH_PTMH
            // 
            this.cbMH_PTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMH_PTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMH_PTMH.FormattingEnabled = true;
            this.cbMH_PTMH.Location = new System.Drawing.Point(254, 87);
            this.cbMH_PTMH.Name = "cbMH_PTMH";
            this.cbMH_PTMH.Size = new System.Drawing.Size(383, 36);
            this.cbMH_PTMH.TabIndex = 1;
            this.cbMH_PTMH.SelectedIndexChanged += new System.EventHandler(this.cbMH_PTMH_SelectedIndexChanged);
            // 
            // cbCTDT_PTMH
            // 
            this.cbCTDT_PTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCTDT_PTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCTDT_PTMH.FormattingEnabled = true;
            this.cbCTDT_PTMH.Location = new System.Drawing.Point(254, 30);
            this.cbCTDT_PTMH.Name = "cbCTDT_PTMH";
            this.cbCTDT_PTMH.Size = new System.Drawing.Size(383, 36);
            this.cbCTDT_PTMH.TabIndex = 0;
            this.cbCTDT_PTMH.SelectedIndexChanged += new System.EventHandler(this.cbCTDT_PTMH_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label46.Location = new System.Drawing.Point(106, 87);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(140, 29);
            this.label46.TabIndex = 12;
            this.label46.Text = "Tên môn học";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label47.Location = new System.Drawing.Point(18, 32);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(230, 29);
            this.label47.TabIndex = 11;
            this.label47.Text = "Chương trình đào tạo";
            // 
            // btnAdd_PTMH
            // 
            this.btnAdd_PTMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_PTMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_PTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_PTMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_PTMH.Location = new System.Drawing.Point(764, 141);
            this.btnAdd_PTMH.Name = "btnAdd_PTMH";
            this.btnAdd_PTMH.Size = new System.Drawing.Size(273, 36);
            this.btnAdd_PTMH.TabIndex = 4;
            this.btnAdd_PTMH.Text = "Thêm phụ trách môn học";
            this.btnAdd_PTMH.UseVisualStyleBackColor = false;
            this.btnAdd_PTMH.Click += new System.EventHandler(this.btnAdd_PTMH_Click);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label42);
            this.panel23.Controls.Add(this.btnEditMode_PTMH);
            this.panel23.Controls.Add(this.label49);
            this.panel23.Location = new System.Drawing.Point(4, 4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(1060, 47);
            this.panel23.TabIndex = 16;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(6, 7);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(266, 33);
            this.label42.TabIndex = 4;
            this.label42.Text = "PHỤ TRÁCH MÔN HỌC";
            // 
            // btnEditMode_PTMH
            // 
            this.btnEditMode_PTMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_PTMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_PTMH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_PTMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnEditMode_PTMH.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_PTMH.Name = "btnEditMode_PTMH";
            this.btnEditMode_PTMH.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_PTMH.TabIndex = 5;
            this.btnEditMode_PTMH.Text = "OFF";
            this.btnEditMode_PTMH.UseVisualStyleBackColor = false;
            this.btnEditMode_PTMH.Click += new System.EventHandler(this.btnEditMode_PhuTrachMonHoc_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(848, 6);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(127, 29);
            this.label49.TabIndex = 4;
            this.label49.Text = "EDIT MODE";
            // 
            // tabKH
            // 
            this.tabKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabKH.Controls.Add(this.groupBox19);
            this.tabKH.Controls.Add(this.groupBox23);
            this.tabKH.Controls.Add(this.panel24);
            this.tabKH.Controls.Add(this.panel25);
            this.tabKH.Controls.Add(this.groupBox20);
            this.tabKH.Controls.Add(this.panel26);
            this.tabKH.Location = new System.Drawing.Point(4, 54);
            this.tabKH.Name = "tabKH";
            this.tabKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabKH.Size = new System.Drawing.Size(1066, 809);
            this.tabKH.TabIndex = 6;
            this.tabKH.Text = "Khóa học";
            this.tabKH.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.ListKhoaHoc);
            this.groupBox19.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(2, 455);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1059, 349);
            this.groupBox19.TabIndex = 24;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Danh sách khóa học";
            // 
            // ListKhoaHoc
            // 
            this.ListKhoaHoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListKhoaHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListKhoaHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListKhoaHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListKhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.ListKhoaHoc.ColumnHeadersHeight = 50;
            this.ListKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoaHoc_KH,
            this.TenKhoaHoc_KH,
            this.TenChuongTrinh_KH,
            this.NamBatDaU,
            this.NamKetThuc});
            this.ListKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListKhoaHoc.EnableHeadersVisualStyles = false;
            this.ListKhoaHoc.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListKhoaHoc.Location = new System.Drawing.Point(3, 32);
            this.ListKhoaHoc.MultiSelect = false;
            this.ListKhoaHoc.Name = "ListKhoaHoc";
            this.ListKhoaHoc.RowHeadersVisible = false;
            this.ListKhoaHoc.RowHeadersWidth = 51;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle36.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            this.ListKhoaHoc.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.ListKhoaHoc.RowTemplate.Height = 50;
            this.ListKhoaHoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListKhoaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListKhoaHoc.Size = new System.Drawing.Size(1053, 314);
            this.ListKhoaHoc.TabIndex = 9;
            this.ListKhoaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListKhoaHoc_CellClick);
            // 
            // MaKhoaHoc_KH
            // 
            this.MaKhoaHoc_KH.DataPropertyName = "MaKhoaHoc";
            this.MaKhoaHoc_KH.HeaderText = "ID";
            this.MaKhoaHoc_KH.MinimumWidth = 6;
            this.MaKhoaHoc_KH.Name = "MaKhoaHoc_KH";
            this.MaKhoaHoc_KH.Width = 125;
            // 
            // TenKhoaHoc_KH
            // 
            this.TenKhoaHoc_KH.DataPropertyName = "TenKhoaHoc";
            this.TenKhoaHoc_KH.HeaderText = "Tên khóa học";
            this.TenKhoaHoc_KH.MinimumWidth = 6;
            this.TenKhoaHoc_KH.Name = "TenKhoaHoc_KH";
            this.TenKhoaHoc_KH.Width = 330;
            // 
            // TenChuongTrinh_KH
            // 
            this.TenChuongTrinh_KH.DataPropertyName = "TenChuongTrinh";
            this.TenChuongTrinh_KH.HeaderText = "Chương trình đào tạo";
            this.TenChuongTrinh_KH.MinimumWidth = 6;
            this.TenChuongTrinh_KH.Name = "TenChuongTrinh_KH";
            this.TenChuongTrinh_KH.Width = 300;
            // 
            // NamBatDaU
            // 
            this.NamBatDaU.DataPropertyName = "NamBatDau";
            this.NamBatDaU.HeaderText = "Năm Bắt đầu";
            this.NamBatDaU.MinimumWidth = 6;
            this.NamBatDaU.Name = "NamBatDaU";
            this.NamBatDaU.Width = 150;
            // 
            // NamKetThuc
            // 
            this.NamKetThuc.DataPropertyName = "NamKetThuc";
            this.NamKetThuc.HeaderText = "Năm kết thúc";
            this.NamKetThuc.MinimumWidth = 6;
            this.NamKetThuc.Name = "NamKetThuc";
            this.NamKetThuc.Width = 160;
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox23.Controls.Add(this.SearchBox_KhoaHoc);
            this.groupBox23.Controls.Add(this.cbCTDTSearch_KhoaHoc);
            this.groupBox23.Controls.Add(this.label50);
            this.groupBox23.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox23.Location = new System.Drawing.Point(3, 381);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(1061, 66);
            this.groupBox23.TabIndex = 23;
            this.groupBox23.TabStop = false;
            // 
            // SearchBox_KhoaHoc
            // 
            this.SearchBox_KhoaHoc.BackColor = System.Drawing.Color.White;
            this.SearchBox_KhoaHoc.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.SearchBox_KhoaHoc.Location = new System.Drawing.Point(641, 21);
            this.SearchBox_KhoaHoc.Name = "SearchBox_KhoaHoc";
            this.SearchBox_KhoaHoc.Size = new System.Drawing.Size(35, 36);
            this.SearchBox_KhoaHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBox_KhoaHoc.TabIndex = 11;
            this.SearchBox_KhoaHoc.TabStop = false;
            this.SearchBox_KhoaHoc.Click += new System.EventHandler(this.SearchBox_KhoaHoc_Click);
            // 
            // cbCTDTSearch_KhoaHoc
            // 
            this.cbCTDTSearch_KhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCTDTSearch_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCTDTSearch_KhoaHoc.FormattingEnabled = true;
            this.cbCTDTSearch_KhoaHoc.Location = new System.Drawing.Point(266, 21);
            this.cbCTDTSearch_KhoaHoc.Name = "cbCTDTSearch_KhoaHoc";
            this.cbCTDTSearch_KhoaHoc.Size = new System.Drawing.Size(356, 36);
            this.cbCTDTSearch_KhoaHoc.TabIndex = 8;
            this.cbCTDTSearch_KhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbCTDTSearch_KhoaHoc_SelectedIndexChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label50.Location = new System.Drawing.Point(30, 24);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(230, 29);
            this.label50.TabIndex = 3;
            this.label50.Text = "Chương trình đào tạo";
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel24.Controls.Add(this.label51);
            this.panel24.ForeColor = System.Drawing.Color.White;
            this.panel24.Location = new System.Drawing.Point(3, 338);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(1060, 47);
            this.panel24.TabIndex = 22;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(5, 6);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(109, 31);
            this.label51.TabIndex = 7;
            this.label51.Text = "Tìm kiếm";
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel25.Controls.Add(this.pictureBox17);
            this.panel25.Controls.Add(this.label52);
            this.panel25.ForeColor = System.Drawing.SystemColors.Window;
            this.panel25.Location = new System.Drawing.Point(3, 55);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1061, 50);
            this.panel25.TabIndex = 20;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.White;
            this.pictureBox17.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox17.Location = new System.Drawing.Point(125, 9);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(29, 30);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox17.TabIndex = 10;
            this.pictureBox17.TabStop = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(6, 7);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(111, 31);
            this.label52.TabIndex = 6;
            this.label52.Text = "Thông tin";
            // 
            // groupBox20
            // 
            this.groupBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox20.Controls.Add(this.numNamKetThuc);
            this.groupBox20.Controls.Add(this.btnDelete_KhoaHoc);
            this.groupBox20.Controls.Add(this.numNamBatDau);
            this.groupBox20.Controls.Add(this.label70);
            this.groupBox20.Controls.Add(this.btnSave_KhoaHoc);
            this.groupBox20.Controls.Add(this.label69);
            this.groupBox20.Controls.Add(this.cbCTDT_KhoaHoc);
            this.groupBox20.Controls.Add(this.label53);
            this.groupBox20.Controls.Add(this.btnAdd_KhoaHoc);
            this.groupBox20.Controls.Add(this.txtTenKhoaHoc_KhoaHoc);
            this.groupBox20.Controls.Add(this.txtID_KhoaHoc);
            this.groupBox20.Controls.Add(this.label54);
            this.groupBox20.Controls.Add(this.label55);
            this.groupBox20.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox20.Location = new System.Drawing.Point(3, 97);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(1061, 244);
            this.groupBox20.TabIndex = 18;
            this.groupBox20.TabStop = false;
            // 
            // numNamKetThuc
            // 
            this.numNamKetThuc.Location = new System.Drawing.Point(929, 80);
            this.numNamKetThuc.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numNamKetThuc.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNamKetThuc.Name = "numNamKetThuc";
            this.numNamKetThuc.Size = new System.Drawing.Size(111, 36);
            this.numNamKetThuc.TabIndex = 4;
            this.numNamKetThuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNamKetThuc.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // btnDelete_KhoaHoc
            // 
            this.btnDelete_KhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_KhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_KhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_KhoaHoc.Location = new System.Drawing.Point(840, 191);
            this.btnDelete_KhoaHoc.Name = "btnDelete_KhoaHoc";
            this.btnDelete_KhoaHoc.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_KhoaHoc.TabIndex = 6;
            this.btnDelete_KhoaHoc.Text = "Xóa";
            this.btnDelete_KhoaHoc.UseVisualStyleBackColor = false;
            this.btnDelete_KhoaHoc.Click += new System.EventHandler(this.btnDelete_KhoaHoc_Click);
            // 
            // numNamBatDau
            // 
            this.numNamBatDau.Location = new System.Drawing.Point(929, 24);
            this.numNamBatDau.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numNamBatDau.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNamBatDau.Name = "numNamBatDau";
            this.numNamBatDau.Size = new System.Drawing.Size(111, 36);
            this.numNamBatDau.TabIndex = 3;
            this.numNamBatDau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNamBatDau.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label70.Location = new System.Drawing.Point(682, 82);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(146, 29);
            this.label70.TabIndex = 11;
            this.label70.Text = "Năm kết thúc";
            // 
            // btnSave_KhoaHoc
            // 
            this.btnSave_KhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_KhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_KhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_KhoaHoc.Location = new System.Drawing.Point(961, 191);
            this.btnSave_KhoaHoc.Name = "btnSave_KhoaHoc";
            this.btnSave_KhoaHoc.Size = new System.Drawing.Size(79, 36);
            this.btnSave_KhoaHoc.TabIndex = 7;
            this.btnSave_KhoaHoc.Text = "Lưu";
            this.btnSave_KhoaHoc.UseVisualStyleBackColor = false;
            this.btnSave_KhoaHoc.Click += new System.EventHandler(this.btnSave_KhoaHoc_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label69.Location = new System.Drawing.Point(681, 29);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(143, 29);
            this.label69.TabIndex = 10;
            this.label69.Text = "Năm bắt đầu";
            // 
            // cbCTDT_KhoaHoc
            // 
            this.cbCTDT_KhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCTDT_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCTDT_KhoaHoc.FormattingEnabled = true;
            this.cbCTDT_KhoaHoc.Location = new System.Drawing.Point(281, 142);
            this.cbCTDT_KhoaHoc.Name = "cbCTDT_KhoaHoc";
            this.cbCTDT_KhoaHoc.Size = new System.Drawing.Size(358, 36);
            this.cbCTDT_KhoaHoc.TabIndex = 2;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label53.Location = new System.Drawing.Point(27, 145);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(230, 29);
            this.label53.TabIndex = 7;
            this.label53.Text = "Chương trình đào tạo";
            // 
            // btnAdd_KhoaHoc
            // 
            this.btnAdd_KhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_KhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_KhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_KhoaHoc.Location = new System.Drawing.Point(768, 191);
            this.btnAdd_KhoaHoc.Name = "btnAdd_KhoaHoc";
            this.btnAdd_KhoaHoc.Size = new System.Drawing.Size(272, 36);
            this.btnAdd_KhoaHoc.TabIndex = 5;
            this.btnAdd_KhoaHoc.Text = "Thêm khóa học";
            this.btnAdd_KhoaHoc.UseVisualStyleBackColor = false;
            this.btnAdd_KhoaHoc.Click += new System.EventHandler(this.btnAdd_KhoaHoc_Click);
            // 
            // txtTenKhoaHoc_KhoaHoc
            // 
            this.txtTenKhoaHoc_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoaHoc_KhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtTenKhoaHoc_KhoaHoc.Location = new System.Drawing.Point(281, 83);
            this.txtTenKhoaHoc_KhoaHoc.Name = "txtTenKhoaHoc_KhoaHoc";
            this.txtTenKhoaHoc_KhoaHoc.Size = new System.Drawing.Size(358, 36);
            this.txtTenKhoaHoc_KhoaHoc.TabIndex = 1;
            // 
            // txtID_KhoaHoc
            // 
            this.txtID_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_KhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtID_KhoaHoc.Location = new System.Drawing.Point(281, 31);
            this.txtID_KhoaHoc.Name = "txtID_KhoaHoc";
            this.txtID_KhoaHoc.Size = new System.Drawing.Size(358, 36);
            this.txtID_KhoaHoc.TabIndex = 0;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label54.Location = new System.Drawing.Point(30, 86);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(144, 29);
            this.label54.TabIndex = 4;
            this.label54.Text = "Tên khóa học";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label55.Location = new System.Drawing.Point(30, 31);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(34, 29);
            this.label55.TabIndex = 3;
            this.label55.Text = "ID";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.label56);
            this.panel26.Controls.Add(this.btnEditMode_KhoaHoc);
            this.panel26.Controls.Add(this.label57);
            this.panel26.Location = new System.Drawing.Point(4, 2);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(1060, 47);
            this.panel26.TabIndex = 16;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(5, 7);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(136, 33);
            this.label56.TabIndex = 4;
            this.label56.Text = "KHÓA HỌC";
            // 
            // btnEditMode_KhoaHoc
            // 
            this.btnEditMode_KhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_KhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_KhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_KhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnEditMode_KhoaHoc.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_KhoaHoc.Name = "btnEditMode_KhoaHoc";
            this.btnEditMode_KhoaHoc.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_KhoaHoc.TabIndex = 5;
            this.btnEditMode_KhoaHoc.Text = "OFF";
            this.btnEditMode_KhoaHoc.UseVisualStyleBackColor = false;
            this.btnEditMode_KhoaHoc.Click += new System.EventHandler(this.btnEditMode_KhoaHoc_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(848, 6);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(127, 29);
            this.label57.TabIndex = 4;
            this.label57.Text = "EDIT MODE";
            // 
            // tabCTKH
            // 
            this.tabCTKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCTKH.Controls.Add(this.groupBox24);
            this.tabCTKH.Controls.Add(this.groupBox21);
            this.tabCTKH.Controls.Add(this.panel27);
            this.tabCTKH.Controls.Add(this.panel28);
            this.tabCTKH.Controls.Add(this.groupBox22);
            this.tabCTKH.Controls.Add(this.panel29);
            this.tabCTKH.Location = new System.Drawing.Point(4, 54);
            this.tabCTKH.Name = "tabCTKH";
            this.tabCTKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabCTKH.Size = new System.Drawing.Size(1066, 809);
            this.tabCTKH.TabIndex = 7;
            this.tabCTKH.Text = "Chi tiết khóa học";
            this.tabCTKH.UseVisualStyleBackColor = true;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.ListCTKH);
            this.groupBox24.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox24.Location = new System.Drawing.Point(-2, 473);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(1064, 328);
            this.groupBox24.TabIndex = 25;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Danh sách chi tiết khóa học";
            // 
            // ListCTKH
            // 
            this.ListCTKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ListCTKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ListCTKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListCTKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCTKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.ListCTKH.ColumnHeadersHeight = 50;
            this.ListCTKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhoaHoc_CTKH,
            this.TenMonHoc_CTKH,
            this.HoTen_CTKH,
            this.MaPhong_CTKH,
            this.MaThu_CTKH});
            this.ListCTKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCTKH.EnableHeadersVisualStyles = false;
            this.ListCTKH.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ListCTKH.Location = new System.Drawing.Point(3, 32);
            this.ListCTKH.MultiSelect = false;
            this.ListCTKH.Name = "ListCTKH";
            this.ListCTKH.RowHeadersVisible = false;
            this.ListCTKH.RowHeadersWidth = 51;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle38.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White;
            this.ListCTKH.RowsDefaultCellStyle = dataGridViewCellStyle38;
            this.ListCTKH.RowTemplate.Height = 50;
            this.ListCTKH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListCTKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCTKH.Size = new System.Drawing.Size(1058, 293);
            this.ListCTKH.TabIndex = 10;
            this.ListCTKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCTKH_CellClick);
            // 
            // groupBox21
            // 
            this.groupBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox21.Controls.Add(this.searchBox_CTKH);
            this.groupBox21.Controls.Add(this.cbKhoaHoc_Search_CTKH);
            this.groupBox21.Controls.Add(this.label72);
            this.groupBox21.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox21.Location = new System.Drawing.Point(3, 390);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(1061, 66);
            this.groupBox21.TabIndex = 24;
            this.groupBox21.TabStop = false;
            // 
            // searchBox_CTKH
            // 
            this.searchBox_CTKH.BackColor = System.Drawing.Color.White;
            this.searchBox_CTKH.Image = global::MainForm.Properties.Resources.Search_PNG_Images;
            this.searchBox_CTKH.Location = new System.Drawing.Point(611, 21);
            this.searchBox_CTKH.Name = "searchBox_CTKH";
            this.searchBox_CTKH.Size = new System.Drawing.Size(37, 36);
            this.searchBox_CTKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBox_CTKH.TabIndex = 11;
            this.searchBox_CTKH.TabStop = false;
            this.searchBox_CTKH.Click += new System.EventHandler(this.searchBox_CTKH_Click);
            // 
            // btnDelete_CTKH
            // 
            this.btnDelete_CTKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnDelete_CTKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete_CTKH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_CTKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnDelete_CTKH.Location = new System.Drawing.Point(834, 179);
            this.btnDelete_CTKH.Name = "btnDelete_CTKH";
            this.btnDelete_CTKH.Size = new System.Drawing.Size(82, 36);
            this.btnDelete_CTKH.TabIndex = 6;
            this.btnDelete_CTKH.Text = "Xóa";
            this.btnDelete_CTKH.UseVisualStyleBackColor = false;
            this.btnDelete_CTKH.Click += new System.EventHandler(this.btnDelete_CTKH_Click);
            // 
            // cbKhoaHoc_Search_CTKH
            // 
            this.cbKhoaHoc_Search_CTKH.DropDownHeight = 400;
            this.cbKhoaHoc_Search_CTKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaHoc_Search_CTKH.DropDownWidth = 400;
            this.cbKhoaHoc_Search_CTKH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaHoc_Search_CTKH.FormattingEnabled = true;
            this.cbKhoaHoc_Search_CTKH.IntegralHeight = false;
            this.cbKhoaHoc_Search_CTKH.Location = new System.Drawing.Point(216, 21);
            this.cbKhoaHoc_Search_CTKH.MaxLength = 8;
            this.cbKhoaHoc_Search_CTKH.Name = "cbKhoaHoc_Search_CTKH";
            this.cbKhoaHoc_Search_CTKH.Size = new System.Drawing.Size(377, 36);
            this.cbKhoaHoc_Search_CTKH.TabIndex = 8;
            this.cbKhoaHoc_Search_CTKH.SelectedIndexChanged += new System.EventHandler(this.cbKhoaHoc_Search_CTKH_SelectedIndexChanged);
            // 
            // btnSave_CTKH
            // 
            this.btnSave_CTKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave_CTKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave_CTKH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_CTKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnSave_CTKH.Location = new System.Drawing.Point(951, 179);
            this.btnSave_CTKH.Name = "btnSave_CTKH";
            this.btnSave_CTKH.Size = new System.Drawing.Size(79, 36);
            this.btnSave_CTKH.TabIndex = 7;
            this.btnSave_CTKH.Text = "Lưu";
            this.btnSave_CTKH.UseVisualStyleBackColor = false;
            this.btnSave_CTKH.Click += new System.EventHandler(this.btnSave_CTKH_Click);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label72.Location = new System.Drawing.Point(43, 24);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(144, 29);
            this.label72.TabIndex = 3;
            this.label72.Text = "Tên khóa học";
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel27.Controls.Add(this.label59);
            this.panel27.ForeColor = System.Drawing.Color.White;
            this.panel27.Location = new System.Drawing.Point(3, 347);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(1060, 47);
            this.panel27.TabIndex = 17;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(5, 6);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(109, 31);
            this.label59.TabIndex = 7;
            this.label59.Text = "Tìm kiếm";
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel28.Controls.Add(this.pictureBox19);
            this.panel28.Controls.Add(this.label60);
            this.panel28.ForeColor = System.Drawing.SystemColors.Window;
            this.panel28.Location = new System.Drawing.Point(4, 55);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(1060, 50);
            this.panel28.TabIndex = 20;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.White;
            this.pictureBox19.Image = global::MainForm.Properties.Resources.Information;
            this.pictureBox19.Location = new System.Drawing.Point(125, 9);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(29, 30);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox19.TabIndex = 10;
            this.pictureBox19.TabStop = false;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(6, 7);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(111, 31);
            this.label60.TabIndex = 6;
            this.label60.Text = "Thông tin";
            // 
            // groupBox22
            // 
            this.groupBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.groupBox22.Controls.Add(this.txtMaPhong);
            this.groupBox22.Controls.Add(this.btnDelete_CTKH);
            this.groupBox22.Controls.Add(this.cbThoiGian);
            this.groupBox22.Controls.Add(this.btnSave_CTKH);
            this.groupBox22.Controls.Add(this.cbMH_CTKH);
            this.groupBox22.Controls.Add(this.cbGV_CTKH);
            this.groupBox22.Controls.Add(this.cbKhoaHoc_CTKH);
            this.groupBox22.Controls.Add(this.label71);
            this.groupBox22.Controls.Add(this.label63);
            this.groupBox22.Controls.Add(this.label62);
            this.groupBox22.Controls.Add(this.label61);
            this.groupBox22.Controls.Add(this.label58);
            this.groupBox22.Controls.Add(this.btnAdd_CTKH);
            this.groupBox22.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox22.Location = new System.Drawing.Point(4, 97);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(1060, 253);
            this.groupBox22.TabIndex = 18;
            this.groupBox22.TabStop = false;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.txtMaPhong.Location = new System.Drawing.Point(159, 98);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(177, 36);
            this.txtMaPhong.TabIndex = 2;
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.DropDownHeight = 400;
            this.cbThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiGian.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.IntegralHeight = false;
            this.cbThoiGian.Items.AddRange(new object[] {
            "S2",
            "C2",
            "T2",
            "S3",
            "C3",
            "T3",
            "S4",
            "C4",
            "T4",
            "S5",
            "C5",
            "T5",
            "S6",
            "C6",
            "T6",
            "S7",
            "C7",
            "T7"});
            this.cbThoiGian.Location = new System.Drawing.Point(159, 151);
            this.cbThoiGian.MaxLength = 8;
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(177, 36);
            this.cbThoiGian.TabIndex = 3;
            // 
            // cbMH_CTKH
            // 
            this.cbMH_CTKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMH_CTKH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMH_CTKH.FormattingEnabled = true;
            this.cbMH_CTKH.Location = new System.Drawing.Point(690, 35);
            this.cbMH_CTKH.Name = "cbMH_CTKH";
            this.cbMH_CTKH.Size = new System.Drawing.Size(340, 36);
            this.cbMH_CTKH.TabIndex = 1;
            this.cbMH_CTKH.SelectedIndexChanged += new System.EventHandler(this.cbMH_CTKH_SelectedIndexChanged);
            // 
            // cbGV_CTKH
            // 
            this.cbGV_CTKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGV_CTKH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGV_CTKH.FormattingEnabled = true;
            this.cbGV_CTKH.Location = new System.Drawing.Point(772, 98);
            this.cbGV_CTKH.Name = "cbGV_CTKH";
            this.cbGV_CTKH.Size = new System.Drawing.Size(258, 36);
            this.cbGV_CTKH.TabIndex = 4;
            // 
            // cbKhoaHoc_CTKH
            // 
            this.cbKhoaHoc_CTKH.DropDownHeight = 400;
            this.cbKhoaHoc_CTKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaHoc_CTKH.DropDownWidth = 400;
            this.cbKhoaHoc_CTKH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaHoc_CTKH.FormattingEnabled = true;
            this.cbKhoaHoc_CTKH.IntegralHeight = false;
            this.cbKhoaHoc_CTKH.Location = new System.Drawing.Point(159, 42);
            this.cbKhoaHoc_CTKH.MaxLength = 8;
            this.cbKhoaHoc_CTKH.Name = "cbKhoaHoc_CTKH";
            this.cbKhoaHoc_CTKH.Size = new System.Drawing.Size(358, 36);
            this.cbKhoaHoc_CTKH.TabIndex = 0;
            this.cbKhoaHoc_CTKH.SelectedIndexChanged += new System.EventHandler(this.cbKhoaHoc_CTKH_SelectedIndexChanged);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label71.Location = new System.Drawing.Point(544, 101);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(205, 29);
            this.label71.TabIndex = 16;
            this.label71.Text = "Giáo viên giảng dạy";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label63.Location = new System.Drawing.Point(8, 158);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(106, 29);
            this.label63.TabIndex = 15;
            this.label63.Text = "Thời gian";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label62.Location = new System.Drawing.Point(9, 101);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(117, 29);
            this.label62.TabIndex = 14;
            this.label62.Text = "Phòng học";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label61.Location = new System.Drawing.Point(544, 42);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(140, 29);
            this.label61.TabIndex = 13;
            this.label61.Text = "Tên môn học";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(67)))));
            this.label58.Location = new System.Drawing.Point(9, 45);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(144, 29);
            this.label58.TabIndex = 7;
            this.label58.Text = "Tên khóa học";
            // 
            // btnAdd_CTKH
            // 
            this.btnAdd_CTKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd_CTKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_CTKH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_CTKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnAdd_CTKH.Location = new System.Drawing.Point(772, 179);
            this.btnAdd_CTKH.Name = "btnAdd_CTKH";
            this.btnAdd_CTKH.Size = new System.Drawing.Size(258, 36);
            this.btnAdd_CTKH.TabIndex = 5;
            this.btnAdd_CTKH.Text = "Thêm chi tiết khóa học";
            this.btnAdd_CTKH.UseVisualStyleBackColor = false;
            this.btnAdd_CTKH.Click += new System.EventHandler(this.btnAdd_CTKH_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.label64);
            this.panel29.Controls.Add(this.btnEditMode_ChiTietKhoaHoc);
            this.panel29.Controls.Add(this.label65);
            this.panel29.Location = new System.Drawing.Point(3, 2);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(1060, 47);
            this.panel29.TabIndex = 16;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(4, 7);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(232, 33);
            this.label64.TabIndex = 4;
            this.label64.Text = "CHI TIẾT KHÓA HỌC";
            // 
            // btnEditMode_ChiTietKhoaHoc
            // 
            this.btnEditMode_ChiTietKhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnEditMode_ChiTietKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMode_ChiTietKhoaHoc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode_ChiTietKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.btnEditMode_ChiTietKhoaHoc.Location = new System.Drawing.Point(981, 3);
            this.btnEditMode_ChiTietKhoaHoc.Name = "btnEditMode_ChiTietKhoaHoc";
            this.btnEditMode_ChiTietKhoaHoc.Size = new System.Drawing.Size(70, 36);
            this.btnEditMode_ChiTietKhoaHoc.TabIndex = 5;
            this.btnEditMode_ChiTietKhoaHoc.Text = "OFF";
            this.btnEditMode_ChiTietKhoaHoc.UseVisualStyleBackColor = false;
            this.btnEditMode_ChiTietKhoaHoc.Click += new System.EventHandler(this.btnEditMode_ChiTietKhoaHoc_Click);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(848, 6);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(127, 29);
            this.label65.TabIndex = 4;
            this.label65.Text = "EDIT MODE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(274, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 124);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::MainForm.Properties.Resources.Logo_UEH_xanh_2;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1070, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tra cứu thông tin";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 53);
            this.panel5.TabIndex = 0;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.White;
            this.panel32.Controls.Add(this.panel33);
            this.panel32.Controls.Add(this.dataGridView11);
            this.panel32.Location = new System.Drawing.Point(274, 167);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(1074, 868);
            this.panel32.TabIndex = 11;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.White;
            this.panel33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel33.Controls.Add(this.label74);
            this.panel33.Location = new System.Drawing.Point(3, 1);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(1066, 53);
            this.panel33.TabIndex = 6;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(5, 7);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(93, 33);
            this.label74.TabIndex = 5;
            this.label74.Text = "Bản tin";
            // 
            // dataGridView11
            // 
            this.dataGridView11.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView11.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView11.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView11.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridView11.ColumnHeadersHeight = 50;
            this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nguoigui,
            this.Ngaygui});
            this.dataGridView11.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView11.Location = new System.Drawing.Point(3, 54);
            this.dataGridView11.MultiSelect = false;
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.RowHeadersVisible = false;
            this.dataGridView11.RowHeadersWidth = 51;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle40.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView11.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridView11.RowTemplate.Height = 50;
            this.dataGridView11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView11.Size = new System.Drawing.Size(1067, 809);
            this.dataGridView11.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenKhoaHoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tiêu đề";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 440;
            // 
            // Nguoigui
            // 
            this.Nguoigui.HeaderText = "Người gửi";
            this.Nguoigui.MinimumWidth = 6;
            this.Nguoigui.Name = "Nguoigui";
            this.Nguoigui.Width = 315;
            // 
            // Ngaygui
            // 
            this.Ngaygui.HeaderText = "Ngày gửi";
            this.Ngaygui.MinimumWidth = 6;
            this.Ngaygui.Name = "Ngaygui";
            this.Ngaygui.Width = 315;
            // 
            // TenKhoaHoc_CTKH
            // 
            this.TenKhoaHoc_CTKH.DataPropertyName = "TenKhoaHoc";
            this.TenKhoaHoc_CTKH.HeaderText = "Tên khóa học";
            this.TenKhoaHoc_CTKH.MinimumWidth = 6;
            this.TenKhoaHoc_CTKH.Name = "TenKhoaHoc_CTKH";
            this.TenKhoaHoc_CTKH.Width = 270;
            // 
            // TenMonHoc_CTKH
            // 
            this.TenMonHoc_CTKH.DataPropertyName = "TenMonHoc";
            this.TenMonHoc_CTKH.HeaderText = "Tên môn học";
            this.TenMonHoc_CTKH.MinimumWidth = 6;
            this.TenMonHoc_CTKH.Name = "TenMonHoc_CTKH";
            this.TenMonHoc_CTKH.Width = 270;
            // 
            // HoTen_CTKH
            // 
            this.HoTen_CTKH.DataPropertyName = "HoTen";
            this.HoTen_CTKH.HeaderText = "Giáo viên giảng dạy";
            this.HoTen_CTKH.MinimumWidth = 6;
            this.HoTen_CTKH.Name = "HoTen_CTKH";
            this.HoTen_CTKH.Width = 230;
            // 
            // MaPhong_CTKH
            // 
            this.MaPhong_CTKH.DataPropertyName = "MaPhong";
            this.MaPhong_CTKH.HeaderText = "Phòng học";
            this.MaPhong_CTKH.MinimumWidth = 6;
            this.MaPhong_CTKH.Name = "MaPhong_CTKH";
            this.MaPhong_CTKH.Width = 150;
            // 
            // MaThu_CTKH
            // 
            this.MaThu_CTKH.DataPropertyName = "MaThu";
            this.MaThu_CTKH.HeaderText = "Thời gian";
            this.MaThu_CTKH.MinimumWidth = 6;
            this.MaThu_CTKH.Name = "MaThu_CTKH";
            this.MaThu_CTKH.Width = 150;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1348, 1037);
            this.Controls.Add(this.tabFunction);
            this.Controls.Add(this.panel32);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý chương trình học";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabFunction.ResumeLayout(false);
            this.tabKhoa.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListKhoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabGiaoVien.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListGiaoVien)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxGiaoVien)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tabCTĐT.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListChuongTrinh)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxChuongTrinh)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.tabMH.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListMonHoc)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxMonHoc)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi_MonHoc)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.tabCTMH.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListCTMH)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seachBoxCTMH)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy_CTMH)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.tabPTMH.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListPTMH)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxPTMH)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.tabKH.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListKhoaHoc)).EndInit();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox_KhoaHoc)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamBatDau)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.tabCTKH.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListCTKH)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox_CTKH)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox backPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbdatetime;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabFunction;
        private System.Windows.Forms.TabPage tabKhoa;
        private System.Windows.Forms.TabPage tabGiaoVien;
        private System.Windows.Forms.TabPage tabCTĐT;
        private System.Windows.Forms.TabPage tabMH;
        private System.Windows.Forms.TabPage tabCTMH;
        private System.Windows.Forms.TabPage tabPTMH;
        private System.Windows.Forms.TabPage tabKH;
        private System.Windows.Forms.TabPage tabCTKH;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TreeView TreeMenu;
        private System.Windows.Forms.Button btnEditMode_Khoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd_Khoa;
        private System.Windows.Forms.TextBox txtTenKhoa_Khoa;
        private System.Windows.Forms.TextBox txtID_Khoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete_Khoa;
        private System.Windows.Forms.ComboBox cbMaKhoa_Khoa;
        private System.Windows.Forms.Button btnSave_Khoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ListKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa_Khoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView ListGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien_GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen_GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa_GiaoVien;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDelete_GiaoVien;
        private System.Windows.Forms.ComboBox cbMaKhoa_GiaoVien;
        private System.Windows.Forms.Button btnSave_GiaoVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox searchBoxGiaoVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbKhoa_GiaoVien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdd_GiaoVien;
        private System.Windows.Forms.TextBox txtHoTen_GiaoVien;
        private System.Windows.Forms.TextBox txtID_GiaoVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEditMode_GiaoVien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView ListChuongTrinh;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnDelete_ChuongTrinh;
        private System.Windows.Forms.ComboBox cbMaKhoa_ChuongTrinh;
        private System.Windows.Forms.Button btnSave_ChuongTrinh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox searchBoxChuongTrinh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnAdd_ChuongTrinh;
        private System.Windows.Forms.TextBox txtBacHoc_ChuongTrinh;
        private System.Windows.Forms.TextBox txtID_ChuongTrinh;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnEditMode_ChuongTrinh;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnDelete_MonHoc;
        private System.Windows.Forms.ComboBox cbMaKhoa_MonHoc;
        private System.Windows.Forms.Button btnSave_MonHoc;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox searchBoxMonHoc;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox cbKhoa_MonHoc;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnAdd_MonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc_MonHoc;
        private System.Windows.Forms.TextBox txtID_MonHoc;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnEditMode_MonHoc;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DataGridView ListCTMH;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button btnDelete_CTMH;
        private System.Windows.Forms.ComboBox CbSearchCTDT_CTMH;
        private System.Windows.Forms.Button btnSave_CTMH;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.PictureBox seachBoxCTMH;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.ComboBox cbCTDT_CTMH;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnAdd_CTMH;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnEditMode_ChuongTrinhMonHoc;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DataGridView ListPTMH;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button btnDelete_PTMH;
        private System.Windows.Forms.ComboBox cbGiaoVien_Search;
        private System.Windows.Forms.Button btnSave_PTMH;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.PictureBox searchBoxPTMH;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button btnAdd_PTMH;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnEditMode_PTMH;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.ComboBox cbCTDT_KhoaHoc;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btnAdd_KhoaHoc;
        private System.Windows.Forms.TextBox txtTenKhoaHoc_KhoaHoc;
        private System.Windows.Forms.TextBox txtID_KhoaHoc;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button btnEditMode_KhoaHoc;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.PictureBox searchBox_CTKH;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Button btnAdd_CTKH;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Button btnEditMode_ChiTietKhoaHoc;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox cbGiaoVien_ChuongTrinh;
        private System.Windows.Forms.ComboBox cbKhoa_ChuongTrinh;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView ListMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa_MH;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.NumericUpDown numHocKy_CTMH;
        private System.Windows.Forms.ComboBox cbMH_CTMH;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.CheckBox ckDamNhiemChinh;
        private System.Windows.Forms.ComboBox cbGV_PTMH;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox cbMH_PTMH;
        private System.Windows.Forms.ComboBox cbCTDT_PTMH;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown numNamKetThuc;
        private System.Windows.Forms.NumericUpDown numNamBatDau;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.NumericUpDown numSoTinChi_MonHoc;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.DataGridView ListKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoaHoc_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaHoc_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuongTrinh_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamBatDaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamKetThuc;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Button btnDelete_KhoaHoc;
        private System.Windows.Forms.ComboBox cbCTDTSearch_KhoaHoc;
        private System.Windows.Forms.Button btnSave_KhoaHoc;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.PictureBox SearchBox_KhoaHoc;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.DataGridView ListCTKH;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Button btnDelete_CTKH;
        private System.Windows.Forms.ComboBox cbKhoaHoc_Search_CTKH;
        private System.Windows.Forms.Button btnSave_CTKH;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cbThoiGian;
        private System.Windows.Forms.ComboBox cbMH_CTKH;
        private System.Windows.Forms.ComboBox cbGV_CTKH;
        private System.Windows.Forms.ComboBox cbKhoaHoc_CTKH;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nguoigui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaygui;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txtTenChuongTrinh_ChuongTrinh;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuongTrinh_CTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc_CTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy_CTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuongTrinh_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuongTrinh_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBacHoc_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamDoc_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc_PTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuongTrinh_PTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen_PTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoLaDamNhiemChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaHoc_CTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc_CTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen_CTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong_CTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThu_CTKH;
    }
}