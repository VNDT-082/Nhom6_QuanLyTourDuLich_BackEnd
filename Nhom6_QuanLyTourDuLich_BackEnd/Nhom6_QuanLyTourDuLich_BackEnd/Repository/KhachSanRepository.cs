using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class KhachSanRepository:IKhachSanRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public KhachSanRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(KhachSanEntity khachSanEntity)
        {
            try
            {
                await _DBContext.KhachSans.AddAsync(khachSanEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }

        public Task<bool> DeleteAsync(KhachSanEntity khachSanEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KhachSanEntity>> GetAllAsync()
        {
            var list = await _DBContext.KhachSans.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<KhachSanEntity> GetLastAsync()
        {
            var khachSan = await _DBContext.KhachSans.OrderBy(i=>i.Id).LastAsync();
            return khachSan;
        }

        public async Task<List<KhachSanEntity>> GetListByHangSao(string hangSao)
        {
            var list = await _DBContext.KhachSans.Where(i=>i.hangSao==hangSao).OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<List<KhachSanEntity>> GetListByXaIdAsync(string maXa)
        {
            var list = await _DBContext.KhachSans.Where(i => i.id_Xa == maXa).OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<KhachSanEntity> GetOneById(string maKhachSan)
        {
            var khachSan = await _DBContext.KhachSans.FirstOrDefaultAsync(i => i.Id == maKhachSan);
            return khachSan;
        }

        public async Task<bool> UpdateAsync(KhachSanEntity khachSanEntity)
        {
            try
            {
                _DBContext.KhachSans!.Update(khachSanEntity);
                _DBContext.Entry(khachSanEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }
    }
}
