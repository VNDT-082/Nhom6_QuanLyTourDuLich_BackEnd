using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public TaiKhoanRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task<TaiKhoanEntity> AddAsync(TaiKhoanEntity taiKhoanEntity)
        {
            try {
                await _DBContext.TaiKhoans.AddAsync(taiKhoanEntity);
                await _DBContext.SaveChangesAsync();
                return await GetOneByIdAsync(taiKhoanEntity.IdTaiKhoan);
            } catch (Exception ex) { Console.WriteLine(ex); return null; }
            
        }

        public async Task<bool> DeleteAsync(TaiKhoanEntity taiKhoanEntity)
        {
            try
            {
                string strKhacHangId = _DBContext.LoaiTaiKhoans.FirstOrDefault(i => i.tenLoai == "Khách hàng").IdLoaiTaiKhoan;
                if (taiKhoanEntity.maLoai == strKhacHangId)
                {
                    var kh = _DBContext.KhachHangs.FirstOrDefault(i => i.maTaiKhoan == taiKhoanEntity.IdTaiKhoan);
                    kh.maTaiKhoan = null;
                    KhachHangRepository khRepo = new KhachHangRepository(_DBContext);
                    khRepo.UpdateAsync(kh);
                }
                else
                {
                    var nv = _DBContext.NhanViens.FirstOrDefault(i => i.maTaiKhoan == taiKhoanEntity.IdTaiKhoan);
                    nv.maTaiKhoan = null;
                    NhanVienRepository nvRepo = new NhanVienRepository(_DBContext);
                    nvRepo.UpdateAsync(nv);
                }
                _DBContext.TaiKhoans.Remove(taiKhoanEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<List<TaiKhoanEntity>> GetAllAsync()
        {
            var list = await _DBContext.TaiKhoans.AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<TaiKhoanEntity> GetLastAsync()
        {
            var taiKhoan = await _DBContext.TaiKhoans.OrderBy(i => i.IdTaiKhoan).LastAsync();
            return taiKhoan;
        }

        public async Task<List<TaiKhoanEntity>> GetListByTrangThai(bool trangThai)
        {
            var list = await _DBContext.TaiKhoans.AsNoTracking().Where(i=>i.trangThai==trangThai).ToListAsync();
            return list;
        }

        public async Task<TaiKhoanEntity> GetOneByIdAsync(string Id)
        {
            //return await _DBContext.TaiKhoans.Where(i => i.IdTaiKhoan == Id).AsNoTracking().FirstOrDefaultAsync();
            var taiKhoan = await _DBContext.TaiKhoans.AsNoTracking().FirstOrDefaultAsync(i => i.IdTaiKhoan == Id);
            return taiKhoan;
        }

        public async Task<TaiKhoanEntity> LoginAsync(string soDienThoaiOrEmail)
        {
            var taiKhoan = await _DBContext.TaiKhoans.AsNoTracking()
                .FirstOrDefaultAsync(i => i.soDienThoai == soDienThoaiOrEmail || i.email == soDienThoaiOrEmail);
            return taiKhoan;
        }

        public async Task<TaiKhoanEntity> UpdateAsync(TaiKhoanEntity taiKhoanEntity)
        {
            try
            {
                _DBContext.TaiKhoans!.Update(taiKhoanEntity);
                await _DBContext.SaveChangesAsync();
                return await GetOneByIdAsync(taiKhoanEntity.IdTaiKhoan);
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }
            
        }
    }
}
