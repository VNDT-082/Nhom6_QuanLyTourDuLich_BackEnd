using AutoMapper;
using DevOne.Security.Cryptography.BCrypt;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

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

        public async Task<TaiKhoanModel> AddAsync(TaiKhoan_repo taiKhoan_repo)
        {
            TaiKhoanEntity taiKhoanEntity = _IMapper.Map<TaiKhoanEntity>(taiKhoan_repo);
            //DateTime time = DateTime.Now;
            ////taiKhoanEntity.Id = "TK" + time.ToString("yyyyMMddHHmmss");
            string salt = BCryptHelper.GenerateSalt();
            string passHashCode = BCryptHelper.HashPassword(taiKhoanEntity.matKhau, salt);
            taiKhoanEntity.matKhau = passHashCode;
            var taiKhoanEntity_repo= await _ITaiKhoanRepository.AddAsync(taiKhoanEntity);
            return (taiKhoanEntity_repo == null) ? null : _IMapper.Map<TaiKhoanModel>(taiKhoanEntity_repo);
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

        public async Task<TaiKhoanModel> LoginAsync(string soDienThoaiOrEmail,string matKhau)
        {
            TaiKhoanEntity taiKhoan = await _ITaiKhoanRepository.LoginAsync(soDienThoaiOrEmail);
            if (taiKhoan != null)
            {
                bool passwordMatch = BCryptHelper.CheckPassword(matKhau,taiKhoan.matKhau);
                if (passwordMatch==true)
                {
                    TaiKhoanModel _TaiKhoanModel = _IMapper.Map<TaiKhoanModel>(taiKhoan);
                    return _TaiKhoanModel;
                }
            }
            return null;
        }

        public async Task<TaiKhoanModel> UpdateAsync(TaiKhoanModel taiKhoanModel)
        {
            TaiKhoanEntity taiKhoan = await _ITaiKhoanRepository.GetOneByIdAsync(taiKhoanModel.IdTaiKhoan);
            if (taiKhoan != null)
            {
                TaiKhoanEntity taiKhoanEntity = _IMapper.Map<TaiKhoanEntity>(taiKhoanModel);
                string salt = BCryptHelper.GenerateSalt();
                string passHashCode = BCryptHelper.HashPassword(taiKhoanEntity.matKhau, salt);
                taiKhoanEntity.matKhau = passHashCode;

                var _TaiKhoanEntity_repo = await _ITaiKhoanRepository.UpdateAsync(taiKhoanEntity);
                return (_TaiKhoanEntity_repo != null) ? _IMapper.Map<TaiKhoanModel>(_TaiKhoanEntity_repo) : null;
            }
            return null;
        }
    }
}
