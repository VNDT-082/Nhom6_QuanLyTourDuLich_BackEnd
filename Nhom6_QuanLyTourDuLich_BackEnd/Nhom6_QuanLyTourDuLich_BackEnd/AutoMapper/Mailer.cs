using Nhom6_QuanLyTourDuLich_BackEnd.Controllers;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper
{
    public class Mailer
    {
        //private ITourService _ITourService;
        //private IKhachHangService _IKhachHangService;
        //private IThanhVienService _IThanhVienService;
        //public Mailer(ITourService _ITourService, IKhachHangService _IKhachHangService, IThanhVienService _IThanhVienService) {
        //    this._ITourService= _ITourService;
        //    this._IKhachHangService= _IKhachHangService;
        //    this._IThanhVienService= _IThanhVienService;
        //}

        public static bool SendMail(ThanhToanModel datTourModel)
        {

            double TongTien = datTourModel.soLuong * datTourModel.Tour.chiPhi;
            string listThanhVien = "";
            if (datTourModel.ThanhViens != null)
            {
                int i = 0;
                foreach (var item in datTourModel.ThanhViens)
                {
                    listThanhVien += ++i + ". Họ tên: " + item.hoTen + " - giới tính: "+ item.gioiTinh + " - Ngày sinh: "+item.ngaySinh.ToShortDateString()+"\n";
               
                }
            }

            string email = "vonguyenduytan08022002@gmail.com";
            string password = "kfyk nufa clxf sstl";

            // Tạo đối tượng MailMessage
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email);
            mail.To.Add(datTourModel.KhachHang.email);
            mail.Subject = "Thong bao";
            mail.Body = "Xin chào!" + datTourModel.KhachHang.hoTen +
                "Cảm ơn bạn đã tin tưởng chúng tôi.\n" +
                "Sau đây chúng tôi xin thông báo tour mà bạn đã đặt trên hệ  thống của chúng tôi\n" +
                "Mã Tour: " + datTourModel.maTour + " - Tên Tour: " + datTourModel.Tour.tenTour
                + "\n Giá: " + datTourModel.Tour.chiPhi.ToString("N0") + " VND - so luong: " + datTourModel.soLuong
                + "\n Tổng cộng: " + TongTien.ToString("N0") + "VND \n"
                + "Thành viên:\n"
                + listThanhVien;

            // Cấu hình thông tin SMTP server
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(email, password);
            smtpClient.EnableSsl = true;

            try
            {
                // Gửi email
                smtpClient.Send(mail);

                Console.WriteLine("Email sent successfully.");
                  return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email. Error message: " + ex.Message);
                return false;
            }
        }

        public static bool SendMailForgetPass(TaiKhoanModel TaiKhoanModel_)
        {

            string email = "vonguyenduytan08022002@gmail.com";
            string password = "kfyk nufa clxf sstl";

            // Tạo đối tượng MailMessage
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email);
            mail.To.Add(TaiKhoanModel_.email);
            mail.Subject = "Thong bao";
            mail.Body = "Xin chào! " + TaiKhoanModel_.email + "\n Mật khẩu mới của bạn là: " + TaiKhoanModel_.matKhau +
                "\n Vui lòng không chia sẻ mật khẩu cho bất kì ai";

            // Cấu hình thông tin SMTP server
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(email, password);
            smtpClient.EnableSsl = true;

            try
            {
                // Gửi email
                smtpClient.Send(mail);

                Console.WriteLine("Email sent successfully.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email. Error message: " + ex.Message);
                return false;
            }
        }
        public string GetGioiTinh(bool gt)
        {
            return (gt == true) ? "Nam" : "Nữ";
        }
    }
}
