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
        string password = "";
        string email = "";
        public dashboard()
        {
            InitializeComponent();
        }

        private async void dashboard_Load(object sender, EventArgs e)
        {
            LoadArrayList();
            await GetUserInfo();
            kredietLbl.Text = saldo;
            await GetInfo();
          //  List<string> lijst = new List<string>(j);
            
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
                    this.Text = jsonObject["username"].ToString();
                    saldo = "€"+ jsonObject["saldo"].ToString();
                    password = jsonObject["password"].ToString();
                    email = jsonObject["email"].ToString(); 
                }
                else
                {
                }
            }
            catch (Exception ex)
            {

            }

        }
        private async Task GetInfo()
        {

            try
            {
                var values = "{\"pincode\":\"" + Data.pin + "\", \"bcode\":\"" + Data.bcode + "\"}";
                JObject json = JObject.Parse(values);
                var jsonString = JsonConvert.SerializeObject(json);
                var content = new StringContent(values, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Data.server_address+"/get-user-beurten", content);
                Debug.WriteLine("fetching");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject jsonObject = JObject.Parse(responseString);
                    activeDevices.Text = jsonObject["devices"].ToString();
                    activeGdevicesLbl.Text = jsonObject["gDevices"].ToString();
                }
                else
                {
                    this.Text = "Er ging iets mis.";
                }
            }
            catch (Exception ex)
            {
                this.Text = "Er ging iets mis.";
            }

        }

        private void showGDeviceInfo_Click(object sender, EventArgs e)
        {
            gastInfo info = new gastInfo();
            info.ShowDialog();
        }
        void LoadArrayList()
        {

            string tr = File.ReadAllText("C:\\test\\test.json");
            JSON[] jsonObjects = JsonConvert.DeserializeObject<JSON[]>(tr);

            //for (int i = 0; i < list.Count; i++)
           // this.Text = jsonObjects[0].ok.ToString();

        }
    }
 

}
