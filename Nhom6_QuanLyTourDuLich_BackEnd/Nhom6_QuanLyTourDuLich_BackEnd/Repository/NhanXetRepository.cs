using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class NhanXetRepository:INhanXetRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public NhanXetRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(NhanXetEntity _NhanXetEntity)
        {
            try
            {
                await _DBContext.NhanXets.AddAsync(_NhanXetEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }

        public async Task<bool> Clear(string IdTour)
        {
            try {
                var listNhanXet = await _DBContext.NhanXets.Where(i => i.IdTour == IdTour).ToListAsync();
                if (listNhanXet != null)
                {
                    _DBContext.NhanXets.RemoveRange(listNhanXet);
                    _DBContext.SaveChanges();
                    return true;
                }
                return false;
            }catch (Exception ex) { Console.WriteLine(ex.ToString());return false; }
        }

        public async Task<bool> DeleteAsync(NhanXetEntity _NhanXetEntity)
        {
            try
            {
                var NhanXetEntity_ = await _DBContext.NhanXets.FirstOrDefaultAsync(i => i.IdNhanXet==_NhanXetEntity.IdNhanXet);
                if (NhanXetEntity_ != null)
                {
                    _DBContext.NhanXets.Remove(NhanXetEntity_);
                    await _DBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }

        public async Task<List<NhanXetEntity>> GetAllAsync(string IdTour)
        {
            var list = await _DBContext.NhanXets.Where(i=>i.IdTour==IdTour).ToListAsync();
            return list;
        }

        //public async Task<NhanXetEntity> GetLastAsync()
        //{
        //    var NhanXet = await _DBContext.NhanXets.AsNoTracking().OrderBy(i => i.IdNhanXet).LastAsync();
        //    return NhanXet;
        //}

        public async Task<NhanXetEntity> GetOneByIDAsync(string Id)
        {
            var NhanXet_ = await _DBContext.NhanXets.AsNoTracking().FirstOrDefaultAsync(i => i.IdNhanXet == Id);
            return NhanXet_;
        }

        public async Task<bool> UpdateAsync(NhanXetEntity _NhanXetEntity)
        {
            try
            {
                var NhanXetEntity_ = _DBContext.NhanXets.FirstOrDefaultAsync(i => i.IdNhanXet == _NhanXetEntity.IdNhanXet);
                if(NhanXetEntity_ != null)
                {
                    _DBContext.NhanXets!.Update(_NhanXetEntity);
                    await _DBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }
    }
}
