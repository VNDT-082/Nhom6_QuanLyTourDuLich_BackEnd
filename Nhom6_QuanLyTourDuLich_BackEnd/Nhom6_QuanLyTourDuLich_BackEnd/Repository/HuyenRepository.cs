using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class HuyenRepository : IHuyenRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public HuyenRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task AddAsync(HuyenEntity huyenEntity)
        {
            await _DBContext.Huyens.AddAsync(huyenEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(HuyenEntity huyenEntity)
        {
            _DBContext.Huyens.Remove(huyenEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task<List<HuyenEntity>> GetAllAsync()
        {
            var list = await _DBContext.Huyens.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<HuyenEntity> GetLastAsync()
        {
            var huyen = await _DBContext.Huyens.OrderBy(i => i.Id).LastOrDefaultAsync();
            return huyen;
        }

        public async Task<List<HuyenEntity>> GetListByTinhIdAsync(string maTinh)
        {
            var list = await _DBContext.Huyens.Where(i => i.maTinh == maTinh).ToListAsync();
            return list;
        }

        public async Task<HuyenEntity> GetOneByIDAsync(string Id)
        {
            var huyen = await _DBContext.Huyens.FirstOrDefaultAsync(i => i.Id == Id);
            return huyen;
        }

        public async Task UpdateAsync(HuyenEntity huyenEntity)
        {
            _DBContext.Huyens!.Update(huyenEntity);
            _DBContext.Entry(huyenEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }
    }
}
