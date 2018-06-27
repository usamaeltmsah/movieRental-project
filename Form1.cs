using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqLConnection = new SqlConnection("Data Source=DESKTOP-20MBGTT;Integrated Security=True");
            SqlCommand sqlComand = new SqlCommand();
            sqlComand.Connection = sqLConnection;
            sqLConnection.Open();

            Form2 ins = new Form2();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void custSignUpButt_Click(object sender, EventArgs e)
        {

        }
    }
}
