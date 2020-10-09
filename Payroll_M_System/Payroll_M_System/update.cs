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
    public partial class update : Form
    {
        
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\payroll.mdf;Integrated Security=True;Connect Timeout=30");

      
        public update()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            
        }

        private void Btn_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_up_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_empid.Text == ""&&txt_accno.Text=="")
                {
                    MessageBox.Show("Enter Employee Id and Account Number To Update");
                }
                else
                {
                    int loan_ins = int.Parse(txt_loanins.Text);
                    int leave_days = int.Parse(txt_leavedays.Text);
                    int over_hour = int.Parse(txt_overtime.Text);
                    
                    int days_work = int.Parse(txt_dayswork.Text);

                    int salary, ans_day, ans_over, ans_leave;

                    ans_day = days_work * 1500;
                    ans_over = over_hour * 400;
                    ans_leave = leave_days * 1000;
                    salary = ans_day + ans_over - (loan_ins);


                    SqlCommand cmdupdate = new SqlCommand("Update employee SET f_name='" + txt_fname.Text + "',l_name='" + txt_lname.Text + "'  where emp_id=" + txt_empid.Text + "", con);
                    SqlCommand cmdupdate2 = new SqlCommand("Update salary SET acc_no=" + txt_accno.Text + ",days_worked=" + txt_dayswork.Text + ",overtime=" + txt_overtime.Text + "," +
                        "leaves=" + txt_leavedays.Text + ",loan_inst="+txt_loanins.Text+",salary='"+lbl_salary.Text+"'  where acc_no=" + txt_accno.Text + "", con);

                    con.Open();
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();

                    cmdupdate2.CommandType = CommandType.Text;
                    cmdupdate2.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


    }
    
}
