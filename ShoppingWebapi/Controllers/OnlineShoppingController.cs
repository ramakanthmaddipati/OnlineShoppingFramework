using ShoppingRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingWebapi.Controllers
{
    public class OnlineShoppingController : ApiController
    {
        private IShopping _onlineRepository;
        public OnlineShoppingController()
        {
            _onlineRepository = new Shopping(new ShoppingEntity.HCLDBEntities());
        }
        public OnlineShoppingController(IShopping Shopping)
        {
            _onlineRepository = Shopping;
        }
    }
}
