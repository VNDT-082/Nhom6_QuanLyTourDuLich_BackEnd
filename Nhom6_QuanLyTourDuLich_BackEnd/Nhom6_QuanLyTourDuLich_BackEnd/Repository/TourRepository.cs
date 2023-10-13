using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class TourRepository : ITourRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public TourRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task<bool> AddAsync(TourEntity tourEntity)
        {
            try
            {
                await _DBContext.Tours.AddAsync(tourEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<int> Count()
        {
            int soLuong = _DBContext.Tours.AsNoTracking().Count();
            return soLuong;
        }

        public async Task<bool> DeleteAsync(TourEntity tourEntity)
        {
            try
            {
                tourEntity.trangThai = false;
                _DBContext.Tours!.Update(tourEntity);
                _DBContext.Entry(tourEntity).State = EntityState.Modified;
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<List<TourEntity>> GetAllAsync()
        {
            var list = await _DBContext.Tours.OrderByDescending(i => i.IdTour).ToListAsync();
            return list;
        }

        public async Task<List<TourEntity>> GetAllAsync(bool trangThai)
        {
            var list = await _DBContext.Tours.Where(i => i.trangThai == trangThai).OrderByDescending(i => i.IdTour).ToListAsync();
            return list;
        }

        public async Task<TourEntity> GetLastAsync()
        {
            var tour = await _DBContext.Tours.OrderBy(i => i.IdTour).LastOrDefaultAsync();
            return tour;
        }

        public async Task<List<TourEntity>> GetListTheoGia(double giaMin, double giaMax)
        {
            var list = await _DBContext.Tours.Where(i => i.chiPhi >= giaMin && i.chiPhi <= giaMax)
                .OrderByDescending(i => i.IdTour).ToListAsync();
            return list;
        }

        public async Task<List<TourEntity>> GetListTheoLoai(string maLoai)
        {
            var list = await _DBContext.Tours.Where(i => i.maLoaiTour == maLoai).ToListAsync();
            return list;
        }

        public async Task<List<TourEntity>> GetListTheoLoai(string maLoai, bool trangThai)
        {
            var list = await _DBContext.Tours.Where(i => i.maLoaiTour == maLoai && i.trangThai==trangThai).ToListAsync();
            return list;
        }


        public async Task<List<TourEntity>> GetListTheoNguoiLap(string maNhanVien)
        {
            var list = await _DBContext.Tours.Where(i => i.nguoiLap==maNhanVien).ToListAsync();
            return list;
        }

        public async Task<List<TourEntity>> GetListTheoTen(string tenTour)
        {
            var list = _DBContext.Tours.Where(i => i.tenTour.Contains("/tenTour/")).ToList();
            return list;
        }

        public async Task<TourEntity> GetOneByIDAsync(string Id)
        {
            var tour = await _DBContext.Tours.AsNoTracking().FirstOrDefaultAsync(i => i.IdTour == Id);
            return tour;
        }

        public async Task<List<TourEntity>> GetPage(byte pageSize, int pageNumber)
        {
            var list = await _DBContext.Tours.AsNoTracking().OrderByDescending(i => i.IdTour).Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToListAsync();
            return list;
        }

        public async Task<List<TourEntity>> GetPage(byte pageSize, int pageNumber, bool trangThai)
        {
            var list = await _DBContext.Tours.AsNoTracking().OrderByDescending(i => i.IdTour).Where(i=>i.trangThai==trangThai)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToListAsync();
            return list;
        }

        public async Task<bool> UpdateAsync(TourEntity tourEntity)
        {
            try
            {
                _DBContext.Tours!.Update(tourEntity);
                await _DBContext.SaveChangesAsync();
              
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }


    }
}
