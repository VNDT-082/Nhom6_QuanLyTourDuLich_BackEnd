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
        public async Task AddAsync(TourEntity tourEntity)
        {
            await _DBContext.Tours.AddAsync(tourEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task<int> Count()
        {
            int soLuong = _DBContext.Tours.Count();
            return soLuong;
        }

        public async Task DeleteAsync(TourEntity tourEntity)
        {
            tourEntity.trangThai = false;
            _DBContext.Tours!.Update(tourEntity);
            _DBContext.Entry(tourEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }

        public async Task<List<TourEntity>> GetAllAsync()
        {
            var list = await _DBContext.Tours.OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<List<TourEntity>> GetAllAsync(bool trangThai)
        {
            var list = await _DBContext.Tours.Where(i => i.trangThai == trangThai).OrderByDescending(i => i.Id).ToListAsync();
            return list;
        }

        public async Task<TourEntity> GetLastAsync()
        {
            var tour = await _DBContext.Tours.OrderBy(i => i.Id).LastOrDefaultAsync();
            return tour;
        }

        public async Task<List<TourEntity>> GetListTheoGia(double giaMin, double giaMax)
        {
            var list = await _DBContext.Tours.Where(i => i.chiPhi >= giaMin && i.chiPhi <= giaMax)
                .OrderByDescending(i => i.Id).ToListAsync();
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

        public async Task<TourEntity> GetOneByIDAsync(string Id)
        {
            var tour = await _DBContext.Tours.FirstOrDefaultAsync(i => i.Id == Id);
            return tour;
        }

        public async Task<List<TourEntity>> GetPage(byte pageSize, int pageNumber)
        {
            var list = await _DBContext.Tours.OrderByDescending(i => i.Id).Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToListAsync();
            return list;
        }

        public async Task<List<TourEntity>> GetPage(byte pageSize, int pageNumber, bool trangThai)
        {
            var list = await _DBContext.Tours.OrderByDescending(i => i.Id).Where(i=>i.trangThai==trangThai)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToListAsync();
            return list;
        }

        public async Task UpdateAsync(TourEntity tourEntity)
        {
            _DBContext.Tours!.Update(tourEntity);
            _DBContext.Entry(tourEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }


    }
}
