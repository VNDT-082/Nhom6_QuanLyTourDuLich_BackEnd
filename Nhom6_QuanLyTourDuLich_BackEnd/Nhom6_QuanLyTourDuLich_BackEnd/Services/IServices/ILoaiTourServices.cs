using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ILoaiTourServices
    {
        public Task<List<LoaiTourModel>> GetAllAsync();
        public Task<LoaiTourModel> GetOneByIdAsync(string Id);
        public Task<LoaiTourModel> GetLastAsync();
        public Task<bool> AddAsync(LoaiTourModel loaiTour);
        public Task<bool> UpdateAsync(LoaiTourModel loaiTour);
        public Task<bool> DeleteAsync(string Id);
    }
}
