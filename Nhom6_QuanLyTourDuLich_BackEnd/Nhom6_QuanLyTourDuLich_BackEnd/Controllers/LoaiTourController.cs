using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiTourController : ControllerBase
    {
        public readonly ILoaiTourServices loaiTourService;
        public LoaiTourController(ILoaiTourServices loaiTourService)
        {
            this.loaiTourService = loaiTourService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-loai-tour")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<LoaiTourModel> values = await loaiTourService.GetAllAsync();
                if (values != null)
                { 
                    if(values.Count > 0)
                        return Ok(values);
                } 
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-by-id-loai-tour")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                var value = await loaiTourService.GetOneByIdAsync(Id);
                if (value != null)
                    return Ok(value);
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-loai-tour")]
        public async Task<IActionResult> Create(LoaiTour_repo loaiTour)
        {
            try
            {
                bool kq = await loaiTourService.AddAsync(loaiTour);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-loai-tour")]
        public async Task<IActionResult> Update(LoaiTourModel loaiTourModel)
        {
            var loaiTour = await loaiTourService.GetOneByIdAsync(loaiTourModel.Id);
            if (loaiTour != null)
            {
                loaiTour.tenLoai = loaiTourModel.tenLoai;
                bool kq = await loaiTourService.UpdateAsync(loaiTourModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-loai-tour")]
        public async Task<IActionResult> Delete(string Id)
        {
            var loaiTour = await loaiTourService.GetOneByIdAsync(Id);
            if (loaiTour != null)
            {
                bool kq = await loaiTourService.DeleteAsync(loaiTour.Id);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
