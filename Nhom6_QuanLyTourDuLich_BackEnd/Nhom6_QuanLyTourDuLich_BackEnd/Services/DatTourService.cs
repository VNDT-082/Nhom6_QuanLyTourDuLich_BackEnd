using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class DatTourService:IDatTourService
    {
        public readonly IDatTourRepository _IDatTourRepo;
        public IMapper _IMapper;
        public DatTourService(IDatTourRepository _IDatTourRepo, IMapper _IMapper)
        {
            this._IDatTourRepo = _IDatTourRepo;
            this._IMapper = _IMapper;
        }

        public async Task<bool> AddAsync(DatTour_repo datTour_repo)
        {
            DatTourEntity datTourLast = await _IDatTourRepo.GetLastAsync();
            DatTourEntity datTourEntity = _IMapper.Map<DatTourEntity>(datTour_repo);
            if (datTourLast != null)
            {
                datTourEntity.Id = GenarateId.setIdDatTour(datTourLast.Id);
            }
            else
            {
                datTourEntity.Id = "DT001";
            }
            return await _IDatTourRepo.AddAsync(datTourEntity);
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            DatTourEntity datTour = await _IDatTourRepo.GetOneByIDAsync(ID);
            if (datTour != null)
            {
                return await _IDatTourRepo.DeleteAsync(datTour);
            }
            return false;
        }

        public async Task<List<DatTourModel>> GetAllAsync()
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetAllAsync();
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetAllAsync(bool trangThai)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetAllAsync(trangThai);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<DatTourModel> GetLastAsync()
        {
            DatTourEntity datTour = await _IDatTourRepo.GetLastAsync();
            if (datTour != null)
            {
                DatTourModel datTourModel = _IMapper.Map<DatTourModel>(datTour);
                return datTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListByHuongDanVienIdAsync(string? maHuongDanVien)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListByHuongDanVienIdAsync(maHuongDanVien);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListByKhachHangIdAsync(string maKhach)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListByKhachHangIdAsync(maKhach);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListByTourIdAsync(string maTour)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListByTourIdAsync(maTour);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListByTourIdAsync(string maTour, bool trangThai)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListByTourIdAsync(maTour,trangThai);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListTheoNgayDatAsync(ngayMin,ngayMax);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayDat)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListTheoNgayDatAsync(ngayDat);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax, bool trangThai)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListTheoNgayDatAsync(ngayMin, ngayMax, trangThai);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<List<DatTourModel>> GetListTheoNgayDatAsync(DateTime ngayDat, bool trangThai)
        {
            List<DatTourEntity> listDatTour = await _IDatTourRepo.GetListTheoNgayDatAsync(ngayDat,trangThai);
            if (listDatTour != null)
            {
                List<DatTourModel> listDatTourModel = _IMapper.Map<List<DatTourModel>>(listDatTour);
                return listDatTourModel;
            }
            return null;
        }

        public async Task<DatTourModel> GetOneByIDAsync(string Id)
        {
            DatTourEntity datTour = await _IDatTourRepo.GetOneByIDAsync(Id);
            if (datTour != null)
            {
                DatTourModel datTourModel = _IMapper.Map<DatTourModel>(datTour);
                return datTourModel;
            }
            return null; 
        }

        public async Task<bool> UpdateAsync(DatTourModel datTourModel)
        {
            DatTourEntity datTour = await _IDatTourRepo.GetOneByIDAsync(datTourModel.Id);
            if (datTour != null)
            {
                DatTourEntity datTourEntity = _IMapper.Map<DatTourEntity>(datTourModel);
                return await _IDatTourRepo.UpdateAsync(datTourEntity);
            }
            return false;
        }
    }
}
