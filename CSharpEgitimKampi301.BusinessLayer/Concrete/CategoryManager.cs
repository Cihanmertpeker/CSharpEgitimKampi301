using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal CategoryDal)
        {
            _CategoryDal = CategoryDal;
        }

        public void TDelete(Category entity)
        {
            _CategoryDal.Delete(entity);
        }

        public Category TGet(int id)
        {
            return _CategoryDal.Get(id);
        }

        public List<Category> TGetAll()
        {
            return _CategoryDal.GetAll();
        }

        public void TInsert(Category entity)
        {
            _CategoryDal.Insert(entity);
        }

        public void TUpgrade(Category entity)
        {
            _CategoryDal.Upgrade(entity);
        }
    }
}
