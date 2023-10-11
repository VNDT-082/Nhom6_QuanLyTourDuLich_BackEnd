using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatTourController : ControllerBase
    {
        private readonly IDatTourService _IDatTourService;
        public DatTourController(IDatTourService _IDatTourService)
        {
            this._IDatTourService = _IDatTourService;
        }
        [HttpGet]
        [Route("/[Controller]/get-dat-tour")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetAllAsync();
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-one-dat-tour")]
        public async Task<IActionResult> GetOneAll(string maDatTour)
        {
            try
            {
                DatTourModel dsDatTourModel = await _IDatTourService.GetOneByIDAsync(maDatTour);
                if (dsDatTourModel != null)
                {
                    return Ok(dsDatTourModel);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-dat-tour")]
        public async Task<IActionResult> Create(DatTour_repo _DatTour_Repo)
        {
            try
            {
                bool kq = await _IDatTourService.AddAsync(_DatTour_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-dat-tour")]
        public async Task<IActionResult> Update(DatTourModel _DatTourModel)
        {
            var DatTourModel_ = await _IDatTourService.GetOneByIDAsync(_DatTourModel.Id);
            if (DatTourModel_ != null)
            {
                bool kq = await _IDatTourService.UpdateAsync(_DatTourModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-dat-tour")]
        public async Task<IActionResult> Delete(string Id)
        {
            var DatTourModel_ = await _IDatTourService.GetOneByIDAsync(Id);
            if (DatTourModel_ != null)
            {
                bool kq = await _IDatTourService.DeleteAsync(DatTourModel_.Id);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }


        [HttpGet]
        [Route("/[Controller]/get-all-dat-tour-trang-thai")]
        public async Task<IActionResult> GetAllAsync(bool trangThai)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetAllAsync(trangThai);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-by-khach-id")]
        public async Task<IActionResult> GetListByKhachHangIdAsync(string maKhach)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListByKhachHangIdAsync(maKhach);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-by-tour-id")]
        public async Task<IActionResult> GetListByTourIdAsync(string maTour)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListByTourIdAsync(maTour);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-by-tour-id-trang-thai")]
        public async Task<IActionResult> GetListByTourIdAsync(string maTour, bool trangThai)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListByTourIdAsync(maTour,trangThai);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-by-huong-dan-vien-id")]
        public async Task<IActionResult> GetListByHuongDanVienIdAsync(string? maHuongDanVien)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListByHuongDanVienIdAsync(maHuongDanVien);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-trong-khoang-ngay")]
        public async Task<IActionResult> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListTheoNgayDatAsync(ngayMin,ngayMax);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-by-ngay-dat")]
        public async Task<IActionResult> GetListTheoNgayDatAsync(DateTime ngayDat)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListTheoNgayDatAsync(ngayDat);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-trong-khoang-ngay-trang-thai")]
        public async Task<IActionResult> GetListTheoNgayDatAsync(DateTime ngayMin, DateTime ngayMax, bool trangThai)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListTheoNgayDatAsync(ngayMin,ngayMax,trangThai);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-dat-tour-by-ngay-dat-trang-thai")]
        public async Task<IActionResult> GetListTheoNgayDatAsync(DateTime ngayDat, bool trangThai)
        {
            try
            {
                List<DatTourModel> dsDatTour = await _IDatTourService.GetListTheoNgayDatAsync(ngayDat,trangThai);
                if (dsDatTour != null || dsDatTour.Count > 0)
                {
                    return Ok(dsDatTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-dat-tour-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                DatTourModel values = await _IDatTourService.GetOneByIDAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

    }
}
