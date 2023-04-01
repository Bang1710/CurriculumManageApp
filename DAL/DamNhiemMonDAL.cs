using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
