using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IDanhMucHinhRepository
    {
        public Task<List<DanhMucHinhEntity>> GetAllAsync(string maTour);//lay theo ma tour
        public Task<DanhMucHinhEntity> GetOneByIDAsync(string Id);
        public Task<DanhMucHinhEntity> GetLastAsync();
        public Task<DanhMucHinhEntity> GetLastOfTourAsync(string maTour);
        public Task<bool> AddAsync(DanhMucHinhEntity danhMucHinhEntity);
        public Task<bool> UpdateAsync(DanhMucHinhEntity danhMucHinhEntity);
        public Task<bool> DeleteAsync(DanhMucHinhEntity danhMucHinhEntity);
    }
}
