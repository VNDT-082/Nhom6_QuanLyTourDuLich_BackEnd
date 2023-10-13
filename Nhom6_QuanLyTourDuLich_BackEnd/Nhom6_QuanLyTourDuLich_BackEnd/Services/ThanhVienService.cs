using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class ThanhVienService:IThanhVienService
    {
        public readonly IThanhVienRepository _IThanhVienRepository;
        public IMapper _IMapper;
        public ThanhVienService(IThanhVienRepository _IThanhVienRepository, IMapper _IMapper)
        {
            this._IThanhVienRepository = _IThanhVienRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(ThanhVien_repo thanhVienRepo)
        {
            ThanhVienEntity thanhVienEntity = _IMapper.Map<ThanhVienEntity>(thanhVienRepo);
            //DateTime time = DateTime.Now;
            //thanhVienEntity.Id = "TV" + time.ToString("yyyyMMddHHmmss");
                
            return await _IThanhVienRepository.AddAsync(thanhVienEntity);
        }

        public async Task<bool> DeleteAsync(string maThanhVien)
        {
            ThanhVienEntity thanhVienEntity = await _IThanhVienRepository.GetOneByIDAsync(maThanhVien);
            if (thanhVienEntity != null)
            {
                return await _IThanhVienRepository.DeleteAsync(thanhVienEntity);
            }   
            return false;
        }

        public async Task<List<ThanhVienModel>> GetAllAsync(string datTourId)
        {
            List<ThanhVienEntity> listThanhVienEntity = await _IThanhVienRepository.GetAllAsync(datTourId);
            if (listThanhVienEntity != null)
            {
                List<ThanhVienModel> listThanhVienModel = _IMapper.Map<List<ThanhVienModel>>(listThanhVienEntity);
                return listThanhVienModel;
            }
            return null;
        }

        public async Task<List<ThanhVienModel>> GetAllTheoGioiTinhAsync(bool gioiTinh)
        {
            List<ThanhVienEntity> listThanhVienEntity = await _IThanhVienRepository.GetAllTheoGioiTinhAsync(gioiTinh);
            if (listThanhVienEntity != null)
            {
                List<ThanhVienModel> listThanhVienModel = _IMapper.Map<List<ThanhVienModel>>(listThanhVienEntity);
                return listThanhVienModel;
            }
            return null;
        }

        public async Task<ThanhVienModel> GetLastAsync()
        {
            ThanhVienEntity thanhVienEntity = await _IThanhVienRepository.GetLastAsync();
            if (thanhVienEntity != null)
            {
                ThanhVienModel thanhVienModel = _IMapper.Map<ThanhVienModel>(thanhVienEntity);
                return thanhVienModel;
            }
            return null;
        }

        public async Task<ThanhVienModel> GetLastOfDatTourAsync(string maDatTour)
        {

            ThanhVienEntity thanhVienEntity = await _IThanhVienRepository.GetLastOfDatTourAsync(maDatTour);
            if (thanhVienEntity != null)
            {
                ThanhVienModel thanhVienModel = _IMapper.Map<ThanhVienModel>(thanhVienEntity);
                return thanhVienModel;
            }
            return null;
        }

        public async Task<List<ThanhVienModel>> GetListByDatTourID(string maDatTour)
        {
            var listThanhVienEnity = await _IThanhVienRepository.GetAllAsync(maDatTour);
            if (listThanhVienEnity.Count > 0)
            {
                List<ThanhVienModel> listThanhVienModel = _IMapper.Map<List<ThanhVienModel>>(listThanhVienEnity);
                return listThanhVienModel;
            }
            return null;
        }

        public async Task<ThanhVienModel> GetOneByIDAsync(string Id)
        {
            ThanhVienEntity thanhVienEntity = await _IThanhVienRepository.GetOneByIDAsync(Id);
            if (thanhVienEntity != null)
            {
                ThanhVienModel thanhVienModel = _IMapper.Map<ThanhVienModel>(thanhVienEntity);
                return thanhVienModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(ThanhVienModel thanhVienModel)
        {
            var thanhVienEntity = await _IThanhVienRepository.GetOneByIDAsync(thanhVienModel.IdThanhVien);
            if (thanhVienEntity != null)
            {
                ThanhVienEntity value = _IMapper.Map<ThanhVienEntity>(thanhVienModel);
                await _IThanhVienRepository.UpdateAsync(value);
                return true;
            }
            return false;
        }
    }
}
