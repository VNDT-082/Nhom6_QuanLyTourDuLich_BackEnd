namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class TinhModel
    {
        public string Id { get; set; }
        public string tenTinh { get; set; }
        public TinhModel() { }

        public TinhModel(string id, string tenTinh)
        {
            Id = id;
            this.tenTinh = tenTinh;
        }
    }
}
