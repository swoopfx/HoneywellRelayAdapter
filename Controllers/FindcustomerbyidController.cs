using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
// using


namespace relayAdapter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FindcustomerbyidController : ControllerBase
    {

        [HttpPost]
        public ActionResult<string> findcustomerbyid(Dtos.Findcustomerbyiddto findcustomerbyiddto)
        {
            // return  Jnew [] { "Matthew", "Mark", "Luke", "John" };
            // return new JsonResult();
           // JsonSerializer();
            return "";

        }

    }
}