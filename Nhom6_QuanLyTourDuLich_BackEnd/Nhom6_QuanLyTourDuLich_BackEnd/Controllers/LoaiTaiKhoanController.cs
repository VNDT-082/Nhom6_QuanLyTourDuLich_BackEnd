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
    public class LoaiTaiKhoanController : ControllerBase
    {
        private readonly ILoaiTaiKhoanService _ILoaiTaiKhoanService;
        public LoaiTaiKhoanController(ILoaiTaiKhoanService _ILoaiTaiKhoanService)
        {
            this._ILoaiTaiKhoanService = _ILoaiTaiKhoanService;
        }
        [HttpGet]
        [Route("/[Controller]/get-loai-tai-khoan")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<LoaiTaiKhoanModel> dsLoaiTaiKhoan = await _ILoaiTaiKhoanService.GetAllAsync();
                if (dsLoaiTaiKhoan != null || dsLoaiTaiKhoan.Count > 0)
                {
                    return Ok(dsLoaiTaiKhoan);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-tai-khoan-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                LoaiTaiKhoanModel values = await _ILoaiTaiKhoanService.GetOneByIdAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-loai-tai-khoan")]
        public async Task<IActionResult> Create(LoaiTaiKhoan_repo _LoaiTaiKhoan_Repo)
        {
            try
            {
                bool kq = await _ILoaiTaiKhoanService.AddAsync(_LoaiTaiKhoan_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-loai-tai-khoan")]
        public async Task<IActionResult> Update(LoaiTaiKhoanModel _LoaiTaiKhoanModel)
        {
            var LoaiTaiKhoanModel_ = await _ILoaiTaiKhoanService.GetOneByIdAsync(_LoaiTaiKhoanModel.Id);
            if (LoaiTaiKhoanModel_ != null)
            {
                bool kq = await _ILoaiTaiKhoanService.UpdateAsync(_LoaiTaiKhoanModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-loai-tai-khoan")]
        public async Task<IActionResult> Delete(string Id)
        {
            var LoaiTaiKhoanModel_ = await _ILoaiTaiKhoanService.GetOneByIdAsync(Id);
            if (LoaiTaiKhoanModel_ != null)
            {
                bool kq = await _ILoaiTaiKhoanService.DeleteAsync(LoaiTaiKhoanModel_.Id);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
