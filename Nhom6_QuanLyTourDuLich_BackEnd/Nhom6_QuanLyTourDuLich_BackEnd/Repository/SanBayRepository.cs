using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class SanBayRepository:ISanBayRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public SanBayRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(SanBayEntity sanBayEntity)
        {
            try
            {
                await _DBContext.SanBays.AddAsync(sanBayEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(SanBayEntity sanBayEntity)
        {
            try
            {
                var list = _DBContext.ChuyenBays.AsNoTracking().Where(i => i.noiKhoiHanh == sanBayEntity.IdSanBay ||
                i.noiDen == sanBayEntity.IdSanBay).ToList();
                if (list != null || list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        if (item.noiKhoiHanh == sanBayEntity.IdSanBay)
                        {
                            item.noiKhoiHanh = null;
                            item.trangThai = false;
                        }
                        if (item.noiDen == sanBayEntity.IdSanBay)
                        {
                            item.noiDen = null;
                            item.trangThai = false;
                        }
                    }
                    _DBContext.ChuyenBays!.UpdateRange(list);
                    await _DBContext.SaveChangesAsync();
                }
                _DBContext.SanBays.Remove(sanBayEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<List<SanBayEntity>> GetAllAsync()
        {
            var list = await _DBContext.SanBays.ToListAsync();
            return list;
        }

        public async Task<SanBayEntity> GetLastAsync()
        {
            var sanBay = await _DBContext.SanBays.AsNoTracking().OrderBy(i => i.IdSanBay).LastAsync();
            return sanBay;
        }

        public async Task<SanBayEntity> GetOneByIDAsync(string Id)
        {
            var sanBay = await _DBContext.SanBays.AsNoTracking().FirstOrDefaultAsync(i => i.IdSanBay==Id);
            return sanBay;
        }

        public async Task<bool> UpdateAsync(SanBayEntity sanBayEntity)
        {
            try
            {
                _DBContext.SanBays!.Update(sanBayEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
