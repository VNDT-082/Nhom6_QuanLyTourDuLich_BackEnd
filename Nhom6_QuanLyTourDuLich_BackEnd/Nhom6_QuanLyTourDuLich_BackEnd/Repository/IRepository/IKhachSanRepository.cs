using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IKhachSanRepository
    {
        public Task<List<KhachSanEntity>> GetAllAsync();
        public Task<List<KhachSanEntity>> GetListByHangSao(string hangSao);
        public Task<KhachSanEntity> GetOneByXaIdAsync(string xaId);
        public Task<KhachSanEntity> GetLastAsync();
        public Task AddAsync(KhachSanEntity khachSanEntity);
        public Task UpdateAsync(KhachSanEntity khachSanEntity);
        public Task DeleteAsync(KhachSanEntity khachSanEntity);
    }
}
