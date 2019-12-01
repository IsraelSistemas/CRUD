using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlConnectionLibrary;

namespace CRUD
{
    public partial class Form1 : Form
    {
        sqlConnectionLibrary.sqlConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new sqlConnectionLibrary.sqlConnection();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (con.TestConnection())
            {
                MessageBox.Show("Connection OK");
            } 
            else
            {
                MessageBox.Show("Something goes wrong");
            }
        }
    }
}
