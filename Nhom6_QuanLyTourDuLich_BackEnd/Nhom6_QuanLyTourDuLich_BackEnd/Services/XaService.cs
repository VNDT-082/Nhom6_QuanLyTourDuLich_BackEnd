using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class XaService : IXaService
    {
        public readonly IXaRepository _IXaRepository;
        public readonly IMapper _IMapper;
        public XaService(IXaRepository _IXaRepository, IMapper _IMapper)
        {
            this._IXaRepository = _IXaRepository;
            this._IMapper = _IMapper;
        }
        public async Task<bool> AddAsync(Xa_repo xaRepo)
        {
            XaEntity xaEntity = _IMapper.Map<XaEntity>(xaRepo);
            DateTime time = DateTime.Now;
            xaEntity.Id = "Xa" + time.ToString("yyyyMMddHHmmss");
            return await _IXaRepository.AddAsync(xaEntity);
        }

        public Task<bool> DeleteAsync(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<XaModel>> GetAll()
        {
            List<XaEntity> list = await _IXaRepository.GetAllAsync();
            if (list != null | list.Count > 0)
            {
                List<XaModel> values = _IMapper.Map<List<XaModel>>(list);
                return values;
            }
            return null;
        }

        public async Task<List<XaModel>> GetListByHuyenID(string maHuyen)
        {
            List<XaEntity> list = await _IXaRepository.GetListByHuyenId(maHuyen);
            if (list != null | list.Count > 0)
            {
                List<XaModel> values = _IMapper.Map<List<XaModel>>(list);
                return values;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(XaModel xaModel)
        {
            var xaEntity = await _IXaRepository.GetOneByIDAsync(xaModel.Id);
            if (xaEntity != null)
            {
                var value = _IMapper.Map<XaEntity>(xaModel);
                return await _IXaRepository.UpdateAsync(value);
            }
            return false;
        }
    }
}
