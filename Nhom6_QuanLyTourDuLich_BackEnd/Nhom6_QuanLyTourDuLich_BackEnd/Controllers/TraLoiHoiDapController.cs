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
    public class TraLoiHoiDapController : ControllerBase
    {
        private readonly ITraLoiHoiDapService _ITraLoiHoiDapService;
        public TraLoiHoiDapController(ITraLoiHoiDapService _ITraLoiHoiDapService)
        {
            this._ITraLoiHoiDapService = _ITraLoiHoiDapService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-tra-loi-hoi-dap")]
        public async Task<IActionResult> GetAll(string Id)
        {
            try
            {
                List<TraLoiHoiDapModel> dsTraLoiHoiDap = await _ITraLoiHoiDapService.GetAllAsync(Id);
                if (dsTraLoiHoiDap != null)
                {
                    return Ok(dsTraLoiHoiDap);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-one-tra-loi-hoi-dap-by-id")]
        public async Task<IActionResult> GetOneByIDAsync(string Id)
        {
            try
            {
                TraLoiHoiDapModel _TraLoiHoiDap = await _ITraLoiHoiDapService.GetOneByIDAsync(Id);
                if (_TraLoiHoiDap != null)
                {
                    return Ok(_TraLoiHoiDap);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-tra-loi-hoi-dap")]
        public async Task<IActionResult> Create(TraLoiHoiDap_repo _TraLoiHoiDap_Repo)
        {
            try
            {
                bool kq = await _ITraLoiHoiDapService.AddAsync(_TraLoiHoiDap_Repo);
                return (kq == true) ? Ok(kq) : BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-tra-loi-hoi-dap")]
        public async Task<IActionResult> Update(TraLoiHoiDapModel _TraLoiHoiDapModel)
        {
            bool kq = await _ITraLoiHoiDapService.UpdateAsync(_TraLoiHoiDapModel);
            return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/deletetra-loi-hoi-dap")]
        public async Task<IActionResult> Delete(string Id)
        {
            bool kq = await _ITraLoiHoiDapService.DeleteAsync(Id);
            return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-all-tra-loi-hoi-dap-cua-cau-hoi")]
        public async Task<IActionResult> Clear(string Id)
        {
            bool kq = await _ITraLoiHoiDapService.Clear(Id);
            return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
        }
    }
}
