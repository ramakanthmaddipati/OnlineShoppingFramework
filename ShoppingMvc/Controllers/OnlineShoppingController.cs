using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingMvc.Controllers
{
    public class OnlineShoppingController : Controller
    {
        // GET: OnlineShopping
        public ActionResult Index()
        {
            return View();
        }
    }
}