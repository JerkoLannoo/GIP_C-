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
        public string server_address = Data.server_address;
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
            client.On("register-status", response =>
            {
                text = response.GetValue<string>();
                Debug.WriteLine("received code: " + text);
                info.Invoke((MethodInvoker)(() => info.Text = "Kijk in uw mailbox voor een verificatie link."));
                codelbl.Invoke((MethodInvoker)(() => codelbl.Text = ""));
                pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Visible = false));
            });
            client.On("scan-status", response =>
            {
                text = response.GetValue<string>();
                Debug.WriteLine("received code: " + text);
                info.Invoke((MethodInvoker)(() => info.Text = "Voer de gegevens in op uw apparaat."));
                codelbl.Invoke((MethodInvoker)(() => codelbl.Text = ""));
                pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Visible =false));
            });
            client.On("end-connection", response =>
            {
                text = response.GetValue<string>();
                Debug.WriteLine("received code: " + text);
                info.Invoke((MethodInvoker)(() => info.Text = text));
                codelbl.Invoke((MethodInvoker)(() => codelbl.Text = ""));
                pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Visible = false));
                Thread.Sleep(5000);
                this.Invoke((MethodInvoker)(() => this.Close()));

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
            pictureBox1.Image = qrcode.Draw("https://gip.jerkolannoo.be/register/remote-registration?code="+codelbl.Text, 60);
        }
    }
}