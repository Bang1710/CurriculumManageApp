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

    }
}
