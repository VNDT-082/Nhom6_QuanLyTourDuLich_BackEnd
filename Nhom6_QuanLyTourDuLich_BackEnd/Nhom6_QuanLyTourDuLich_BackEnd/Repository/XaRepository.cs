using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class XaRepository : IXaRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public XaRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task<bool> AddAsync(XaEntity xaEntity)
        {
            try
            {
                await _DBContext.Xas.AddAsync(xaEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(XaEntity xaEntity)
        {
            try
            {
                _DBContext.Xas.Remove(xaEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<List<XaEntity>> GetAllAsync()
        {
            List<XaEntity> list = await _DBContext.Xas.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<XaEntity> GetLastAsync()
        {
            var xa = await _DBContext.Xas.OrderBy(i => i.Id).LastOrDefaultAsync();
            return xa;
        }

        public async Task<List<XaEntity>> GetListByHuyenId(string maHuyen)
        {
            List<XaEntity> list = await _DBContext.Xas.Where(i => i.maHuyen == maHuyen).ToListAsync();
            return list;
        }

        public async Task<XaEntity> GetOneByIDAsync(string Id)
        {
            var xa = await _DBContext.Xas.FirstOrDefaultAsync(i => i.Id == Id);
            return xa;
        }

        public async Task<bool> UpdateAsync(XaEntity xaEntity)
        {
            try
            {
                _DBContext.Xas!.Update(xaEntity);
                _DBContext.Entry(xaEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
