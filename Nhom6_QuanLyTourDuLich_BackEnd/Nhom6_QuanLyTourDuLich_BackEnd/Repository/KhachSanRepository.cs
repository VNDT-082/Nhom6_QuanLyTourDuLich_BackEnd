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

        public async Task<bool> AddAsync(KhachSanEntity khachSanEntity)
        {
            try
            {
                await _DBContext.KhachSans.AddAsync(khachSanEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }

        public async Task<bool> DeleteAsync(KhachSanEntity khachSanEntity)
        {
            try
            {
                var listCTT = _DBContext.ChiTietChuongTrinhTours.AsNoTracking()
                    .Where(i => i.maKhachSan == khachSanEntity.IdKhachSan).ToList();
                if (listCTT != null)
                {
                    ChiTietChuongTrinhTourRepository chiTietChuongTrinhTourRepository =
                        new ChiTietChuongTrinhTourRepository(this._DBContext);
                    foreach (var item in listCTT)
                    {
                        item.maKhachSan = null;
                        chiTietChuongTrinhTourRepository.UpdateAsync(item);
                    }
                    
                }
                var listTour = _DBContext.Tours.AsNoTracking()
                    .Where(i => i.maKhachSan == khachSanEntity.IdKhachSan).ToList();
                if (listTour != null || listTour.Count > 0)
                {
                    TourRepository tourRepository=new TourRepository(this._DBContext);  
                    foreach (var item in listTour)
                    {
                        item.maKhachSan = null;
                        tourRepository.UpdateAsync(item);
                    }
                }
                _DBContext.KhachSans.Remove(khachSanEntity);
                _DBContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public async Task<List<KhachSanEntity>> GetAllAsync()
        {
            var list = await _DBContext.KhachSans.AsNoTracking().OrderByDescending(i => i.IdKhachSan).ToListAsync();
            return list;
        }

        public async Task<KhachSanEntity> GetLastAsync()
        {
            var khachSan = await _DBContext.KhachSans.AsNoTracking().OrderBy(i=>i.IdKhachSan).LastAsync();
            return khachSan;
        }

        public async Task<List<KhachSanEntity>> GetListByHangSao(string hangSao)
        {
            var list = await _DBContext.KhachSans.AsNoTracking().Where(i=>i.hangSao==hangSao).OrderByDescending(i => i.IdKhachSan).ToListAsync();
            return list;
        }

        //public async Task<List<KhachSanEntity>> GetListByXaIdAsync(string maXa)
        //{
        //    var list = await _DBContext.KhachSans.Where(i => i.IdKhachSan_Xa == maXa).OrderByDescending(i => i.IdKhachSan).ToListAsync();
        //    return list;
        //}

        public async Task<KhachSanEntity> GetOneById(string maKhachSan)
        {
            var khachSan = await _DBContext.KhachSans.AsNoTracking().FirstOrDefaultAsync(i => i.IdKhachSan == maKhachSan);
            return khachSan;
        }

        public async Task<bool> UpdateAsync(KhachSanEntity khachSanEntity)
        {
            try
            {
                _DBContext.KhachSans!.Update(khachSanEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }
    }
}
