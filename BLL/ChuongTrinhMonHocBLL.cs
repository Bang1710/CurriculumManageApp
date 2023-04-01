using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChuongTrinhMonHocBLL
    {
        ChuongTrinhMonHocDAL ctmhDAL;
        public ChuongTrinhMonHocBLL() { 
            ctmhDAL = new ChuongTrinhMonHocDAL();
        }

        public IList<ChuongTrinhMonHoc> getListCTMH()
        {
            return ctmhDAL.getListCTMH();
        }

        public bool AddCTMH(ChuongTrinhMonHoc ctmh)
        {
            return ctmhDAL.AddCTMH(ctmh);
        }

        public bool EditCTMH(string mactdt, string mamh, int hk)
        {
            return ctmhDAL.EditCTMH(mactdt, mamh, hk);
        }

        public bool DeleteCTMH(string mactdt, string mamh)
        {
            return ctmhDAL.DeleteCTMH(mactdt, mamh);
        }
    }
}
