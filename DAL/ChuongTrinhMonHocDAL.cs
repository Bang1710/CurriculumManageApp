using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuongTrinhMonHocDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();
        public IList<ChuongTrinhMonHoc> getListCTMH()
        {
            var ctmhs = context.ChuongTrinhMonHocs.ToList();
            return ctmhs;
        }

        public bool AddCTMH(ChuongTrinhMonHoc ctmh)
        {
            try
            {
                var chuongtrinhmonhoc = new ChuongTrinhMonHoc()
                {
                    MaChuongTrinh = ctmh.MaChuongTrinh,
                    MaMonHoc = ctmh.MaMonHoc,
                    HocKy = ctmh.HocKy,
                };
                context.ChuongTrinhMonHocs.Add(ctmh);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool EditCTMH(string mactdt, string mamh, int hk)
        {
            try
            {
                var ctmh = context.ChuongTrinhMonHocs.Where(c => c.MaChuongTrinh == mactdt && c.MaMonHoc == mamh).SingleOrDefault();
                ctmh.MaChuongTrinh = mactdt;
                ctmh.MaMonHoc = mamh;
                ctmh.HocKy = hk;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteCTMH(string mactdt, string mamh)
        {
            try
            {
                var ctmh = context.ChuongTrinhMonHocs.Where(c => c.MaChuongTrinh == mactdt && c.MaMonHoc == mamh).FirstOrDefault();
                context.ChuongTrinhMonHocs.Remove(ctmh);
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
