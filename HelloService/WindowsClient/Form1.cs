using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        HelloService.HelloServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HelloService.HelloServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task<string> t = client.GetMessageWithoutAnyProtectionAsync();
            MessageBox.Show(t.Result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task<string> t = client.GetSignedMessageAsync();
            MessageBox.Show(t.Result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task<string> t = client.GetSignedAndEncrytedMessageAsync();
            MessageBox.Show(t.Result);
        }
    }
}
