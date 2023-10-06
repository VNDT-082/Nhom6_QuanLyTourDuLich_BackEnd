using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IChiTietChuongTrinhTourRepository
    {
        //public Task<List<ChiTietChuongTrinhTourEntity>> GetAllAsync(string maTour);
        public Task<List<ChiTietChuongTrinhTourEntity>> GetListByTourId(string maTour);
        public Task<ChiTietChuongTrinhTourEntity> GetOneByIDAsync(string Id);
        public Task<ChiTietChuongTrinhTourEntity> GetLastAsync();
        public Task<ChiTietChuongTrinhTourEntity> GetLastOfTourAsync(string maTour);
        public Task<bool> AddAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity);
        public Task<bool> UpdateAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity);
        public Task<bool> DeleteAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity);

        
    }
}
