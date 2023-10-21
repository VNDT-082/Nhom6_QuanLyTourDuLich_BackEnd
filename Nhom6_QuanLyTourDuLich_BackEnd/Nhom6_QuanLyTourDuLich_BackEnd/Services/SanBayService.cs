using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class SanBayService:ISanBayService
    {
        public readonly ISanBayRepository _ISanBayRepo;
        public IMapper _IMapper;
        public SanBayService(ISanBayRepository _ISanBayRepo, IMapper _IMapper)
        {
            this._ISanBayRepo = _ISanBayRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(SanBay_repo sanBay_repo)
        {
            SanBayEntity _SanBayEntity = _IMapper.Map<SanBayEntity>(sanBay_repo);
            //DateTime time = DateTime.Now;
            //_SanBayEntity.Id = "NV" + time.ToString("yyyyMMddHHmmss");
            await _ISanBayRepo.AddAsync(_SanBayEntity);
            return true;
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            var _SanBayEntiy = await _ISanBayRepo.GetOneByIDAsync(ID);
            if (_SanBayEntiy != null)
                return await _ISanBayRepo.DeleteAsync(_SanBayEntiy);
            return false;
        }

        public async Task<List<SanBayModel>> GetAllAsync()
        {
            var listSanBayEnity = await _ISanBayRepo.GetAllAsync();

            if (listSanBayEnity!=null)
            {
                List<SanBayModel> listSanBayModel = _IMapper.Map<List<SanBayModel>>(listSanBayEnity);
                return listSanBayModel;
            }
            return null;
        }

        public async Task<SanBayModel> GetLastAsync()
        {
            SanBayEntity SanBay = await _ISanBayRepo.GetLastAsync();
            if (SanBay != null)
            {
                SanBayModel _SanBayModel = _IMapper.Map<SanBayModel>(SanBay);
                return _SanBayModel;
            }
            return null;
        }

        public async Task<SanBayModel> GetOneByIDAsync(string Id)
        {
            var _SanBayEntity = await _ISanBayRepo.GetOneByIDAsync(Id);

            if (_SanBayEntity != null)
            {
                SanBayModel _SanBayModel = _IMapper.Map<SanBayModel>(_SanBayEntity);
                return _SanBayModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(SanBayModel sanBayModel)
        {
            var _SanBayEntity = await _ISanBayRepo.GetOneByIDAsync(sanBayModel.IdSanBay);
            if (_SanBayEntity != null)
            {
                var _SanBayEntityUpdate = _IMapper.Map<SanBayEntity>(sanBayModel);
                await _ISanBayRepo.UpdateAsync(_SanBayEntityUpdate);
                return true;
            }
            return false;
        }
    }
}
