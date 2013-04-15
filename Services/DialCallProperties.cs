using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    public class DialCallProperties
    {
        public DialCallProperties(string callerId)
        {
            this.callerId = callerId;
        }

        public string callerId { set; get; }
    }
}