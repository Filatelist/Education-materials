using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace CourseProgram
{
    public partial class Form1 : Form
    {
        List<Things> thingslist;
        private void UpdateGrid()
        {
            thingslist = new List<Things>();
            var table = new DataTable("Stock");

            // Создаем объекты DataColumn
            var make = new DataColumn("Name");
            var name = new DataColumn("Price");
            var color = new DataColumn("Producer");
            table.Columns.Add(name);
            table.Columns.Add(make);
            table.Columns.Add(color);
            foreach (Things thing in thingslist)
            {
                DataRow row = table.NewRow();
                row["Name"] = thing.name;
                row["Price"] = thing.price;
                row["Producer"] = thing.producer;
                table.Rows.Add(row);
            }
            
            dataGridView1.DataSource = table;
        }
        Things things = null;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.things = new Things(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text);
            thingslist.Add(things);
            UpdateGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //Name of product
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //price of product
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           //Producer of product
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
