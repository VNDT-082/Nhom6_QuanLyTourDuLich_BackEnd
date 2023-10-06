using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ISanBayService
    {
        public Task<List<SanBayModel>> GetAllAsync();
        public Task<SanBayModel> GetOneByIDAsync(string Id);
        public Task<SanBayModel> GetLastAsync();
        public Task<bool> AddAsync(SanBay_repo sanBay_repo);
        public Task<bool> UpdateAsync(SanBayModel sanBayModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
