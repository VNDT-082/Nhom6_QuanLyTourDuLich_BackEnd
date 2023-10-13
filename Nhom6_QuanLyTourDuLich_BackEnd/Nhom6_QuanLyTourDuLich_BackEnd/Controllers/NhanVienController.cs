using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _INhanVienService;
        public NhanVienController(INhanVienService _INhanVienService)
        {
            this._INhanVienService = _INhanVienService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-nhan-vien")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<NhanVienModel> dsNhanVien = await _INhanVienService.GetAllAsync();
                if (dsNhanVien != null || dsNhanVien.Count > 0)
                {
                    return Ok(dsNhanVien);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-nhan-vien-theo-loai")]
        public async Task<IActionResult> GetListByLoaiNhanVienIdAsync(string maLoaiNhanVien)
        {
            try
            {
                List<NhanVienModel> dsNhanVien = await _INhanVienService.GetListByLoaiNhanVienIdAsync(maLoaiNhanVien);
                if (dsNhanVien != null || dsNhanVien.Count > 0)
                {
                    return Ok(dsNhanVien);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-one-nhan-vien-by-id")]
        public async Task<IActionResult> GetOneByIDAsync(string Id)
        {
            try
            {
                NhanVienModel _NhanVien = await _INhanVienService.GetOneByIDAsync(Id);
                if (_NhanVien != null )
                {
                    return Ok(_NhanVien);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-nhan-vien-by-cccd")]
        public async Task<IActionResult> GetOneByCCCDAsync(string canCuocConDan)
        {
            try
            {
                NhanVienModel _NhanVien = await _INhanVienService.GetOneByCCCDAsync(canCuocConDan);
                if (_NhanVien != null)
                {
                    return Ok(_NhanVien);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-nhan-vien")]
        public async Task<IActionResult> Create(NhanVien_repo _NhanVien_Repo)
        {
            try
            {
                bool kq = await _INhanVienService.AddAsync(_NhanVien_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-nhan-vien")]
        public async Task<IActionResult> Update(NhanVienModel _NhanVienModel)
        {
            var NhanVienModel_ = await _INhanVienService.GetOneByIDAsync(_NhanVienModel.IdNhanVien);
            if (NhanVienModel_ != null)
            {
                bool kq = await _INhanVienService.UpdateAsync(_NhanVienModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-nhan-vien")]
        public async Task<IActionResult> Delete(string Id)
        {
            var NhanVienModel_ = await _INhanVienService.GetOneByIDAsync(Id);
            if (NhanVienModel_ != null)
            {
                bool kq = await _INhanVienService.DeleteAsync(NhanVienModel_.IdNhanVien);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
