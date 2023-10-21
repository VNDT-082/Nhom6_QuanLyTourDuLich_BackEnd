using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface INhanXetService
    {
        public Task<List<NhanXetModel>> GetAllAsync(string IdTour);
        public Task<NhanXetModel> GetOneByIDAsync(string Id);
        //public Task<NhanXetEntity> GetLastAsync();
        public Task<bool> AddAsync(NhanXet_repo _NhanXet_repo);
        public Task<bool> UpdateAsync(NhanXetModel _NhanXetModel);
        public Task<bool> DeleteAsync(string Id);
        public Task<bool> Clear(string IdTour);
    }
}
