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
    public class LoaiNhanVienService:ILoaiNhanVienService
    {
        public readonly ILoaiNhanVienRepository _ILoaiNhanVienRepository;
        public IMapper _IMapper;
        public LoaiNhanVienService(ILoaiNhanVienRepository _ILoaiNhanVienRepository, IMapper _IMapper)
        {
            this._ILoaiNhanVienRepository = _ILoaiNhanVienRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(LoaiNhanVien_repo loaiNhanVien_repo)
        {
            LoaiNhanVienEntity loaiNhanVienEntity = _IMapper.Map<LoaiNhanVienEntity>(loaiNhanVien_repo);
            //DateTime time = DateTime.Now;
            //loaiNhanVienEntity.Id = "LNV" + time.ToString("yyyyMMddHHmmss");
            return await _ILoaiNhanVienRepository.AddAsync(loaiNhanVienEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            LoaiNhanVienEntity _LoaiNhanVienEntity = await _ILoaiNhanVienRepository.GetOneByIdAsync(ID);
            if (_LoaiNhanVienEntity != null)
                return await _ILoaiNhanVienRepository.DeleteAsync(_LoaiNhanVienEntity);
            return false;
        }

        public async Task<List<LoaiNhanVienModel>> GetAllAsync()
        {
            List<LoaiNhanVienEntity> listLoaiNhanVien = await _ILoaiNhanVienRepository.GetAllAsync();
            if (listLoaiNhanVien != null || listLoaiNhanVien.Count > 0)
            {
                List<LoaiNhanVienModel> listLoaiNhanVienModel = _IMapper.Map<List<LoaiNhanVienModel>>(listLoaiNhanVien);
                return listLoaiNhanVienModel;
            }
            return null;
        }

        public async Task<LoaiNhanVienModel> GetLastAsync()
        {
            LoaiNhanVienEntity loaiNhanVien = await _ILoaiNhanVienRepository.GetLastAsync();
            if (loaiNhanVien != null)
            {
                LoaiNhanVienModel loaiNhanVienModel = _IMapper.Map<LoaiNhanVienModel>(loaiNhanVien);
                return loaiNhanVienModel;
            }
            return null;
        }

        public async Task<LoaiNhanVienModel> GetOneByIdAsync(string Id)
        {
            LoaiNhanVienEntity loaiNhanVien = await _ILoaiNhanVienRepository.GetOneByIdAsync(Id);
            if (loaiNhanVien != null)
            {
                LoaiNhanVienModel loaiNhanVienModel = _IMapper.Map<LoaiNhanVienModel>(loaiNhanVien);
                return loaiNhanVienModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(LoaiNhanVienModel loaiNhanVienModel)
        {
            LoaiNhanVienEntity loaiNhanVien = await _ILoaiNhanVienRepository.GetOneByIdAsync(loaiNhanVienModel.IdLoaiNhanVien);
            if (loaiNhanVien != null)
            {
                LoaiNhanVienEntity loaiNhanVienEntity = _IMapper.Map<LoaiNhanVienEntity>(loaiNhanVienModel);
                return await _ILoaiNhanVienRepository.UpdateAsync(loaiNhanVienEntity);
            }
            return false;
        }
    }
}
