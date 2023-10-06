using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class KhachHangService:IKhachHangService
    {
        public readonly IKhachHangRepository _IKhachHangRepo;
        public IMapper _IMapper;
        public KhachHangService(IKhachHangRepository _IKhachHangRepo, IMapper _IMapper)
        {
            this._IKhachHangRepo = _IKhachHangRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(KhachHang_repo khachHang_repo)
        {
            KhachHangEntity khachHangLast = await _IKhachHangRepo.GetLastAsync();
            KhachHangEntity khachHangEntity = _IMapper.Map<KhachHangEntity>(khachHang_repo);
            if (khachHangLast != null)
            {
                khachHangEntity.Id = GenarateId.setIdKhachHang(khachHangLast.Id);
            }
            else
            {
                khachHangEntity.Id ="KH001";
            }
            return await _IKhachHangRepo.AddAsync(khachHangEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            KhachHangEntity khachHang = await _IKhachHangRepo.GetOneByIdAsync(ID);
            if (khachHang != null)
            {
                return await _IKhachHangRepo.DeleteAsync(khachHang);
            }
            return false;
        }

        public async Task<List<KhachHangModel>> GetAllAsync()
        {
            List<KhachHangEntity> listKhachHang = await _IKhachHangRepo.GetAllAsync();
            if (listKhachHang != null || listKhachHang.Count > 0)
            {
                List<KhachHangModel> listKhachHangModel = _IMapper.Map<List<KhachHangModel>>(listKhachHang);
                return listKhachHangModel;
            }
            return null;
        }

        public async Task<List<KhachHangModel>> GetAllTheoGioiTinhAsync(bool gioiTinh)
        {
            List<KhachHangEntity> listKhachHang = await _IKhachHangRepo.GetAllTheoGioiTinhAsync(gioiTinh);
            if (listKhachHang != null||listKhachHang.Count>0)
            {
                List<KhachHangModel> listKhachHangModel = _IMapper.Map<List<KhachHangModel>>(listKhachHang);
                return listKhachHangModel;
            }
            return null;
        }

        public async Task<KhachHangModel> GetLastAsync()
        {
            KhachHangEntity khachHang = await _IKhachHangRepo.GetLastAsync();
            if (khachHang != null)
            {
                KhachHangModel khachHangModel = _IMapper.Map<KhachHangModel>(khachHang);
                return khachHangModel;
            }
            return null;
        }

        public async Task<KhachHangModel> GetOneByIdAsync(string Id)
        {
            KhachHangEntity khachHang = await _IKhachHangRepo.GetOneByIdAsync(Id);
            if (khachHang != null)
            {
                KhachHangModel khachHangModel = _IMapper.Map<KhachHangModel>(khachHang);
                return khachHangModel;
            }
            return null;
        }

        public async Task<KhachHangModel> GetOneByTaiKhoanIdAsync(string maTaiKhoan)
        {
            KhachHangEntity khachHang = await _IKhachHangRepo.GetOneByTaiKhoanIdAsync(maTaiKhoan);
            if (khachHang != null)
            {
                KhachHangModel khachHangModel= _IMapper.Map<KhachHangModel>(khachHang);
                return khachHangModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(KhachHangModel khachHangModel)
        {
            KhachHangEntity khachHang = await _IKhachHangRepo.GetOneByIdAsync(khachHangModel.Id);
            if (khachHang != null)
            {
                KhachHangEntity khachHangEntity = _IMapper.Map<KhachHangEntity>(khachHangModel);
                return await _IKhachHangRepo.UpdateAsync(khachHangEntity);
            }
            return false;
        }
    }
}
