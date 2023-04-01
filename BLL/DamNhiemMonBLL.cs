using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DamNhiemMonBLL
    {
        DamNhiemMonDAL damnhiemmonDAL;
        public DamNhiemMonBLL()
        {
            damnhiemmonDAL = new DamNhiemMonDAL();
        }

        public IList<DamNhiemMon> getListDamNhiemMon()
        {
            return damnhiemmonDAL.getListDamNhiemMon();
        }
    }
}
