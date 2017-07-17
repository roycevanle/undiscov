using System;
using RestSharp;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CreateUser : Controller
    {
        // GET: Movies/Random
        public ActionResult Indexx()
        {
            return View("~/Views/CreateUser/Indexx");
        }

        [HttpPost]
        public ActionResult CalculateSimpleInterestResult(userID model)
        {
            string uri = "https://test16host.openapi.starbucks.com/identifier/v1/xid/" + model.xid + "/userId";
            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine("This is the result for searching for a UserId by ExternalID:");
            model = JsonConvert.DeserializeObject<userID>(response.Content);
            return Redirect("google.cocm");
            //return Content(response.StatusCode.ToString());
        }
    }
}
/*
[HttpPost]
public ActionResult Subscribe(userID model)
{


}
public static void searchUID()
{
    var client = new RestClient("https://test16host.openapi.starbucks.com/identifier/v1/xid/AE72AABA-439F-45C8-A56C-D07DD996C509/userId");
    var request = new RestRequest(Method.GET);
    request.AddHeader("postman-token", "6d8bbb2c-6c08-b7f4-4826-d4824242c86f");
    request.AddHeader("cache-control", "no-cache");
    request.AddHeader("accept", "application/json");
    IRestResponse response = client.Execute(request);
    Console.WriteLine("This is the result for searching for a UserId by ExternalID:");
    Console.WriteLine("*The status code is: " + (int)response.StatusCode + " " + response.StatusCode);
    userID usID = JsonConvert.DeserializeObject<userID>(response.Content); // or dynamic object?? or var
    Console.WriteLine("*The User's UserID: " + usID.userid);
    Console.WriteLine();
}
}
*/
