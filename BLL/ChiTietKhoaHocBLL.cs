using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public class ChiTietKhoaHocBLL
    {
        ChiTietKhoaHocDAL chitietkhoahocDAL;
        public ChiTietKhoaHocBLL() { 
            chitietkhoahocDAL = new ChiTietKhoaHocDAL();
        }

        public IList<KhoaHocMon> getListChiTietKhoaHoc()
        {
            return chitietkhoahocDAL.getListChiTietKhoaHoc();
        }

        public bool AddChiTietKhoaHoc(KhoaHocMon mon)
        {
            return chitietkhoahocDAL.AddChiTietKhoaHoc(mon);
        }

        public bool EditChiTietKhoaHoc(string makhoahoc, string mamh, string magv, string maphong, string mathu)
        {
            return chitietkhoahocDAL.EditChiTietKhoaHoc(makhoahoc, mamh, magv, maphong, mathu); 
        }

        public bool DeleteChiTietKhoaHoc(string makhoahoc, string mamh, string magv)
        {
            return chitietkhoahocDAL.DeleteChiTietKhoaHoc(makhoahoc, mamh, magv);
        }
    }
}
