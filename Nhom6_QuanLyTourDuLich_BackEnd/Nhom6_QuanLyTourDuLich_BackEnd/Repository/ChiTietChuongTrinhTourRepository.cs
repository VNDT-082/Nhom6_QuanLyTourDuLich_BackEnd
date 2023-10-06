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
                await _DBContext.ChiTietChuongTrinhTours.AddAsync(chiTietChuongTrinhTourEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity)
        {
            throw new NotImplementedException();
        }

        //public async Task<List<ChiTietChuongTrinhTourEntity>> GetAllAsync()
        //{
        //    var list = await _DBContext.ChiTietChuongTrinhTours.OrderBy(i => i.Id).ToListAsync();
        //    return list;
        //}

        public async Task<ChiTietChuongTrinhTourEntity> GetLastAsync()
        {
            var ct = await _DBContext.ChiTietChuongTrinhTours.OrderBy(i => i.Id).LastAsync();
            return ct;
        }

        public async Task<ChiTietChuongTrinhTourEntity> GetLastOfTourAsync(string maTour)
        {
            var ct = await _DBContext.ChiTietChuongTrinhTours.Where(i=>i.maTour==maTour).OrderBy(i => i.Id).LastAsync();
            return ct;
        }

        public async Task<List<ChiTietChuongTrinhTourEntity>> GetListByTourId(string maTour)
        {
            var list = await _DBContext.ChiTietChuongTrinhTours.Where(i=>i.maTour==maTour).OrderBy(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<ChiTietChuongTrinhTourEntity> GetOneByIDAsync(string Id)
        {
            var ct = await _DBContext.ChiTietChuongTrinhTours.FirstOrDefaultAsync(i =>i.Id==Id);
            return ct;
        }

        public async Task<bool> UpdateAsync(ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity)
        {
            try
            {
                _DBContext.ChiTietChuongTrinhTours!.Update(chiTietChuongTrinhTourEntity);
                _DBContext.Entry(chiTietChuongTrinhTourEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
