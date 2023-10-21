using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class TraLoiHoiDapRepository:ITraLoiHoiDapRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public TraLoiHoiDapRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(TraLoiHoiDapEntity _TraLoiHoiDapEntity)
        {
            try
            {
                await _DBContext.TraLoiHoiDaps.AddAsync(_TraLoiHoiDapEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }

        public async Task<bool> Clear(string IdHoiDap)
        {
            try
            {
                var listTraLoiHoiDap = await _DBContext.TraLoiHoiDaps.Where(i => i.IdHoiDap == IdHoiDap).ToListAsync();
                if (listTraLoiHoiDap != null)
                {
                    _DBContext.TraLoiHoiDaps.RemoveRange(listTraLoiHoiDap);
                    _DBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return false; }
        }

        public async Task<bool> DeleteAsync(TraLoiHoiDapEntity _TraLoiHoiDapEntity)
        {
            try
            {
                var TraLoiHoiDapEntity_ = await _DBContext.TraLoiHoiDaps.FirstOrDefaultAsync(i => i.IdTraLoiHoiDap == _TraLoiHoiDapEntity.IdTraLoiHoiDap);
                if (TraLoiHoiDapEntity_ != null)
                {
                    _DBContext.TraLoiHoiDaps.Remove(TraLoiHoiDapEntity_);
                    await _DBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }

        public async Task<List<TraLoiHoiDapEntity>> GetAllAsync(string IdHoiDap)
        {
            var list = await _DBContext.TraLoiHoiDaps.Where(i => i.IdHoiDap == IdHoiDap).ToListAsync();
            return list;
        }

        //public async Task<TraLoiHoiDapEntity> GetLastAsync()
        //{
        //    var TraLoiHoiDap = await _DBContext.TraLoiHoiDaps.AsNoTracking().OrderBy(i => i.IdTraLoiHoiDap).LastAsync();
        //    return TraLoiHoiDap;
        //}

        public async Task<TraLoiHoiDapEntity> GetOneByIDAsync(string Id)
        {
            var TraLoiHoiDap_ = await _DBContext.TraLoiHoiDaps.AsNoTracking().FirstOrDefaultAsync(i => i.IdTraLoiHoiDap == Id);
            return TraLoiHoiDap_;
        }

        public async Task<bool> UpdateAsync(TraLoiHoiDapEntity _TraLoiHoiDapEntity)
        {
            try
            {
                var TraLoiHoiDapEntity_ = _DBContext.TraLoiHoiDaps.FirstOrDefaultAsync(i => i.IdTraLoiHoiDap == _TraLoiHoiDapEntity.IdTraLoiHoiDap);
                if (TraLoiHoiDapEntity_ != null)
                {
                    _DBContext.TraLoiHoiDaps!.Update(_TraLoiHoiDapEntity);
                    await _DBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }
    }
}
