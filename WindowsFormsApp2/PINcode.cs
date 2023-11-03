using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class PINcode : Form
    {
        public bool login = false;
        byte status=0;
        private static readonly HttpClient client = new HttpClient();
        public PINcode()
        {
            InitializeComponent();
        }

        private void checkNrBtn(object sender, EventArgs e)
        {

            Button button = sender as Button;
            pinBox.Text += button.Text;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            pinBox.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (pinBox.Text.Length > 0) pinBox.Text = pinBox.Text.Remove(pinBox.Text.Length - 1);
        }

        private async void okbtn_Click(object sender, EventArgs e)
        {
            this.Text = Data.bcode;
            await SendInfo();
        }
        private async Task SendInfo()
        {

            try
            {
                info.Text = "Wacht even...";
                var values = "{\"pincode\":\"" + pinBox.Text + "\", \"bcode\":\"" + Data.bcode + "\"}";
                JObject json = JObject.Parse(values);
                var jsonString = JsonConvert.SerializeObject(json);
                var content = new StringContent(values, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Data.server_address+"/check-pin", content);
                Debug.WriteLine("fetching");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject jsonObject = JObject.Parse(responseString);
                    string value = jsonObject["login"].ToString();
                    login = Convert.ToBoolean(value);
                    if (login) {
                        info.Text = "OK";
                        okbtn.Enabled = false;
                        Data.pin = Convert.ToInt32(pinBox.Text);
                        dashboard dash = new dashboard();
                        dash.ShowDialog();
                        this.Close();
                    }
                    else info.Text = "Verkeerde PIN-code";
                }
                else
                {
                    info.Text = "Er ging iets mis.";
                }
            }
            catch (Exception ex)
            {
                this.info.Invoke((MethodInvoker)delegate
                {
                    info.Text = "Er ging iets mis.";
                    info.Update();
                });


            }

        }
    }
}
