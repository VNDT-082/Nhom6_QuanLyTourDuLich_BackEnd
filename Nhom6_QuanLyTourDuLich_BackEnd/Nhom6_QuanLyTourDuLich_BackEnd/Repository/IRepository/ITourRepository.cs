using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ITourRepository
    {
        public Task<int> Count();
        public Task<List<TourEntity>> GetAllAsync();
        public Task<List<TourEntity>> GetAllAsync(bool trangThai);
        public Task<List<TourEntity>> GetPage(byte pageSize, int pageNumber);
        public Task<List<TourEntity>> GetPage(byte pageSize, int pageNumber, bool trangThai);
        public Task<List<TourEntity>> GetListTheoLoai(string maLoai);
        public Task<List<TourEntity>> GetListTheoTen(string tenTour);
        public Task<List<TourEntity>> GetListTheoLoai(string maLoai, bool trangThai);
        public Task<List<TourEntity>> GetListTheoGia(double giaMin, double giaMax);
        public Task<List<TourEntity>> GetListTheoNguoiLap(string maNhanVien);
        //public Task<List<TourEntity>> GetListTheoKhoangThoiGian(DateTime ngayBatDau, DateTime ngayKetThuc);//doi chieu vao chuong trinh tour
        //public Task<List<TourEntity>> GetListTheoNgay(DateTime ngayBatDau);//ngay dau tien cua chuong trinh tour
        public Task<TourEntity> GetOneByIDAsync(string Id);
        public Task<TourEntity> GetLastAsync();
        public Task<bool> AddAsync(TourEntity tourEntity);
        public Task<bool> UpdateAsync(TourEntity tourEntity);
        public Task<bool> DeleteAsync(TourEntity tourEntity);

        public Task<bool> KichHoatTourAsync(TourEntity tourEntity);
    }
}
