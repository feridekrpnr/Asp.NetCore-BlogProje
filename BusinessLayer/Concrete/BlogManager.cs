using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }
        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
        public void TDelete(Blog t)
        {
            _blogDal.Delete(t); //t parametresine karsılık olarak gelen deger blogvaluedan gelen deger
        }
        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        public Blog TGetById(int id)
        {
            return _blogDal.GetByID(id);
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id); //dışarıdan gönderdiğimiz id ye eşit olanları listele
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();

        }
        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id); // writer idsi dışarıdan gönderdiğimiz idye  eşit olan dgerleri listele
        }

    }
}
