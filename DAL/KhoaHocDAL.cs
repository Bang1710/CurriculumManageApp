using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaHocDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();
        public IList<KhoaHoc> getListKhoaHoc()
        {
            var list = context.KhoaHocs.ToList();
            return list;
        }

        public bool AddKhoaHoc(KhoaHoc khoaHoc)
        {
            try
            {
                var kh = new KhoaHoc()
                { 
                    MaKhoaHoc = khoaHoc.MaKhoaHoc,
                    TenKhoaHoc = khoaHoc.TenKhoaHoc,
                    MaChuongTrinh = khoaHoc.MaChuongTrinh,
                    NamBatDau = khoaHoc.NamBatDau,
                    NamKetThuc = khoaHoc.NamKetThuc
                };
                context.KhoaHocs.Add(kh);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool EditKhoaHoc(string makhoahoc, string tenkhoahoc, int nambatdau, int namketthuc, string mactdt)
        {
            try
            {
                var kh = context.KhoaHocs.Find(makhoahoc);
                kh.TenKhoaHoc = tenkhoahoc;
                kh.NamBatDau = nambatdau;
                kh.NamKetThuc = namketthuc;
                kh.MaChuongTrinh = mactdt;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteKhoaHoc(string makhoahoc)
        {
            try
            {
                var kh = context.KhoaHocs.Where(k => k.MaKhoaHoc == makhoahoc).FirstOrDefault();
                context.KhoaHocs.Remove(kh);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
