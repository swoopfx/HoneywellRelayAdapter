using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
// using


namespace relayAdapter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FindcustomerbyidController : ControllerBase
    {

        [HttpPost]
        public async  Task<JsonResult> findcustomerbyid(Dtos.Findcustomerbyiddto findcustomerbyiddto)
        {
            ServiceReference.CallContext callcontext = new ServiceReference.CallContext();
            callcontext.Company = "hfmp";
            callcontext.Language = "";
            callcontext.LogonAsUser = "BankCollect2";
            callcontext.MessageId = "";
            callcontext.PartitionKey = "";
            // callcontext.PropertyBag.Keys
 
            // return  Jnew [] { "Matthew", "Mark", "Luke", "John" };
            // return new JsonResult();
           // JsonSerializer();
           ServiceReference.HFMP_AX_ECollectionClient client = new ServiceReference.HFMP_AX_ECollectionClient(ServiceReference.HFMP_AX_ECollectionClient.EndpointConfiguration.NetTcpBinding_HFMP_AX_ECollection);
           client.ClientCredentials.Windows.ClientCredential.UserName = "BankCollect2";
           client.ClientCredentials.Windows.ClientCredential.Password = "Password@123";
        
        //    try
        //    {
          if (client.InnerChannel.State != System.ServiceModel.CommunicationState.Faulted)
            {
               var res = await client.findCustomerByIdAsync(callcontext, findcustomerbyiddto._custAccount);
                string jsonText = JsonConvert.SerializexmlNode(res);
            }else{
               return await client.findCustomerByIdAsync(callcontext, findcustomerbyiddto._custAccount);
                
            }
          

        }

    }
}