using TechMaaCart.AllRepository;
using TechMaaCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TechMaaCart.Controllers
{
    public class HomeController : ApiController
    {
        private IRepository<Registration> regist;
        public HomeController()
        {
            this.regist = new Repository<Registration>();
        }
        public HomeController(IRepository<Registration> regist)
        {
            this.regist = regist;
        }
        [System.Web.Http.HttpGet]
        public IHttpActionResult Index()
        {
           var model= this.regist.GetAll();

            return Ok(model);
        }
    }
}
