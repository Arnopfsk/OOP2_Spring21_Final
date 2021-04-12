using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GIU_DB_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string c_code = textBox1.Text;
            string c_name = textBox2.Text;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("insert into Course values ('{0}','{1}')", c_code, c_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Could not insert data");
            }






        }
    }
}