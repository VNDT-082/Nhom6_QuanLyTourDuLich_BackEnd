using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class TinhRepository : ITinhRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public TinhRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task<bool> AddAsync(TinhEntity tinhEntity)
        {
            try
            {
                await _DBContext.Tinhs.AddAsync(tinhEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(TinhEntity tinhEntity)
        {
            try
            {
                _DBContext.Tinhs.Remove(tinhEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<List<TinhEntity>> GetAllAsync()
        {
            var list = await _DBContext.Tinhs.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<TinhEntity> GetLastAsync()
        {
            var tinh = await _DBContext.Tinhs.OrderBy(i => i.Id).LastOrDefaultAsync();
            return tinh;
        }

        public async Task<TinhEntity> GetOneByIDAsync(string Id)
        {
            var tinh = await _DBContext.Tinhs.FirstOrDefaultAsync(i => i.Id == Id);
            return tinh;
        }

        public async Task<bool> UpdateAsync(TinhEntity tinhEntity)
        {
            try
            {
                _DBContext.Tinhs!.Update(tinhEntity);
                _DBContext.Entry(tinhEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
