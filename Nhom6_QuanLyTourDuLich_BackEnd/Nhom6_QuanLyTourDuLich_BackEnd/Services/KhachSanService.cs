using AutoMapper;
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

        public Task<bool> AddAsync(KhachSan_repo khachSan_repo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<KhachSanModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<KhachSanModel> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<KhachSanModel>> GetListByHangSao(string hangSao)
        {
            throw new NotImplementedException();
        }

        public Task<KhachSanModel> GetOneByXaIdAsync(string xaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(KhachSanModel khachSanModel)
        {
            throw new NotImplementedException();
        }
    }
}
