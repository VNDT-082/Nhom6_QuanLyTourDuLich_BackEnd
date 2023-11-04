using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IDanhMucHinhService
    {
        public Task<List<DanhMucHinhModel>> GetAllAsync(string maTour);//lay theo ma tour
        public Task<DanhMucHinhModel> GetOneByIDAsync(string Id);
        public Task<DanhMucHinhModel> GetLastAsync();
        public Task<DanhMucHinhModel> GetLastOfTourAsync(string maTour);
        public Task<bool> AddAsync(DanhMucHinh_repo danhMucHinh_repo);
        public Task<bool> UpdateAsync(DanhMucHinhModel danhMucHinhModel);
        public Task<bool> DeleteAsync(string ID);
        public Task<bool> DeleteListAsync(string maTour);
    }
}
