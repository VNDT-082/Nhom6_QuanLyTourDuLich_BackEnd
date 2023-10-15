using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class NhanVienService:INhanVienService
    {
        public readonly INhanVienRepository _INhanVienRepo;
        public IMapper _IMapper;
        public NhanVienService(INhanVienRepository _INhanVienRepo, IMapper _IMapper)
        {
            this._INhanVienRepo = _INhanVienRepo;
            this._IMapper = _IMapper;
        }

        public async Task<NhanVienModel> AddAsync(NhanVien_repo nhaVien_repo)
        {
            NhanVienEntity _NhanVienEntity = _IMapper.Map<NhanVienEntity>(nhaVien_repo);
            //DateTime time = DateTime.Now;
            //_NhanVienEntity.Id = "NV" + time.ToString("yyyyMMddHHmmss");
            var _NhanVienEntity_repo = await _INhanVienRepo.AddAsync(_NhanVienEntity);
            return (_NhanVienEntity_repo!=null)?_IMapper.Map<NhanVienModel>(_NhanVienEntity_repo):null;
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            var nhanVienEntiy = await _INhanVienRepo.GetOneByIDAsync(ID);
            if (nhanVienEntiy != null)
                return await _INhanVienRepo.DeleteAsync(nhanVienEntiy);
            return false;
        }

        public async Task<List<NhanVienModel>> GetAllAsync()
        {
            var listNhanVienEnity = await _INhanVienRepo.GetAllAsync();
            
            if (listNhanVienEnity.Count > 0)
            {
                List<NhanVienModel> listNhanVienModel = _IMapper.Map<List<NhanVienModel>>(listNhanVienEnity);
                return listNhanVienModel;
            }
            return null;
        }

        public async Task<NhanVienModel> GetLastAsync()
        {
            NhanVienEntity NhanVien = await _INhanVienRepo.GetLastAsync();
            if (NhanVien != null)
            {
                NhanVienModel NhanVienModel = _IMapper.Map<NhanVienModel>(NhanVien);
                return NhanVienModel;
            }
            return null;
        }

        public async Task<List<NhanVienModel>> GetListByLoaiNhanVienIdAsync(string maLoaiNhanVien)
        {
            var listNhanVienEnity = await _INhanVienRepo.GetListByLoaiNhanVienIdAsync(maLoaiNhanVien);

            if (listNhanVienEnity.Count > 0)
            {
                List<NhanVienModel> listNhanVienModel = _IMapper.Map<List<NhanVienModel>>(listNhanVienEnity);
                return listNhanVienModel;
            }
            return null;
        }

        public async Task<NhanVienModel> GetOneByCCCDAsync(string canCuocConDan)
        {
            NhanVienEntity NhanVien = await _INhanVienRepo.GetOneByCCCDAsync(canCuocConDan);
            if (NhanVien != null)
            {
                NhanVienModel NhanVienModel = _IMapper.Map<NhanVienModel>(NhanVien);
                return NhanVienModel;
            }
            return null;
        }

        public async Task<NhanVienModel> GetOneByIDAsync(string Id)
        {
            NhanVienEntity NhanVien = await _INhanVienRepo.GetOneByIDAsync(Id);
            if (NhanVien != null)
            {
                NhanVienModel NhanVienModel = _IMapper.Map<NhanVienModel>(NhanVien);
                return NhanVienModel;
            }
            return null;
        }

        public async Task<NhanVienModel> UpdateAsync(NhanVienModel nhanVienModel)
        {
            var _NhanVienEntity = await _INhanVienRepo.GetOneByIDAsync(nhanVienModel.IdNhanVien);
            if (_NhanVienEntity != null)
            {
                var _NhanVienEntityUpdate = _IMapper.Map<NhanVienEntity>(nhanVienModel);
                await _INhanVienRepo.UpdateAsync(_NhanVienEntityUpdate);
                var _NhanVienEntity_repo = await _INhanVienRepo.UpdateAsync(_NhanVienEntityUpdate);
                return (_NhanVienEntity_repo != null) ? _IMapper.Map<NhanVienModel>(_NhanVienEntity_repo) : null;
            }
            return null;
        }
    }
}
