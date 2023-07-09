using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogManagement
{
    public partial class ViewCallDetails : Form
    {
        public ViewCallDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clear the current records in the grid
            dataGridView1.Rows.Clear();

            // fetch records from the database
            // display them in the grid
            Connection connection = new Connection();
            connection.data_receive("Select * from CallDetails where Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
            DataTable dt = new DataTable();
            connection.data_adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["FatherName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Address"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["MobileNumber"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Date"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Time"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["Duration"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["Notes"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["Status"].ToString();
            }
        }
    }
}
