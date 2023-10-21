using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class HoiDapRepository:IHoiDapRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public HoiDapRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(HoiDapEntity _HoiDapEntity)
        {
            try
            {
                await _DBContext.HoiDaps.AddAsync(_HoiDapEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }

        public async Task<bool> Clear(string IdTour)
        {
            try
            {
                var listHoiDap = await _DBContext.HoiDaps.Where(i => i.IdTour == IdTour).ToListAsync();
                if (listHoiDap != null)
                {
                    _DBContext.HoiDaps.RemoveRange(listHoiDap);
                    _DBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return false; }
        }

        public async Task<bool> DeleteAsync(HoiDapEntity _HoiDapEntity)
        {
            try
            {
                var HoiDapEntity_ = await _DBContext.HoiDaps.FirstOrDefaultAsync(i => i.IdHoiDap == _HoiDapEntity.IdHoiDap);
                if (HoiDapEntity_ != null)
                {
                    _DBContext.HoiDaps.Remove(HoiDapEntity_);
                    await _DBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }

        public async Task<List<HoiDapEntity>> GetAllAsync(string IdTour)
        {
            var list = await _DBContext.HoiDaps.Where(i => i.IdTour == IdTour).ToListAsync();
            if (list != null)
            {
                foreach (var item in list)
                {
                    var listTraLoiHoiDap = await _DBContext.TraLoiHoiDaps.Where(i => i.IdHoiDap == item.IdHoiDap).ToListAsync();
                    if (listTraLoiHoiDap != null)
                        item.danhSachCauTraLoi = listTraLoiHoiDap;
                }
            }
            return list;
        }

        //public async Task<HoiDapEntity> GetLastAsync()
        //{
        //    var HoiDap = await _DBContext.HoiDaps.AsNoTracking().OrderBy(i => i.IdHoiDap).LastAsync();
        //    return HoiDap;
        //}

        public async Task<HoiDapEntity> GetOneByIDAsync(string Id)
        {
            var HoiDap_ = await _DBContext.HoiDaps.AsNoTracking().FirstOrDefaultAsync(i => i.IdHoiDap == Id);
            if (HoiDap_ != null)
            {
                var listTraLoiHoiDap = await _DBContext.TraLoiHoiDaps.Where(i => i.IdHoiDap == HoiDap_.IdHoiDap).ToListAsync();
                if (listTraLoiHoiDap != null)
                    HoiDap_.danhSachCauTraLoi = listTraLoiHoiDap;
            }
            
            return HoiDap_;
        }

        public async Task<bool> UpdateAsync(HoiDapEntity _HoiDapEntity)
        {
            try
            {
                var HoiDapEntity_ = _DBContext.HoiDaps.FirstOrDefaultAsync(i => i.IdHoiDap == _HoiDapEntity.IdHoiDap);
                if (HoiDapEntity_ != null)
                {
                    _DBContext.HoiDaps!.Update(_HoiDapEntity);
                    await _DBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }
    }
}
