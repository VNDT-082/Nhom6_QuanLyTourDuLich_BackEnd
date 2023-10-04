using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class DanhMucHinhRepository:IDanhMucHinhRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public DanhMucHinhRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task AddAsync(DanhMucHinhEntity danhMucHinhEntity)
        {
            await _DBContext.DanhMucHinhs.AddAsync(danhMucHinhEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(DanhMucHinhEntity danhMucHinhEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DanhMucHinhEntity>> GetAllAsync()
        {
            var list = await _DBContext.DanhMucHinhs.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<DanhMucHinhEntity> GetLastAsync()
        {
            var danhMuc = await _DBContext.DanhMucHinhs.OrderBy(i => i.Id).LastAsync();
            return danhMuc;
        }

        public async Task<DanhMucHinhEntity> GetOneByIDAsync(string Id)
        {
            var danhMuc = await _DBContext.DanhMucHinhs.FirstOrDefaultAsync(i => i.Id==Id);
            return danhMuc;
        }

        public async Task UpdateAsync(DanhMucHinhEntity danhMucHinhEntity)
        {
            _DBContext.DanhMucHinhs!.Update(danhMucHinhEntity);
            _DBContext.Entry(danhMucHinhEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }
    }
}
