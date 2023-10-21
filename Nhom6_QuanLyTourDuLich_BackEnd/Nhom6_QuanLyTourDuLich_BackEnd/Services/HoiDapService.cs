using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class HoiDapService: IHoiDapService
    {
        public readonly IHoiDapRepository _IHoiDapRepository;
        public IMapper _IMapper;
        public HoiDapService(IHoiDapRepository _IHoiDapRepository, IMapper _IMapper)
        {
            this._IHoiDapRepository = _IHoiDapRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(HoiDap_repo _HoiDap_Repo)
        {

            HoiDapEntity _HoiDapEntity = _IMapper.Map<HoiDapEntity>(_HoiDap_Repo);
            return await _IHoiDapRepository.AddAsync(_HoiDapEntity);
        }

        public async Task<bool> Clear(string IdTour)
        {
            return await _IHoiDapRepository.Clear(IdTour);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            var _HoiDapEntiy = await _IHoiDapRepository.GetOneByIDAsync(ID);
            if (_HoiDapEntiy != null)
                return await _IHoiDapRepository.DeleteAsync(_HoiDapEntiy);
            return false;
        }


        public async Task<List<HoiDapModel>> GetAllAsync(string IdTour)
        {
            var listHoiDapEnity = await _IHoiDapRepository.GetAllAsync(IdTour);

            if (listHoiDapEnity != null)
            {
                List<HoiDapModel> listHoiDapModel = _IMapper.Map<List<HoiDapModel>>(listHoiDapEnity);
                return listHoiDapModel;
            }
            return null;
        }

        //public async Task<HoiDapModel> GetLastAsync()
        //{
        //    HoiDapEntity HoiDap = await _IHoiDapRepository.GetLastAsync();
        //    if (HoiDap != null)
        //    {
        //        HoiDapModel _HoiDapModel = _IMapper.Map<HoiDapModel>(HoiDap);
        //        return _HoiDapModel;
        //    }
        //    return null;
        //}

        public async Task<HoiDapModel> GetOneByIDAsync(string Id)
        {
            var _HoiDapEntity = await _IHoiDapRepository.GetOneByIDAsync(Id);

            if (_HoiDapEntity != null)
            {
                HoiDapModel _HoiDapModel = _IMapper.Map<HoiDapModel>(_HoiDapEntity);
                return _HoiDapModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(HoiDapModel HoiDapModel)
        {
            var _HoiDapEntity = await _IHoiDapRepository.GetOneByIDAsync(HoiDapModel.IdHoiDap);
            if (_HoiDapEntity != null)
            {
                var _HoiDapEntityUpdate = _IMapper.Map<HoiDapEntity>(HoiDapModel);
                return await _IHoiDapRepository.UpdateAsync(_HoiDapEntityUpdate);
            }
            return false;
        }
    }
}
