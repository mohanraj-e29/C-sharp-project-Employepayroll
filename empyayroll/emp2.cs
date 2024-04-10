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
    public partial class emp2 : Form
    {
        public emp2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=employe_payroll;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int empids = int.Parse(textBox1.Text);
            String empfna = textBox2.Text;
            String emplna = textBox3.Text;
            int ages = int.Parse(textBox4.Text);
            String dob = textBox5.Text;
            String emlid = textBox6.Text;
            String address =textBox7.Text;
            int aadar = int.Parse(textBox8.Text);
            int pancrd =int.Parse(textBox9.Text);
            String bnkna = textBox10.Text;
            String bnkloc =textBox11.Text;
            int ifsc =int.Parse(textBox12.Text);
            int mslry = int.Parse(textBox13.Text);
            int dslry = int.Parse(textBox14.Text);
            int anslry=int.Parse(textBox15.Text);
            SqlCommand cmds = new SqlCommand("insert into empsalary_info values(" + empids + ",'" + empfna + "','" + emplna + "'," + ages + ",'" + dob + "','" + emlid+ "','" + address + "'," + aadar+ "," + pancrd + ",'" + bnkna + "','" +bnkloc + "'," + ifsc + "," + mslry + "," + dslry+ "," + anslry + ")", con);
            con.Open();
            int s = cmds.ExecuteNonQuery();
            MessageBox.Show(s != 0 ? "Data Saved..." : "Data Not Saved...");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String empfna = textBox2.Text;
            int anslry = int.Parse(textBox15.Text);
            SqlCommand cmds = new SqlCommand("update empsalary_info set emp_Fname='" + empfna + "' where Annual_Salary=" + anslry + "", con);
            con.Open();
            int s = cmds.ExecuteNonQuery();
            MessageBox.Show(s != 0 ? "Data Modified..." : "Invalid Fname...");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String address = textBox7.Text;
            SqlCommand cmds = new SqlCommand("delete from empsalary_info where Addres='" + address + "'", con);
            con.Open();
            int s = cmds.ExecuteNonQuery();
            MessageBox.Show(s != 0 ? "Data deleted..." : "Invalid Address...");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmds = new SqlCommand("select*from empsalary_info", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmds);
            DataSet se = new DataSet();
            ad.Fill(se);
            rest.DataSource = se.Tables[0];
            con.Close();
        }
    }
}
