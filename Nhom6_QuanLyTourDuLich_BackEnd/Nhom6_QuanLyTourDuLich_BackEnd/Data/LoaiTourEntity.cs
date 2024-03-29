﻿using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("LoaiTour")]
    public class LoaiTourEntity
    {
        public LoaiTourEntity()
        {

            IdLoaiTour = "LTour" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdLoaiTour { get; set; }
        [Required]
        public string tenLoai { get; set; }
        public virtual ICollection<TourEntity>? Tours { get; set; }
    }
}
