using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class LoaiTaiKhoanService:ILoaiTaiKhoanService
    {
        public readonly ILoaiTaiKhoanRepository _ILoaiTaiKhoanRepository;
        public IMapper _IMapper;
        public LoaiTaiKhoanService(ILoaiTaiKhoanRepository _ILoaiTaiKhoanRepository, IMapper _IMapper)
        {
            this._ILoaiTaiKhoanRepository = _ILoaiTaiKhoanRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(LoaiTaiKhoan_repo loaiTaiKhoan_repo)
        {
            LoaiTaiKhoanEntity loaiTaiKhoanEntity = _IMapper.Map<LoaiTaiKhoanEntity>(loaiTaiKhoan_repo);
            DateTime time = DateTime.Now;
            loaiTaiKhoanEntity.Id = "LTK" + time.ToString("yyyyMMddHHmmss");
            return await _ILoaiTaiKhoanRepository.AddAsync(loaiTaiKhoanEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            LoaiTaiKhoanEntity loaiTaiKhoan = await _ILoaiTaiKhoanRepository.GetOneByIdAsync(ID);
            if (loaiTaiKhoan != null)
            {
                return await _ILoaiTaiKhoanRepository.DeleteAsync(loaiTaiKhoan);
            }
            return false; 
        }

        public async Task<List<LoaiTaiKhoanModel>> GetAllAsync()
        {
            List<LoaiTaiKhoanEntity> listLoaiTaiKhoan = await _ILoaiTaiKhoanRepository.GetAllAsync();
            if (listLoaiTaiKhoan != null||listLoaiTaiKhoan.Count>0)
            {
                List<LoaiTaiKhoanModel> listLoaiTaiKhoanModel = _IMapper.Map<List<LoaiTaiKhoanModel>>(listLoaiTaiKhoan);
                return listLoaiTaiKhoanModel;
            }
            return null;
        }

        public async Task<LoaiTaiKhoanModel> GetLastAsync()
        {
            LoaiTaiKhoanEntity loaiTaiKhoan = await _ILoaiTaiKhoanRepository.GetLastAsync();
            if (loaiTaiKhoan != null)
            {
                LoaiTaiKhoanModel loaiTaiKhoanModel = _IMapper.Map<LoaiTaiKhoanModel>(loaiTaiKhoan);
                return loaiTaiKhoanModel;
            }
            return null;
        }

        public async Task<LoaiTaiKhoanModel> GetOneByIdAsync(string Id)
        {
            LoaiTaiKhoanEntity loaiTaiKhoan = await _ILoaiTaiKhoanRepository.GetOneByIdAsync(Id);
            if (loaiTaiKhoan != null)
            {
                LoaiTaiKhoanModel loaiTaiKhoanModel= _IMapper.Map<LoaiTaiKhoanModel>(loaiTaiKhoan);
                return loaiTaiKhoanModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(LoaiTaiKhoanModel loaiTaiKhoanModel)
        {
            LoaiTaiKhoanEntity loaiTaiKhoan = await _ILoaiTaiKhoanRepository.GetOneByIdAsync(loaiTaiKhoanModel.Id);
            if (loaiTaiKhoan != null)
            {
                LoaiTaiKhoanEntity loaiTaiKhoanEntity = _IMapper.Map<LoaiTaiKhoanEntity>(loaiTaiKhoanModel);
                return await _ILoaiTaiKhoanRepository.UpdateAsync(loaiTaiKhoanEntity);
            }
            return false;
        }
    }
}
