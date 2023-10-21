using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IHoiDapService
    {
        public Task<List<HoiDapModel>> GetAllAsync(string IdTour);
        public Task<HoiDapModel> GetOneByIDAsync(string Id);
        //public Task<HoiDapEntity> GetLastAsync();
        public Task<bool> AddAsync(HoiDap_repo _HoiDap_repo);
        public Task<bool> UpdateAsync(HoiDapModel _HoiDapModel);
        public Task<bool> DeleteAsync(string Id);
        public Task<bool> Clear(string IdTour);
    }
}
