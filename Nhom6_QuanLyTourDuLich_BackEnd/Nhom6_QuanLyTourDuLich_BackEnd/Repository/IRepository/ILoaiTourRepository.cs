using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ILoaiTourRepository
    {
        public Task<List<LoaiTourEntity>> GetAllAsync();
        public Task<LoaiTourEntity> GetOneByIDAsync(string Id);
        public Task<LoaiTourEntity> GetLastAsync();
        public Task AddAsync(LoaiTourEntity loaiTour);
        public Task UpdateAsync(LoaiTourEntity loaiTour);
        public Task DeleteAsync(LoaiTourEntity loaiTour);
    }
}
