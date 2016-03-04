using System;
using System.Collections.Generic;
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
        public async Task<ActionResult> Index()
        {
            var ad = await GetClientValuationDetails();
            return View(ad);
        }

        public async Task<AccountDetails> GetClientValuationDetails()
        {
            var model = new AccountDetails();

            using (new HttpClient())
            {
                var request = WebRequest.CreateHttp("http://reykervaluationsdata.azurewebsites.net/api/plans/6733");
                request.ContentType = "text/json";
                request.Method = "GET";

                //Need to change username to provided username
                const string authHeader = "Reyker USERNAME";
                request.Headers.Add("Authorization", authHeader);

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

            return model;
        } 
    }
}