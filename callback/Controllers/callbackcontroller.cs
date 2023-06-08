using callback.model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace callback.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class callbackcontroller : Controller
    {
        public static string status;
        

        [HttpPost]
        public IActionResult ProcessPayment([FromBody] PaymentRequest paymentRequest)
        {
            var id = paymentRequest.order_id;
            PostToDynamic postToDynamic = new PostToDynamic();

            if (paymentRequest.link == null)
            {
                status = "payment has been cancelled";

            }
            else
            {

                foreach (var operation in paymentRequest.operations)
                {

                    if (operation.type == "refund")
                    {
                        status = operation.type;

                    }

                    
                }
                if (paymentRequest.operations.Count > 0 && paymentRequest.operations[0].qp_status_msg == "Approved")
                {
                    
                    status = "Approved";
                    Console.WriteLine("okay");
                    

                }
                else if (paymentRequest.operations.Count > 0 && paymentRequest.operations[0].qp_status_msg == "Rejected")
                {
                    status = "Rejected";
                    Console.WriteLine("Rejected");
                }
                else if (paymentRequest.operations.Count > 0 && paymentRequest.operations[0].qp_status_msg == " Card Expired")
                {
                    status = "Card Expired";
                    Console.WriteLine("Card Expired");
                }



            }
            if(status == null)
            {
                status = "waiting for payment";
            }
            postToDynamic.postdata(id, status);
            return Ok();

        }
    }
}
