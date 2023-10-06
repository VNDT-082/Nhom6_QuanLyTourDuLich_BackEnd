using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class DanhMucHinhRepository:IDanhMucHinhRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public DanhMucHinhRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(DanhMucHinhEntity danhMucHinhEntity)
        {
            try
            {
                await _DBContext.DanhMucHinhs.AddAsync(danhMucHinhEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(DanhMucHinhEntity danhMucHinhEntity)
        {
            try
            {
                _DBContext.DanhMucHinhs.Remove(danhMucHinhEntity);
                _DBContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }

        public async Task<List<DanhMucHinhEntity>> GetAllAsync()
        {
            var list = await _DBContext.DanhMucHinhs.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<DanhMucHinhEntity> GetLastAsync()
        {
            var danhMuc = await _DBContext.DanhMucHinhs.OrderBy(i => i.Id).LastAsync();
            return danhMuc;
        }

        public async Task<DanhMucHinhEntity> GetLastOfTourAsync(string maTour)
        {
            var danhMuc = await _DBContext.DanhMucHinhs.Where(i=>i.maTour==maTour).OrderBy(i => i.Id).LastAsync();
            return danhMuc;
        }

        public async Task<DanhMucHinhEntity> GetOneByIDAsync(string Id)
        {
            var danhMuc = await _DBContext.DanhMucHinhs.FirstOrDefaultAsync(i => i.Id==Id);
            return danhMuc;
        }

        public async Task<bool> UpdateAsync(DanhMucHinhEntity danhMucHinhEntity)
        {
            try
            {
                _DBContext.DanhMucHinhs!.Update(danhMucHinhEntity);
                _DBContext.Entry(danhMucHinhEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }
    }
}
