
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietChuongTrinhTourController : ControllerBase
    {
        private readonly IChiTietChuongTrinhTourService _ChiTietChuongTrinhTourService;
        public ChiTietChuongTrinhTourController(IChiTietChuongTrinhTourService _ChiTietChuongTrinhTourService)
        {
            this._ChiTietChuongTrinhTourService = _ChiTietChuongTrinhTourService;
        }

        [HttpGet]
        [Route("/[Controller]/get-all-chi-tiet-chuong-trinh-tour")]
        public async Task<IActionResult> GetAll(string maTour)
        {
            try {
                List<ChiTietChuongTrinhTourModel> dsChiTietChuongTrinhTour = await _ChiTietChuongTrinhTourService.GetListByTourId(maTour);
                if (dsChiTietChuongTrinhTour != null || dsChiTietChuongTrinhTour.Count > 0)
                {
                    return Ok(dsChiTietChuongTrinhTour);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-chi-tiet-chuong-trinh-tour-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                ChiTietChuongTrinhTourModel values = await _ChiTietChuongTrinhTourService.GetOneByIDAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-chi-tiet-chuong-trinh-tour")]
        public async Task<IActionResult> Create(ChiTietChuongTrinhTour_repo _ChiTietChuongTrinhTour_Repo)
        {
            try
            {
                bool kq = await _ChiTietChuongTrinhTourService.AddAsync(_ChiTietChuongTrinhTour_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-chi-tiet-chuong-trinh-tour")]
        public async Task<IActionResult> Update(ChiTietChuongTrinhTourModel _ChiTietChuongTrinhTourModel)
        {
            var ChiTietChuongTrinhTourModel_ = await _ChiTietChuongTrinhTourService
                .GetOneByIDAsync(_ChiTietChuongTrinhTourModel.IdChiTietChuongTrinhTour);
            if (ChiTietChuongTrinhTourModel_ != null)
            {
                bool kq = await _ChiTietChuongTrinhTourService.UpdateAsync(_ChiTietChuongTrinhTourModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        [HttpDelete]
        [Route("/[Controller]/delete-chi-tiet-chuong-trinh-tour")]
        public async Task<IActionResult> Delete(string Id)
        {
            var ChiTietChuongTrinhTourModel_ = await _ChiTietChuongTrinhTourService.GetOneByIDAsync(Id);
            if (ChiTietChuongTrinhTourModel_ != null)
            {
                bool kq = await _ChiTietChuongTrinhTourService
                    .DeleteAsync(ChiTietChuongTrinhTourModel_.IdChiTietChuongTrinhTour);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
