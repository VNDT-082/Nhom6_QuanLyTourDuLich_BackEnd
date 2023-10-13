using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class ChiTietChuongTrinhTourService:IChiTietChuongTrinhTourService
    {
        public readonly IChiTietChuongTrinhTourRepository _IChiTietChuongTrinhTourRepo;
        public IMapper _IMapper;
        public ChiTietChuongTrinhTourService(IChiTietChuongTrinhTourRepository _IChiTietChuongTrinhTourRepo, IMapper _IMapper)
        {
            this._IChiTietChuongTrinhTourRepo = _IChiTietChuongTrinhTourRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(ChiTietChuongTrinhTour_repo chiTietChuongTrinhTour_repo)
        {
            ChiTietChuongTrinhTourEntity chiTietChuongTrinhTourEntity = _IMapper.Map<ChiTietChuongTrinhTourEntity>(chiTietChuongTrinhTour_repo);
            //DateTime time = DateTime.Now;
            //chiTietChuongTrinhTourEntity.IdChiTietChuongTrinhTour = "CTT" + time.ToString("yyyyMMddHHmmss");
            return await _IChiTietChuongTrinhTourRepo.AddAsync(chiTietChuongTrinhTourEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            var chiTietChuongTrinhTour = await _IChiTietChuongTrinhTourRepo.GetOneByIDAsync(ID);
            if (chiTietChuongTrinhTour != null)
            {
                await _IChiTietChuongTrinhTourRepo.DeleteAsync(chiTietChuongTrinhTour);
                return true;
            }
            return false;
        }

        public async Task<ChiTietChuongTrinhTourModel> GetLastAsync()
        {
            var chiTietChuongTrinhTour = await _IChiTietChuongTrinhTourRepo.GetLastAsync();
            if (chiTietChuongTrinhTour != null)
            {
                var chiTietChuongTrinhTourModel = _IMapper.Map<ChiTietChuongTrinhTourModel>(chiTietChuongTrinhTour);
                return chiTietChuongTrinhTourModel;
            }
            return null;
        }

        public async Task<List<ChiTietChuongTrinhTourModel>> GetListByTourId(string maTour)
        {
            List<ChiTietChuongTrinhTourEntity> listChiTietChuongTrinhTour = await _IChiTietChuongTrinhTourRepo.GetListByTourId(maTour);
            if (listChiTietChuongTrinhTour != null || listChiTietChuongTrinhTour.Count>0)
            {
                List<ChiTietChuongTrinhTourModel> listChiTietChuongTrinhTourModel = _IMapper
                    .Map<List<ChiTietChuongTrinhTourModel>>(listChiTietChuongTrinhTour);
                return listChiTietChuongTrinhTourModel;
            }
            return null;
        }

        public async Task<ChiTietChuongTrinhTourModel> GetOneByIDAsync(string Id)
        {
            var chiTietChuongTrinhTour = await _IChiTietChuongTrinhTourRepo.GetOneByIDAsync(Id);
            if (chiTietChuongTrinhTour != null)
            {
                var chiTietChuongTrinhTourModel = _IMapper.Map<ChiTietChuongTrinhTourModel>(chiTietChuongTrinhTour);
                return chiTietChuongTrinhTourModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(ChiTietChuongTrinhTourModel chiTietChuongTrinhTourModel)
        {
            var chiTietChuongTrinhTourEntity = await _IChiTietChuongTrinhTourRepo
                .GetOneByIDAsync(chiTietChuongTrinhTourModel.IdChiTietChuongTrinhTour);
            if (chiTietChuongTrinhTourEntity != null)
            {
                ChiTietChuongTrinhTourEntity chiTietChuongTrinhTour = _IMapper
                    .Map<ChiTietChuongTrinhTourEntity>(chiTietChuongTrinhTourModel);
                return await _IChiTietChuongTrinhTourRepo.UpdateAsync(chiTietChuongTrinhTour);
            }
            return false;
        }
    }
}
