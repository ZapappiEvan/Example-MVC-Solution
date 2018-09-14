using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zapappi.Client;
using Zapappi.Client.Models;

namespace Example_MVC_Solution.Controllers
{
    public class HomeController : BaseController
    {
        public ViewResult Index()
        {
            //Bring back a list of numbers
            var AllNumbers = GetExistingNumbers();

            return View(AllNumbers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<TelephoneNumberModel> GetExistingNumbers() 
        {
            return client.Numbers.ExistingNumbers(SubsId).Items.ToList();
        }
    }
}