using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class LoaiNhanVienRepository:ILoaiNhanVienRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public LoaiNhanVienRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(LoaiNhanVienEntity loaiNhanVienEntity)
        {
            try
            {
                await _DBContext.LoaiNhanViens.AddAsync(loaiNhanVienEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(LoaiNhanVienEntity loaiNhanVienEntity)
        {
            //if (loaiNhanVienEntity.Id != "KhachHang")
            //{
            //    _DBContext.LoaiNhanViens.Remove(loaiNhanVienEntity);
            //    await _DBContext.SaveChangesAsync();
            //}
            throw new NotImplementedException();
        }

        public async Task<List<LoaiNhanVienEntity>> GetAllAsync()
        {
            var list = await _DBContext.LoaiNhanViens.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<LoaiNhanVienEntity> GetLastAsync()
        {
            var loai = await _DBContext.LoaiNhanViens.OrderBy(i => i.Id).LastAsync();
            return loai;
        }

        public async Task<LoaiNhanVienEntity> GetOneByIdAsync(string Id)
        {
            var loai = await _DBContext.LoaiNhanViens.FirstOrDefaultAsync(i => i.Id == Id);
            return loai;
        }


        public async Task<bool> UpdateAsync(LoaiNhanVienEntity loaiNhanVienEntity)
        {
            try
            {
                _DBContext.LoaiNhanViens!.Update(loaiNhanVienEntity);
                _DBContext.Entry(loaiNhanVienEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
