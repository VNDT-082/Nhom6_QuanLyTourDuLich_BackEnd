using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachSanController : ControllerBase
    {
        private readonly IKhachSanService _IKhachSanService;
        public KhachSanController(IKhachSanService _IKhachSanService)
        {
            this._IKhachSanService = _IKhachSanService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-khach-san")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<KhachSanModel> dsKhachSan = await _IKhachSanService.GetAllAsync();
                if (dsKhachSan != null || dsKhachSan.Count > 0)
                {
                    return Ok(dsKhachSan);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-khach-san-theo-hang-sao")]
        public async Task<IActionResult> GetListByHangSao(string hangSao)
        {
            try
            {
                List<KhachSanModel> dsKhachSan = await _IKhachSanService.GetListByHangSao(hangSao);
                if (dsKhachSan != null || dsKhachSan.Count > 0)
                {
                    return Ok(dsKhachSan);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-khach-san-theo-xa")]
        public async Task<IActionResult> GetListByXaIdAsync(string maXa)
        {
            try
            {
                List<KhachSanModel> dsKhachSan = await _IKhachSanService.GetListByXaIdAsync(maXa);
                if (dsKhachSan != null || dsKhachSan.Count > 0)
                {
                    return Ok(dsKhachSan);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-tour-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                KhachSanModel values = await _IKhachSanService.GetOneById(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-khach-san")]
        public async Task<IActionResult> Create(KhachSan_repo _KhachSan_Repo)
        {
            try
            {
                bool kq = await _IKhachSanService.AddAsync(_KhachSan_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-khach-san")]
        public async Task<IActionResult> Update(KhachSanModel _KhachSanModel)
        {
            var KhachSanModel_ = await _IKhachSanService.GetOneById(_KhachSanModel.Id);
            if (KhachSanModel_ != null)
            {
                bool kq = await _IKhachSanService.UpdateAsync(_KhachSanModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        //[HttpDelete]
        //[Route("/[Controller]/delete-khach-san")]
        //public async Task<IActionResult> Delete(string Id)
        //{
        //    var KhachSanModel_ = await _IKhachSanService.GetOneById(Id);
        //    if (KhachSanModel_ != null)
        //    {
        //        bool kq = await _IKhachSanService.DeleteAsync(KhachSanModel_.Id);
        //        return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
        //    }
        //    return BadRequest("Lỗi delete");
        //}
    }
}
