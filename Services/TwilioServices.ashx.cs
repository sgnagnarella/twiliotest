using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    /// <summary>
    /// Summary description for TwilioServices
    /// </summary>
    public class TwilioServices : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Clear(); 
            context.Response.ContentType = "text/xml"; 
            context.Response.ContentEncoding = System.Text.Encoding.UTF8; 
            string twiMLResponse = "<Response><Say>Hello World</Say></Response>"; 
            context.Response.Write(twiMLResponse); 
            context.Response.End(); 
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}