using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;


namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class TinhService:ITinhService
    {
        public readonly ITinhRepository _ITinhRepo;
        public IMapper _IMapper;
        public TinhService(ITinhRepository _ITinhRepo, IMapper _IMapper)
        {
            this._ITinhRepo = _ITinhRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(Tinh_repo tinhRepo)
        {
            TinhEntity tinhEntity = await _ITinhRepo.GetLastAsync();
            if (tinhEntity != null)
            {
                tinhEntity.tenTinh = tinhRepo.tenTinh;
                tinhEntity.Id = GenarateId.setIdTinh(tinhEntity.Id);
            }
            else
            { 
                tinhEntity.Id = "T001";
            }
            return await _ITinhRepo.AddAsync(tinhEntity);
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TinhModel>> GetAll()
        {
            List<TinhEntity> list = await _ITinhRepo.GetAllAsync();
            var listModel = _IMapper.Map<List<TinhModel>>(list);
            return listModel;
        }

        public async Task<bool> UpdateAsync(TinhModel tinhModel)
        {
            var tinhEntity = await _ITinhRepo.GetOneByIDAsync(tinhModel.Id);
            if (tinhEntity != null)
            {
                var tourE = _IMapper.Map<TinhEntity>(tinhModel);
                await _ITinhRepo.UpdateAsync(tourE);
                return true;
            }
            return false;
        }
    }
}
