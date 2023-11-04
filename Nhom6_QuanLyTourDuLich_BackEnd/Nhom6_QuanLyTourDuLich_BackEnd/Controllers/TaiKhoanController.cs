using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;
using Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly ITaiKhoanService _ITaiKhoanService;
        public TaiKhoanController(ITaiKhoanService _ITaiKhoanService)
        {
            this._ITaiKhoanService = _ITaiKhoanService;
        }
        [HttpGet]
        [Route("/[Controller]/get-tai-khoan")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<TaiKhoanModel> dsTaiKhoan = await _ITaiKhoanService.GetAllAsync();
                if (dsTaiKhoan != null || dsTaiKhoan.Count > 0)
                {
                    return Ok(dsTaiKhoan);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }
        [HttpGet]
        [Route("/[Controller]/get-one-tai-khoan-by-id")]
        public async Task<IActionResult> GetOneById(string Id)
        {
            try
            {
                TaiKhoanModel values = await _ITaiKhoanService.GetOneByIdAsync(Id);
                if (values != null)
                {
                    return Ok(values);
                }
                return NoContent();
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/login")]
        public async Task<IActionResult> Login(Login_Repo _Login_Repo)
        {
            try
            {
                TaiKhoanModel _TaiKhoanModel = await _ITaiKhoanService.LoginAsync(_Login_Repo.TenDangNhap, _Login_Repo.MatKhau);
                if (_TaiKhoanModel != null)
                {

                    return Ok(_TaiKhoanModel);
                }
                return BadRequest("LoiDangNhap");
            }
            catch { return NotFound(); }
        }

        [HttpPost]
        [Route("/[Controller]/create-tai-khoan")]
        public async Task<IActionResult> Create(TaiKhoan_repo _TaiKhoan_Repo)
        {
            try
            {
                var taiKhoanModel = await _ITaiKhoanService.AddAsync(_TaiKhoan_Repo);
                return (taiKhoanModel!=null)?Ok(taiKhoanModel): BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-tai-khoan")]
        public async Task<IActionResult> Update(TaiKhoanModel _TaiKhoanModel)
        {
            var TaiKhoanModel_ = await _ITaiKhoanService.GetOneByIdAsync(_TaiKhoanModel.IdTaiKhoan);
            if (TaiKhoanModel_ != null)
            {
                var  _TaiKhoanModel_repo = await _ITaiKhoanService.UpdateAsync(_TaiKhoanModel);
                return (_TaiKhoanModel_repo != null) ? Ok(_TaiKhoanModel_repo) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }

        [HttpPut]
        [Route("/[Controller]/forget-password")]
        public async Task<IActionResult> fotGetPassWord(string email)
        {
            var TaiKhoanModel_ = await _ITaiKhoanService.GetOneByEmailAsync(email);
            if (TaiKhoanModel_ != null)
            {
                string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; // Các ký tự có thể xuất hiện trong chuỗi

                string randomStringPassword = "";

                Random random = new Random();

                for (int i = 0; i < 6; i++)
                {
                    randomStringPassword += chars[random.Next(chars.Length)];
                }


                TaiKhoanModel_.matKhau = randomStringPassword;
                Mailer.SendMailForgetPass(TaiKhoanModel_);
                var _TaiKhoanModel_repo = await _ITaiKhoanService.ChangePasswordAsync(TaiKhoanModel_);
                return (_TaiKhoanModel_repo != null) ? Ok(_TaiKhoanModel_repo) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }


        [HttpPut]
        [Route("/[Controller]/change-password")]
        public async Task<IActionResult> ChangePasswordAsync(TaiKhoanUpdate_repo taiKhoanUpdate_)
        {
            var TaiKhoanModel_ = await _ITaiKhoanService.GetOneByEmailAsync(taiKhoanUpdate_.email);
            if (TaiKhoanModel_ != null)
            {
                TaiKhoanModel_.matKhau = taiKhoanUpdate_.matKhau;
                var _TaiKhoanModel_repo = await _ITaiKhoanService.ChangePasswordAsync(TaiKhoanModel_);
                return (_TaiKhoanModel_repo != null) ? Ok(_TaiKhoanModel_repo) : BadRequest("Lỗi update");
            }
            return BadRequest("Lỗi update");
        }

        [HttpDelete]
        [Route("/[Controller]/delete-tai-khoan")]
        public async Task<IActionResult> Delete(string Id)
        {
            var TaiKhoanModel_ = await _ITaiKhoanService.GetOneByIdAsync(Id);
            if (TaiKhoanModel_ != null)
            {
                bool kq = await _ITaiKhoanService.DeleteAsync(TaiKhoanModel_.IdTaiKhoan);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}
