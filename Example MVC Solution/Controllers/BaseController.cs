using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zapappi.Client;

namespace Example_MVC_Solution.Controllers
{
    public class BaseController : Controller
    {
        protected string SubsId = ConfigurationManager.AppSettings["ZapappiSubscriptionId"];

        protected ZapappiClient client = new ZapappiClient(new Uri("https://zapappi-publicapi-dev-test.azurewebsites.net"), new BasicAuthenticationCredentials()
        {
            UserName = ConfigurationManager.AppSettings["ZapappiAPIKey"],
            Password = ConfigurationManager.AppSettings["ZapappiAPISecret"]
        });
    }
}