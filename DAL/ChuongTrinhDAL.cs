using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuongTrinhDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();

        public IList<ChuongTrinh> getListChuongTrinh()
        {
            var chuongtrinhs = context.ChuongTrinhs.ToList();
            return chuongtrinhs;
        }
    }
}
