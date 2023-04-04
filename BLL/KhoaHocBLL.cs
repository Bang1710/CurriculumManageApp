using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoaHocBLL
    {
        KhoaHocDAL khoahocDAL;
        
        public KhoaHocBLL()
        {
            khoahocDAL = new KhoaHocDAL();
        }

        public IList<KhoaHoc> getListKhoaHoc()
        {
            return khoahocDAL.getListKhoaHoc();
        }

        public bool AddKhoaHoc(KhoaHoc khoaHoc)
        {
            return khoahocDAL.AddKhoaHoc(khoaHoc);
        }

        public bool EditKhoaHoc(string makhoahoc, string tenkhoahoc, int nambatdau, int namketthuc, string mactdt)
        {
            return khoahocDAL.EditKhoaHoc(makhoahoc, tenkhoahoc, nambatdau, namketthuc, mactdt);
        }

        public bool DeleteKhoaHoc(string makhoahoc)
        {
            return khoahocDAL.DeleteKhoaHoc(makhoahoc);
        }
    }
}
