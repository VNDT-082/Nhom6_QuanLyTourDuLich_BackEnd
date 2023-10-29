using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IDatTourRepository
    {
        public Task<List<DatTourEntity>> GetAllAsync();
        public Task<List<DatTourEntity>> GetAllAsync(bool trangThai);
        public Task<List<DatTourEntity>> GetListByKhachHangIdAsync(string maKhach);
        public Task<List<DatTourEntity>> GetListByTourIdAsync(string maTour);
        public Task<List<DatTourEntity>> GetListByTourIdAsync(string maTour, bool trangThai);
        public Task<List<DatTourEntity>> GetListByHuongDanVienIdAsync(string? maHuongDanVien);
        public Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax);
        public Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayDat);
        public Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax, bool trangThai);
        public Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayDat, bool trangThai);

       
        public Task<DatTourEntity> getThanhToanAsync(string Id);
        public Task<DatTourEntity> GetOneByIDAsync(string Id);
        public Task<DatTourEntity> GetLastAsync();
        public Task<DatTourEntity> AddAsync(DatTourEntity datTourEntity);
        public Task<DatTourEntity> UpdateAsync(DatTourEntity datTourEntity);
        public Task<bool> DeleteAsync(DatTourEntity datTourEntity);
    }
}
