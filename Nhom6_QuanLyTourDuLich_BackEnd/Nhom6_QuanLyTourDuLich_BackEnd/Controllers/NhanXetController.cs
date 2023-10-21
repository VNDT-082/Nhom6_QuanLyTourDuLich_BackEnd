using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanXetController : ControllerBase
    {
        private readonly INhanXetService _INhanXetService;
        public NhanXetController(INhanXetService _INhanXetService)
        {
            this._INhanXetService = _INhanXetService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-nhan-xet")]
        public async Task<IActionResult> GetAll(string Id)
        {
            try
            {
                List<NhanXetModel> dsNhanXet = await _INhanXetService.GetAllAsync(Id);
                if (dsNhanXet != null)
                {
                    return Ok(dsNhanXet);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-one-nhan-xet-by-id")]
        public async Task<IActionResult> GetOneByIDAsync(string Id)
        {
            try
            {
                NhanXetModel _NhanXet = await _INhanXetService.GetOneByIDAsync(Id);
                if (_NhanXet != null)
                {
                    return Ok(_NhanXet);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-nhan-xet")]
        public async Task<IActionResult> Create(NhanXet_repo _NhanXet_Repo)
        {
            try
            {
                bool kq = await _INhanXetService.AddAsync(_NhanXet_Repo);
                return (kq==true) ? Ok(kq): BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-nhan-xet")]
        public async Task<IActionResult> Update(NhanXetModel _NhanXetModel)
        {
            bool kq = await _INhanXetService.UpdateAsync(_NhanXetModel);
            return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-nhan-xet")]
        public async Task<IActionResult> Delete(string Id)
        {
            var NhanXetModel_ = await _INhanXetService.GetOneByIDAsync(Id);
            if (NhanXetModel_ != null)
            {
                bool kq = await _INhanXetService.DeleteAsync(NhanXetModel_.IdNhanXet);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
