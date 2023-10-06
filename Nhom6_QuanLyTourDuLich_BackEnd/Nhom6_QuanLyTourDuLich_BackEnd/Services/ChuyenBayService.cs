using AutoMapper;
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

        public Task<bool> AddAsync(ChuyenBay_repo chuyenBay_repo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChuyenBayModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChuyenBayModel> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ChuyenBayModel>> GetListKhuHoi(bool khuHoi)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChuyenBayModel>> GetListNoiDen(string maSanBay)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChuyenBayModel>> GetListNoiDi(string maSanBay)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChuyenBayModel>> GetListTheoNgay(DateTime gioDi, DateTime gioDen)
        {
            throw new NotImplementedException();
        }

        public Task<ChuyenBayModel> GetOneByIDAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ChuyenBayModel chuyenBayModel)
        {
            throw new NotImplementedException();
        }
    }
}
