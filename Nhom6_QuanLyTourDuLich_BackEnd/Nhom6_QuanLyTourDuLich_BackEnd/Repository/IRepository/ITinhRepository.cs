using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ITinhRepository
    {
        public Task<List<TinhEntity>> GetAllAsync();
        public Task<TinhEntity> GetOneByIDAsync(string Id);
        public Task<TinhEntity> GetLastAsync();
        public Task<bool> AddAsync(TinhEntity tinhEntity);
        public Task<bool> UpdateAsync(TinhEntity tinhEntity);
        public Task<bool> DeleteAsync(TinhEntity tinhEntity);
    }
}
