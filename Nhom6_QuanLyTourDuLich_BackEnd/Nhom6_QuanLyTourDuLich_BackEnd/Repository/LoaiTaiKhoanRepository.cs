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
                var loaiTaiKhoanUnDefined= _DBContext.LoaiTaiKhoans.FirstOrDefault(i => i.tenLoai == "UNDEFINED");
                string strUndefineId = "";
                if (loaiTaiKhoanUnDefined == null)
                {
                    LoaiTaiKhoanEntity loaiTaiKhoanNew = new LoaiTaiKhoanEntity();
                    loaiTaiKhoanNew.tenLoai = "UNDEFINED";

                    await this.AddAsync(loaiTaiKhoanNew);
                    strUndefineId = loaiTaiKhoanNew.IdLoaiTaiKhoan;
                }
                else
                {
                    strUndefineId = loaiTaiKhoanUnDefined.IdLoaiTaiKhoan;
                }
                if (loaiTaiKhoanEntity.IdLoaiTaiKhoan != strUndefineId)
                {
                    var listTaiKhoan = await _DBContext.TaiKhoans.AsNoTracking()
                        .Where(i => i.maLoai == loaiTaiKhoanEntity.IdLoaiTaiKhoan).ToListAsync();
                   
                    if (listTaiKhoan != null)
                    {
                        TaiKhoanRepository tkRepo = new TaiKhoanRepository(_DBContext);
                        foreach (var item in listTaiKhoan)
                        {
                            item.maLoai = strUndefineId;
                            item.trangThai = false;
                            tkRepo.UpdateAsync(item);
                        }
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
            var list = await _DBContext.LoaiTaiKhoans.AsNoTracking().OrderByDescending(i => i.IdLoaiTaiKhoan).ToListAsync();
            return list;
        }

        public async Task<LoaiTaiKhoanEntity> GetLastAsync()
        {
            var loai = await _DBContext.LoaiTaiKhoans.AsNoTracking().OrderBy(i => i.IdLoaiTaiKhoan).LastAsync();
            return loai;
        }

        public async Task<LoaiTaiKhoanEntity> GetOneByIdAsync(string Id)
        {
            var loai = await _DBContext.LoaiTaiKhoans.AsNoTracking().FirstOrDefaultAsync(i => i.IdLoaiTaiKhoan==Id);
            return loai;
        }

        public async Task<bool> UpdateAsync(LoaiTaiKhoanEntity loaiTaiKhoanEntity)
        {
            try
            {
                _DBContext.LoaiTaiKhoans!.Update(loaiTaiKhoanEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
