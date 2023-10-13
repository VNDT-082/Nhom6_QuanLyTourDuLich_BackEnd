using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IKhachSanService
    {
        public Task<List<KhachSanModel>> GetAllAsync();
        public Task<List<KhachSanModel>> GetListByHangSao(string hangSao);
        //public Task<List<KhachSanModel>> GetListByXaIdAsync(string xaId);
        public Task<KhachSanModel> GetLastAsync();
        public Task<KhachSanModel> GetOneById(string maKhachSan);
        public Task<bool> AddAsync(KhachSan_repo khachSan_repo);
        public Task<bool> UpdateAsync(KhachSanModel khachSanModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
