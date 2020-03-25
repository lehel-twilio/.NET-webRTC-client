using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CefSharp;
using CefSharp.OffScreen;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Twilio_Client___OffScreen
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public string connectionAddress;

        public string connectedCallSid;

        public Form1()
        {
            InitializeComponent();

            //At the initiailization, start chromium
            InitializeChromium();

            string accountSid = System.Configuration.ConfigurationManager.AppSettings["accountSid"];
            string authToken = System.Configuration.ConfigurationManager.AppSettings["authToken"];

            TwilioClient.Init(accountSid, authToken);

            //Twilio requires TLS 1.2
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void InitializeChromium()
        {
            lvLog.Items.Add("Initializing Chromium");
            
            CefSettings settings = new CefSettings();

            //Allow access to the microsphone and unmute the audio
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            settings.CefCommandLineArgs.Remove("mute-audio");

            //set debug port, to access open http://localhost:8088 in a browser
            settings.RemoteDebuggingPort = 8088;

            //Initialize Cef with provided settings
            Cef.Initialize(settings);

            //Create a browser component

            String page = string.Format(@"{0}\html-resources\index.html", Application.StartupPath);

            if (!File.Exists(page))
            {
                MessageBox.Show("Error, the HTML file doesn't exist" + page);
            }
            chromeBrowser = new ChromiumWebBrowser(page);
            //chromeBrowser = new ChromiumWebBrowser("https://c6e19f64.ngrok.io");

            chromeBrowser.JavascriptObjectRepository.Register("boundAsync", new BoundObject(this), true);

            lvLog.Items.Add("Successfully Initialized Chromium");
        }

        public class BoundObject
        {
            private Form1 frm1;
            
            public BoundObject(Form1 frm1)
            {
                this.frm1 = frm1;
            }

            public void showMessage(string msg)
            {
                frm1.Invoke(new MethodInvoker(delegate ()
                {
                    //Access your controls
                    frm1.lvLog.Items.Add(msg);
                }));
            }

            public void setConnectionAddress(string msg)
            {
                frm1.connectionAddress = msg;
                frm1.Invoke(new MethodInvoker(delegate ()
                {
                    //Access your controls
                    frm1.lblConnectionAddress.Text = "Connection Address: " + msg;
                }));
            }

            public void setConnectedCallSid(string msg)
            {
                frm1.connectedCallSid = msg;
                frm1.Invoke(new MethodInvoker(delegate ()
                {
                    //Access your controls
                    frm1.bDisconnect.Enabled = true;
                    frm1.bDial.Enabled = false;
                }));
            }

            public void callDisconnected()
            {
                frm1.connectedCallSid = null;
                frm1.Invoke(new MethodInvoker(delegate ()
                {
                    //Access your controls
                    frm1.bDisconnect.Enabled = false;
                    frm1.bDial.Enabled = true;
                }));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvLog.Items.Add("Dialing " + tbPhoneNumber.Text);

            var call = CallResource.Create(
                twiml: new Twilio.Types.Twiml("<Response><Dial><Client>+12562578050</Client></Dial></Response>"),
                to: new Twilio.Types.PhoneNumber(tbPhoneNumber.Text),
                from: new Twilio.Types.PhoneNumber("+12562578050")
            );

            lvLog.Items.Add("Call Sid " + call.Sid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallResource.Update(
                status: CallResource.UpdateStatusEnum.Completed,
                pathSid: connectedCallSid
            );
        }
    }
}
