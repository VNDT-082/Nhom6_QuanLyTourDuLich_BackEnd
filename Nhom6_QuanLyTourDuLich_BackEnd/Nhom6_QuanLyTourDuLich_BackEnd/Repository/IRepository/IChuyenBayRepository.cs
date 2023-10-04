using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IChuyenBayRepository
    {
        public Task<List<ChuyenBayEntity>> GetAllAsync();
        public Task<List<ChuyenBayEntity>> GetListNoiDi(string maSanBay);
        public Task<List<ChuyenBayEntity>> GetListNoiDen(string maSanBay);
        public Task<List<ChuyenBayEntity>> GetListTheoNgay(DateTime gioDi, DateTime gioDen);//da co ngay kem theo
        public Task<List<ChuyenBayEntity>> GetListKhuHoi(bool khuHoi);
        public Task<ChuyenBayEntity> GetOneByIDAsync(string Id);
        public Task<ChuyenBayEntity> GetLastAsync();
        public Task AddAsync(ChuyenBayEntity chuyenBayEntity);
        public Task UpdateAsync(ChuyenBayEntity chuyenBayEntity);
        public Task DeleteAsync(ChuyenBayEntity chuyenBayEntity);
    }
}
