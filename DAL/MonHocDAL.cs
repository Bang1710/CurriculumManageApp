using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonHocDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();

        public IList<MonHoc> getListMonHoc()
        {
            var monhocs = context.MonHocs.ToList();
            return monhocs;
        }

        public bool AddMonHoc(MonHoc mh)
        {
            try
            {
                var monhoc = new MonHoc()
                {
                    MaMonHoc = mh.MaMonHoc,
                    TenMonHoc = mh.TenMonHoc,
                    SoTinChi = mh.SoTinChi,
                    MaKhoa = mh.MaKhoa,
                };
                context.MonHocs.Add(monhoc);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool EditMonHoc(string mamh, string tenmh, int stc, string makh)
        {
            try
            {
                var mh = context.MonHocs.Find(mamh);
                mh.TenMonHoc = tenmh;
                mh.SoTinChi = stc;
                mh.MaKhoa = makh;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteMonHoc(string mamh)
        {
            try
            {
                var mh = context.MonHocs.Where(m => m.MaMonHoc == mamh).SingleOrDefault();
                context.MonHocs.Remove(mh);
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
