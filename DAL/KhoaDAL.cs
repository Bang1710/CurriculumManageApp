using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{


    public class KhoaDAL
    {

        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();

        public IList<Khoa> getListKhoa()
        {
            var khoas = context.Khoas.ToList();
            return khoas;
        }

        public bool AddKhoa(Khoa k)
        {
            try
            {
                var khoa = new Khoa()
                {
                    MaKhoa = k.MaKhoa,
                    TenKhoa = k.TenKhoa
                };
                context.Khoas.Add(khoa);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool EditKhoa(string makhoa, string tenkhoa)
        {
            try
            {
                var kh = context.Khoas.Find(makhoa);
                kh.TenKhoa = tenkhoa;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteKhoa(string makhoa)
        {
            try
            {
                var kh = context.Khoas.Where(k => k.MaKhoa == makhoa).SingleOrDefault();
                context.Khoas.Remove(kh);
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Exception baseEx = ex.GetBaseException();

                // Log or display the base exception message
                MessageBox.Show("Không cho phép xóa dữ liệu" + baseEx.Message);
                return false;
            }
            return true;
        }

    }
}
