using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
