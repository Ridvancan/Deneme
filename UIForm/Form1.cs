using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI;
using WebAPI.Models;

namespace UIForm
{
    public partial class Form1 : Form
    {
        public string which = "Orders";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }
       
        public async void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = await ApıDal<Employess>.GetInfo("employess");
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = await ApıDal<Products>.GetInfo("products");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await ApıDal<Customers>.GetInfo("customers");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await ApıDal<Shippers>.GetInfo("shippers");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await ApıDal<Suppliers>.GetInfo("suppliers");
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await ApıDal<Orders>.GetInfo("orders");
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await ApıDal<Categories>.GetInfo("categories");
        }

      
    }
}
