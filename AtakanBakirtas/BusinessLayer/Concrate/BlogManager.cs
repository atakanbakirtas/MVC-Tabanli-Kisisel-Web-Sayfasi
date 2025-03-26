using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class BlogManager:IBlogsService
    {
        IBlogsDal _ıblogDal;
        public BlogManager(IBlogsDal ıblogDal)
        {
            this._ıblogDal = ıblogDal;
        }

        public Blogs GetBlogId(int p)
        {
            return _ıblogDal.List(x => x.BlogId == p).FirstOrDefault();
            
        }

        public List<Blogs> GetBlogList()
        {
            return _ıblogDal.List();
        }
    }
}
