using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class HuyenService:IHuyenService
    {
        public readonly IHuyenRepository _IHuyenRepo;
        public IMapper _IMapper;
        public HuyenService(IHuyenRepository _IHuyenRepo, IMapper _IMapper)
        {
            this._IHuyenRepo = _IHuyenRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(Huyen_repo huyen_repo)
        {
            HuyenEntity huyenEntity = await _IHuyenRepo.GetLastAsync();
            if (huyenEntity != null)
            {
                huyenEntity.tenHuyen = huyen_repo.tenHuyen;
                huyenEntity.Id = GenarateId.setIdHuyen(huyenEntity.Id);
            }
            else
            {
                huyenEntity.Id = "H001";
            }
            return await _IHuyenRepo.AddAsync(huyenEntity);
        }

        public Task<bool> DeleteAsync(string maHuyen)
        {
            throw new NotImplementedException();
        }

        public Task<List<HuyenModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<HuyenModel> GetLastAsync()
        {
            HuyenEntity huyenEntity = await _IHuyenRepo.GetLastAsync();
            if (huyenEntity != null)
            {
                HuyenModel huyenModel = _IMapper.Map<HuyenModel>(huyenEntity);
                return huyenModel;
            }
            return null;
        }

        public async Task<List<HuyenModel>> GetListByTinhIdAsync(string maTinh)
        {
            List<HuyenEntity> list = await _IHuyenRepo.GetListByTinhIdAsync(maTinh);
            if (list != null || list.Count > 0)
            { 
                var listModel = _IMapper.Map<List<HuyenModel>>(list);
                return listModel;
            }
            return null;
        }

        public async Task<HuyenModel> GetOneByIDAsync(string Id)
        {
            HuyenEntity huyenEntity = await _IHuyenRepo.GetOneByIDAsync(Id);
            if (huyenEntity != null)
            { 
                HuyenModel huyenModel = _IMapper.Map<HuyenModel>(huyenEntity);
                return huyenModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(HuyenModel huyenModel)
        {
            var huyenEntity = await _IHuyenRepo.GetOneByIDAsync(huyenModel.Id);
            if (huyenEntity != null)
            {
                var huyen = _IMapper.Map<HuyenEntity>(huyenModel);
                await _IHuyenRepo.UpdateAsync(huyen);
                return true;
            }
            return false;
        }
    }
}
