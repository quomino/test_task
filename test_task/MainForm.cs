using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test_task
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            String login = form1.loginForMainForm();
        }

        private void checkMoney_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            String login = form1.loginForMainForm();


            DatabaseClass db = new DatabaseClass();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE us_login = @loginU", db.getConnection());

            command.Parameters.Add("@loginU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = login;



            MessageBox.Show("на вашем счету ..."+"");
        }

        private void changePW_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePWForm ch = new changePWForm();
            ch.Show();
        }
        
        private void moneyOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            moneyOutForm aMF = new moneyOutForm();
            aMF.Show();
        }

        private void addMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            addMoneyForm aMF = new addMoneyForm();
            aMF.Show();
        }
    }
}
