using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
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
    }
}
