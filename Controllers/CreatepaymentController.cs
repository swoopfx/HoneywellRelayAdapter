using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net;

using System.Threading.Tasks;


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
        public async Task<ServiceReference.HFMP_AX_ECollectionCreateAndPostPaymentResponse> Postpayment(Dtos.Createpaymentdto createpaymentdto)
        {
            // return NotFound();
            ServiceReference.CallContext callcontext = new ServiceReference.CallContext();
             callcontext.Company = "hfmp";
            callcontext.Language = "";
            callcontext.LogonAsUser = "BankCollect2";
            callcontext.MessageId = "";
            callcontext.PartitionKey = "";
            

            ServiceReference.HFMP_AX_ECollectionClient client = new ServiceReference.HFMP_AX_ECollectionClient();
            // client.Client
            client.ClientCredentials.Windows.ClientCredential.UserName = "BankCollect2";
           client.ClientCredentials.Windows.ClientCredential.Password = "Password@123";
            if (client.InnerChannel.State != System.ServiceModel.CommunicationState.Faulted){
                return await client.createAndPostPaymentAsync(callcontext, createpaymentdto._custAccount, createpaymentdto._currencyCode, createpaymentdto._bankAccountId, createpaymentdto._amount, createpaymentdto._date);
           
            }else{
  return await client.createAndPostPaymentAsync(callcontext, createpaymentdto._custAccount, createpaymentdto._currencyCode, createpaymentdto._bankAccountId, createpaymentdto._amount, createpaymentdto._date);
            
            }
          // return "";
            //Call Soap Reference Service here and return json packets
            // return createpaymentdto;

        }

    }

}