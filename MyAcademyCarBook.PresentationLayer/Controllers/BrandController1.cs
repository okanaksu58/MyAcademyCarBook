using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstrsct;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class BrandController1 : Controller
	{
		private readonly IBrandService _brandService;

		public BrandController1(IBrandService brandService)
		{
			_brandService = brandService;
		}

		public IActionResult Index()
		{
			var values = _brandService.TGetListAll();
			return View();
		}
	}
}
