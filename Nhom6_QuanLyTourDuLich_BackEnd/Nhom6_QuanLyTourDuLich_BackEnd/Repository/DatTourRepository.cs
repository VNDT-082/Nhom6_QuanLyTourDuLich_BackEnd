using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using System.Collections.Generic;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class DatTourRepository:IDatTourRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public DatTourRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }

        public async Task<bool> AddAsync(DatTourEntity datTourEntity)
        {
            try
            {
                await _DBContext.DatTours.AddAsync(datTourEntity);
                await _DBContext.SaveChangesAsync();
                if (datTourEntity.ThanhViens != null || datTourEntity.ThanhViens.Count > 0)
                {
                    ThanhVienRepository thanhVienRepository = new ThanhVienRepository(_DBContext);
                    foreach (ThanhVienEntity thanhVienEntity in datTourEntity.ThanhViens)
                    {
                        thanhVienRepository.AddAsync(thanhVienEntity);
                    }
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }

        public async Task<bool> DeleteAsync(DatTourEntity datTourEntity)
        {
            try
            {
                ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
                var listThanhVien = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
                bool Flag = false;
                if (listThanhVien != null)
                {
                    foreach (var item in listThanhVien)
                    {
                        Flag = await thanhVienRepository.DeleteAsync(item);
                    }
                }
                if (Flag == true)
                {
                    _DBContext.DatTours.Remove(datTourEntity);
                    _DBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        public async Task<List<DatTourEntity>> GetAllAsync()
        {
            var list = await _DBContext.DatTours.AsNoTracking().OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetAllAsync(bool trangThai)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.trangThai==trangThai)
               .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<DatTourEntity> GetLastAsync()
        {
            var datTour = await _DBContext.DatTours.AsNoTracking().OrderBy(i => i.IdDatTour).LastAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            datTour.ThanhViens = await thanhVienRepository.GetAllAsync(datTour.IdDatTour);
            return datTour;
        }

        public async Task<List<DatTourEntity>> GetListByHuongDanVienIdAsync(string? maHuongDanVien)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.maHuongDanVien == maHuongDanVien)
                .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetListByKhachHangIdAsync(string maKhach)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.maKhach == maKhach)
                .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetListByTourIdAsync(string maTour)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.maTour == maTour)
                .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetListByTourIdAsync(string maTour, bool trangThai)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.maTour==maTour && i.trangThai==trangThai)
                .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.ngayDat >= ngayMin && i.ngayDat <= ngayMax)
                .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayDat)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.ngayDat == ngayDat)
                .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax, bool trangThai)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.ngayDat >= ngayMin&&i.ngayDat<=ngayMax && i.trangThai == trangThai)
                .OrderBy(i => i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<List<DatTourEntity>> GetListTheoNgayDatAsync(DateTime ngayDat, bool trangThai)
        {
            var list = await _DBContext.DatTours.AsNoTracking().Where(i => i.ngayDat == ngayDat && i.trangThai == trangThai)
                .OrderBy(i=>i.ngayDat).ToListAsync();
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            foreach (DatTourEntity datTourEntity in list)
            {
                datTourEntity.ThanhViens = await thanhVienRepository.GetAllAsync(datTourEntity.IdDatTour);
            }
            return list;
        }

        public async Task<DatTourEntity> GetOneByIDAsync(string Id)
        {
            var datTour = await _DBContext.DatTours.AsNoTracking().FirstOrDefaultAsync(i => i.IdDatTour == Id);
            ThanhVienRepository thanhVienRepository = new ThanhVienRepository(this._DBContext);
            datTour.ThanhViens = await thanhVienRepository.GetAllAsync(datTour.IdDatTour);
            return datTour;
        }

        public async Task<bool> UpdateAsync(DatTourEntity datTourEntity)
        {
            try
            {
                _DBContext.DatTours!.Update(datTourEntity);
                await _DBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
            
        }
    }
}
