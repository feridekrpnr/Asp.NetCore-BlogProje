using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        //Kategori ile birlikte listeyi getir
        List<Blog> GetListWithCategoryByWriter(int id);
        //Yazara göre kategori ile beraber getir
    }
}
