﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ObraSocialWeb.WebService
{
    /// <summary>
    /// Summary description for ObraSocialWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ObraSocialWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld1()
        {
            return "Hello World 1";
        }

        [WebMethod]
        public string HelloWorld2()
        {
            return "Hello World 2";
        }
    }
}