using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ITraLoiHoiDapService
    {
        public Task<List<TraLoiHoiDapModel>> GetAllAsync(string IdHoiDap);
        public Task<TraLoiHoiDapModel> GetOneByIDAsync(string Id);
        //public Task<TraLoiHoiDapEntity> GetLastAsync();
        public Task<bool> AddAsync(TraLoiHoiDap_repo _TraLoiHoiDap_repo);
        public Task<bool> UpdateAsync(TraLoiHoiDapModel _TraLoiHoiDapModel);
        public Task<bool> DeleteAsync(string Id);
        public Task<bool> Clear(string IdHoiDap);
    }
}
