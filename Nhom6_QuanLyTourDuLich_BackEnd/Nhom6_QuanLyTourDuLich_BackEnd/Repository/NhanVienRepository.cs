using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class NhanVienRepository:INhanVienRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public NhanVienRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<NhanVienEntity> AddAsync(NhanVienEntity nhanVienEntity)
        {
            try
            {
                await _DBContext.NhanViens.AddAsync(nhanVienEntity);
                await _DBContext.SaveChangesAsync();
                return await GetOneByIDAsync(nhanVienEntity.IdNhanVien);
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }

        }

        public async Task<bool> DeleteAsync(NhanVienEntity nhanVienEntity)
        {
            try
            {
                nhanVienEntity.trangThai = false;
                _DBContext.NhanViens!.Update(nhanVienEntity);
                _DBContext.Entry(nhanVienEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }

        public async Task<List<NhanVienEntity>> GetAllAsync()
        {
            var list = await _DBContext.NhanViens.AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<NhanVienEntity> GetLastAsync()
        {
            var nhanVien = await _DBContext.NhanViens.AsNoTracking().OrderBy(i => i.IdNhanVien).LastAsync();
            return nhanVien;
        }

        public async Task<List<NhanVienEntity>> GetListByLoaiNhanVienIdAsync(string maLoaiNhanVien)
        {
            var list = await _DBContext.NhanViens.AsNoTracking().Where(i=>i.maLoaiNhanVien==maLoaiNhanVien).ToListAsync();
            return list;
        }

        public async Task<NhanVienEntity> GetOneByCCCDAsync(string canCuocConDan)
        {
            var nhanVien = await _DBContext.NhanViens.AsNoTracking().FirstOrDefaultAsync(i=>i.canCuocConDan==canCuocConDan);
            return nhanVien;
        }

        public async Task<NhanVienEntity> GetOneByIDAsync(string Id)
        {
            var nhanVien = await _DBContext.NhanViens.AsNoTracking().FirstOrDefaultAsync(i => i.IdNhanVien == Id);
            return nhanVien;
        }

        public async Task<NhanVienEntity> UpdateAsync(NhanVienEntity nhanVienEntity)
        {
            try
            {
                _DBContext.NhanViens!.Update(nhanVienEntity);
                await _DBContext.SaveChangesAsync();
                return await GetOneByIDAsync(nhanVienEntity.IdNhanVien);
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }
            
        }
    }
}
