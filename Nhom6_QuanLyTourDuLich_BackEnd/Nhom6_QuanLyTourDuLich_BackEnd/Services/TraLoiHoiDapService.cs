using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class TraLoiHoiDapService:ITraLoiHoiDapService
    {
        public readonly ITraLoiHoiDapRepository _ITraLoiHoiDapRepository;
        public IMapper _IMapper;
        public TraLoiHoiDapService(ITraLoiHoiDapRepository _ITraLoiHoiDapRepository, IMapper _IMapper)
        {
            this._ITraLoiHoiDapRepository = _ITraLoiHoiDapRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(TraLoiHoiDap_repo _TraLoiHoiDap_Repo)
        {

            TraLoiHoiDapEntity _TraLoiHoiDapEntity = _IMapper.Map<TraLoiHoiDapEntity>(_TraLoiHoiDap_Repo);
            return await _ITraLoiHoiDapRepository.AddAsync(_TraLoiHoiDapEntity);
        }

        public async Task<bool> Clear(string IdHoiDap)
        {
            return await _ITraLoiHoiDapRepository.Clear(IdHoiDap);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            var _TraLoiHoiDapEntiy = await _ITraLoiHoiDapRepository.GetOneByIDAsync(ID);
            if (_TraLoiHoiDapEntiy != null)
                return await _ITraLoiHoiDapRepository.DeleteAsync(_TraLoiHoiDapEntiy);
            return false;
        }


        public async Task<List<TraLoiHoiDapModel>> GetAllAsync(string IdHoiDap)
        {
            var listTraLoiHoiDapEnity = await _ITraLoiHoiDapRepository.GetAllAsync(IdHoiDap);

            if (listTraLoiHoiDapEnity != null)
            {
                List<TraLoiHoiDapModel> listTraLoiHoiDapModel = _IMapper.Map<List<TraLoiHoiDapModel>>(listTraLoiHoiDapEnity);
                return listTraLoiHoiDapModel;
            }
            return null;
        }

        //public async Task<TraLoiHoiDapModel> GetLastAsync()
        //{
        //    TraLoiHoiDapEntity TraLoiHoiDap = await _ITraLoiHoiDapRepository.GetLastAsync();
        //    if (TraLoiHoiDap != null)
        //    {
        //        TraLoiHoiDapModel _TraLoiHoiDapModel = _IMapper.Map<TraLoiHoiDapModel>(TraLoiHoiDap);
        //        return _TraLoiHoiDapModel;
        //    }
        //    return null;
        //}

        public async Task<TraLoiHoiDapModel> GetOneByIDAsync(string Id)
        {
            var _TraLoiHoiDapEntity = await _ITraLoiHoiDapRepository.GetOneByIDAsync(Id);

            if (_TraLoiHoiDapEntity != null)
            {
                TraLoiHoiDapModel _TraLoiHoiDapModel = _IMapper.Map<TraLoiHoiDapModel>(_TraLoiHoiDapEntity);
                return _TraLoiHoiDapModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(TraLoiHoiDapModel TraLoiHoiDapModel)
        {
            var _TraLoiHoiDapEntity = await _ITraLoiHoiDapRepository.GetOneByIDAsync(TraLoiHoiDapModel.IdTraLoiHoiDap);
            if (_TraLoiHoiDapEntity != null)
            {
                var _TraLoiHoiDapEntityUpdate = _IMapper.Map<TraLoiHoiDapEntity>(TraLoiHoiDapModel);
                return await _ITraLoiHoiDapRepository.UpdateAsync(_TraLoiHoiDapEntityUpdate);
            }
            return false;
        }
    }
}
