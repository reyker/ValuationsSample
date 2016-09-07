using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ValuationsConsumer.Models;
using ValuationsConsumer.Utilities;

namespace ValuationsConsumer.Controllers
{
    public class BulkValuationsController : Controller
    {
        // GET: BulkValuations
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> GetBulkClientDetails()
        {
            var model = new List<AccountDetails>();

            using (new HttpClient())
            {
                var url = ConfigurationManager.AppSettings["APIUrl"];

                var request =
                    WebRequest.CreateHttp(url + "api/AggregatePlans/");
                request.ContentType = "text/json";
                request.Method = "GET";

                //NEED TO CHANGE USERNAME TO PROVIDED USERNAME
                const string authHeader = "Reyker USERNAME";
                request.Headers.Add("Authorization", authHeader);


                var response = request.GetResponse() as HttpWebResponse;

                if (response != null && response.StatusCode == HttpStatusCode.OK)
                {
                    using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        var objText = reader.ReadToEnd();
                        model = await objText.AES_Decrypt<List<AccountDetails>>();
                    }
                }
                ViewData["ResponseStatusCode"] = response.StatusCode;
                ViewData["ResponseStatusMessage"] = response.StatusDescription;

            }

            return View("BulkValuationsResult", model);
        }
    }
}