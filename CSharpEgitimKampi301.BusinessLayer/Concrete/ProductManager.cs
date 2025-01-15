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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public Product TGet(int id)
        {
            return _productDal.Get(id);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public void TInsert(Product entity)
        {
           _productDal.Insert(entity);
        }

        public void TUpgrade(Product entity)
        {
           _productDal.Upgrade(entity);
        }
    }
}
