using System.Web.Mvc;
using IdentitySample.Models;
using roletest.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity;

namespace IdentitySample.Controllers

{
    public class HomeController : Controller
    {
        private Entities db = new Entities();
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Learn() {
            return View();
        }
        public ActionResult Index(bool? noti)
        {
        if (noti != null) {  AspNetUser theUser= db.AspNetUsers.Find(User.Identity.GetUserId());
            if (theUser.newUser == true) {
                theUser.newUser = false;
                db.Entry(theUser).State = EntityState.Modified;
                db.SaveChanges();
               
                ViewBag.noti = 2;
           
            }else
                if (noti == true)
                {
                    ViewBag.noti = 1;
                }
            }
           
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
