using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Zen.Barcode;
namespace WindowsFormsApp2
{
    public partial class codeViewer : Form
    {
        public Data data = new Data();
        public string server_address = "http://10.0.0.72:80/";
        public string web_server_address = "http://10.0.0.72:8080/";
        public codeViewer()
        {
            InitializeComponent();
        }

        private void codeViewer_Load(object sender, EventArgs e)
        {
            Socket();
        }
        private  async void Socket()
        {
            string text = "";
            var client = new SocketIOClient.SocketIO(server_address);
            client.On("get-code", response =>
            {
                 text = response.GetValue<string>();
                Debug.WriteLine("received code: "+text);
                info.Invoke((MethodInvoker)(() => info.Text = "Scan de QR-code of ga naar de site (tabblad \"Registreren via terminal\") en geef deze code in: "));
                codelbl.Invoke((MethodInvoker)(() => codelbl.Text = text));
            });
            client.OnConnected += async (sender, e) =>
            {
                await client.EmitAsync("get-code", Data.bcode);
                Debug.WriteLine("request send");
            };
            await client.ConnectAsync();
        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(web_server_address+"register/remote-registration?bcode="+codelbl.Text, 60);
        }
    }
}