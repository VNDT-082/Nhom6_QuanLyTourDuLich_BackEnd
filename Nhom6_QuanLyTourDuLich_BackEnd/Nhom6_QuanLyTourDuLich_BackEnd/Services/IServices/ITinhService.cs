using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ITinhService
    {
        public Task<bool> AddAsync(Tinh_repo tinhRepo);
        public Task<bool> UpdateAsync(TinhModel tinhModel);
        public Task<bool> DeleteAsync(string ID);
        public Task<List<TinhModel>> GetAll();
    }
}
