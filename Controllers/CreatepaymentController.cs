using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net;


namespace relayAdapter.Controller
{

    [ApiController]
     [Route("[controller]")]
    public class CreatepaymentController : ControllerBase
    {

        // [HttpPost]
        // public IEnumerable<Payment> Post()
        // {

        // }

        public CreatepaymentController()
        {

        }
        [HttpPost]
        public ActionResult<Dtos.Createpaymentdto> Postpayment(Dtos.Createpaymentdto createpaymentdto)
        {
            // return NotFound();
            // return "";
            //Call Soap Reference Service here and return json packets
            return createpaymentdto;

        }

    }

}