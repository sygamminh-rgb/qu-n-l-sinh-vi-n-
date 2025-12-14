using qlsv.QLSV.DAL;
using qlsv.QLSV.DAL.DAL;
using qlsv.QLSV.MODEL;
using qlsv.QLSV.MODEL.MODEL;
using System;
using System.Data;

namespace qlsv.QLSV.BLL
{
    public class SinhVienBLL
    {
        SinhVienDAL dal = new SinhVienDAL();

        public DataTable GetAllSV()
        {
            return dal.GetAll();
        }

        public void ThemSV(SinhVien sv)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV) ||
                string.IsNullOrWhiteSpace(sv.HoTen))
                throw new Exception("Không được để trống dữ liệu");

            dal.Insert(sv);
        }
    }
}
