using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using System.Globalization;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class LoaiTourRepository : ILoaiTourRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public LoaiTourRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task AddAsync(LoaiTourEntity loaiTour)
        {
            await _DBContext.LoaiTours.AddAsync(loaiTour);
            await _DBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(LoaiTourEntity loaiTour)
        {
            _DBContext.LoaiTours.Remove(loaiTour);
            await _DBContext.SaveChangesAsync();
        }

        public async Task<List<LoaiTourEntity>> GetAllAsync()
        {
            List<LoaiTourEntity> list = await _DBContext.LoaiTours.OrderByDescending(i=>i.Id).ToListAsync();
            return list;
        }

        public async Task<LoaiTourEntity> GetOneByIDAsync(string Id)
        {
            var loaiTour = await _DBContext.LoaiTours.FirstOrDefaultAsync(i => i.Id == Id);
            return loaiTour;
        }

        public async Task UpdateAsync(LoaiTourEntity loaiTour)
        {
            _DBContext.LoaiTours!.Update(loaiTour);
            _DBContext.Entry(loaiTour).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }
        public async Task<LoaiTourEntity> GetLastAsync()
        {
            var loaiTour = await _DBContext.LoaiTours.OrderBy(i=>i.Id).LastOrDefaultAsync();
            return loaiTour;
        }
    }
}
