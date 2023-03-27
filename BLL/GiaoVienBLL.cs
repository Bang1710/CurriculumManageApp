using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GiaoVienBLL
    {
        GiaoVienDAL giaovienDAL;
        public GiaoVienBLL() {
            giaovienDAL = new GiaoVienDAL();
        }

        public IList<GiaoVien> getListGiaoVien()
        {
            return giaovienDAL.getListGiaoVien();
        }

        public bool AddGiangVien(GiaoVien gv)
        {
            return giaovienDAL.AddGiangVien(gv);
        }

        public bool EditGiangVien(string id, string hoten, string makhoa)
        {
            return giaovienDAL.EditGiangVien(id, hoten, makhoa);
        }

        public bool DeleteGiaoVien(string id)
        {
            return giaovienDAL.DeleteGiaoVien(id);
        }
    }
}
