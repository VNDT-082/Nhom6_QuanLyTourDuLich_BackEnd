using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IXaRepository
    {
        public Task<List<XaEntity>> GetAllAsync();
        public Task<List<XaEntity>> GetListByHuyenId(string maHuyen);
        public Task<XaEntity> GetOneByIDAsync(string Id);
        public Task<XaEntity> GetLastAsync();
        public Task AddAsync(XaEntity xaEntity);
        public Task UpdateAsync(XaEntity xaEntity);
        public Task DeleteAsync(XaEntity xaEntity);
    }
}
