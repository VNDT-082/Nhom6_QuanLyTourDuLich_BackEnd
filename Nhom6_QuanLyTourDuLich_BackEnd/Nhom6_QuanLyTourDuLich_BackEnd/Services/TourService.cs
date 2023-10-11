using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class TourService:ITourService
    {
        public readonly ITourRepository _ITourRepository;
        public IMapper _IMapper;
        public TourService(ITourRepository _ITourRepository, IMapper _IMapper)
        {
            this._ITourRepository = _ITourRepository;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(Tour_repo tourRepo)
        {
            TourEntity tour = _IMapper.Map<TourEntity>(tourRepo);
            DateTime time = DateTime.Now;
            tour.Id = "Tour" + time.ToString("yyyyMMddHHmmss");
            return await _ITourRepository.AddAsync(tour);
        }

        public async Task<int> Count()
        {
            int sl =await _ITourRepository.Count();
            return sl;
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            var _TourEntity = await _ITourRepository.GetOneByIDAsync(ID);
            if(_TourEntity!=null)
                return await _ITourRepository.DeleteAsync(_TourEntity);
            return false;
        }

        public async Task<List<TourModel>> GetAllAsync()
        {
            var listTourEnity = await _ITourRepository.GetAllAsync();
            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetAllAsync(bool trangThai)
        {
            var listTourEnity = await _ITourRepository.GetAllAsync(trangThai);
            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<TourModel> GetLastAsync()
        {
            TourEntity tourEntity = await _ITourRepository.GetLastAsync();
            if (tourEntity!=null)
            {
                TourModel tourModel = _IMapper.Map<TourModel>(tourEntity);
                return tourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetListTheoGia(double giaMin, double giaMax)
        {
            var listTourEnity = await _ITourRepository.GetListTheoGia(giaMin, giaMax);

            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetListTheoLoai(string maLoai)
        {
            var listTourEnity = await _ITourRepository.GetListTheoLoai(maLoai);
            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetListTheoLoai(string maLoai, bool trangThai)
        {
            var listTourEnity = await _ITourRepository.GetListTheoLoai(maLoai, trangThai);

            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetListTheoNguoiLap(string maNhanVien)
        {
            var listTourEnity = await _ITourRepository.GetListTheoNguoiLap(maNhanVien);

            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetListTheoTen(string tenTour)
        {
            var list = await _ITourRepository.GetListTheoTen(tenTour);
            if (list != null || list.Count > 0)
            {
                List<TourModel> dsTour = _IMapper.Map<List<TourModel>>(list);
                return dsTour;
            }
            return null;
        }

        public async Task<TourModel> GetOneByIDAsync(string Id)
        {
            TourEntity tourEntity = await _ITourRepository.GetOneByIDAsync(Id);
            if (tourEntity != null)
            {
                TourModel tourModel = _IMapper.Map<TourModel>(tourEntity);
                return tourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetPage(byte pageSize, int pageNumber)
        {
            var listTourEnity = await _ITourRepository.GetPage(pageSize, pageNumber);
            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<List<TourModel>> GetPage(byte pageSize, int pageNumber, bool trangThai)
        {
            var listTourEnity = await _ITourRepository.GetPage(pageSize, pageNumber, trangThai);
           
            if (listTourEnity.Count > 0)
            {
                List<TourModel> listTourModel = _IMapper.Map<List<TourModel>>(listTourEnity);
                return listTourModel;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(TourModel tourModel)
        {
            var tinhEntity = await _ITourRepository.GetOneByIDAsync(tourModel.Id);
            if (tinhEntity != null)
            {
                TourEntity tourE = _IMapper.Map<TourEntity>(tourModel);
                await _ITourRepository.UpdateAsync(tourE);
                return true;
            }
            return false;
        }
    }
}
