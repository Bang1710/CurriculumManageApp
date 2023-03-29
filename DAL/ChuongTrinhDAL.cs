using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuongTrinhDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();

        public IList<ChuongTrinh> getListChuongTrinh()
        {
            var chuongtrinhs = context.ChuongTrinhs.ToList();
            return chuongtrinhs;
        }

        public bool AddChuongTrinh(ChuongTrinh chuongtrinh)
        {
            try
            {
                var ct = new ChuongTrinh()
                {
                    MaChuongTrinh = chuongtrinh.MaChuongTrinh,
                    TenChuongTrinh = chuongtrinh.TenChuongTrinh,
                    MaBacHoc = chuongtrinh.MaBacHoc,
                    MaKhoa = chuongtrinh.MaKhoa,
                    MaGiaoVien_GiamDocCT = chuongtrinh.MaGiaoVien_GiamDocCT
                };
                context.ChuongTrinhs.Add(ct);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true; 
        }

        public bool EditChuongTrinh(string mact, string tenct, string mabh, string makhoa, string mgv)
        {
            try
            {
                var ct = context.ChuongTrinhs.Find(mact);
                ct.MaChuongTrinh = mact;
                ct.TenChuongTrinh= tenct;
                ct.MaBacHoc = mabh; 
                ct.MaKhoa = makhoa;
                ct.MaGiaoVien_GiamDocCT = mgv;
                context.SaveChanges();

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteChuongTrinh(string mact)
        {

            try
            {
                var ct = context.ChuongTrinhs.Where(c => c.MaChuongTrinh == mact).SingleOrDefault();
                context.ChuongTrinhs.Remove(ct);
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
