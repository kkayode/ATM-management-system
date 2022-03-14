using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ATM_Management_System_Using_Csharp
{
    public partial class frm_login : Form
    {


        

        public frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM atm.login WHERE username='" + txt_accountno.Text + "'";
            command = new MySqlCommand(query, connections);
            connections.Open();
            mdr = command.ExecuteReader();






        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_register fr = new frm_register();
            fr.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
