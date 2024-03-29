﻿using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ITaiKhoanService
    {
        public Task<List<TaiKhoanModel>> GetAllAsync();
        public Task<List<TaiKhoanModel>> GetListByTrangThai(bool trangThai);
        public Task<TaiKhoanModel> GetOneByIdAsync(string Id);
        public Task<TaiKhoanModel> GetOneByEmailAsync(string email);
        public Task<TaiKhoanModel> LoginAsync(string soDienThoaiOrEmail, string matKhau);
        public Task<TaiKhoanModel> GetLastAsync();
        public Task<TaiKhoanModel> AddAsync(TaiKhoan_repo taiKhoan_repo);
        public Task<TaiKhoanModel> UpdateAsync(TaiKhoanModel taiKhoanModel);
        public Task<TaiKhoanModel> ChangePasswordAsync(TaiKhoanModel taiKhoanModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
