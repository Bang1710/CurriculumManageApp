using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChuongTrinhBLL
    {
        ChuongTrinhDAL chuongtrinhDAL;

        public ChuongTrinhBLL()
        {
            chuongtrinhDAL = new ChuongTrinhDAL();
        }

        public IList<ChuongTrinh> getListChuongTrinh()
        {
            return chuongtrinhDAL.getListChuongTrinh();
        }

        public bool AddChuongTrinh(ChuongTrinh chuongtrinh)
        {
            return chuongtrinhDAL.AddChuongTrinh(chuongtrinh);
        }

        public bool EditChuongTrinh(string mact, string tenct, string mabh, string makhoa, string mgv)
        {
            return chuongtrinhDAL.EditChuongTrinh(mact, tenct, mabh, makhoa, mgv);
        }

        public bool DeleteChuongTrinh(string mact)
        {
            return chuongtrinhDAL.DeleteChuongTrinh(mact);
        }


    }
}
