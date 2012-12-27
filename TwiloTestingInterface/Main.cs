using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Twilio;

namespace TwiloTestingInterface
{
    public partial class Main : Form
    {
        private TwilioRestClient client;

        
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string accountSid = "AC910947335f85f6b222394231ac5f064d";
            string authToken = "44e9b67a8f82209656db45e7575759c5";
            

            Dictionary<string, string> dqueues = new Dictionary<string, string>();

            client = new TwilioRestClient(accountSid, authToken);
            QueueResult queues = client.ListQueues();

            foreach (Queue queue in queues.Queues)
            {
              
                cmbQueue.Items.Add(new KeyValuePair<string,string>(queue.FriendlyName,queue.Sid));
            }

            
          //  
        }

        private void cmbQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCallsInQueueCounter();
        }

        private void UpdateCallsInQueueCounter()
        {
            KeyValuePair<string, string> kv = (KeyValuePair<string, string>)cmbQueue.Items[cmbQueue.SelectedIndex];
            Queue queue = client.GetQueue(kv.Value);
            if (queue != null)
            {
                lblCallsInQueue.Text = queue.CurrentSize.ToString();
            }
        }

        private void btnRefreshCallsInQueue_Click(object sender, EventArgs e)
        {
            UpdateCallsInQueueCounter();
        }

        private void btnTakeCall_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> kv = (KeyValuePair<string, string>)cmbQueue.Items[cmbQueue.SelectedIndex];
            Queue queue = client.GetQueue(kv.Value);
            QueueMember member = client.GetFirstQueueMember(queue.Sid);
            client.RedirectCall(member.CallSid, "http://twimlets.com/forward?PhoneNumber=" + mskAgentNumer.Text, string.Empty);
            Call call = client.GetCall(member.CallSid);

            txtCallFrom.Text = call.From;
            txtWaitTime.Text = member.WaitTime.ToString() + " s";
           
            //client.DequeueFirstQueueMember(queue.Sid, "http://twimlets.com/forward?PhoneNumber="+mskAgentNumer.Text);
        }

    }
}
