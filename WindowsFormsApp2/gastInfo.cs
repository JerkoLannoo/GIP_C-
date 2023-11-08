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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp2
{
    public partial class gastInfo : Form
    {
        JSON[] jsonObjects;
        private static readonly HttpClient client = new HttpClient();
        string saldo = "";
        string password = "";
        string email = "";
        public gastInfo()
        {
            InitializeComponent();
           
        }

        private async void gastInfo_Load(object sender, EventArgs e)
        {
            await GetUserInfo();

        }
        private async Task GetUserInfo()
        {

                
                var values = "{\"pincode\":\"1234" + "\", \"bcode\":\"42107" +"\"}";
                JObject json = JObject.Parse(values);
                var jsonString = JsonConvert.SerializeObject(json);
                var content = new StringContent(values, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Data.server_address + "/get-guest-beurten", content);
                Debug.WriteLine("fetching");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                Debug.WriteLine(responseString);
                //    JObject jsonObject = JObject.Parse(responseString);
                     jsonObjects = JsonConvert.DeserializeObject<JSON[]>(responseString);
                    for (int i = 0; i < jsonObjects.Length; i++)
                    {
                    string pswd = "";
                    for (int y = 0; y<jsonObjects[i].password.Length; y++) pswd += "*";
                        dataView.Rows.Add(jsonObjects[i].username, formatTime(Convert.ToInt32(jsonObjects[i].time)), jsonObjects[i].devices, pswd);
                    }
                }
                else
                {
                    this.Text = "Er ging iets mis."+response.StatusCode;
                }
            
          

        }
        private string formatTime(int time)
        {
            if (time < 24) return time + "h";
            else if (time >= 24 && time < 720)
            {
                return (time / 24) + "d";
            }
            else if (time >= 720)
            {
                return (time / 720) + "m";
            }
            else return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows[0] != null)
            {
                dataView.Rows[Convert.ToInt32(dataView.SelectedRows[0])].Cells[3].Value ="test";
            }
        }
    }
    class JSON
    {
        public string email { get; set; }
        public int devices { get; set; }
        public string time { get; set; }
        public string loginDate { get; set; }
        public string creationDate { get; set; }
        public float price { get; set; }
        public int type { get; set; }
        public long activeDate { get; set; }
        public int used { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
