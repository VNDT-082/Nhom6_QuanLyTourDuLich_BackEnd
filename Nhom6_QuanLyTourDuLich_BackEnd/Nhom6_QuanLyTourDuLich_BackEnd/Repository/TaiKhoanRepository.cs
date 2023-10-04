﻿using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        public readonly QuanLyTourDuLich_DBContext _DBContext = new QuanLyTourDuLich_DBContext();
        public TaiKhoanRepository(QuanLyTourDuLich_DBContext _DBContext)
        {
            this._DBContext = _DBContext;
        }
        public async Task AddAsync(TaiKhoanEntity taiKhoanEntity)
        {
            await _DBContext.TaiKhoans.AddAsync(taiKhoanEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TaiKhoanEntity taiKhoanEntity)
        {
            
            if (taiKhoanEntity.maLoai == "KhachHang")
            {
                var kh = _DBContext.KhachHangs.FirstOrDefault(i => i.maTaiKhoan == taiKhoanEntity.Id);
                kh.maTaiKhoan = null;
                KhachHangRepository khRepo = new KhachHangRepository(_DBContext);
                khRepo.UpdateAsync(kh);
            }
            else
            {
                var nv = _DBContext.NhanViens.FirstOrDefault(i => i.maTaiKhoan == taiKhoanEntity.Id);
                nv.maTaiKhoan = null;
                NhanVienRepository nvRepo = new NhanVienRepository(_DBContext);
                nvRepo.UpdateAsync(nv);
            }
            _DBContext.TaiKhoans.Remove(taiKhoanEntity);
            await _DBContext.SaveChangesAsync();
        }

        public async Task<List<TaiKhoanEntity>> GetAllAsync()
        {
            var list = await _DBContext.TaiKhoans.ToListAsync();
            return list;
        }

        public async Task<TaiKhoanEntity> GetLastAsync()
        {
            var taiKhoan = await _DBContext.TaiKhoans.OrderBy(i => i.Id).LastAsync();
            return taiKhoan;
        }

        public async Task<List<TaiKhoanEntity>> GetListByTrangThai(bool trangThai)
        {
            var list = await _DBContext.TaiKhoans.Where(i=>i.trangThai==trangThai).ToListAsync();
            return list;
        }

        public async Task<TaiKhoanEntity> GetOneByIdAsync(string Id)
        {
            var taiKhoan = await _DBContext.TaiKhoans.FirstOrDefaultAsync(i => i.Id==Id);
            return taiKhoan;
        }

        public async Task<TaiKhoanEntity> LoginAsync(string soDienThoaiOrEmail)
        {
            var taiKhoan = await _DBContext.TaiKhoans
                .FirstOrDefaultAsync(i => i.soDienThoai == soDienThoaiOrEmail || i.email == soDienThoaiOrEmail);
            return taiKhoan;
        }

        public async Task UpdateAsync(TaiKhoanEntity taiKhoanEntity)
        {
            _DBContext.TaiKhoans!.Update(taiKhoanEntity);
            _DBContext.Entry(taiKhoanEntity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
        }
    }
}