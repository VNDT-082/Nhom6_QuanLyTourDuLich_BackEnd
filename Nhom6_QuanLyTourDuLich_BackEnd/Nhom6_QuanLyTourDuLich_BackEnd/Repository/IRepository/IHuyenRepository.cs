using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IHuyenRepository
    {
        public Task<List<HuyenEntity>> GetAllAsync();
        public Task<List<HuyenEntity>> GetListByTinhIdAsync(string maTinh);
        public Task<HuyenEntity> GetOneByIDAsync(string Id);
        public Task<HuyenEntity> GetLastAsync();
        public Task<bool> AddAsync(HuyenEntity huyenEntity);
        public Task<bool> UpdateAsync(HuyenEntity huyenEntity);
        public Task<bool> DeleteAsync(HuyenEntity huyenEntity);
    }
}
