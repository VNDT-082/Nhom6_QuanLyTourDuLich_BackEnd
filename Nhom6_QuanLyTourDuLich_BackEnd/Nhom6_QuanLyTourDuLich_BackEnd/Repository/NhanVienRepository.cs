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

        public Task<bool> AddAsync(NhanVienEntity nhanVienEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(NhanVienEntity nhanVienEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<NhanVienEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NhanVienEntity> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<NhanVienEntity>> GetListByLoaiNhanVienIdAsync(string maLoaiNhanVien)
        {
            throw new NotImplementedException();
        }

        public Task<NhanVienEntity> GetOneByCCCDAsync(string canCuocConDan)
        {
            throw new NotImplementedException();
        }

        public Task<NhanVienEntity> GetOneByIDAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(NhanVienEntity nhanVienEntity)
        {
            try
            {
                _DBContext.NhanViens!.Update(nhanVienEntity);
                _DBContext.Entry(nhanVienEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
