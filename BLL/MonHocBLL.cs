using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonHocBLL
    {
        MonHocDAL monhocDAL;
        public MonHocBLL()
        {
            monhocDAL = new MonHocDAL();
        }

        public IList<MonHoc> getListMonHoc()
        {
            return monhocDAL.getListMonHoc();
        }

        public bool AddMonHoc(MonHoc mh)
        {
            return monhocDAL.AddMonHoc(mh);
        }

        public bool EditMonHoc(string mamh, string tenmh, int stc, string makh)
        {
            return monhocDAL.EditMonHoc(mamh, tenmh, stc, makh);
        }

        public bool DeleteMonHoc(string mamh)
        {
            return monhocDAL.DeleteMonHoc(mamh);
        }
    }
}
