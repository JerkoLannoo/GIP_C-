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
        private static readonly HttpClient client = new HttpClient();

        string code = "";
        bool login = false;
        int status = 0;
    
        public Form1()
        {
            InitializeComponent();
            textBox1.Hide();
            loading_icon.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
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
                    info.Text = "Ongeldige Barcode.";
                    code = "";
                    this.ActiveControl = textBox1;
           

                }
                else
                {
                    loading_icon.Visible = true;
                    status = 0;
                    info.Text = "Barcode controleren...";
                   
                  
               
                    var s = await Task.Factory.StartNew(async() =>
                    {
                       

                        return false;
                    });




                    await SendInfo();

                    Debug.WriteLine(s.Result);
                   
                    Form2 form2 = new Form2();
                    form2.code = code;
                   
                    if (login&&status==1)
                    {
                        info.Text = "Scan je leerlingenkaart.";
                      
                     
                        form2.ShowDialog();
                    }
                    else if (status == 1 && !login)
                    {
                    
                        info.Text = "Ongeldige leerlingenkaart.";
                        Thread.Sleep(3000);
                        info.Invoke((MethodInvoker)(() => info.Text = "Scan je leerlingenkaart."));

                    }
                    else if(status==2)
                    {

                        Debug.WriteLine("er ging iets mis2");
                        Thread.Sleep(3000);
                        

                        info.Text = "Scan je leerlingenkaart.";
                        info.Update();
                    }
                    else
                        //  form2.ShowDialog();
                        code = "";
                    
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

                var values = "{\"code\":\"" + code + "\"}";
                JObject json = JObject.Parse(values);

                var jsonString = JsonConvert.SerializeObject(json);


                var content = new StringContent(values, Encoding.UTF8, "application/json");


                var response = await client.PostAsync("http://192.168.100.3/", content);

                Debug.WriteLine("fetching");

                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject jsonObject = JObject.Parse(responseString);
                    string value = jsonObject["login"].ToString();
                    login = Convert.ToBoolean(value);
                    loading_icon.Visible = false;
                    status = 1;
                    code = "";
               
                }
                else
                {
                    info.Text = "Er ging iets mis.";

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
                    info.Text = "Er ging iets mis. (server is onbereikbaar)";
                    loading_icon.Visible = false;
                    info.Update();
                    Debug.WriteLine("Exeption used");
                });


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
    }


}
