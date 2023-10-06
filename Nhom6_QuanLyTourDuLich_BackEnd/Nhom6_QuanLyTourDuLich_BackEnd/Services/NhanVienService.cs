using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class NhanVienService:INhanVienService
    {
        public readonly INhanVienRepository _INhanVienRepo;
        public IMapper _IMapper;
        public NhanVienService(INhanVienRepository _INhanVienRepo, IMapper _IMapper)
        {
            this._INhanVienRepo = _INhanVienRepo;
            this._IMapper = _IMapper;
        }

        public Task<bool> AddAsync(NhanVien_repo nhaVien_repo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<NhanVienModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NhanVienModel> GetLastAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<NhanVienModel>> GetListByLoaiNhanVienIdAsync(string maLoaiNhanVien)
        {
            throw new NotImplementedException();
        }

        public Task<NhanVienModel> GetOneByCCCDAsync(string canCuocConDan)
        {
            throw new NotImplementedException();
        }

        public Task<NhanVienModel> GetOneByIDAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(NhanVienModel nhanVienModel)
        {
            throw new NotImplementedException();
        }
    }
}
