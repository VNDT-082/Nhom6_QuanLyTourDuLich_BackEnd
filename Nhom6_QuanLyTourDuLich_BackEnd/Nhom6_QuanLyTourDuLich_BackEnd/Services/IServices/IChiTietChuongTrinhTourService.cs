using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IChiTietChuongTrinhTourService
    {
        public Task<List<ChiTietChuongTrinhTourModel>> GetListByTourId(string maTour);
        public Task<ChiTietChuongTrinhTourModel> GetOneByIDAsync(string Id);
        public Task<ChiTietChuongTrinhTourModel> GetLastAsync();
        public Task<bool> AddAsync(ChiTietChuongTrinhTour_repo chiTietChuongTrinhTour_repo);
        public Task<bool> UpdateAsync(ChiTietChuongTrinhTourModel chiTietChuongTrinhTourModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
