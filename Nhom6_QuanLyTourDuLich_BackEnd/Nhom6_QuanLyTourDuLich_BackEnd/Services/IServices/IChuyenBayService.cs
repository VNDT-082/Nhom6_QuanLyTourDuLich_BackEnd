using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IChuyenBayService
    {
        public Task<List<ChuyenBayModel>> GetAllAsync();
        public Task<List<ChuyenBayModel>> GetListNoiDi(string maSanBay);
        public Task<List<ChuyenBayModel>> GetListNoiDen(string maSanBay);
        public Task<List<ChuyenBayModel>> GetListTheoNgay(DateTime gioDi, DateTime gioDen);//da co ngay kem theo
        public Task<List<ChuyenBayModel>> GetListKhuHoi(bool khuHoi);
        public Task<ChuyenBayModel> GetOneByIDAsync(string Id);
        public Task<ChuyenBayModel> GetLastAsync();
        public Task<bool> AddAsync(ChuyenBay_repo chuyenBay_repo);
        public Task<bool> UpdateAsync(ChuyenBayModel chuyenBayModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
