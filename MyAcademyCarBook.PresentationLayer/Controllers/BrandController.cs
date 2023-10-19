using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstrsct;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class BrandController : Controller
	{
		private readonly IBrandService _brandService;

		public BrandController(IBrandService brandService)
		{
			_brandService = brandService;
		}

		public IActionResult Index()
		{
			var values = _brandService.TGetListAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddBrand()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddBrand(Brand brand)
		{
			_brandService.TInsert(brand);
			return RedirectToAction("Index");
		}
        public IActionResult DeleteBrand(int id)
		{
			var value=_brandService.TGetById(id);
			_brandService.TDelete(value);
			return RedirectToAction("Index");
			
		}
        [HttpGet]
        public IActionResult UpdateBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            _brandService.TInsert(brand);
            return RedirectToAction("Index");
        }

    }
}
