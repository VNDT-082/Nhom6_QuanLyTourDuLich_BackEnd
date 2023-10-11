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
    public class ThanhVienController : ControllerBase
    {
        private readonly IThanhVienService _IThanhVienService;
        public ThanhVienController(IThanhVienService _IThanhVienService)
        {
            this._IThanhVienService = _IThanhVienService;
        }
        [HttpGet]
        [Route("/[Controller]/get-thanh-vien")]
        public async Task<IActionResult> GetAll(string maDatTour)
        {
            try
            {
                List<ThanhVienModel> dsThanhVien = await _IThanhVienService.GetAllAsync(maDatTour);
                if (dsThanhVien != null || dsThanhVien.Count > 0)
                {
                    return Ok(dsThanhVien);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-thanh-vien-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                ThanhVienModel values = await _IThanhVienService.GetOneByIDAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-thanh-vien")]
        public async Task<IActionResult> Create(ThanhVien_repo _ThanhVien_Repo)
        {
            try
            {
                bool kq = await _IThanhVienService.AddAsync(_ThanhVien_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-thanh-vien")]
        public async Task<IActionResult> Update(ThanhVienModel _ThanhVienModel)
        {
            var ThanhVienModel_ = await _IThanhVienService.GetOneByIDAsync(_ThanhVienModel.Id);
            if (ThanhVienModel_ != null)
            {
                bool kq = await _IThanhVienService.UpdateAsync(_ThanhVienModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-thanh-vien")]
        public async Task<IActionResult> Delete(string Id)
        {
            var ThanhVienModel_ = await _IThanhVienService.GetOneByIDAsync(Id);
            if (ThanhVienModel_ != null)
            {
                bool kq = await _IThanhVienService.DeleteAsync(ThanhVienModel_.Id);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
