using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ITourService
    {
        public Task<int> Count();
        public Task<List<TourModel>> GetAllAsync();
        public Task<List<TourModel>> GetAllAsync(bool trangThai);
        public Task<List<TourModel>> GetPage(byte pageSize, int pageNumber);
        public Task<List<TourModel>> GetPage(byte pageSize, int pageNumber, bool trangThai);
        public Task<List<TourModel>> GetListTheoLoai(string maLoai);
        public Task<List<TourModel>> GetListTheoLoai(string maLoai, bool trangThai);
        public Task<List<TourModel>> GetListTheoGia(double giaMin, double giaMax);
        public Task<List<TourModel>> GetListTheoNguoiLap(string maNhanVien);
        public Task<TourModel> GetOneByIDAsync(string Id);
        public Task<TourModel> GetLastAsync();
        public Task<bool> AddAsync(Tour_repo tourRepo);
        public Task<bool> UpdateAsync(TourModel tourModel);
        public Task<bool> DeleteAsync(string ID);

    }
}
