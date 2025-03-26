using AtakanBakirtas.Entityies;
using BusinessLayer.Concrate;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtakanBakirtas.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager(new EFBlogsDal());
        public ActionResult Index()
        {
            var blogList=bm.GetBlogList();
            return View(blogList);
        }


        public ActionResult GetBlog(int id)
        {
            var getİd=bm.GetBlogId(id);
            return View(getİd);
        }
       




    }
}