using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class LoaiTaiKhoanRepository:ILoaiTaiKhoanRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public LoaiTaiKhoanRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(LoaiTaiKhoanEntity loaiTaiKhoanEntity)
        {
            try
            {
                await _DBContext.LoaiTaiKhoans.AddAsync(loaiTaiKhoanEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(LoaiTaiKhoanEntity loaiTaiKhoanEntity)
        {
            try
            {
                if (loaiTaiKhoanEntity.Id != "KhachHang")
                {
                    var listTaiKhoan = await _DBContext.TaiKhoans.Where(i => i.maLoai == loaiTaiKhoanEntity.Id).ToListAsync();
                    TaiKhoanRepository tkRepo = new TaiKhoanRepository(_DBContext);
                    foreach (var item in listTaiKhoan)
                    {
                        item.maLoai = "KhachHang";
                        item.trangThai = false;
                        tkRepo.UpdateAsync(item);
                    }
                    _DBContext.LoaiTaiKhoans.Remove(loaiTaiKhoanEntity);
                    await _DBContext.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<List<LoaiTaiKhoanEntity>> GetAllAsync()
        {
            var list = await _DBContext.LoaiTaiKhoans.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<LoaiTaiKhoanEntity> GetLastAsync()
        {
            var loai = await _DBContext.LoaiTaiKhoans.OrderBy(i => i.Id).LastAsync();
            return loai;
        }

        public async Task<LoaiTaiKhoanEntity> GetOneByIdAsync(string Id)
        {
            var loai = await _DBContext.LoaiTaiKhoans.FirstOrDefaultAsync(i => i.Id==Id);
            return loai;
        }

        public async Task<bool> UpdateAsync(LoaiTaiKhoanEntity loaiTaiKhoanEntity)
        {
            try
            {
                _DBContext.LoaiTaiKhoans!.Update(loaiTaiKhoanEntity);
                _DBContext.Entry(loaiTaiKhoanEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
