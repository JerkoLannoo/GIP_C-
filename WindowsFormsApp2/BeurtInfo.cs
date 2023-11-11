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
    public partial class BeurtInfo : Form
    {
        JSON[] jsonObjects;
        private static readonly HttpClient client = new HttpClient();
        string saldo = "";
        string password = "";
        string email = "";
        public BeurtInfo()
        {
            InitializeComponent();
        }

        private void filterChk_CheckedChanged(object sender, EventArgs e)
        {
            if (filterChk.Checked)
            {
                dataView.Rows.Clear();
                for(int i=0; i<jsonObjects.Length;i++)
                {
                    if (jsonObjects[i].used==0) dataView.Rows.Add(jsonObjects[i].username, formatTime(Convert.ToInt32(jsonObjects[i].time)), jsonObjects[i].devices);
                }

            }
            else
            {
                dataView.Rows.Clear();
                for (int i = 0; i < jsonObjects.Length; i++)
                {
                    dataView.Rows.Add(jsonObjects[i].username, formatTime(Convert.ToInt32(jsonObjects[i].time)), jsonObjects[i].devices);
                }
            }

        }
        private async Task getUserInfo()
        {


            var values = "{\"pincode\":\"1234" + "\", \"bcode\":\"42107" + "\"}";
            JObject json = JObject.Parse(values);
            var jsonString = JsonConvert.SerializeObject(json);
            var content = new StringContent(values, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Data.server_address + "/get-user-beurten", content);
            Debug.WriteLine("fetching");
            var responseString = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Debug.WriteLine(responseString);
                //    JObject jsonObject = JObject.Parse(responseString);
                jsonObjects = JsonConvert.DeserializeObject<JSON[]>(responseString);
                for (int i = 0; i < jsonObjects.Length; i++)
                {
                    dataView.Rows.Add(jsonObjects[i].username, formatTime(Convert.ToInt32(jsonObjects[i].time)), jsonObjects[i].devices);
                }
            }
            else
            {
                this.Text = "Er ging iets mis." + response.StatusCode;
            }



        }

        private async void BeurtInfo_Load(object sender, EventArgs e)
        {
           await getUserInfo();
        }
        private string formatTime(int time)
        {
            if (time < 24) return time + "h";
            else if (time >= 24 && time < 720)
            {
                return (time / 24) + " Dagen(en)";
            }
            else if (time >= 720)
            {
                return (time / 720) + " Maand(en)";
            }
            else return null;
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
