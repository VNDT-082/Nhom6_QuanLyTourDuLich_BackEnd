using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ITraLoiHoiDapRepository
    {
        public Task<List<TraLoiHoiDapEntity>> GetAllAsync(string IdHoiDap);
        public Task<TraLoiHoiDapEntity> GetOneByIDAsync(string Id);
        //public Task<TraLoiHoiDapEntity> GetLastAsync();
        public Task<bool> AddAsync(TraLoiHoiDapEntity _TraLoiHoiDapEntity);
        public Task<bool> UpdateAsync(TraLoiHoiDapEntity _TraLoiHoiDapEntity);
        public Task<bool> DeleteAsync(TraLoiHoiDapEntity _TraLoiHoiDapEntity);
        public Task<bool> Clear(string IdHoiDap);
    }
}
