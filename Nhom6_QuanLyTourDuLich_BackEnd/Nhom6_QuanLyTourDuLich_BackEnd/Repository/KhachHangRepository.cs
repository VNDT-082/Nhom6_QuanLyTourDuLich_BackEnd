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
        public async Task<bool> AddAsync(KhachHangEntity khachHangEntity)
        {
            try
            {
                await _DBContext.KhachHangs.AddAsync(khachHangEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(KhachHangEntity khachHangEntity)
        {
            try
            {
                DatTourRepository datTourRepository = new DatTourRepository(this._DBContext);
                var listDatTour = await datTourRepository.GetListByKhachHangIdAsync(khachHangEntity.IdKhachHang);
                if (listDatTour != null)
                {
                    bool Flag = false;
                    foreach (var item in listDatTour)
                    {
                        Flag = await datTourRepository.DeleteAsync(item);
                    }
                    if (Flag == true)
                    {
                        _DBContext.KhachHangs.Remove(khachHangEntity);
                        _DBContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch { return false; }
        }

        public async Task<List<KhachHangEntity>> GetAllAsync()
        {
            var list = await _DBContext.KhachHangs.AsNoTracking().OrderByDescending(i => i.IdKhachHang).ToListAsync();
            return list;
        }

        public async Task<List<KhachHangEntity>> GetAllTheoGioiTinhAsync(bool gioiTinh)
        {
            var list = await _DBContext.KhachHangs.AsNoTracking().Where(i=>i.gioiTinh==gioiTinh).OrderByDescending(i => i.IdKhachHang).ToListAsync();
            return list;
        }

        public async Task<KhachHangEntity> GetLastAsync()
        {
            var khachHang = await _DBContext.KhachHangs.AsNoTracking().OrderBy(i => i.IdKhachHang).LastAsync();
            return khachHang;
        }

        public async Task<KhachHangEntity> GetOneByIdAsync(string Id)
        {
            var khachHang = await _DBContext.KhachHangs.AsNoTracking().FirstOrDefaultAsync(i => i.IdKhachHang==Id);
            return khachHang;
        }

        public async Task<KhachHangEntity> GetOneByTaiKhoanIdAsync(string maTaiKhoan)
        {
            var khachHang = await _DBContext.KhachHangs.AsNoTracking().FirstOrDefaultAsync(i => i.maTaiKhoan == maTaiKhoan);
            return khachHang;
        }

        public async Task<bool> UpdateAsync(KhachHangEntity khachHangEntity)
        {
            try
            {
                _DBContext.KhachHangs!.Update(khachHangEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
