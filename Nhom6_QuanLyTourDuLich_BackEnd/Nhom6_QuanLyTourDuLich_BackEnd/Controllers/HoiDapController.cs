using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoiDapController : ControllerBase
    {
        private readonly IHoiDapService _IHoiDapService;
        public HoiDapController(IHoiDapService _IHoiDapService)
        {
            this._IHoiDapService = _IHoiDapService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-hoi-dap")]
        public async Task<IActionResult> GetAll(string IdTour)
        {
            try
            {
                List<HoiDapModel> dsHoiDap = await _IHoiDapService.GetAllAsync(IdTour);
                if (dsHoiDap != null)
                {
                    var options = new JsonSerializerOptions
                    {
                        ReferenceHandler = ReferenceHandler.Preserve
                    };
                    var jsondata = JsonSerializer.Serialize(dsHoiDap,options);
                    return Ok(dsHoiDap);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-one-hoi-dap-by-id")]
        public async Task<IActionResult> GetOneByIDAsync(string Id)
        {
            try
            {
                HoiDapModel _HoiDap = await _IHoiDapService.GetOneByIDAsync(Id);
                if (_HoiDap != null)
                {
                    return Ok(_HoiDap);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-hoi-dap")]
        public async Task<IActionResult> Create(HoiDap_repo _HoiDap_Repo)
        {
            try
            {
                bool kq = await _IHoiDapService.AddAsync(_HoiDap_Repo);
                return (kq == true) ? Ok(kq) : BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-hoi-dap")]
        public async Task<IActionResult> Update(HoiDapModel _HoiDapModel)
        {
            bool kq = await _IHoiDapService.UpdateAsync(_HoiDapModel);
            return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-hoi-dap")]
        public async Task<IActionResult> Delete(string Id)
        {
            bool kq = await _IHoiDapService.DeleteAsync(Id);
            return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
        }

        [HttpDelete]
        [Route("/[Controller]/delete-all-hoi-dap-cua-mot-tour")]
        public async Task<IActionResult> Clear(string IdTour)
        {
            bool kq = await _IHoiDapService.Clear(IdTour);
            return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
        }
    }
}
