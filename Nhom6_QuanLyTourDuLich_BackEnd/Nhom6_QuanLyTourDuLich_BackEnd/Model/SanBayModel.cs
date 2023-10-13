namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class SanBayModel
    {
        public string IdSanBay { get; set; }
        public string tenSanBay { get; set; }

        public SanBayModel() { }
        public SanBayModel(string IdSanBay, string tenSanBay)
        {
            this.IdSanBay = IdSanBay;
            this.tenSanBay = tenSanBay;
        }

    }
}
