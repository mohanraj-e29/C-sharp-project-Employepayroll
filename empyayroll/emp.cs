using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empyayroll
{
    public partial class emp : Form
    {
        public emp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp1 ed = new emp1();
            ed.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emp2 nb = new emp2();
            nb.Show();
            this.Hide();
        }
    }
}
