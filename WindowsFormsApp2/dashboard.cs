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
    public partial class dashboard : Form
    {
        private static readonly HttpClient client = new HttpClient();
        string saldo = "";
        int devices = 0;
        int gDevices = 0;
        int nDevices = 0;
        int nGDevices = 0;
        public dashboard()
        {
            InitializeComponent();
        }

        private async void dashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Laden...";
            await GetUserInfo();
         
            kredietLbl.Text = saldo;
            activeGdevicesLbl.Text = gDevices.ToString();
            activeDevicesLbl.Text = devices.ToString();
            nonActiveDevicesLbl.Text = nDevices.ToString();
            nonActiveGDevicesLbl.Text = nGDevices.ToString();
            if (nGDevices + gDevices > 0) showGDeviceInfo.Enabled = true;
            if (nDevices + devices > 0) showDeviceInfo.Enabled = true;
        }
        private async Task GetUserInfo()
        {

            try
            {
                var values = "{\"pincode\":\"" + Data.pin + "\", \"bcode\":\"" + Data.bcode + "\"}";
                JObject json = JObject.Parse(values);
                var jsonString = JsonConvert.SerializeObject(json);
                var content = new StringContent(values, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Data.server_address+"/get-user-info", content);
                Debug.WriteLine("fetching");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject jsonObject = JObject.Parse(responseString);
                    this.Text = "Dashboard";
                    saldo = "€"+ Math.Round(Convert.ToDouble(jsonObject["saldo"]), 2).ToString();
                    devices = Convert.ToInt32(jsonObject["devices"]);
                    gDevices = Convert.ToInt32(jsonObject["gDevices"]); 
                    nGDevices= Convert.ToInt32(jsonObject["nGDevices"]);
                    nDevices = Convert.ToInt32(jsonObject["nDevices"]);
                }
                else
                {
                    MessageBox.Show("Er ging iets mis");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er ging iets mis");
                this.Close();   
            }

        }
        private void showGDeviceInfo_Click(object sender, EventArgs e)
        {
            gastInfo info = new gastInfo();
            info.ShowDialog();
        }

        private void addDeviceBtn_Click(object sender, EventArgs e)
        {
            addBeurt addBeurt = new addBeurt();
            addBeurt.Show();
            this.Close();
        }

        private void showDeviceInfo_Click(object sender, EventArgs e)
        {
            BeurtInfo info = new BeurtInfo();
            info.ShowDialog();
        }

        private async void addGDeviceBtn_Click(object sender, EventArgs e)
        {
            AddGuest addGuest = new AddGuest();
            addGuest.Show();
            this.Close();
        }
    }
 

}
