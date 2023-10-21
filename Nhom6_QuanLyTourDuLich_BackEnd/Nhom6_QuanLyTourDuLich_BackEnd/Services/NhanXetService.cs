using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class NhanXetService:INhanXetService
    {
        public readonly INhanXetRepository _INhanXetRepository;
        public IMapper _IMapper;
        public NhanXetService(INhanXetRepository _INhanXetRepository, IMapper _IMapper)
        {
            this._INhanXetRepository = _INhanXetRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(NhanXet_repo _NhanXet_Repo)
        {

            NhanXetEntity _NhanXetEntity = _IMapper.Map<NhanXetEntity>(_NhanXet_Repo);
            return await _INhanXetRepository.AddAsync(_NhanXetEntity);
        }

        public async Task<bool> Clear(string IdTour)
        {
            return await _INhanXetRepository.Clear(IdTour);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            var _NhanXetEntiy = await _INhanXetRepository.GetOneByIDAsync(ID);
            if (_NhanXetEntiy != null)
                return await _INhanXetRepository.DeleteAsync(_NhanXetEntiy);
            return false;
        }


        public async Task<List<NhanXetModel>> GetAllAsync(string Id)
        {
            var listNhanXetEnity = await _INhanXetRepository.GetAllAsync(Id);

            if (listNhanXetEnity!=null)
            {
                List<NhanXetModel> listNhanXetModel = _IMapper.Map<List<NhanXetModel>>(listNhanXetEnity);
                return listNhanXetModel;
            }
            return null;
        }

        //public async Task<NhanXetModel> GetLastAsync()
        //{
        //    NhanXetEntity NhanXet = await _INhanXetRepository.GetLastAsync();
        //    if (NhanXet != null)
        //    {
        //        NhanXetModel _NhanXetModel = _IMapper.Map<NhanXetModel>(NhanXet);
        //        return _NhanXetModel;
        //    }
        //    return null;
        //}

        public async Task<NhanXetModel> GetOneByIDAsync(string Id)
        {
            var _NhanXetEntity = await _INhanXetRepository.GetOneByIDAsync(Id);

            if (_NhanXetEntity != null)
            {
                NhanXetModel _NhanXetModel = _IMapper.Map<NhanXetModel>(_NhanXetEntity);
                return _NhanXetModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(NhanXetModel NhanXetModel)
        {
            var _NhanXetEntity = await _INhanXetRepository.GetOneByIDAsync(NhanXetModel.IdNhanXet);
            if (_NhanXetEntity != null)
            {
                var _NhanXetEntityUpdate = _IMapper.Map<NhanXetEntity>(NhanXetModel);
                return await _INhanXetRepository.UpdateAsync(_NhanXetEntityUpdate);
            }
            return false;
        }
    }
}
