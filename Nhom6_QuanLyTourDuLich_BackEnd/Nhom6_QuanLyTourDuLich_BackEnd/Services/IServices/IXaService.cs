using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IXaService
    {
        public Task<bool> AddAsync(Xa_repo xaRepo);
        public Task<bool> UpdateAsync(XaModel xaModel);
        public Task<bool> DeleteAsync(string ID);
        public Task<List<XaModel>> GetAll();
        public Task<List<XaModel>> GetListByHuyenID(string maHuyen);
    }
}
