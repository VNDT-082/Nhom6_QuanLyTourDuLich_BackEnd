using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class ThanhVienRepository : IThanhVienRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public ThanhVienRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task<bool> AddAsync(ThanhVienEntity thanhVienEntity)
        {
            try { 
                await _DBContext.ThanhViens.AddAsync(thanhVienEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            } catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(ThanhVienEntity thanhVienEntity)
        {
            try
            {
                _DBContext.ThanhViens.Remove(thanhVienEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex);return false; }
        }

        public async Task<List<ThanhVienEntity>> GetAllAsync(string datTourId)
        {
            var list = await _DBContext.ThanhViens.Where(i => i.maDatTour == datTourId).ToListAsync();
            return list;
        }

        public async Task<List<ThanhVienEntity>> GetAllTheoGioiTinhAsync(bool gioiTinh)
        {
            var list = await _DBContext.ThanhViens.Where(i => i.gioiTinh == gioiTinh).ToListAsync();
            return list;
        }

        public async Task<ThanhVienEntity> GetLastAsync()
        {
            var thanhVien = await _DBContext.ThanhViens.OrderBy(i => i.Id).LastAsync();
            return thanhVien;
        }

        public async Task<ThanhVienEntity> GetLastOfDatTourAsync(string maDatTour)
        {
            var thanhVien = await _DBContext.ThanhViens.Where(i=>i.maDatTour==maDatTour).OrderBy(i => i.Id).LastAsync();
            return thanhVien;
        }

        public async Task<ThanhVienEntity> GetOneByIDAsync(string Id)
        {
            var thanhVien = await _DBContext.ThanhViens.FirstOrDefaultAsync(i => i.Id == Id);
            return thanhVien;
        }

        public async Task<bool> UpdateAsync(ThanhVienEntity thanhVienEntity)
        {
            try { 
                _DBContext.ThanhViens!.Update(thanhVienEntity);
                _DBContext.Entry(thanhVienEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            } catch (Exception ex) { Console.WriteLine(ex);return false; }
            
        }
    }
}
