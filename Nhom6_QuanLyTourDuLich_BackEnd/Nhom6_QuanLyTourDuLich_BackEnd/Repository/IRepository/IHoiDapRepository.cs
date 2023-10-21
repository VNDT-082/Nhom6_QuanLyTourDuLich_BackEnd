using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IHoiDapRepository
    {
        public Task<List<HoiDapEntity>> GetAllAsync(string IdTour);
        public Task<HoiDapEntity> GetOneByIDAsync(string Id);
        //public Task<HoiDapEntity> GetLastAsync();
        public Task<bool> AddAsync(HoiDapEntity _HoiDapEntity);
        public Task<bool> UpdateAsync(HoiDapEntity _HoiDapEntity);
        public Task<bool> DeleteAsync(HoiDapEntity _HoiDapEntity);
        public Task<bool> Clear(string IdTour);
    }
}
