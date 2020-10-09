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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        } 

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_login_Click(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\payroll.mdf;Integrated Security=True;Connect Timeout=30");
            String qry = "select * from admin where user_name='"+txt_uName.Text+ "'and user_id='" + txt_uId.Text + "' and pass='"+txt_pwd.Text+"'";

            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
                   
            if (dtbl.Rows.Count==1)
            {
                display dis = new display();
                dis.Show();
            }
            else

            { MessageBox.Show("Invalid User Identifications"); }
                                                 
        }
    }
}
