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
    public partial class emp1 : Form
    {
        public emp1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=employe_payroll;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int empids = int.Parse(textBox1.Text);
            String empfn = textBox2.Text;
            String empln = textBox3.Text;
            int eage = int.Parse(textBox4.Text);
            String daob = textBox5.Text;
            String adrs = textBox6.Text;
            int aadar = int.Parse(textBox7.Text);
            int phono = int.Parse(textBox8.Text);
            String email = textBox9.Text;
            String jnam = textBox10.Text;
            int mangid = int.Parse(textBox11.Text);
            String hirdte = textBox12.Text;
            int salary = int.Parse(textBox13.Text);
            int depaid = int.Parse(textBox14.Text);
            String loca = textBox15.Text;
            SqlCommand cmds = new SqlCommand("insert into employee_info values(" + empids + ",'" + empfn + "','" + empln + "'," + eage + ",'" + daob + "','" + adrs + "'," + aadar + "," + phono + ",'" + email + "','" + jnam + "'," + mangid + ",'" + hirdte + "'," + salary + "," + depaid + ",'" + loca + "')", con);
            con.Open();
            int s = cmds.ExecuteNonQuery();
            MessageBox.Show(s != 0 ? "Data Saved..." : "Data Not Saved...");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmds = new SqlCommand("select*from employee_info", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmds);
            DataSet se = new DataSet();
            ad.Fill(se);
            res.DataSource = se.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String jnam = textBox10.Text;
            SqlCommand cmds= new SqlCommand("delete from employee_info where job_name='" + jnam + "'", con);
            con.Open();
            int s = cmds.ExecuteNonQuery();
            MessageBox.Show(s != 0 ? "Data deleted..." : "Invalid job name...");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String empfn = textBox2.Text;
            String loca = textBox15.Text;
            SqlCommand cmds = new SqlCommand("update employee_info set emp_fname='" + empfn + "' where location='" + loca + "'", con);
            con.Open();
            int s = cmds.ExecuteNonQuery();
            MessageBox.Show(s != 0 ? "Data Saved..." : "Invalid location...");
            con.Close();
        }
    }
}
