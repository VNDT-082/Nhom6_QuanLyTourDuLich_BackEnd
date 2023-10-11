using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class ChuyenBayService:IChuyenBayService
    {
        public readonly IChuyenBayRepository _IChuyenBayRepo;
        public IMapper _IMapper;
        public ChuyenBayService(IChuyenBayRepository _IChuyenBayRepo, IMapper _IMapper)
        {
            this._IChuyenBayRepo = _IChuyenBayRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(ChuyenBay_repo chuyenBay_repo)
        {
            ChuyenBayEntity _ChuyenBayEntity = _IMapper.Map<ChuyenBayEntity>(chuyenBay_repo);
            DateTime time = DateTime.Now;
            _ChuyenBayEntity.Id = "CTT" + time.ToString("yyyyMMddHHmmss");
            return await _IChuyenBayRepo.AddAsync(_ChuyenBayEntity);
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ChuyenBayModel>> GetAllAsync()
        {
            var listChuyenBay = await _IChuyenBayRepo.GetAllAsync();
            if (listChuyenBay != null||listChuyenBay.Count>0)
            {
                var listChuyenBayModel = _IMapper.Map<List<ChuyenBayModel>>(listChuyenBay);
                return listChuyenBayModel;
            }
            return null;
        }

        public async Task<ChuyenBayModel> GetLastAsync()
        {
            var _ChuyenBay = await _IChuyenBayRepo.GetLastAsync();
            if (_ChuyenBay != null)
            {
                var _ChuyenBayModel = _IMapper.Map<ChuyenBayModel>(_ChuyenBay);
                return _ChuyenBayModel;
            }
            return null;
        }

        public async Task<List<ChuyenBayModel>> GetListKhuHoi(bool khuHoi)
        {
            var listChuyenBay = await _IChuyenBayRepo.GetListKhuHoi(khuHoi);
            if (listChuyenBay != null || listChuyenBay.Count > 0)
            {
                var listChuyenBayModel = _IMapper.Map<List<ChuyenBayModel>>(listChuyenBay);
                return listChuyenBayModel;
            }
            return null;
        }

        public async Task<List<ChuyenBayModel>> GetListNoiDen(string maSanBay)
        {
            var listChuyenBay = await _IChuyenBayRepo.GetListNoiDen(maSanBay);
            if (listChuyenBay != null || listChuyenBay.Count > 0)
            {
                var listChuyenBayModel = _IMapper.Map<List<ChuyenBayModel>>(listChuyenBay);
                return listChuyenBayModel;
            }
            return null;
        }

        public async Task<List<ChuyenBayModel>> GetListNoiDi(string maSanBay)
        {
            var listChuyenBay = await _IChuyenBayRepo.GetListNoiDi(maSanBay);
            if (listChuyenBay != null || listChuyenBay.Count > 0)
            {
                var listChuyenBayModel = _IMapper.Map<List<ChuyenBayModel>>(listChuyenBay);
                return listChuyenBayModel;
            }
            return null;
        }

        public async Task<List<ChuyenBayModel>> GetListTheoNgay(DateTime gioDi, DateTime gioDen)
        {
            var listChuyenBay = await _IChuyenBayRepo.GetListTheoNgay(gioDi, gioDen);
            if (listChuyenBay != null || listChuyenBay.Count > 0)
            {
                var listChuyenBayModel = _IMapper.Map<List<ChuyenBayModel>>(listChuyenBay);
                return listChuyenBayModel;
            }
            return null;
        }

        public async Task<ChuyenBayModel> GetOneByIDAsync(string Id)
        {
            var _ChuyenBay = await _IChuyenBayRepo.GetOneByIDAsync(Id);
            if (_ChuyenBay != null)
            {
                var _ChuyenBayModel = _IMapper.Map<ChuyenBayModel>(_ChuyenBay);
                return _ChuyenBayModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(ChuyenBayModel chuyenBayModel)
        {
            var _ChuyenBayEntity = await _IChuyenBayRepo.GetOneByIDAsync(chuyenBayModel.Id);
            if (_ChuyenBayEntity != null)
            {
                ChuyenBayEntity ChuyenBayUpdate = _IMapper.Map<ChuyenBayEntity>(chuyenBayModel);
                return await _IChuyenBayRepo.UpdateAsync(ChuyenBayUpdate);
            }
            return false;
        }
    }
}
