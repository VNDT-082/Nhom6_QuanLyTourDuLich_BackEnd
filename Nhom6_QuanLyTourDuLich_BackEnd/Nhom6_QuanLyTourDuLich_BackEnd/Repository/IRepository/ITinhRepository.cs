using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ITinhRepository
    {
        public Task<List<TinhEntity>> GetAllAsync();
        public Task<TinhEntity> GetOneByIDAsync(string Id);
        public Task<TinhEntity> GetLastAsync();
        public Task AddAsync(TinhEntity tinhEntity);
        public Task UpdateAsync(TinhEntity tinhEntity);
        public Task DeleteAsync(TinhEntity tinhEntity);
    }
}
