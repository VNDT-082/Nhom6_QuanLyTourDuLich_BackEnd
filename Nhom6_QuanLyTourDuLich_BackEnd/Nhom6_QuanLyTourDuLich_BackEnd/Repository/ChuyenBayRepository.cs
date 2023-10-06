using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class ChuyenBayRepository:IChuyenBayRepository
    {

        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public ChuyenBayRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(ChuyenBayEntity chuyenBayEntity)
        {
            try
            {
                await _DBContext.ChuyenBays.AddAsync(chuyenBayEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public Task<bool> DeleteAsync(ChuyenBayEntity chuyenBayEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ChuyenBayEntity>> GetAllAsync()
        {
            var list = await _DBContext.ChuyenBays.OrderBy(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<ChuyenBayEntity> GetLastAsync()
        {
            var chuyenBay = await _DBContext.ChuyenBays.OrderBy(i => i.Id).LastAsync();
            return chuyenBay;
        }

        public async Task<List<ChuyenBayEntity>> GetListKhuHoi(bool khuHoi)
        {
            var list = await _DBContext.ChuyenBays.Where(i => i.khuHoi == khuHoi).ToListAsync();
            return list;
        }

        public async Task<List<ChuyenBayEntity>> GetListNoiDen(string maSanBay)
        {
            var list = await _DBContext.ChuyenBays.Where(i => i.noiDen == maSanBay).ToListAsync();
            return list;
        }

        public async Task<List<ChuyenBayEntity>> GetListNoiDi(string maSanBay)
        {
            var list = await _DBContext.ChuyenBays.Where(i => i.noiKhoiHanh == maSanBay).ToListAsync();
            return list;
        }

        public async Task<List<ChuyenBayEntity>> GetListTheoNgay(DateTime gioDi, DateTime gioDen)
        {
            var list = await _DBContext.ChuyenBays.Where(i => i.gioKhoiHanh >= gioDi && i.gioDen <= gioDen).ToListAsync();
            return list;
        }

        public async Task<ChuyenBayEntity> GetOneByIDAsync(string Id)
        {
            var chuyenBay = await _DBContext.ChuyenBays.FirstOrDefaultAsync(i => i.Id == Id);
            return chuyenBay;
        }

        public async Task<bool> UpdateAsync(ChuyenBayEntity chuyenBayEntity)
        {
            try
            {
                _DBContext.ChuyenBays!.Update(chuyenBayEntity);
                _DBContext.Entry(chuyenBayEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
