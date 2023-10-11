using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ChuyenBayController : ControllerBase
    {
        private readonly IChuyenBayService _IChuyenBayService;
        public ChuyenBayController(IChuyenBayService _IChuyenBayService)
        {
            this._IChuyenBayService = _IChuyenBayService;
        }
        [HttpGet]
        [Route("/[Controller]/get-danh-chuyen-bay")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<ChuyenBayModel> dsChuyenBay = await _IChuyenBayService.GetAllAsync();
                if (dsChuyenBay != null || dsChuyenBay.Count > 0)
                {
                    return Ok(dsChuyenBay);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-chuyen-bay-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                ChuyenBayModel values = await _IChuyenBayService.GetOneByIDAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-noi-di")]
        public async Task<IActionResult> GetListNoiDi(string maSanBay)
        {
            try
            {
                List<ChuyenBayModel> values = await _IChuyenBayService.GetListNoiDi(maSanBay);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-noi-den")]
        public async Task<IActionResult> GetListNoiDen(string maSanBay)
        {
           try
            {
                List<ChuyenBayModel> values = await _IChuyenBayService.GetListNoiDen(maSanBay);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-list-theo-ngay")]
        public async Task<IActionResult> GetListTheoNgay(DateTime gioDi, DateTime gioDen)
        {
            try
            {
                List<ChuyenBayModel> values = await _IChuyenBayService.GetListTheoNgay(gioDi,gioDen);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-khu-hoi")]
        public async Task<IActionResult> GetListKhuHoi(bool khuHoi)
        {
            try
            {
                List<ChuyenBayModel> values = await _IChuyenBayService.GetListKhuHoi(khuHoi);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpPost]
        [Route("/[Controller]/create-one-chuyen-bay")]
        public async Task<IActionResult> Create(ChuyenBay_repo _ChuyenBay_Repo)
        {
            try
            {
                bool kq = await _IChuyenBayService.AddAsync(_ChuyenBay_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-chuyen-bay")]
        public async Task<IActionResult> Update(ChuyenBayModel _ChuyenBayModel)
        {
            var ChuyenBayModel_ = await _IChuyenBayService.GetOneByIDAsync(_ChuyenBayModel.Id);
            if (ChuyenBayModel_ != null)
            {
                bool kq = await _IChuyenBayService.UpdateAsync(_ChuyenBayModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }
        //[HttpDelete]
        //[Route("/[Controller]/delete-chuyen-bay")]
        //public async Task<IActionResult> Delete(string Id)
        //{
        //    var ChuyenBayModel_ = await _IChuyenBayService.GetOneByIDAsync(Id);
        //    if (ChuyenBayModel_ != null)
        //    {
        //        bool kq = await _IChuyenBayService.DeleteAsync(ChuyenBayModel_.Id);
        //        return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
        //    }
        //    return BadRequest("Lỗi delete");
        //}
    }
}
