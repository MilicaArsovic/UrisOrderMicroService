using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using UrisOrderMicroService.DataAccess;
using UrisOrderMicroService.Models;
using URISUtil.DataAccess;

namespace UrisOrderMicroService.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/{id}"), HttpGet]
        public Order GetOrder(int id)
        {
            return OrderDB.GetOrder(id);
        }

        [Route("api/User"), HttpPost]
        public Order CreateOrder([FromBody]Order order)
        {
            return OrderDB.CreateOrder(order);
        }

        [Route("api/Order"),HttpPut]
        public Order UpdateOrder([FromBody]Order order)
        {
            return OrderDB.UpdateOrder(order);
        }

        [Route("api/Order/{id}"), HttpDelete]
        public void DeleteOrder(int id)
        {
            OrderDB.DeleteOrder(id);
        }
    }
    
}


