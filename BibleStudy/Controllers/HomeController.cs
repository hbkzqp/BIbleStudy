﻿using BibleStudy.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BibleStudy.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Home
        public HomeModel Get()
        {
            HomeModel home = new HomeModel();
            return home;
        }

        // GET: api/Home/5

        public HomeModel Get(int a)
        {
            HomeModel home = new HomeModel();
            return home;
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
