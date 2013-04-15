using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio.TwiML;
using Twilio;

namespace Services
{
    /// <summary>
    /// Summary description for TwilioServices
    /// </summary>
    public class Call : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string customerPhone = context.Request.QueryString.Get("customerPhone");

            context.Response.Clear();
            context.Response.ContentType = "text/xml";
            context.Response.ContentEncoding = System.Text.Encoding.UTF8;
            var twiml = new Twilio.TwiML.TwilioResponse();

            //twiml.Say("Hello Seba");
            //twiml.Enqueue("QueueDemo");

            DialCallProperties cp = new DialCallProperties(customerPhone);

            twiml.Dial("+17202822742", cp);

            context.Response.Write(twiml.ToString());
            context.Response.End(); 
            //string accountSid = "AC910947335f85f6b222394231ac5f064d";
            //string authToken = "44e9b67a8f82209656db45e7575759c5";
            //var twilio = new TwilioRestClient(accountSid, authToken);
            //var call = twilio.InitiateOutboundCall("+17209615246", "+17202822742", "http://twimlets.com/holdmusic?Bucket=com.twilio.music.ambient");



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