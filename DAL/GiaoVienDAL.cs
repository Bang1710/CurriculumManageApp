using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class GiaoVienDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();

        //public void getListKhoa(DataGridView dg)
        //{
        //    var khoas = context.Khoas.Select(k => new {k.MaKhoa, k.TenKhoa }).ToList();
        //    dg.DataSource = khoas;
        //} 

        public IList<GiaoVien> getListGiaoVien()
        {
            var GiaoVienLq = context.GiaoViens.ToList();
            return GiaoVienLq;
            //var khoaList = new List<DTO.Khoa>();

            //foreach (var khoa in khoaLq)
            //{
            //    var khoaObj = new Khoa()
            //    {
            //        MaKhoa = khoa.MaKhoa_Khoa,
            //        TenKhoa = khoa.TenKhoa_Khoa

            //    };
            //    khoaList.Add(khoaObj);
            //}
            //return khoaList;
        }

        public bool AddGiangVien(GiaoVien gv)
        {
            try
            {
                var giaovien = new GiaoVien()
                {
                    MaGiaoVien = gv.MaGiaoVien,
                    HoTen = gv.HoTen,
                    MaKhoa = gv.MaKhoa,
                };
                context.GiaoViens.Add(giaovien);
                context.SaveChanges();
                MessageBox.Show("Thêm giáo viên thành công");
            }
            catch (Exception e)
            {
                //MessageBox.Show("Thêm giáo viên không thành công");
                return false;
            }

            return true;
        }

        public bool EditGiangVien(string id, string hoten, string makhoa)
        {
            try
            {
                var gv = context.GiaoViens.Find(id);
                gv.HoTen = hoten;
                gv.MaKhoa = makhoa;
                context.SaveChanges();
                MessageBox.Show("Update thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Update không thành công");
                return false;
            }
            return true;
        }

        public bool DeleteGiaoVien(string id)
        {
            try
            {
                var gv = context.GiaoViens.Where(g => g.MaGiaoVien == id).SingleOrDefault();
                context.GiaoViens.Remove(gv);
                context.SaveChanges();
                MessageBox.Show("Delete thành công");
            }
            catch (DbUpdateException ex)
            {
                //MessageBox.Show("Delete không thành công, vì ảnh hưởng đến dữ liệu của các đối tượng liên quan");
                return false;
            }
            return true;
        }

    }
}
