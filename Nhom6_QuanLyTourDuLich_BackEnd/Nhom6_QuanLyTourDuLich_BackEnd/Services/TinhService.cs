using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services
{
    public class TinhService:ITinhService
    {
        public readonly ITinhRepository _ITinhRepo;
        public IMapper _IMapper;
        public TinhService(ITinhRepository _ITinhRepo, IMapper _IMapper)
        {
            this._ITinhRepo = _ITinhRepo;
            this._IMapper = _IMapper;
        }
    }
}
