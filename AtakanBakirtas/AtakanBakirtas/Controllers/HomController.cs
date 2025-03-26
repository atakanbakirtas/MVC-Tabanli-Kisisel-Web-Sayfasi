using AtakanBakirtas.Entityies;
using AtakanBakirtas.view;
using BusinessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtakanBakirtas.Controllers
{
    public class HomController : Controller
    {
        // GET: Hom

        UserManager um = new UserManager(new EFUserDal());

        SkilsManager sm=new SkilsManager(new EFSkilsDal());
        public ActionResult Index()
        {
            var user = um.GetUser();
            var skils = sm.GetSkills();
            var viewmodel=new UserSkillsViewModel
            { Users=user,
            Skills=skils};
            
           return View(viewmodel);
        }
    }
}