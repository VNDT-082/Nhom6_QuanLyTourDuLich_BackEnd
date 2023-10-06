using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class KhachSanRepository:IKhachSanRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public KhachSanRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public Task<bool> AddAsync(KhachSanEntity khachSanEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(KhachSanEntity khachSanEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<KhachSanEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<KhachSanEntity> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<KhachSanEntity>> GetListByHangSao(string hangSao)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(KhachSanEntity khachSanEntity)
        {
            try
            {
                _DBContext.KhachSans!.Update(khachSanEntity);
                _DBContext.Entry(khachSanEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }
    }
}
