using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstrsct;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class CarStatusController : Controller
	{
		private readonly ICarStatusService _carStatusService;

		public CarStatusController(ICarStatusService carStatusService)
		{
			_carStatusService = carStatusService;
		}

		public IActionResult Index()
		{
			var values = _carStatusService.TGetListAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateCarStatus()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateCarStatus(CarStatus carStatus) 
		{
			_carStatusService.TInsert(carStatus);
			return RedirectToAction("Index");
		}
		public IActionResult RemoveCarStatus(int id)
		{
			var value=_carStatusService.TGetById(id);
			_carStatusService.TDelete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult UpdateCarStatus(int id) 
		{
			var value = _carStatusService.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public ActionResult UpdateCarStatus(CarStatus carStatus)
		{
			_carStatusService.TUpdate(carStatus);
			return RedirectToAction("Index");
		}


    }
}
