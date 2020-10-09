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
    public partial class display : Form
    {
       
        
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\payroll.mdf;Integrated Security=True;Connect Timeout=30";

        public display()
        {
            InitializeComponent();
            DisplayData();

        }

        private void DisplayData()
        {
            
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            
           
            string qry = "SELECT emp_id,f_name,l_name,desi,acc_no,loan_inst,salary From employee,salary";

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "employee,salary");
            dgv1.DataSource = ds.Tables["employee,salary"];
            
        }

       
        

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            insert open = new insert();
            open.Show();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            update open = new update();
            open.Show();
        }



        private void Dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          


        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {

            delete open = new delete();
            open.Show();



        }

    }

        
    }

