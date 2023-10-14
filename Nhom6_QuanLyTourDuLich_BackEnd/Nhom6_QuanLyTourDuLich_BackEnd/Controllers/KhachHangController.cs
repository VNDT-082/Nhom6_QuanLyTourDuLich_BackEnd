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
    public class KhachHangController : ControllerBase
    {
        private readonly IKhachHangService _IKhachHangService;
        public KhachHangController(IKhachHangService _IKhachHangService)
        {
            this._IKhachHangService = _IKhachHangService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-khach-hang")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<KhachHangModel> dsKhachHang = await _IKhachHangService.GetAllAsync();
                if (dsKhachHang != null || dsKhachHang.Count > 0)
                {
                    return Ok(dsKhachHang);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-khach-hang-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                KhachHangModel values = await _IKhachHangService.GetOneByIdAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-khach-hang-by-ma-tai-khoan-id")]
        public async Task<IActionResult> GetOneBymaTaiKhoanId(string maTaiKhoan)
        {
            try
            {
                KhachHangModel values = await _IKhachHangService.GetOneByTaiKhoanIdAsync(maTaiKhoan);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-khach-hang")]
        public async Task<IActionResult> Create(KhachHang_repo _KhachHang_Repo)
        {
            try
            {
                KhachHangModel khachHangModel = await _IKhachHangService.AddAsync(_KhachHang_Repo);
                if (khachHangModel!=null)
                    return Ok(khachHangModel);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-khach-hang")]
        public async Task<IActionResult> Update(KhachHangModel _KhachHangModel)
        {
            var KhachHangModel_ = await _IKhachHangService.GetOneByIdAsync(_KhachHangModel.IdKhachHang);
            if (KhachHangModel_ != null)
            {
                bool kq = await _IKhachHangService.UpdateAsync(_KhachHangModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-khach-hang")]
        public async Task<IActionResult> Delete(string Id)
        {
            var KhachHangModel_ = await _IKhachHangService.GetOneByIdAsync(Id);
            if (KhachHangModel_ != null)
            {
                bool kq = await _IKhachHangService.DeleteAsync(KhachHangModel_.IdKhachHang);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
