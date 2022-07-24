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
    public partial class moneyOutForm : Form
    {
        public moneyOutForm()
        {
            InitializeComponent();
        }

        private void moneyOutBox_TextChanged(object sender, EventArgs e)
        {
            string a = moneyOutBox.Text;
            int b = int.Parse(a);

            Form1 form1 = new Form1();
            string login = form1.loginForMainForm();

            DatabaseClass db = new DatabaseClass();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand(" UPDATE users SET us_money = us_money - @moneyU WHERE us_login IN(SELECT us_login FROM users where us_login = @loginU)", db.getConnection());
            command.Parameters.Add("@loginU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = login;
            command.Parameters.Add("@moneyU", NpgsqlTypes.NpgsqlDbType.Integer).Value = b;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("снято");
            else
                MessageBox.Show("ошибка");
            db.closeConnection();


        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main_menu = new MainForm();
            main_menu.Show();
        }
    }
}
