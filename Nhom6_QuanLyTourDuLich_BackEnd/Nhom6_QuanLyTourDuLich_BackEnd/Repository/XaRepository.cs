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
        public async Task AddAsync(XaEntity xaEntity)
        {
            await _DBContext.Xas.AddAsync(xaEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(XaEntity xaEntity)
        {
            _DBContext.Xas.Remove(xaEntity);
            await _DBContext.SaveChangesAsync();
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

        public async Task UpdateAsync(XaEntity xaEntity)
        {
            _DBContext.Xas!.Update(xaEntity);
            _DBContext.Entry(xaEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }
    }
}
