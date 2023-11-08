using System;
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
using System.Text.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Diagnostics;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
      
        public string code = "";
        private static readonly HttpClient client = new HttpClient();
        bool login = false;
        int status = 0;
        public Form1()
        {
            
            InitializeComponent();
            textBox1.Hide();
            loading_icon.Visible = false;
          //  Thread print = new Thread(Print);
            //print.Start();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PINcode form = new PINcode();
            form.ShowDialog();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void focusOpTextbox(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }
        private async void checkEnter(object sender, KeyPressEventArgs e)
        {
            info.Text = code;
            if (e.KeyChar == (char)Keys.Escape) this.Close();
          else  if (e.KeyChar == (char)13)
            {
                if (code.Length != 5)
                {
                    info.Text = "Scan je leerlingenkaart.";
                    MessageBox.Show("Ongeldige Barcode.");
                   // info.Text = "";
                    //info.Update();
                    code = "";
                    this.ActiveControl = textBox1;       
                }
                else
                {
                
                    Debug.WriteLine("barcode controleren");
                    this.KeyPreview =false;
                    textBox1.Enabled = false;
                    loading_icon.Visible = true;
                    status = 0;
                    info.Text = "Barcode controleren.";
                   
                  
               
                    var s = await Task.Factory.StartNew(async() =>
                    {
                        return false;
                    });
                    await SendInfo();
                    Debug.WriteLine(s.Result);
                    PINcode form = new PINcode();
                   // form.ShowDialog();
                    if (login&&status==1)
                    {
                        info.Text = "Scan je leerlingenkaart.";
                        Data.bcode = code;
                        code = "";
                        form.ShowDialog();
                    }
                    else if (status == 1 && !login)
                    {
                        Data.bcode = code;
                        code = "";
                        info.Text = "Scan je leerlingenkaart.";
                        geen_account_dialog geen_Account=new geen_account_dialog(); 
                        geen_Account.ShowDialog();
                       // info.Text = "Ongeldige leerlingenkaart.";
                    }
                    else if(status==2)
                    {
                        info.Text = "Scan je leerlingenkaart.";
                        MessageBox.Show("Er ging iets mis. (server is onbereikbaar)");

                    }
                    else code = "";
                    this.ActiveControl = textBox1;
                }
            }
            else
            {
                code += e.KeyChar;
            } 
        }
        private async Task SendInfo()
        {

            try
            {

                var values = "{\"bcode\":\"" + code + "\"}";
                JObject json = JObject.Parse(values);
                var jsonString = JsonConvert.SerializeObject(json);
                var content = new StringContent(values, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Data.server_address+"/check-code", content);
                Debug.WriteLine("fetching");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject jsonObject = JObject.Parse(responseString);
                    string value = jsonObject["login"].ToString();
                    login = Convert.ToBoolean(value);
                    loading_icon.Visible = false;
                    status = 1;
                }
                else
                {
                    info.Text = "Scan je leerlingenkaart.";
                    MessageBox.Show("Er ging iets mis.");
                   // info.Text = "Er ging iets mis.";
                    code = "";
                    loading_icon.Visible = false;
                    status = 2;
                }
            }
            catch (Exception ex)
            {
                code = "";
                status = 2;
                this.info.Invoke((MethodInvoker)delegate {
                    info.Text = "Scan je leerlingenkaart.";
                    loading_icon.Visible = false;
                    info.Update();
                });


            }

        }
        private void Print()
        {
            string oudInfo = info.Text;
            while (true)
            {


                if (info.Text == "Barcode controleren.")
                {
                    while (status == 0)
                    {

                        if (info.Text == "Barcode controleren...") info.Invoke((MethodInvoker)(() => info.Text = "Barcode controleren."));
                        else if (info.Text == "Barcode controleren..") info.Invoke((MethodInvoker)(() => info.Text = "Barcode controleren..."));
                        else if (info.Text == "Barcode controleren.") info.Invoke((MethodInvoker)(() => info.Text = "Barcode controleren.."));
                        Thread.Sleep(500);  


                    }


                }

                if (info.Text == "Ongeldige Barcode." || info.Text == "Ongeldige leerlingenkaart." || info.Text == "Er ging iets mis." || info.Text == "Er ging iets mis. (server is onbereikbaar)")
                {
                    Thread.Sleep(3000);
                    info.Invoke((MethodInvoker)(() => info.Text = "Scan je leerlingenkaart."));
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void loading_icon_Click(object sender, EventArgs e)
        {

        }

        private void loading_icon_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class Data
    {
        static public string bcode = "";
        static public string server_address = "http://192.168.100.3:80";
        static public int pin;
    }
}
