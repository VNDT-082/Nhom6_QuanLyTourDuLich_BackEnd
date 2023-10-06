using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IKhachSanService
    {
        public Task<List<KhachSanModel>> GetAllAsync();
        public Task<List<KhachSanModel>> GetListByHangSao(string hangSao);
        public Task<KhachSanModel> GetOneByXaIdAsync(string xaId);
        public Task<KhachSanModel> GetLastAsync();
        public Task<bool> AddAsync(KhachSan_repo khachSan_repo);
        public Task<bool> UpdateAsync(KhachSanModel khachSanModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
