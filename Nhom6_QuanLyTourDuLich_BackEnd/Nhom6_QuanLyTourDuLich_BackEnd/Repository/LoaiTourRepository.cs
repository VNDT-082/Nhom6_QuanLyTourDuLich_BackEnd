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
                TourRepository tourRepository=new TourRepository(this._DBContext);

                var dsTour = await tourRepository.GetListTheoLoai(loaiTour.IdLoaiTour); //_DBContext.Tours.AsNoTracking().Where(i => i.maLoaiTour == loaiTour.IdLoaiTour).ToList();
                bool Flag = true;
                if (dsTour != null)
                {
                    var loaiTourUnDefined = _DBContext.LoaiTours.FirstOrDefault(i => i.tenLoai == "UNDEFINED");
                    string strUndefineId = "";
                    if (loaiTourUnDefined == null)
                    {
                        LoaiTourEntity loaiTourNew = new LoaiTourEntity();
                        loaiTourNew.tenLoai = "UNDEFINED";

                        await this.AddAsync(loaiTourNew);
                        strUndefineId = loaiTourNew.IdLoaiTour;
                    }
                    else
                    {
                        strUndefineId = loaiTourUnDefined.IdLoaiTour;
                    }

                    foreach (var item in dsTour)
                    {
                        item.maLoaiTour = strUndefineId;
                        Flag=await tourRepository.UpdateAsync(item);
                    }
                    

                }
                if (Flag == true)
                {
                    _DBContext.LoaiTours.Remove(loaiTour);
                    await _DBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<List<LoaiTourEntity>> GetAllAsync()
        {
            List<LoaiTourEntity> list = await _DBContext.LoaiTours.AsNoTracking().OrderByDescending(i=>i.IdLoaiTour).ToListAsync();
            return list;
        }

        public async Task<LoaiTourEntity> GetOneByIDAsync(string Id)
        {
            var loaiTour = await _DBContext.LoaiTours.AsNoTracking().FirstOrDefaultAsync(i => i.IdLoaiTour == Id);
            return loaiTour;
        }

        public async Task<bool> UpdateAsync(LoaiTourEntity loaiTour)
        {
            try
            {
                _DBContext.LoaiTours!.Update(loaiTour);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
        public async Task<LoaiTourEntity> GetLastAsync()
        {
            var loaiTour = await _DBContext.LoaiTours.AsNoTracking().OrderBy(i=>i.IdLoaiTour).LastOrDefaultAsync();
            return loaiTour;
        }
    }
}
