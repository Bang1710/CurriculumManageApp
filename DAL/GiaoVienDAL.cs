using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DAL
{
    public class GiaoVienDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();

        public IList<GiaoVien> getListGiaoVien()
        {
            var GiaoVienLq = context.GiaoViens.ToList();
            return GiaoVienLq;
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
            }
            catch (Exception e)
            {
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
            }
            catch (Exception e)
            {
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
            }
            catch ( Exception e)
            {
                return false;
            }
            return true;
        }

    }
}



