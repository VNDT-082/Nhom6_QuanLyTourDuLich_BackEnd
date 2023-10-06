using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ISanBayRepository
    {
        public Task<List<SanBayEntity>> GetAllAsync();
        public Task<SanBayEntity> GetOneByIDAsync(string Id);
        public Task<SanBayEntity> GetLastAsync();
        public Task<bool> AddAsync(SanBayEntity sanBayEntity);
        public Task<bool> UpdateAsync(SanBayEntity sanBayEntity);
        public Task<bool> DeleteAsync(SanBayEntity sanBayEntity);
    }
}
