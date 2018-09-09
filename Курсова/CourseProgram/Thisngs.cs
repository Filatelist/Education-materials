using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProgram
{
    [Serializable]
    public class Things
    {
        public string name, producer;
        public int price;

        public Things(string name, int price, string producer)
        {      
             
            this.name = name;
            this.price = price;
            this.producer = producer;
            
       
        }
    }

}
//private void GridMethod1()
//{
//    DataTable table = new DataTable("Stock");
//    var name = new DataColumn("Name");
//    var price = new DataColumn("Price");
//    var producer = new DataColumn("Producer");
//    table.Columns.Add(name);
//    table.Columns.Add(price);
//    table.Columns.Add(producer);
//    foreach (Things thing in thingslist)
//    {
//        DataRow row = table.NewRow();
//        row["Name"] = thing.name;
//        row["Price"] = thing.price;
//        row["Producer"] = thing.producer;
//        table.Rows.Add(row);
//    }
//    dataGridView1.DataSource = table;
//}