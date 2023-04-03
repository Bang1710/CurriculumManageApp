using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DamNhiemMonDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();
        public IList<DamNhiemMon> getListDamNhiemMon()
        {
            var dnms = context.DamNhiemMons.ToList();
            return dnms;
        }

        public bool AddDamNhiemMon(DamNhiemMon mon)
        {
            try
            {
                var dnm = new DamNhiemMon()
                {
                    MaChuongTrinh = mon.MaChuongTrinh,
                    MaMonHoc = mon.MaMonHoc,
                    MaGiaoVien = mon.MaGiaoVien,
                    CoLaDamNhiemChinh = mon.CoLaDamNhiemChinh
                };
                context.DamNhiemMons.Add(dnm);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool EditDamNhiemMon(string mactdt, string mamh, string magv, int dnc)
        {
            try
            {
                var damnhiemmon = context.DamNhiemMons.Where(d => d.MaChuongTrinh == mactdt && d.MaMonHoc == mamh && d.MaGiaoVien == magv).FirstOrDefault();
                damnhiemmon.CoLaDamNhiemChinh = dnc;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteDamNhiemMon(string mactdt, string mamh, string magv)
        {
            try
            {
                var damnhiemmon = context.DamNhiemMons.Where(d => d.MaChuongTrinh == mactdt && d.MaMonHoc == mamh && d.MaGiaoVien == magv).FirstOrDefault();
                context.DamNhiemMons.Remove(damnhiemmon);
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
