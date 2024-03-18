using Ecommerce.Data;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly Hshop2023Context db;

        public HangHoaController(Hshop2023Context context) => db = context; 
        public IActionResult Index(int? loai)
        {
            var lstHangHoa = db.HangHoas.AsQueryable();
            if(loai.HasValue)
            {
                 lstHangHoa = lstHangHoa.Where(p=> p.MaLoai == loai.Value);
            }
            var result = lstHangHoa.Select(p => new HangHoaVM
            {
                MaHH = p.MaHh,
                TenHH = p.TenHh,
                Gia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                Mota = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai


,
            });
            return View(result);
        }
        public IActionResult Search(string? search)
        {
            ViewBag.Search = search;
            var lstHangHoa = db.HangHoas.AsQueryable();
            if (search!=null)
            {
                lstHangHoa = lstHangHoa.Where(p => p.TenHh.Contains(search));
            }
            var result = lstHangHoa.Select(p => new HangHoaVM
            {
                MaHH = p.MaHh,
                TenHH = p.TenHh,
                Gia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                Mota = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai


,
            });
            return View(result);
        }
        public IActionResult Detail(int id)
        {
            var data = db.HangHoas.Include(p=>p.MaLoaiNavigation)
                .SingleOrDefault(p=>p.MaHh == id);
            if (data == null)
            {
                TempData["Message"] = $"Not found the item with id { id}";
                return Redirect("/404");
            }
            var result = new ChiTietHangHoaVM
            {
                MaHH = data.MaHh,
                TenHH = data.TenHh,
                Gia = data.DonGia ?? 0,
                ChiTiet = data.MoTa ?? "",
                Hinh = data.Hinh ?? "",
                Mota = data.MoTaDonVi ?? "",
                TenLoai = data.MaLoaiNavigation.TenLoai,
                SoLuongTon = 10, //check later
                DiemDanhGia = 5

            };
            return View(result);
        }
    }
}
