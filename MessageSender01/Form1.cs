using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Win32;
using MessageSender01.Properties;

namespace MessageSender01
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        string previousAddress = Settings.Default.previousAddress;
        string previousDevName = Settings.Default.previousName;
        string previousPasword = Settings.Default.previousPassword;
        bool credentialsOK = false;
        bool addressOK = false;
        DateTime currentGMT;

        public Form1()
        {
            InitializeComponent();
            buttonSendHello.Enabled = false;
            buttonSendContinuously.Enabled = false;
            buttonStopSending.Enabled = false;
            buttonSend.Enabled = false;

        }




        public class InputData
        {
            public string Message { get; set; }
        }

        static async Task<Uri> CreateMessageAsync(InputData testData)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/values/", testData);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }


        static async Task RunAsync(string inputmessage)
        {

            try
            {
                InputData data000 = new InputData();
                data000.Message = inputmessage;
                Console.WriteLine("Message = " + data000.Message);

                var url =  CreateMessageAsync(data000);
                Console.WriteLine("Message successfully sent!");
                return;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return;
        }

        private void buttonLoadPrevCredentials_Click(object sender, EventArgs e)
        {
            textBox1.Text = previousDevName;
            textBox2.Text = previousPasword;
            credentialsOK = true;
            enable_lower_interface();
        }

        private void buttonLoadPrevAddress_Click(object sender, EventArgs e)
        {
            textBox3.Text = previousAddress;
            credentialsOK = true;
            enable_lower_interface();
        }

        private void buttonConfirmCredentials_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("~"))
            {
                labelMain.Text = "Username Cannot contain '~' ";
                return;
            }
            if (textBox2.Text.Contains("~"))
            {
                labelMain.Text = "Password Cannot contain '~' ";
                return;
            }
            if (textBox1.Text.Length > 5 && textBox2.Text.Length > 5)
            {
                Settings.Default.previousName = textBox1.Text;
                Settings.Default.previousPassword = textBox2.Text;
                Settings.Default.Save();
                credentialsOK = true;
                enable_lower_interface();
            }
            else labelMain.Text = "Please enter more appropriate credentials";
        }

        private void buttonConfirmsAddress_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 5)
            {
                Settings.Default.previousAddress = textBox3.Text;
                Settings.Default.Save();
                addressOK = true;
                enable_lower_interface();
            }
            else labelMain.Text = "Please enter an appropriate address";
        }

        private void enable_lower_interface()
        {
            if(credentialsOK && addressOK)
            {
                client.BaseAddress = new Uri(textBox3.Text); //"http://localhost:55461/"
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                labelMain.Text = "Device Ready to Launch";
                buttonConfirmCredentials.Enabled = false;
                buttonLoadPrevCredentials.Enabled = false;
                buttonConfirmAddress.Enabled = false;
                buttonLoadPrevAddress.Enabled = false;
                buttonSendHello.Enabled = true;
                buttonSendContinuously.Enabled = true;
                buttonStopSending.Enabled = true;
                buttonSend.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string message_to_send = textBox1.Text + "~" + textBox2.Text + "~" + "Hello" ;
            RunAsync(message_to_send); //.GetAwaiter().GetResult();
            return;
        }

        private void buttonSendContinuously_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStopSending_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentGMT = DateTime.Now;
            string message_to_send = textBox1.Text + "~" + textBox2.Text + "~" + currentGMT;
            RunAsync(message_to_send);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message_to_send = textBox1.Text + "~" + textBox2.Text + "~" + textBox4.Text;
            RunAsync(message_to_send);
        }
    }
}
