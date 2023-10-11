using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class KhachSanService:IKhachSanService
    {
        public readonly IKhachSanRepository _IKhachSanRepo;
        public IMapper _IMapper;
        public KhachSanService(IKhachSanRepository _IKhachSanRepo, IMapper _IMapper)
        {
            this._IKhachSanRepo = _IKhachSanRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(KhachSan_repo khachSan_repo)
        {
            KhachSanEntity _KhachSanEntity = _IMapper.Map<KhachSanEntity>(khachSan_repo);
            DateTime time = DateTime.Now;
            _KhachSanEntity.Id = "Hotel" + time.ToString("yyyyMMddHHmmss");
            return await _IKhachSanRepo.AddAsync(_KhachSanEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {

            //KhachSanEntity _KhachSan = await _IKhachSanRepo.GetOneById(ID);
            //if (_KhachSan != null)
            //{
            //    return await _IKhachSanRepo.DeleteAsync(_KhachSan);
            //}
            //return false;
            throw new NotImplementedException();
        }

        public async Task<List<KhachSanModel>> GetAllAsync()
        {
            List<KhachSanEntity> listKhachSan = await _IKhachSanRepo.GetAllAsync();
            if (listKhachSan != null || listKhachSan.Count > 0)
            {
                List<KhachSanModel> listKhachSanModel = _IMapper.Map<List<KhachSanModel>>(listKhachSan);
                return listKhachSanModel;
            }
            return null;
        }

        public async Task<KhachSanModel> GetLastAsync()
        {
            KhachSanEntity _KhachSan = await _IKhachSanRepo.GetLastAsync();
            if (_KhachSan != null)
            {
                KhachSanModel _KhachSanModel = _IMapper.Map<KhachSanModel>(_KhachSan);
                return _KhachSanModel;
            }
            return null;
        }

        public async Task<List<KhachSanModel>> GetListByHangSao(string hangSao)
        {
            List<KhachSanEntity> listKhachSan = await _IKhachSanRepo.GetListByHangSao(hangSao);
            if (listKhachSan != null || listKhachSan.Count > 0)
            {
                List<KhachSanModel> listKhachSanModel = _IMapper.Map<List<KhachSanModel>>(listKhachSan);
                return listKhachSanModel;
            }
            return null;
        }

        public async Task<KhachSanModel> GetOneById(string maKhachSan)
        {
            KhachSanEntity _KhachSan = await _IKhachSanRepo.GetOneById(maKhachSan);
            if (_KhachSan != null)
            {
                KhachSanModel _KhachSanModel = _IMapper.Map<KhachSanModel>(_KhachSan);
                return _KhachSanModel;
            }
            return null;
        }



        public async Task<bool> UpdateAsync(KhachSanModel khachSanModel)
        {
            KhachSanEntity _KhachSan = await _IKhachSanRepo.GetOneById(khachSanModel.Id);
            if (_KhachSan != null)
            {
                KhachSanEntity _KhachSanEntity = _IMapper.Map<KhachSanEntity>(khachSanModel);
                return await _IKhachSanRepo.UpdateAsync(_KhachSanEntity);
            }
            return false;
        }

        public async Task<List<KhachSanModel>> GetListByXaIdAsync(string xaId)
        {
            List<KhachSanEntity> listKhachSan = await _IKhachSanRepo.GetListByXaIdAsync(xaId);
            if (listKhachSan != null || listKhachSan.Count > 0)
            {
                List<KhachSanModel> listKhachSanModel = _IMapper.Map<List<KhachSanModel>>(listKhachSan);
                return listKhachSanModel;
            }
            return null;
        }
    }
}
