using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learning_dock2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("getvalues")]
        public List<string> getvalues()
        {
            List<string> l = new List<string>();

            l.Add("dock1");
            l.Add("dock2");
            l.Add("dock3");
            l.Add("dock4");
            l.Add("dock5");

            return l;
        }

     }

}
