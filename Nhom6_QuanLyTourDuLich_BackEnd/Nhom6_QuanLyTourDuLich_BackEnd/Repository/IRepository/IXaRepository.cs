using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IXaRepository
    {
        public Task<List<XaEntity>> GetAllAsync();
        public Task<List<XaEntity>> GetListByHuyenId(string maHuyen);
        public Task<XaEntity> GetOneByIDAsync(string Id);
        public Task<XaEntity> GetLastAsync();
        public Task<bool> AddAsync(XaEntity xaEntity);
        public Task<bool> UpdateAsync(XaEntity xaEntity);
        public Task<bool> DeleteAsync(XaEntity xaEntity);
    }
}
