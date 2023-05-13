using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsWCFToDb.ServiceReference1;

namespace WinFormsWCFToDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.ID = Convert.ToInt32(txtID.Text);
            p.Name = txtName.Text;
            p.Age = Convert.ToInt32(txtAge.Text);

            Service1Client service = new Service1Client();
            if(service.InsertPerson(p) ==1)
            {
                MessageBox.Show("Person Insert Successfully");
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                ID = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text),
            };
            Service1Client service = new Service1Client();
            if(service.UpdatePerson(p) ==1)
            {
                MessageBox.Show("Person Update Successfully");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                ID = Convert.ToInt32(txtID.Text)
            };
            Service1Client service = new Service1Client();
            if (service.DeletePerson(p) == 1)
            {
                MessageBox.Show("Person Delete Successfully");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<Person> personL = new List<Person>();
            Person p = new Person()
            {
                ID = Convert.ToInt32(txtID.Text)
            };
            Service1Client service = new Service1Client();
            personL.Add(service.GetPerson(p));
            dgvPersons.DataSource = personL;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            List<Person> personL = new List<Person>();
            Service1Client service = new Service1Client();
            dgvPersons.DataSource = service.GetAllPersons();
        }
    }
}
