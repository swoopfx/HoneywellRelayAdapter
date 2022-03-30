using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;
// using


namespace relayAdapter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FindcustomerbyidController : ControllerBase
    {

        [HttpPost]
        public async Task<ServiceReference.HFMP_AX_ECollectionFindCustomerByIdResponse> findcustomerbyid(Dtos.Findcustomerbyiddto findcustomerbyiddto)
        {
            ServiceReference.CallContext callcontext = new ServiceReference.CallContext();
            callcontext.Company = "";
            callcontext.Language = "";
            callcontext.LogonAsUser = "";
            callcontext.MessageId = "";
            callcontext.PartitionKey = "";
            // callcontext.PropertyBag.Keys
 
            // return  Jnew [] { "Matthew", "Mark", "Luke", "John" };
            // return new JsonResult();
           // JsonSerializer();
           ServiceReference.HFMP_AX_ECollectionClient client = new ServiceReference.HFMP_AX_ECollectionClient();
        //    try
        //    {
               var  response  = await client.findCustomerByIdAsync(callcontext, findcustomerbyiddto._custAccount);
               return response;
            //    if(response.)
           
        //    }
        //    catch (System.Exception ee)
        //    {
               
        //        //throw Debug.WriteLine("WElo");
        //    }
           // return "";

        }

    }
}