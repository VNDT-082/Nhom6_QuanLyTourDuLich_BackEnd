using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public KhachHangRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task AddAsync(KhachHangEntity khachHangEntity)
        {
            await _DBContext.KhachHangs.AddAsync(khachHangEntity);
            await _DBContext.SaveChangesAsync();
        }

        public Task DeleteAsync(KhachHangEntity khachHangEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KhachHangEntity>> GetAllAsync()
        {
            var list = await _DBContext.KhachHangs.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<List<KhachHangEntity>> GetAllTheoGioiTinhAsync(bool gioiTinh)
        {
            var list = await _DBContext.KhachHangs.Where(i=>i.gioiTinh==gioiTinh).OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<KhachHangEntity> GetLastAsync()
        {
            var khachHang = await _DBContext.KhachHangs.OrderBy(i => i.Id).LastAsync();
            return khachHang;
        }

        public async Task<KhachHangEntity> GetOneByIdAsync(string Id)
        {
            var khachHang = await _DBContext.KhachHangs.FirstOrDefaultAsync(i => i.Id==Id);
            return khachHang;
        }

        public async Task<KhachHangEntity> GetOneByTaiKhoanIdAsync(string maTaiKhoan)
        {
            var khachHang = await _DBContext.KhachHangs.FirstOrDefaultAsync(i => i.maTaiKhoan == maTaiKhoan);
            return khachHang;
        }

        public async Task UpdateAsync(KhachHangEntity khachHangEntity)
        {
            _DBContext.KhachHangs!.Update(khachHangEntity);
            _DBContext.Entry(khachHangEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }
    }
}
