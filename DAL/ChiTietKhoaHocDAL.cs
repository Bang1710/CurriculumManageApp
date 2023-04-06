using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class ChiTietKhoaHocDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();
        public IList<KhoaHocMon> getListChiTietKhoaHoc()
        {
            var listChiTietKhoaHoc = context.KhoaHocMons.ToList();
            return listChiTietKhoaHoc;
        }


        public bool AddChiTietKhoaHoc(KhoaHocMon mon)
        {
            try
            {
                var ctkh = new KhoaHocMon()
                {
                    MaKhoaHoc = mon.MaKhoaHoc,
                    MaMonHoc = mon.MaMonHoc,
                    MaGiaoVien_day = mon.MaGiaoVien_day,
                    MaPhong = mon.MaPhong,
                    MaThu = mon.MaThu,
                };
                context.KhoaHocMons.Add(ctkh);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool EditChiTietKhoaHoc(string makhoahoc, string mamh, string magv, string maphong, string mathu)
        {
            try
            {
                var ctkh = context.KhoaHocMons.Where(c => c.MaKhoaHoc == makhoahoc && c.MaMonHoc == mamh && c.MaGiaoVien_day == magv).FirstOrDefault();
                ctkh.MaPhong = maphong;
                ctkh.MaThu = mathu;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteChiTietKhoaHoc(string makhoahoc, string mamh, string magv)
        {
            try
            {
                var ctkh = context.KhoaHocMons.Where(c => c.MaKhoaHoc == makhoahoc && c.MaMonHoc == mamh && c.MaGiaoVien_day == magv).FirstOrDefault();
                context.KhoaHocMons.Remove(ctkh);
                context.SaveChanges() ;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
