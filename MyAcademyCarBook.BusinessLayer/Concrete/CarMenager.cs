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
	public class CarMenager : ICarService
	{
		private readonly ICarDal _carDal;

		public CarMenager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public void TDelete(Car entity)
		{
			_carDal.Delete(entity);
		}

		public Car TGetById(int id)
		{
			if (id != null)
			{
				return _carDal.GetById(id);
			}
			return _carDal.GetById(0);//Araba Bulunamadı
		}

		public List<Car> TGetListAll()
		{
			//Bu işlemi yapmaya yetkiliyse
			return  _carDal.GetListAll();
		}

		public void TInsert(Car entity)
		{
			if(entity.Year>=2010 && entity.Prices.Count>0 && entity.Km <=500000)
			{
				_carDal.Insert(entity);
			}
			//hata mesajı ---> Fluent Validadtion
		}

		public void TUpdate(Car entity)
		{
			_carDal.Update(entity);
		}
	}
}
