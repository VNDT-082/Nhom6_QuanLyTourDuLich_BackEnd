using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class TaiKhoanService:ITaiKhoanService
    {
        public readonly ITaiKhoanRepository _ITaiKhoanRepository;
        public IMapper _IMapper;
        public TaiKhoanService(ITaiKhoanRepository _ITaiKhoanRepository, IMapper _IMapper)
        {
            this._ITaiKhoanRepository = _ITaiKhoanRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(TaiKhoan_repo taiKhoan_repo)
        {
            TaiKhoanEntity taiKhoanLast = await _ITaiKhoanRepository.GetLastAsync();
            TaiKhoanEntity taiKhoanEntity = _IMapper.Map<TaiKhoanEntity>(taiKhoan_repo);
            if (taiKhoanLast != null)
            {
                taiKhoanEntity.Id = GenarateId.setIdTaiKhoan(taiKhoanLast.Id);
            }
            else
            {
                taiKhoanEntity.Id = "TK001";
            }
            return await _ITaiKhoanRepository.AddAsync(taiKhoanEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            TaiKhoanEntity taiKhoan = await _ITaiKhoanRepository.GetOneByIdAsync(ID);
            if (taiKhoan != null)
            {
                return await _ITaiKhoanRepository.DeleteAsync(taiKhoan);
            }
            return false;
        }

        public async Task<List<TaiKhoanModel>> GetAllAsync()
        {
            List<TaiKhoanEntity> listTaiKhoan = await _ITaiKhoanRepository.GetAllAsync();
            if (listTaiKhoan != null || listTaiKhoan.Count > 0)
            {
                List<TaiKhoanModel> listTaiKhoanModel = _IMapper.Map<List<TaiKhoanModel>>(listTaiKhoan);
                return listTaiKhoanModel;
            }
            return null;
        }

        public async Task<TaiKhoanModel> GetLastAsync()
        {
            TaiKhoanEntity taiKhoanEntity = await _ITaiKhoanRepository.GetLastAsync();
            if (taiKhoanEntity != null)
            {
                TaiKhoanModel taiKhoanModel = _IMapper.Map<TaiKhoanModel>(taiKhoanEntity);
                return taiKhoanModel;
            }
            return null;
        }

        public async Task<List<TaiKhoanModel>> GetListByTrangThai(bool trangThai)
        {
            List<TaiKhoanEntity> listTaiKhoan = await _ITaiKhoanRepository.GetListByTrangThai(trangThai);
            if (listTaiKhoan != null || listTaiKhoan.Count > 0)
            {
                List<TaiKhoanModel> listTaiKhoanModel = _IMapper.Map<List<TaiKhoanModel>>(listTaiKhoan);
                return listTaiKhoanModel;
            }
            return null;
        }

        public async Task<TaiKhoanModel> GetOneByIdAsync(string Id)
        {
            TaiKhoanEntity taiKhoanEntity = await _ITaiKhoanRepository.GetOneByIdAsync(Id);
            if (taiKhoanEntity != null)
            {
                TaiKhoanModel taiKhoanModel = _IMapper.Map<TaiKhoanModel>(taiKhoanEntity);
                return taiKhoanModel;
            }
            return null;
        }

        public Task<TaiKhoanModel> LoginAsync(string soDienThoaiOrEmail)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(TaiKhoanModel taiKhoanModel)
        {
            TaiKhoanEntity taiKhoan = await _ITaiKhoanRepository.GetOneByIdAsync(taiKhoanModel.Id);
            if (taiKhoan != null)
            {
                TaiKhoanEntity taiKhoanEntity = _IMapper.Map<TaiKhoanEntity>(taiKhoanModel);
                return await _ITaiKhoanRepository.UpdateAsync(taiKhoanEntity);
            }
            return false;
        }
    }
}
