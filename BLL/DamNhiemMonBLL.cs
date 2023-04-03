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

        public bool AddDamNhiemMon(DamNhiemMon mon)
        {
            return damnhiemmonDAL.AddDamNhiemMon(mon);
        }

        public bool EditDamNhiemMon(string mactdt, string mamh, string magv, int dnc)
        {
            return damnhiemmonDAL.EditDamNhiemMon(mactdt, mamh, magv, dnc);
        }

        public bool DeleteDamNhiemMon(string mactdt, string mamh, string magv)
        {
            return damnhiemmonDAL.DeleteDamNhiemMon(mactdt, mamh, magv);
        }
    }
}
