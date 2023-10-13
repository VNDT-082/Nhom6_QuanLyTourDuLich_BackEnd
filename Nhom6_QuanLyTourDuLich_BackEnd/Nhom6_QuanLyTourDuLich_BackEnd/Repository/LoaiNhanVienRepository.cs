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
            try
            {
                NhanVienRepository nhanVienRepository = new NhanVienRepository(this._DBContext);

                var list = await nhanVienRepository.GetListByLoaiNhanVienIdAsync(loaiNhanVienEntity.IdLoaiNhanVien);
                if (list != null)
                {
                    var loaiNhanVienUnDefined = _DBContext.LoaiNhanViens.FirstOrDefault(i => i.tenLoai == "UNDEFINED");
                    string strUndefineId = "";
                    if (loaiNhanVienUnDefined == null)
                    {
                        LoaiNhanVienEntity loaiNhanVienNew = new LoaiNhanVienEntity();
                        loaiNhanVienNew.tenLoai = "UNDEFINED";

                        await this.AddAsync(loaiNhanVienNew);
                        strUndefineId = loaiNhanVienNew.IdLoaiNhanVien;
                    }
                    else
                    {
                        strUndefineId = loaiNhanVienUnDefined.IdLoaiNhanVien;
                    }

                    bool Flag = true;
                    foreach (var item in list)
                    {
                        item.maLoaiNhanVien = strUndefineId;
                        Flag= await nhanVienRepository.UpdateAsync(item);
                    }
                    if (Flag == true)
                    { 
                        _DBContext.LoaiNhanViens!.Remove(loaiNhanVienEntity);
                        await _DBContext.SaveChangesAsync();
                        return true;
                    }
                    
                }
                return false;
            }
            catch { return false; }
        }

        public async Task<List<LoaiNhanVienEntity>> GetAllAsync()
        {
            var list = await _DBContext.LoaiNhanViens.AsNoTracking().OrderByDescending(i => i.IdLoaiNhanVien).ToListAsync();
            return list;
        }

        public async Task<LoaiNhanVienEntity> GetLastAsync()
        {
            var loai = await _DBContext.LoaiNhanViens.AsNoTracking().OrderBy(i => i.IdLoaiNhanVien).LastAsync();
            return loai;
        }

        public async Task<LoaiNhanVienEntity> GetOneByIdAsync(string Id)
        {
            var loai = await _DBContext.LoaiNhanViens.AsNoTracking().FirstOrDefaultAsync(i => i.IdLoaiNhanVien == Id);
            return loai;
        }


        public async Task<bool> UpdateAsync(LoaiNhanVienEntity loaiNhanVienEntity)
        {
            try
            {
                _DBContext.LoaiNhanViens!.Update(loaiNhanVienEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
