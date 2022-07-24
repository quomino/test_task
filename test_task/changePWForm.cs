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
    public partial class changePWForm : Form
    {
        public changePWForm()
        {
            InitializeComponent();
        }

        private void changePWButton_Click(object sender, EventArgs e)
        {
            //string a = addMoneyBox.Text;
            //int b = int.Parse(a);

            //Form1 form1 = new Form1();
            //string login = form1.loginForMainForm();

            DatabaseClass db = new DatabaseClass();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            //NpgsqlCommand command = new NpgsqlCommand(" UPDATE users SET us_money = us_money + @moneyU WHERE us_login IN(SELECT us_login FROM users where us_login = @loginU)", db.getConnection());
            //command.Parameters.Add("@loginU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = login;

            NpgsqlCommand command = new NpgsqlCommand(" UPDATE users SET us_password = @passNew WHERE us_password IN(SELECT us_password FROM users WHERE us_password = @passOld)", db.getConnection());
            command.Parameters.Add("@passOld", NpgsqlTypes.NpgsqlDbType.Varchar).Value = oldPWBox.Text;
            command.Parameters.Add("@passOld", NpgsqlTypes.NpgsqlDbType.Varchar).Value = newPWBox.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("добавлено");
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
