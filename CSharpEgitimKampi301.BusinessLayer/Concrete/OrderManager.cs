using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public Order TGet(int id)
        {
            return _orderDal.Get(id);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpgrade(Order entity)
        {
            _orderDal.Upgrade(entity);
        }
    }
}
