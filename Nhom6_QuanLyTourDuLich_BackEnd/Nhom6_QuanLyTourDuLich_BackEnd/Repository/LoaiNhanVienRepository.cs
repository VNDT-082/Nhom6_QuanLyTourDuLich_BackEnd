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

        public async Task AddAsync(LoaiNhanVienEntity loaiNhanVienEntity)
        {
            await _DBContext.LoaiNhanViens.AddAsync(loaiNhanVienEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(LoaiNhanVienEntity loaiNhanVienEntity)
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


        public async Task UpdateAsync(LoaiNhanVienEntity loaiNhanVienEntity)
        {
            _DBContext.LoaiNhanViens!.Update(loaiNhanVienEntity);
            _DBContext.Entry(loaiNhanVienEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }
    }
}
