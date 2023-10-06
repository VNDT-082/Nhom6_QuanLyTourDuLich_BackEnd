using AutoMapper;
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

        public Task<bool> AddAsync(SanBay_repo sanBay_repo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<SanBayModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SanBayModel> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SanBayModel> GetOneByIDAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(SanBayModel sanBayModel)
        {
            throw new NotImplementedException();
        }
    }
}
