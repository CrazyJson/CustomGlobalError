using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcGlobalError.Controllers
{
    public class ApiTestController : ApiController
    {
        // GET api/apitest/5
        public int Get(int id)
        {
            return TestController.Calc(2,0);
        }
    }
}
