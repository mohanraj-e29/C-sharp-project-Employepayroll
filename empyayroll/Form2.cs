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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=employe_payroll;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            String usern = textBox1.Text;
            int passw = int.Parse(textBox2.Text);
            SqlCommand cmds = new SqlCommand("update admin set Username='" + usern + "' where Pasword=" + passw + "", con);
            con.Open();
            int s = cmds.ExecuteNonQuery();
            MessageBox.Show(s != 0 ? "Password Changed..." : "Invalid Username...");
            con.Close();
            
        }
    }
}
