using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IDatTourService
    {
        public Task<List<DatTourModel>> GetAllAsync();
        public Task<List<DatTourModel>> GetAllAsync(bool trangThai);
        public Task<List<DatTourModel>> GetListByKhachHangIdAsync(string maKhach);
        public Task<List<DatTourModel>> GetListByTourIdAsync(string maTour);
        public Task<List<DatTourModel>> GetListByTourIdAsync(string maTour, bool trangThai);
        public Task<List<DatTourModel>> GetListByHuongDanVienIdAsync(string? maHuongDanVien);
        public Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax);
        public Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayDat);
        public Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax, bool trangThai);
        public Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayDat, bool trangThai);

        public Task<DatTourModel> GetOneByIDAsync(string Id);
        public Task<DatTourModel> GetLastAsync();
        public Task<bool> AddAsync(DatTour_repo datTour_repo);
        public Task<bool> UpdateAsync(DatTourModel datTourModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
