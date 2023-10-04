using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ISanBayRepository
    {
        public Task<List<SanBayEntity>> GetAllAsync();
        public Task<SanBayEntity> GetOneByIDAsync(string Id);
        public Task<SanBayEntity> GetLastAsync();
        public Task AddAsync(SanBayEntity sanBayEntity);
        public Task UpdateAsync(SanBayEntity sanBayEntity);
        public Task DeleteAsync(SanBayEntity sanBayEntity);
    }
}
