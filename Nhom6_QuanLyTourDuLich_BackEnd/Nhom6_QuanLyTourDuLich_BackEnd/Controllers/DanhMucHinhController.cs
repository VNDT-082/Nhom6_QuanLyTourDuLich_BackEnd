using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucHinhController : ControllerBase
    {
        private readonly IDanhMucHinhService _IDanhMucHinhService;
        public DanhMucHinhController(IDanhMucHinhService _IDanhMucHinhService)
        {
            this._IDanhMucHinhService = _IDanhMucHinhService;
        }
        [HttpGet]
        [Route("/[Controller]/get-danh-muc-hinh-tour")]
        public async Task<IActionResult> GetAll(string maTour)
        {
            try
            {
                List<DanhMucHinhModel> dsDanhMucHinh = await _IDanhMucHinhService.GetAllAsync(maTour);
                if (dsDanhMucHinh != null || dsDanhMucHinh.Count > 0)
                {
                    return Ok(dsDanhMucHinh);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-danh-muc-hinh-by-id/{Id}")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                DanhMucHinhModel values = await _IDanhMucHinhService.GetOneByIDAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-danh-muc-hinh-tour")]
        public async Task<IActionResult> Create(DanhMucHinh_repo _DanhMucHinh_Repo)
        {
            try
            {
                bool kq = await _IDanhMucHinhService.AddAsync(_DanhMucHinh_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-danh-muc-hinh-tour")]
        public async Task<IActionResult> Update(DanhMucHinhModel _DanhMucHinhModel)
        {
            var DanhMucHinhModel_ = await _IDanhMucHinhService.GetOneByIDAsync(_DanhMucHinhModel.Id);
            if (DanhMucHinhModel_ != null)
            {
                bool kq = await _IDanhMucHinhService.UpdateAsync(_DanhMucHinhModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-danh-muc-hinh-tour")]
        public async Task<IActionResult> Delete(string Id)
        {
            var DanhMucHinhModel_ = await _IDanhMucHinhService.GetOneByIDAsync(Id);
            if (DanhMucHinhModel_ != null)
            {
                bool kq = await _IDanhMucHinhService.DeleteAsync(DanhMucHinhModel_.Id);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
