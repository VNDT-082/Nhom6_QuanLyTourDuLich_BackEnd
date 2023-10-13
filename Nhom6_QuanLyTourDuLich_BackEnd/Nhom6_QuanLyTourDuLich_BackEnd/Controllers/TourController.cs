using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController : ControllerBase
    {
        public readonly ITourService tourService;
        public TourController(ITourService tourService)
        {
            this.tourService = tourService;
        }
        [HttpGet]
        [Route("/[Controller]/get-all-tour")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<TourModel> values = await tourService.GetAllAsync();
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]

        [Route("/[Controller]/get-count-all")]
        public async Task<IActionResult> Count()
        {
            try
            {
                int values = await tourService.Count();
                if (values != null)
                {
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpGet]
        [Route("/[Controller]/get-all-tour-active")]
        public async Task<IActionResult> GetAll(bool trangThai)
        {
            try
            {
                List<TourModel> values = await tourService.GetAllAsync(trangThai);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }


        [HttpGet]
        [Route("/[Controller]/get-tour-last")]
        public async Task<IActionResult> GetLast()
        {
            try
            {
                TourModel values = await tourService.GetLastAsync();
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-theo-khoang-gia")]
        public async Task<IActionResult> GetListTheoGia(double giaMin,double giaMax)
        {
            try
            {
                List<TourModel> values = await tourService.GetListTheoGia(giaMin,giaMax);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-theo-loai")]
        public async Task<IActionResult> GetListTheoLoai(string maLoai)
        {
            try
            {
                List<TourModel> values = await tourService.GetListTheoLoai(maLoai);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-theo-loai-active")]
        public async Task<IActionResult> GetListTheoLoai(string maLoai,bool trangThai)
        {
            try
            {
                List<TourModel> values = await tourService.GetListTheoLoai(maLoai,trangThai);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-theo-nguoi-lap")]
        public async Task<IActionResult> GetListTheoNguoiLap(string maNhanVien)
        {
            try
            {
                List<TourModel> values = await tourService.GetListTheoNguoiLap(maNhanVien);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
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
                TourModel values = await tourService.GetOneByIDAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-tour-by-page-number")]
        public async Task<IActionResult> GetPage(int pageNum)
        {
            try
            {
                List<TourModel> values = await tourService.GetPage(5,pageNum);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-tour-by-page-number-trang-thai")]
        public async Task<IActionResult> GetPage(int pageNum,bool trangThai)
        {
            try
            {
                List<TourModel> values = await tourService.GetPage(5, pageNum,trangThai);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-list-tour-by-theo-ten")]
        public async Task<IActionResult> GetListTheoTen(string tenTour)
        {
            try
            {
                List<TourModel> values = await tourService.GetListTheoTen(tenTour);
                if (values != null)
                {
                    if (values.Count > 0)
                        return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        
        [HttpPut]
        [Route("/[Controller]/update-one-tour")]
        public async Task<IActionResult> Update(TourModel tourModel)
        {
            var tour = await tourService.GetOneByIDAsync(tourModel.IdTour);
            if (tour != null)
            {
                bool kq = await tourService.UpdateAsync(tourModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }

        [HttpPost]
        [Route("/[Controller]/create-tour")]
        public async Task<IActionResult> Create(Tour_repo tour_Repo)
        {
            try
            {
                bool kq = await tourService.AddAsync(tour_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpDelete]
        [Route("/[Controller]/delete-one-tour")] 
        public async Task<IActionResult> Delete(Tour_repo tour_Repo) //tat trang thai hoat 
        {
            try
            {
                bool kq = await tourService.AddAsync(tour_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể xóa");
            }
            catch { return BadRequest("Không thể xóa"); }
        }
    }
}
