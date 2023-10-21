using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface INhanXetRepository
    {
        public Task<List<NhanXetEntity>> GetAllAsync(string IdTour);
        public Task<NhanXetEntity> GetOneByIDAsync(string Id);
        //public Task<NhanXetEntity> GetLastAsync();
        public Task<bool> AddAsync(NhanXetEntity _NhanXetEntity);
        public Task<bool> UpdateAsync(NhanXetEntity _NhanXetEntity);
        public Task<bool> DeleteAsync(NhanXetEntity _NhanXetEntity);
        public Task<bool> Clear(string IdTour);
    }
}
