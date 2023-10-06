using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{ 
    public interface IHuyenService
    {
        public Task<List<HuyenModel>> GetAllAsync();
        public Task<List<HuyenModel>> GetListByTinhIdAsync(string maTinh);
        public Task<HuyenModel> GetOneByIDAsync(string Id);
        public Task<HuyenModel> GetLastAsync();
        public Task<bool> AddAsync(Huyen_repo huyen_repo);
        public Task<bool> UpdateAsync(HuyenModel huyenModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
