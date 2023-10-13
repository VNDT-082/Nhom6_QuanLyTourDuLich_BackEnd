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
    public class SanBayController : ControllerBase
    {
        private readonly ISanBayService _ISanBayService;
        public SanBayController(ISanBayService _ISanBayService)
        {
            this._ISanBayService = _ISanBayService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-san-bay")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<SanBayModel> dsSanBay = await _ISanBayService.GetAllAsync();
                if (dsSanBay != null || dsSanBay.Count > 0)
                {
                    return Ok(dsSanBay);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-one-san-bay-by-id")]
        public async Task<IActionResult> GetOneByIDAsync(string Id)
        {
            try
            {
                SanBayModel _SanBay = await _ISanBayService.GetOneByIDAsync(Id);
                if (_SanBay != null)
                {
                    return Ok(_SanBay);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-san-bay")]
        public async Task<IActionResult> Create(SanBay_repo _SanBay_Repo)
        {
            try
            {
                bool kq = await _ISanBayService.AddAsync(_SanBay_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-san-bay")]
        public async Task<IActionResult> Update(SanBayModel _SanBayModel)
        {
            var SanBayModel_ = await _ISanBayService.GetOneByIDAsync(_SanBayModel.IdSanBay);
            if (SanBayModel_ != null)
            {
                bool kq = await _ISanBayService.UpdateAsync(_SanBayModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-san-bay")]
        public async Task<IActionResult> Delete(string Id)
        {
            var SanBayModel_ = await _ISanBayService.GetOneByIDAsync(Id);
            if (SanBayModel_ != null)
            {
                bool kq = await _ISanBayService.DeleteAsync(SanBayModel_.IdSanBay);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
