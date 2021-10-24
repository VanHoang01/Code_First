using System;
using System.Linq;
using System.Web.Mvc;
using CodeFirst1.Models;
namespace CodeFirst.Controllers
{
    public class SachController : Controller
    {
        QLSach db = new QLSach();

        // GET: Sach
        public DanhMucSach GetSach(string ms)
        {
            return db.DanhMucSaches.OrderBy(a => a.TenSach).Where(a => a.MaSach == ms).SingleOrDefault();
        }
        public ActionResult Index()
        {
            return View(db.DanhMucSaches.OrderBy(a => a.TenSach).ToList());
        }
        [HttpGet]
        public ActionResult Edit(string ms)
        {
            return View(GetSach(ms));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(FormCollection f)
        {
            if (ModelState.IsValid)
            {
                var s = GetSach(f["MaSach"].ToString()); s.TenSach = f["TenSach"];
                s.TacGia = f["TacGia"]; s.MaNhom = f["MaNhom"];
                s.DonGia = Convert.ToDecimal(f["DonGia"]); s.SLTon = Convert.ToDecimal(f["SLTon"]);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Edit");
            }
        }
        [HttpGet]
        public ActionResult Delete(string ms)
        {

            return View(GetSach(ms));
        }

        [HttpPost]
        public ActionResult Delete(string ms, FormCollection f)
        {
            var sach = GetSach(ms); if (sach == null)
            {
                Response.StatusCode = 404; return null;
            }
            db.DanhMucSaches.Remove(sach); db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(FormCollection f)
        {
            if (ModelState.IsValid)
            {
                DanhMucSach s = new DanhMucSach(); s.MaSach = f["MaSach"];
                s.TenSach = f["TenSach"]; s.TacGia = f["TacGia"]; s.MaNhom = f["MaNhom"];
                s.DonGia = Convert.ToDecimal(f["DonGia"]); s.SLTon = Convert.ToDecimal(f["SLTon"]); db.DanhMucSaches.Add(s); db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Delete");
            }

        }
    }
}