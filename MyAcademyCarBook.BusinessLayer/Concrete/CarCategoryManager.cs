using MyAcademyCarBook.BusinessLayer.Abstrsct;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
	public class CarCategoryManager : ICarCategoryService
	{
		private readonly ICarCategoryDal _carCategoryDal;

		public CarCategoryManager(ICarCategoryDal carCategoryDal)
		{
			_carCategoryDal = carCategoryDal;
		}

		public void TDelete(CarCategory entity)
		{
			this._carCategoryDal.Delete(entity);
		}

		public CarCategory TGetById(int id)
		{
			return this._carCategoryDal.GetById(id);
		}

		public List<CarCategory> TGetListAll()
		{
			return this._carCategoryDal.GetListAll();
		}

		public void TInsert(CarCategory entity)
		{
			this._carCategoryDal.Insert(entity);
		}

		public void TUpdate(CarCategory entity)
		{
			this._carCategoryDal.Update(entity);
		}
	}
}
