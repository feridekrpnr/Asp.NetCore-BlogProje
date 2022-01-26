using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t); //Entitymiz olmadığı için ve dışarıdan gönderdiğimiz entity T olduğu
                          // için T türünde ve t isminde entity çağırırız
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetByID(int id); //dışarıdan bir id parametresi alıyor olacak
    }
}
