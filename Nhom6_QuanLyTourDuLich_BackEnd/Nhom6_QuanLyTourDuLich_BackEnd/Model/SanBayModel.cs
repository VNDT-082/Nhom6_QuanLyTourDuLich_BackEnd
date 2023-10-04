namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class SanBayModel
    {
        public string Id { get; set; }
        public string tenSanBay { get; set; }

        public SanBayModel() { }
        public SanBayModel(string id, string tenSanBay)
        {
            Id = id;
            this.tenSanBay = tenSanBay;
        }

    }
}
