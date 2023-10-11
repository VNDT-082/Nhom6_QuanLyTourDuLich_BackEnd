﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;

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
        [Route("/[Controller]/create-tai-khoan")]
        public async Task<IActionResult> Create(TaiKhoan_repo _TaiKhoan_Repo)
        {
            try
            {
                bool kq = await _ITaiKhoanService.AddAsync(_TaiKhoan_Repo);
                if (kq == true)
                    return Ok(kq);
                return BadRequest("Không thể khởi tạo");
            }
            catch { return BadRequest("Không thể khởi tạo"); }
        }
        [HttpPut]
        [Route("/[Controller]/update-tai-khoan")]
        public async Task<IActionResult> Update(TaiKhoanModel _TaiKhoanModel)
        {
            var TaiKhoanModel_ = await _ITaiKhoanService.GetOneByIdAsync(_TaiKhoanModel.Id);
            if (TaiKhoanModel_ != null)
            {
                bool kq = await _ITaiKhoanService.UpdateAsync(_TaiKhoanModel);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi update");
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
                bool kq = await _ITaiKhoanService.DeleteAsync(TaiKhoanModel_.Id);
                return (kq == true) ? Ok(kq) : BadRequest("Lỗi delete");
            }
            return BadRequest("Lỗi delete");
        }
    }
}