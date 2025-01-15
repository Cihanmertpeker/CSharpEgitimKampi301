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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer TGet(int id)
        {
            return _customerDal.Get(id);
        }

        public List<Customer> TGetAll()
        {
           return _customerDal.GetAll();
        }

        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void TUpgrade(Customer entity)
        {
           _customerDal.Upgrade(entity);
        }
    }
}
