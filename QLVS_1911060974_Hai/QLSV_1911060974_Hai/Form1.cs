using QLSV_1911060974_Hai.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSV_1911060974_Hai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void themtt_Click(object sender, EventArgs e)
        {
            Class1 p = new Class1();
            p.Masv = Convert.ToInt32(txtMasv.Text);
            p.Tensv = txtTensv.Text;
            p.Hocphan = txtHocphan.Text;
            p.Makhoa = txtMakhoa.Text;
            p.Malop = txtMalop.Text;

            Service1Client service = new Service1Client();
            if (service.InsertClass1(p) == 1)
            {
                MessageBox.Show("Class1 Insert Successfully");
            }
        }

        private void suatt_Click(object sender, EventArgs e)
        {
            Class1 p = new Class1()
            {
                Masv = Convert.ToInt32(txtMasv.Text),
                Tensv = txtTensv.Text,
                Hocphan = txtHocphan.Text,
                Makhoa = txtMakhoa.Text,
                Malop = txtMalop.Text,
        };
            Service1Client service = new Service1Client();
            if (service.UpdateClass1(p) == 1)
            {
                MessageBox.Show("Class1 Update Successfully");
            }
        }

        private void xoatt_Click(object sender, EventArgs e)
        {
            Class1 p = new Class1()
            {
                Masv = Convert.ToInt32(txtMasv.Text)
            };
            Service1Client service = new Service1Client();
            if (service.DeleteClass1(p) == 1)
            {
                MessageBox.Show("Class1 Delete Successfully");
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            List<Class1> Class1L = new List<Class1>();
            Class1 p = new Class1()
            {
                Masv = Convert.ToInt32(txtMasv.Text)
            };
            Service1Client service = new Service1Client();
            Class1L.Add(service.GetClass1(p));
            dgvQlsv.DataSource = Class1L;
        }

        private void danhsachsv_Click(object sender, EventArgs e)
        {
            List<Class1> Class1L = new List<Class1>();
            Service1Client service = new Service1Client();
            dgvQlsv.DataSource = service.GetAllClass1s();
        }
    }
}
