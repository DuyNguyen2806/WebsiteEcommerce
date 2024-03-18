namespace Ecommerce.ViewModel
{
    public class HangHoaVM
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public string Mota { get; set; }
        public string Hinh { get; set; }
        public double Gia{ get; set; }
        public string TenLoai { get; set; }
    }
    public class ChiTietHangHoaVM
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public string Mota { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string TenLoai { get; set; }
        public string ChiTiet { get; set; }
        public int DiemDanhGia { get; set; }
        public int SoLuongTon { get; set; }

    }
}
