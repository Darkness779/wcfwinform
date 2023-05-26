using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hai_1911060974
{
    public partial class Form1 : Form
    {
        VuHai_1911060974.IServiceVu_HaiClient client;
        public Form1()
        {
            InitializeComponent();
            client = new VuHai_1911060974.IServiceVu_HaiClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string content = textContent.Text;
            if (!string.IsNullOrEmpty(content))
            {
                string result = await client.GetMessageWithoutAnyProtectionAsync(content);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung.");

            }
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
