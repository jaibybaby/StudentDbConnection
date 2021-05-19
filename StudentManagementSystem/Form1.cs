using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StudentDbConnection : Form
    {
        public StudentDbConnection()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-I0V022D\SQLEXPRESS;Database=StudentManagement;trusted_Connection=True;");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "StudentInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Name",txtName.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("hi");
        }
    }
}
