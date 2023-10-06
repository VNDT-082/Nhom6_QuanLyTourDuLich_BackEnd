using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class LoaiNhanVienService:ILoaiNhanVienService
    {
        public readonly ILoaiNhanVienRepository _ILoaiNhanVienRepo;
        public IMapper _IMapper;
        public LoaiNhanVienService(ILoaiNhanVienRepository _ILoaiNhanVienRepo, IMapper _IMapper)
        {
            this._ILoaiNhanVienRepo = _ILoaiNhanVienRepo;
            this._IMapper = _IMapper;
        }

        public Task<bool> AddAsync(LoaiNhanVien_repo loaiNhanVien_repo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<LoaiNhanVienModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoaiNhanVienModel> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoaiNhanVienModel> GetOneByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(LoaiNhanVienModel loaiNhanVienModel)
        {
            throw new NotImplementedException();
        }
    }
}
