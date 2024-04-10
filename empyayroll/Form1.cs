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
namespace empyayroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=employe_payroll;Integrated Security=True");
        private void login_Click(object sender, EventArgs e)
        {
            String username = (user.Text);
            int password = int.Parse(pass.Text);
            string Command = "select*from admin where Username='" + username + "' and Pasword=" + password + "";
            SqlCommand Com = new SqlCommand(Command, con);
            con.Open();
            SqlDataReader emps = Com.ExecuteReader();
            if (emps.Read())
            {
                emp em= new emp();
                em.Show();
                this.Hide();
                MessageBox.Show("welcome to Employe Payroll " + emps.GetValue(4).ToString());
            }
            else
            {
                MessageBox.Show("Invalid Username or Password ");

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
