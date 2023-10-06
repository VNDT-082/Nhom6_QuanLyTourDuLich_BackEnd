using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class LoaiTourService : ILoaiTourServices
    {
        public readonly ILoaiTourRepository _ILoaiTourRepo;
        public IMapper _IMapper;
        public LoaiTourService(ILoaiTourRepository _ILoaiTourRepo, IMapper _IMapper)
        {
            this._ILoaiTourRepo = _ILoaiTourRepo;
            this._IMapper = _IMapper;
        }
        public async Task<bool> AddAsync(LoaiTour_repo loaiTour)
        {
            LoaiTourEntity loaiTourLast = await _ILoaiTourRepo.GetLastAsync();
            LoaiTourEntity loaiTourEntity = new LoaiTourEntity();
            loaiTourEntity.tenLoai = loaiTour.tenLoai;
            if (loaiTourLast != null)
            {
                loaiTourEntity.Id = GenarateId.setIdLoaiTour(loaiTourLast.Id);
            }
            else
            {
                loaiTourEntity.Id = "LT001";
            }
            await _ILoaiTourRepo.AddAsync(loaiTourEntity);
            return true;
            
        }

        public async Task<bool> DeleteAsync(string Id)
        {
            var loaiTour = await _ILoaiTourRepo.GetOneByIDAsync(Id);
            if (loaiTour != null)
            {
                await _ILoaiTourRepo.DeleteAsync(loaiTour);
                return true;
            }
            return false;
        }

        public async Task<List<LoaiTourModel>> GetAllAsync()
        {
            var listLoaiTourEnity = await _ILoaiTourRepo.GetAllAsync();
            List<LoaiTourModel> listLoaiTourModel = new List<LoaiTourModel>();
            if (listLoaiTourEnity.Count > 0)
            { 
                foreach (var item in listLoaiTourEnity)
                {
                    var loaiTour = _IMapper.Map<LoaiTourModel>(item);
                    listLoaiTourModel.Add(loaiTour);
                }
                return listLoaiTourModel;
            }
            return null;
        }

        public async Task<LoaiTourModel> GetOneByIdAsync(string Id)
        {
            var loaiTourEntity = await _ILoaiTourRepo.GetOneByIDAsync(Id);
            var loaiTourModel = _IMapper.Map<LoaiTourModel>(loaiTourEntity);
            return (loaiTourModel!=null)?loaiTourModel:null;
        }

        public async Task<bool> UpdateAsync(LoaiTourModel loaiTour)
        {
            var loaiTourEntity = await _ILoaiTourRepo.GetOneByIDAsync(loaiTour.Id);
            if (loaiTourEntity != null)
            {
                loaiTourEntity.tenLoai = loaiTour.tenLoai;
                await _ILoaiTourRepo.UpdateAsync(loaiTourEntity);
                return true;
            }
            return false;
        }
        public async Task<LoaiTourModel> GetLastAsync()
        {
            var loaiTourEntity = await _ILoaiTourRepo.GetLastAsync();
            if (loaiTourEntity != null)
            {
                var loaiTourModel = _IMapper.Map<LoaiTourModel>(loaiTourEntity);
                return loaiTourModel;
            }
            return null;
        }
    }
}
