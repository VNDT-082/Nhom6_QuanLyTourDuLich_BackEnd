using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IKhachSanRepository
    {
        public Task<List<KhachSanEntity>> GetAllAsync();
        public Task<List<KhachSanEntity>> GetListByHangSao(string hangSao);
        public Task<KhachSanEntity> GetLastAsync();
        public Task<bool> AddAsync(KhachSanEntity khachSanEntity);
        public Task<bool> UpdateAsync(KhachSanEntity khachSanEntity);
        public Task<bool> DeleteAsync(KhachSanEntity khachSanEntity);
    }
}
