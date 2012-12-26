﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;

namespace Services
{
    /// <summary>
    /// Summary description for Agent
    /// </summary>
    public class Agent : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Clear();
            context.Response.ContentType = "text/xml";
            context.Response.ContentEncoding = System.Text.Encoding.UTF8;
            var twiml = new Twilio.TwiML.TwilioResponse();
            twiml.Dial(new Twilio.TwiML.Queue("QueueDemo"));
            context.Response.Write(twiml.ToString());
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