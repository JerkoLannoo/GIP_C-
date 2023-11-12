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
using System.Collections;
namespace WindowsFormsApp2
{

    public partial class AddGuest : Form
    {
        PRIJZEN[] prijzen;
        SUCCESS success;
        private static readonly HttpClient client = new HttpClient();
        public AddGuest()
        {
            InitializeComponent();
     
        }


         private void button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Close();
        }

        private async void onload(object sender, EventArgs e)
        {
            await getPrices();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private async Task SendInfo()
        {
            addBtn.Enabled = false;
            info.Text = "Wacht even...";
            try
            {
                var values = "{\"pincode\":\"" + Data.pin + "\", \"bcode\":\"" + Data.bcode + "\", \"duration\":\"" + formatTime(duration.Value) + "\", \"devices\":\"" + devices.Value + "\"}";
                JObject json = JObject.Parse(values);
                var jsonString = JsonConvert.SerializeObject(json);
                var content = new StringContent(values, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Data.server_address + "/add-guest-beurt", content);
                Debug.WriteLine("fetching");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    success =JsonConvert.DeserializeObject<SUCCESS>(responseString);
                    if (Convert.ToBoolean(success.success) == true)
                    {
                        MessageBox.Show("Gast beurt toegevoegd.");
                        dashboard dash = new dashboard();
                        dash.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(success.msg);
                        addBtn.Enabled = true;
                    }
                  
                }
                else
                {
                    MessageBox.Show("Er ging iets mis, probeer het later opnieuw."+response.StatusCode.ToString());
                    addBtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er ging iets mis, probeer het later opnieuw."+ex);
                addBtn.Enabled = true;
            }

        }
        private async Task getPrices()
        {
            try
            {
                var response = await client.GetAsync(Data.server_address + "/get-prijzen");
                Debug.WriteLine("fetching");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                   prijzen = JsonConvert.DeserializeObject<PRIJZEN[]>(responseString);
                    prijsLbl.Text ="€"+ prijzen[0].price.ToString();
                }
                else
                {
                    prijsLbl.Text = "Kon prijs niet laden.";
                }
            }
            catch (Exception ex)
            {
                prijsLbl.Text = "Kon prijs niet laden.";
            }

        }
        private decimal formatTime(decimal time)
        {
            if (timetype.SelectedIndex == 0) return time;
            else if (timetype.SelectedIndex == 1) return time * 24;
            else return time * 720;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            await SendInfo();
        }
    }
    class PRIJZEN
    {
        public int time { get; set; }
        public float price { get; set; }
        public int devices { get; set; }
    }
    class SUCCESS
    {
        public string success { get; set; }
        public string msg { get; set; }
    }
}
