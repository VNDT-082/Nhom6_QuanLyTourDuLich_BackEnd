using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ILoaiTaiKhoanRepository
    {
        public Task<List<LoaiTaiKhoanEntity>> GetAllAsync();
        public Task<LoaiTaiKhoanEntity> GetOneByIdAsync(string Id);
        //public Task<LoaiTaiKhoanEntity> GetOneByTenLoaiAsync(string tenLoai);
        public Task<LoaiTaiKhoanEntity> GetLastAsync();
        public Task<bool> AddAsync(LoaiTaiKhoanEntity loaiTaiKhoanEntity);
        public Task<bool> UpdateAsync(LoaiTaiKhoanEntity loaiTaiKhoanEntity);
        public Task<bool> DeleteAsync(LoaiTaiKhoanEntity loaiTaiKhoanEntity);
    }
}
