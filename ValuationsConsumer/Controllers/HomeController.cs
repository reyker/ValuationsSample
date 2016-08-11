using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ValuationsConsumer.Models;
using ValuationsConsumer.Utilities;

namespace ValuationsConsumer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> GetClientValuationDetails(ClientDetailsId clientDetailsId)
        {
            var model = new AccountDetails();

            using (new HttpClient())
            {
                var url = ConfigurationManager.AppSettings["APIUrl"];

                var request = WebRequest.CreateHttp(url + "api/plans/" + clientDetailsId.ReykerClientId);
                request.ContentType = "text/json";
                request.Method = "GET";

                //Need to change username to provided username
                const string authHeader = "Reyker USERNAME";
                request.Headers.Add("Authorization", authHeader);

                try
                {

                    using (var response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response != null && response.StatusCode == HttpStatusCode.OK)
                        {
                            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                            {
                                var objText = reader.ReadToEnd();
                                model = await objText.AES_Decrypt<AccountDetails>();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    var x = ex.Message;
                }
            }

            return View("ClientValuationResult",model);
        }
    }
}