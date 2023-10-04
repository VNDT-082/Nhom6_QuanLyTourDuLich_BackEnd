using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IDanhMucHinhRepository
    {
        public Task<List<DanhMucHinhEntity>> GetAllAsync();//lay theo ma tour
        public Task<DanhMucHinhEntity> GetOneByIDAsync(string Id);
        public Task<DanhMucHinhEntity> GetLastAsync();
        public Task AddAsync(DanhMucHinhEntity danhMucHinhEntity);
        public Task UpdateAsync(DanhMucHinhEntity danhMucHinhEntity);
        public Task DeleteAsync(DanhMucHinhEntity danhMucHinhEntity);
    }
}
