using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class DanhMucHinhService:IDanhMucHinhService
    {
        public readonly IDanhMucHinhRepository _IDanhMucHinhRepo;
        public IMapper _IMapper;
        public DanhMucHinhService(IDanhMucHinhRepository _IDanhMucHinhRepo, IMapper _IMapper)
        {
            this._IDanhMucHinhRepo = _IDanhMucHinhRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(DanhMucHinh_repo danhMucHinh_repo)
        {
            DanhMucHinhEntity danhMucHinhEntity = _IMapper.Map<DanhMucHinhEntity>(danhMucHinh_repo);
            //DateTime time = DateTime.Now;
            //danhMucHinhEntity.Id = "Tour" + time.ToString("yyyyMMddHHmmss");
            return await _IDanhMucHinhRepo.AddAsync(danhMucHinhEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            DanhMucHinhEntity danhMucHinh = await _IDanhMucHinhRepo.GetOneByIDAsync(ID);
            if (danhMucHinh != null)
            {
                return await _IDanhMucHinhRepo.DeleteAsync(danhMucHinh);
            }
            return false;
        }

        public async Task<List<DanhMucHinhModel>> GetAllAsync(string maTour)
        {
            List<DanhMucHinhEntity> listDanhMucHinh = await _IDanhMucHinhRepo.GetAllAsync(maTour);
            if (listDanhMucHinh != null)
            {
                List<DanhMucHinhModel> listDanhMucHinhModel = _IMapper.Map<List<DanhMucHinhModel>>(listDanhMucHinh);
                return listDanhMucHinhModel;
            }
            return null;
        }

        public async Task<DanhMucHinhModel> GetLastAsync()
        {

            DanhMucHinhEntity danhMucHinh = await _IDanhMucHinhRepo.GetLastAsync();
            if (danhMucHinh != null)
            {
                DanhMucHinhModel danhMucHinhModel = _IMapper.Map<DanhMucHinhModel>(danhMucHinh);
                return danhMucHinhModel;
            }
            return null;
        }

        public async Task<DanhMucHinhModel> GetLastOfTourAsync(string maTour)
        {
            DanhMucHinhEntity danhMucHinh = await _IDanhMucHinhRepo.GetLastOfTourAsync(maTour);
            if (danhMucHinh != null)
            {
                DanhMucHinhModel danhMucHinhModel = _IMapper.Map<DanhMucHinhModel>(danhMucHinh);
                return danhMucHinhModel;
            }
            return null;
        }

        public async Task<DanhMucHinhModel> GetOneByIDAsync(string Id)
        {
            DanhMucHinhEntity danhMucHinh = await _IDanhMucHinhRepo.GetLastAsync();
            if (danhMucHinh != null)
            {
                DanhMucHinhModel danhMucHinhModel = _IMapper.Map<DanhMucHinhModel>(danhMucHinh);
                return danhMucHinhModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(DanhMucHinhModel danhMucHinhModel)
        {
            DanhMucHinhEntity danhMucHinh = await _IDanhMucHinhRepo.GetOneByIDAsync(danhMucHinhModel.IdDanhMucHinh);
            if (danhMucHinh != null)
            {
                DanhMucHinhEntity danhMucHinhEntity = _IMapper.Map<DanhMucHinhEntity>(danhMucHinhModel);
                return await _IDanhMucHinhRepo.UpdateAsync(danhMucHinhEntity);
            }
            return false;
            
        }
    }
}
