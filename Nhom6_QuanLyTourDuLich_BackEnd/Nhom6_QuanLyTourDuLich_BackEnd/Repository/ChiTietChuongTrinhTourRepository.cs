using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class ChiTietChuongTrinhTourRepository:IChiTietChuongTrinhTourRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public ChiTietChuongTrinhTourRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity)
        {
            try
            {
                var sl = _DBContext.ChiTietChuongTrinhTours.Where(i => i.maTour == chiTietChuongTrinhTourEntity.maTour).ToList().Count();
                if (sl != null)
                {
                    chiTietChuongTrinhTourEntity.ngayThu = "Ngày" + ++sl;
                }
                else
                    chiTietChuongTrinhTourEntity.ngayThu = "Ngày 1";
                await _DBContext.ChiTietChuongTrinhTours.AddAsync(chiTietChuongTrinhTourEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity)
        {
            try {
                _DBContext.ChiTietChuongTrinhTours.Remove(chiTietChuongTrinhTourEntity);
                _DBContext.SaveChanges();
                return true;
            }catch (Exception ex) { Console.WriteLine(ex.ToString()); return false; }
        }

        //public async Task<List<ChiTietChuongTrinhTourEntity>> GetAllAsync()
        //{
        //    var list = await _DBContext.ChiTietChuongTrinhTours.OrderBy(i => i.IdChiTietChuongTrinhTour).ToListAsync();
        //    return list;
        //}

        public async Task<ChiTietChuongTrinhTourEntity> GetLastAsync()
        {
            var ct = await _DBContext.ChiTietChuongTrinhTours.AsNoTracking()
                .OrderBy(i => i.IdChiTietChuongTrinhTour).LastAsync();
            return ct;
        }

        public async Task<ChiTietChuongTrinhTourEntity> GetLastOfTourAsync(string maTour)
        {
            var ct = await _DBContext.ChiTietChuongTrinhTours.AsNoTracking()
                .Where(i=>i.maTour==maTour).OrderBy(i => i.IdChiTietChuongTrinhTour).LastAsync();
            return ct;
        }

        public async Task<List<ChiTietChuongTrinhTourEntity>> GetListByTourId(string maTour)
        {
            var list = await _DBContext.ChiTietChuongTrinhTours.AsNoTracking()
                .Where(i=>i.maTour==maTour).OrderBy(i => i.IdChiTietChuongTrinhTour).ToListAsync();
            return list;
        }

        public async Task<ChiTietChuongTrinhTourEntity> GetOneByIDAsync(string IdChiTietChuongTrinhTour)
        {
            var ct = await _DBContext.ChiTietChuongTrinhTours.AsNoTracking()
                .FirstOrDefaultAsync(i =>i.IdChiTietChuongTrinhTour==IdChiTietChuongTrinhTour);
            return ct;
        }

        public async Task<bool> UpdateAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity)
        {
            try
            {
                _DBContext.ChiTietChuongTrinhTours!.Update(chiTietChuongTrinhTourEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
