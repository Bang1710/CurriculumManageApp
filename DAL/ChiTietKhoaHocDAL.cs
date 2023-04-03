using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class ChiTietKhoaHocDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();
        public IList<KhoaHocMon> getListChiTietKhoaHoc()
        {
            var listChiTietKhoaHoc = context.KhoaHocMons.ToList();
            return listChiTietKhoaHoc;
        }
    }
}
