using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T > where T : class
    {
        void Insert(T entity);
        void Upgrade(T entity);
        void Delete(T entity);
        List<T> GetAll();        
        T Get(int id);
    }
}
