using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class KhoaBLL
    {
        KhoaDAL khoaDAL;

        public KhoaBLL() { 
            khoaDAL = new KhoaDAL();
        }

        //public void getListKhoa(DataGridView dg) => khoaDAL.getListKhoa(dg);

        public IList<Khoa> getListKhoa()
        {
            return khoaDAL.getListKhoa();
        }

        public bool AddKhoa(Khoa k)
        {
            return khoaDAL.AddKhoa(k);
        }

        public bool EditKhoa(string makhoa, string tenkhoa)
        {
            return khoaDAL.EditKhoa(makhoa, tenkhoa);
        }

        public bool DeleteKhoa(string makhoa)
        {
            return khoaDAL.DeleteKhoa(makhoa);
        }

    }
}
