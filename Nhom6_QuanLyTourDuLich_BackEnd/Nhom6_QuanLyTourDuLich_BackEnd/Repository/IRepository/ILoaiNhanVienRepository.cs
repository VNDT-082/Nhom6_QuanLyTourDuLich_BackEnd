using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ILoaiNhanVienRepository
    {
        public Task<List<LoaiNhanVienEntity>> GetAllAsync();
        public Task<LoaiNhanVienEntity> GetOneByIdAsync(string Id);
        //public Task<LoaiNhanVienEntity> GetOneByTenLoaiAsync(string tenLoai);
        public Task<LoaiNhanVienEntity> GetLastAsync();
        public Task<bool> AddAsync(LoaiNhanVienEntity loaiNhanVienEntity);
        public Task<bool> UpdateAsync(LoaiNhanVienEntity loaiNhanVienEntity);
        public Task<bool> DeleteAsync(LoaiNhanVienEntity loaiNhanVienEntity);
    }
}
