using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IThanhVienRepository
    {
        public Task<List<ThanhVienEntity>> GetAllAsync(string datTourId);//lay theo dat tour id
        public Task<List<ThanhVienEntity>> GetAllTheoGioiTinhAsync(bool gioiTinh);
        public Task<ThanhVienEntity> GetOneByIDAsync(string Id);
        public Task<ThanhVienEntity> GetLastAsync();
        public Task<ThanhVienEntity> GetLastOfDatTourAsync(string maDatTour);
        public Task<bool> AddAsync(ThanhVienEntity thanhVienEntity);
        public Task<bool> UpdateAsync(ThanhVienEntity thanhVienEntity);
        public Task<bool> DeleteAsync(ThanhVienEntity thanhVienEntity);
    }
}
