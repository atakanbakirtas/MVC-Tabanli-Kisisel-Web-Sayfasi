using BusinessLayer.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation;
using EntityLayer;
using BusinessLayer.Concrate;
using AtakanBakirtas.Entityies;


namespace AtakanBakirtas.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserManager um = new UserManager(new EFUserDal());

        [HttpGet]
        public ActionResult Index()
        {
            return View();

        }


        [HttpPost]
        public ActionResult Index(User user)
        {
            //UserValidation uservalidation = new UserValidation();
            //FluentValidation.Results.ValidationResult result = uservalidation.Validate(user);

            //if (!result.IsValid) 
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View(); 
            //}

            //var aut = um.GetUserByCredentials(user.Email, user.Password);

            //if (aut != null)
            //{
            //    return RedirectToAction("UserLogin", "Login");
            //}
            //else
            //{
            //    ViewBag.Message = "Kullanıcı adı veya şifre hatalı!";
            //    return View(); 
            //}
            return View();
        }


        public ActionResult UserLogin() 
        {
            return View();
        }
    }
}