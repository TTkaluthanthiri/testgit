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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void Lbl_loanInstallments_Click(object sender, EventArgs e)
        {

        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
                     
            string fname = txt_firstName.Text;
            string lname = txt_lastName.Text;
            int empID = int.Parse(txt_empID.Text);
            string desi = txt_designation.Text;

                    
            int loan_ins = int.Parse(txt_loanInstallments.Text);
            int leave_days = int.Parse(txt_leaveDays.Text);
            int over_hour = int.Parse(txt_overtimeHours.Text);
            int accNo = int.Parse(txt_accNumber.Text);
            int days_work = int.Parse(txt_daysWorked.Text);

            int salary,ans_day,ans_over,ans_leave;

            ans_day = days_work * 1500;
            ans_over = over_hour * 400;
            ans_leave = leave_days * 1000;
            salary = ans_day + ans_over-(loan_ins);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\payroll.mdf;Integrated Security=True;Connect Timeout=30");
            
            String qry = "INSERT INTO employee Values('" + fname + "','" + lname + "'," + empID + ",'" + desi + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            
            String qry2 = "INSERT INTO salary Values(''," + empID + "," + loan_ins + "," + leave_days + ", " + over_hour + "," + accNo + "," + days_work + "," +salary+")";
            SqlCommand cmd2 = new SqlCommand(qry2, con);
           
                      
            try
            {
                con.Open();
                
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Record Insert Succefully");
            }

            catch (Exception ex)

            { MessageBox.Show("" + ex); }




        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
