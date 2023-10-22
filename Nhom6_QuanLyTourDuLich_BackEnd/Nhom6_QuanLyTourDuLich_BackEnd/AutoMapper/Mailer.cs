using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using System.Net;
using System.Net.Mail;
namespace Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper
{
    public class Mailer
    {
        public static bool SendMail(DatTourModel datTourModel)
        {
            string email = "vonguyenduytan08022002@gmail.com";
            string password = "02B3325FF069793B73A0EA8476A36746E682";

            // Tạo đối tượng MailMessage
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email);
            mail.To.Add("duytantt9@gmail.com");
            mail.Subject = "Thong bao";
            mail.Body = "Xin chào!" +datTourModel.maKhach+
                "Cảm ơn bạn đã tin tưởng chúng tôi.\n" +
                "sau day tui xin thong tin tour ban da dat tren he thong chung toi\n"+
                "ma tour: "+datTourModel.maTour+" ; so luong: "+datTourModel.soLuong;

            // Cấu hình thông tin SMTP server
            SmtpClient smtpClient = new SmtpClient("smtp.elasticemail.com");
            smtpClient.Port = 2525;
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
    }
}
