using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IThanhVienService
    {
        public Task<List<ThanhVienModel>> GetAllAsync(string datTourId);//lay theo dat tour id
        public Task<List<ThanhVienModel>> GetAllTheoGioiTinhAsync(bool gioiTinh);
        public Task<ThanhVienModel> GetOneByIDAsync(string Id);
        public Task<ThanhVienModel> GetLastAsync();
        public Task<ThanhVienModel> GetLastOfDatTourAsync(string maDatTour);
        public Task<bool> AddAsync(ThanhVien_repo thanhVien_repo);
        public Task<bool> UpdateAsync(ThanhVienModel thanhVienModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
