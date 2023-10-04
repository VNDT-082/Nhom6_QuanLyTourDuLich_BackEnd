using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class TourService:ITourService
    {
        public readonly ITourRepository _ITourRepo;
        public IMapper _IMapper;
        public TourService(ITourRepository _ITourRepo, IMapper _IMapper)
        {
            this._ITourRepo = _ITourRepo;
            this._IMapper = _IMapper;
        }

        public Task AddAsync(Tour_repo tourRepo)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TourModel tourModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TourModel>> GetAllAsync()
        {
            var listTourEnity = await _ITourRepo.GetAllAsync();

            List<TourModel> listTourModel = new List<TourModel>();
            if (listTourEnity.Count > 0)
            {
                foreach (var item in listTourEnity)
                {
                    var tour = _IMapper.Map<TourModel>(item);
                    listTourModel.Add(tour);
                }
                return listTourModel;
            }
            return null;
        }

        public Task<List<TourModel>> GetAllAsync(bool trangThai)
        {
            throw new NotImplementedException();
        }

        public Task<TourModel> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<TourModel>> GetListTheoGia(double giaMin, double giaMax)
        {
            throw new NotImplementedException();
        }

        public Task<List<TourModel>> GetListTheoLoai(string maLoai)
        {
            throw new NotImplementedException();
        }

        public Task<List<TourModel>> GetListTheoLoai(string maLoai, bool trangThai)
        {
            throw new NotImplementedException();
        }

        public Task<List<TourModel>> GetListTheoNguoiLap(string maNhanVien)
        {
            throw new NotImplementedException();
        }

        public Task<TourModel> GetOneByIDAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TourModel>> GetPage(byte pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Task<List<TourModel>> GetPage(byte pageSize, int pageNumber, bool trangThai)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TourModel tourModel)
        {
            throw new NotImplementedException();
        }
    }
}
