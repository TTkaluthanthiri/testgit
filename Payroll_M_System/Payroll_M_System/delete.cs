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

namespace Payroll_M_System
{
    public partial class delete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\payroll.mdf;Integrated Security=True;Connect Timeout=30");
        public delete()
        {
            InitializeComponent();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(txt_delete.Text);

            

            String qry = "Delete from employee where emp_id="+empID+" ";
            SqlCommand cmd = new SqlCommand(qry, con);

            String qry2 = "DELETE from salary where acc_no=" + empID + " ";
            SqlCommand cmd2 = new SqlCommand(qry2, con);


            try
            {
                con.Open();

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Record Delete Succefully");
            }

            catch (Exception ex)

            { MessageBox.Show("" + ex); }
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
