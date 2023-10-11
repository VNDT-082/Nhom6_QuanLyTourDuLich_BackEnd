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
    public class LoaiNhanVienController : ControllerBase
    {
        private readonly ILoaiNhanVienService _ILoaiNhanVienService;
        public LoaiNhanVienController(ILoaiNhanVienService _ILoaiNhanVienService)
        {
            this._ILoaiNhanVienService = _ILoaiNhanVienService;
        }
        [HttpGet]
        [Route("/[Controller]/get-loai-nhan-vien")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<LoaiNhanVienModel> dsLoaiNhanVien = await _ILoaiNhanVienService.GetAllAsync();
                if (dsLoaiNhanVien != null || dsLoaiNhanVien.Count > 0)
                {
                    return Ok(dsLoaiNhanVien);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-loai-nhan-vien-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                LoaiNhanVienModel values = await _ILoaiNhanVienService.GetOneByIdAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-loai-nhan-vien")]
        public async Task<IActionResult> Create(LoaiNhanVien_repo _LoaiNhanVien_Repo)
        {
            try
            {
                bool kq = await _ILoaiNhanVienService.AddAsync(_LoaiNhanVien_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-loai-nhan-vien")]
        public async Task<IActionResult> Update(LoaiNhanVienModel _LoaiNhanVienModel)
        {
            var LoaiNhanVienModel_ = await _ILoaiNhanVienService.GetOneByIdAsync(_LoaiNhanVienModel.Id);
            if (LoaiNhanVienModel_ != null)
            {
                bool kq = await _ILoaiNhanVienService.UpdateAsync(_LoaiNhanVienModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-loai-nhan-vien")]
        public async Task<IActionResult> Delete(string Id)
        {
            var LoaiNhanVienModel_ = await _ILoaiNhanVienService.GetOneByIdAsync(Id);
            if (LoaiNhanVienModel_ != null)
            {
                bool kq = await _ILoaiNhanVienService.DeleteAsync(LoaiNhanVienModel_.Id);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
