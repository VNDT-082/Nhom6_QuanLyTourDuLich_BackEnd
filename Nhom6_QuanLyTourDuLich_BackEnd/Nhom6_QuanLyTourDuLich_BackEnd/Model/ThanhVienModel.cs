﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class ThanhVienModel
    {
        public string IdThanhVien { get; set; }
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }

        public string? canCuocConDan { get; set; }
        public DateTime ngaySinh { get; set; }
        public string maDatTour { get; set; }

        public ThanhVienModel() { }
        public ThanhVienModel(string IdThanhVien, string hoTen, bool gioiTinh, string? canCuocConDan, DateTime ngaySinh, string maDatTour)
        {
            this.IdThanhVien = IdThanhVien;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.canCuocConDan = canCuocConDan;
            this.ngaySinh = ngaySinh;
            this.maDatTour = maDatTour;
        }
    }
}
