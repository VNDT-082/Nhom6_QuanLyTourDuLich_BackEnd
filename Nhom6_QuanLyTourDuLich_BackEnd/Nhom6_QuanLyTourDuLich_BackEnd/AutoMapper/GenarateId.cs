namespace Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper
{
    public class GenarateId
    {
        public static string setIdTinh(string maTinh)
        {
            string maTinh_ = "T";
            string num="";
            for(int i=1; i<maTinh.Length;i++)
            {
                num += maTinh[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maTinh_ += "0";
            maTinh_ += numInt;
            return maTinh_;
        }
        public static string setIdHuyen(string maHuyen)
        {
            string maHuyen_ = "H0";
            string num = "";
            for (int i = 2; i < maHuyen.Length; i++)
            {
                num += maHuyen[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maHuyen_ += "0";
            maHuyen_ += numInt;
            return maHuyen_;
        }
        public static string setIdXa(string maXa)
        {
            string maXa_ = "H";
            string num = "";
            for (int i = 1; i < maXa.Length; i++)
            {
                num += maXa[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maXa_ += "0";
            maXa_ += numInt;
            return maXa_;
        }

        public static string setIdTour(string maTour)
        {
            string maTour_ = "Tour0";
            string num = "";
            for (int i = 5; i < maTour.Length; i++)
            {
                num += maTour[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maTour_ += "0";
            maTour_ += numInt;
            return maTour_;
        }
        public static string setIdLoaiTour(string maLoaiTour)
        {
            string maLoaiTour_ = "LT0";
            string num = "";
            for (int i = 3; i < maLoaiTour.Length; i++)
            {
                num += maLoaiTour[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maLoaiTour_ += "0";
            maLoaiTour_ += numInt;
            return maLoaiTour_;
        }
        public static string setIdChiTietChuongTrinhTour(string maChiTietChuongTrinhTour,string maTour)
        {
            string maChiTietChuongTrinhTour_ = maTour+"_0";
            string num = "";
            for (int i = maTour.Length+2; i < maChiTietChuongTrinhTour.Length; i++)
            {
                num += maChiTietChuongTrinhTour[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maChiTietChuongTrinhTour_ += "0";
            maChiTietChuongTrinhTour_ += numInt;
            return maChiTietChuongTrinhTour_;
        }
        
        public static string setIdDanhMucHinh(string maDanhMucHinh,string maTour)
        {
            string maDanhMucHinh_ = maTour+"_H0";
            string num = "";
            for (int i = maTour.Length+3; i < maDanhMucHinh.Length; i++)
            {
                num += maDanhMucHinh[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maDanhMucHinh_ += "0";
            maDanhMucHinh_ += numInt;
            return maDanhMucHinh_;
        }
        public static string setIdDatTour(string maDatTour)
        {
            string maDatTour_= "DT0";
            string num = "";
            for (int i = 3; i < maDatTour.Length; i++)
            {
                num += maDatTour[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maDatTour_ += "0";
            maDatTour_ += numInt;
            return maDatTour_;
        }
        public static string setIdKhachHang(string maKhachHang)
        {
            string maKhachHang_= "KH0";
            string num = "";
            for (int i = 3; i < maKhachHang.Length; i++)
            {
                num += maKhachHang[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maKhachHang_ += "0";
            maKhachHang_ += numInt;
            return maKhachHang_;
        }
        public static string setIdThanhVien(string maThanhVien, string maDatTour)
        {
            string maThanhVien_= maDatTour+ "_TV0";
            string num = "";
            for (int i = maDatTour.Length + 5; i < maThanhVien.Length; i++)
            {
                num += maThanhVien[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maThanhVien_ += "0";
            maThanhVien_ += numInt;
            return maThanhVien_;
        }
        public static string setIdTaiKhoan(string maTaiKhoan)
        {
            string maTaiKhoan_= "TK0";
            string num = "";
            for (int i = 3; i < maTaiKhoan.Length; i++)
            {
                num += maTaiKhoan[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maTaiKhoan_ += "0";
            maTaiKhoan_ += numInt;
            return maTaiKhoan_;
        }
        public static string setIdLoaiTaiKhoan(string maLoaiTaiKhoan)
        {
            string maLoaiTaiKhoan_= "LTK0";
            string num = "";
            for (int i = 4; i < maLoaiTaiKhoan.Length; i++)
            {
                num += maLoaiTaiKhoan[i];
            }
            int numInt = int.Parse(num);
            numInt += 1;
            if (numInt < 10)
                maLoaiTaiKhoan_ += "0";
            maLoaiTaiKhoan_ += numInt;
            return maLoaiTaiKhoan_;
        }
    }
}
