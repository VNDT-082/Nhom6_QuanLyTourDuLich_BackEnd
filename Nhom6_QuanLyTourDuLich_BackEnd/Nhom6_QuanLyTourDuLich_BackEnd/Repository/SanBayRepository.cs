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
                var list = _DBContext.ChuyenBays.Where(i => i.noiKhoiHanh == sanBayEntity.Id || i.noiDen == sanBayEntity.Id).ToList();
                ChuyenBayRepository cbRepo = new ChuyenBayRepository(_DBContext);
                foreach (var item in list)
                {
                    if (item.noiKhoiHanh == sanBayEntity.Id)
                    {
                        item.noiKhoiHanh = null;
                        item.trangThai = false;
                        cbRepo.UpdateAsync(item);
                    }
                    if (item.noiDen == sanBayEntity.Id)
                    {
                        item.noiDen = null;
                        item.trangThai = false;
                        cbRepo.UpdateAsync(item);
                    }
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
            var sanBay = await _DBContext.SanBays.OrderBy(i => i.Id).LastAsync();
            return sanBay;
        }

        public async Task<SanBayEntity> GetOneByIDAsync(string Id)
        {
            var sanBay = await _DBContext.SanBays.FirstOrDefaultAsync(i => i.Id==Id);
            return sanBay;
        }

        public async Task<bool> UpdateAsync(SanBayEntity sanBayEntity)
        {
            try
            {
                _DBContext.SanBays!.Update(sanBayEntity);
                _DBContext.Entry(sanBayEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
