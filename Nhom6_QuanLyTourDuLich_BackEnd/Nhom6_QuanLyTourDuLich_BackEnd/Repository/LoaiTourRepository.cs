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
        public async Task<bool> AddAsync(LoaiTourEntity loaiTour)
        {
            try
            {
                await _DBContext.LoaiTours.AddAsync(loaiTour);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(LoaiTourEntity loaiTour)
        {
            try
            {
                var dsTour = _DBContext.Tours.Where(i => i.maLoaiTour == loaiTour.Id).ToList();
                if (dsTour != null)
                {
                    foreach (var item in dsTour)
                    {
                        item.maLoaiTour = "LT20231011163510";
                    }
                }
                
                _DBContext.LoaiTours.Remove(loaiTour);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
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

        public async Task<bool> UpdateAsync(LoaiTourEntity loaiTour)
        {
            try
            {
                _DBContext.LoaiTours!.Update(loaiTour);
                _DBContext.Entry(loaiTour).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
        public async Task<LoaiTourEntity> GetLastAsync()
        {
            var loaiTour = await _DBContext.LoaiTours.OrderBy(i=>i.Id).LastOrDefaultAsync();
            return loaiTour;
        }
    }
}
