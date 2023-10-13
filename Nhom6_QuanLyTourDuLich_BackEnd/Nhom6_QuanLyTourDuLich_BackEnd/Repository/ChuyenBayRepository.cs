using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class ChuyenBayRepository:IChuyenBayRepository
    {

        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public ChuyenBayRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(ChuyenBayEntity chuyenBayEntity)
        {
            try
            {
                await _DBContext.ChuyenBays.AddAsync(chuyenBayEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(ChuyenBayEntity chuyenBayEntity)
        {
            try
            {
                var listChuyenBay = _DBContext.ChuyenBays.AsNoTracking()
                    .Where(i => i.IdChuyenBay == chuyenBayEntity.IdChuyenBay || i.maChuyenVe == chuyenBayEntity.IdChuyenBay)
                    .ToList();
                bool Flag = false;
                if (listChuyenBay != null)
                {
                    foreach (var item in listChuyenBay)
                    {
                        if (item.IdChuyenBay == chuyenBayEntity.IdChuyenBay)
                        {
                            Flag = await UpdateAsync(item);
                        }
                    }
                }
                var listTour = _DBContext.Tours.AsNoTracking().Where(i => i.maChuyenBay == chuyenBayEntity.IdChuyenBay).ToList();
                if (listTour != null)
                {
                    TourRepository tourRepository = new TourRepository(this._DBContext);
                    foreach (var item in listTour)
                    {
                        item.maChuyenBay = null;
                        Flag = await tourRepository.UpdateAsync(item);
                    }
                }
                if (Flag == true)
                {
                    _DBContext.ChuyenBays.Remove(chuyenBayEntity);
                    _DBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        public async Task<List<ChuyenBayEntity>> GetAllAsync()
        {
            var list = await _DBContext.ChuyenBays.AsNoTracking().OrderBy(i => i.IdChuyenBay).ToListAsync();
            return list;
        }

        public async Task<ChuyenBayEntity> GetLastAsync()
        {
            var chuyenBay = await _DBContext.ChuyenBays.AsNoTracking().OrderBy(i => i.IdChuyenBay).LastAsync();
            return chuyenBay;
        }

        public async Task<List<ChuyenBayEntity>> GetListKhuHoi(bool khuHoi)
        {
            var list = await _DBContext.ChuyenBays.AsNoTracking().Where(i => i.khuHoi == khuHoi).ToListAsync();
            return list;
        }

        public async Task<List<ChuyenBayEntity>> GetListNoiDen(string maSanBay)
        {
            var list = await _DBContext.ChuyenBays.AsNoTracking().Where(i => i.noiDen == maSanBay).ToListAsync();
            return list;
        }

        public async Task<List<ChuyenBayEntity>> GetListNoiDi(string maSanBay)
        {
            var list = await _DBContext.ChuyenBays.AsNoTracking().Where(i => i.noiKhoiHanh == maSanBay).ToListAsync();
            return list;
        }

        public async Task<List<ChuyenBayEntity>> GetListTheoNgay(DateTime gioDi, DateTime gioDen)
        {
            var list = await _DBContext.ChuyenBays.AsNoTracking().Where(i => i.gioKhoiHanh >= gioDi && i.gioDen <= gioDen).ToListAsync();
            return list;
        }

        public async Task<ChuyenBayEntity> GetOneByIDAsync(string Id)
        {
            var chuyenBay = await _DBContext.ChuyenBays.AsNoTracking().FirstOrDefaultAsync(i => i.IdChuyenBay == Id);
            return chuyenBay;
        }

        public async Task<bool> UpdateAsync(ChuyenBayEntity chuyenBayEntity)
        {
            try
            {
                _DBContext.ChuyenBays!.Update(chuyenBayEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
