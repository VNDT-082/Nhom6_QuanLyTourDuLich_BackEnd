using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface INhanVienRepository
    {
        public Task<List<NhanVienEntity>> GetAllAsync();
        public Task<List<NhanVienEntity>> GetListByLoaiNhanVienIdAsync(string maLoaiNhanVien);
        public Task<NhanVienEntity> GetOneByIDAsync(string Id);
        public Task<NhanVienEntity> GetOneByCCCDAsync(string canCuocConDan);
        public Task<NhanVienEntity> GetLastAsync();
        public Task<NhanVienEntity> AddAsync(NhanVienEntity nhanVienEntity);
        public Task<NhanVienEntity> UpdateAsync(NhanVienEntity nhanVienEntity);
        public Task<bool> DeleteAsync(NhanVienEntity nhanVienEntity);
    }
}
