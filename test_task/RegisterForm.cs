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
    public partial class RegisterForm : Form
    {
        public Boolean isUserExists()
        {
            DatabaseClass db = new DatabaseClass();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE us_login = @loginU", db.getConnection());
            command.Parameters.Add("@loginU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("такой логин уже занят");
                return true;
            }
            else
                return false; 
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            loginField.Text = "введите номер карты";
            loginField.ForeColor = Color.Gray;

            passField.Text = "введите пароль";
            passField.ForeColor = Color.Gray;
        }
        
        private void reg_Click(object sender, EventArgs e)
        {

            if (loginField.Text == "")
            {
                MessageBox.Show("введите номер карты");
                return; 
            }

            if (loginField.Text == "введите номер карты")
            {
                MessageBox.Show("введите номер карты");
                return;
            }
            if (passField.Text == "введите пароль")
            {
                MessageBox.Show("введите пароль");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("введите пароль");
                return;
            }

            if (isUserExists()) return;
            DatabaseClass db = new DatabaseClass();

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO users (us_login, us_password) values (@login, @password)", db.getConnection());
            command.Parameters.Add("@login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginField.Text;
            command.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passField.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("аккаунт создан");
            else 
                MessageBox.Show("аккаунт не может быть создан");
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 authorization = new Form1();
            authorization.Show();
        }
        
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "введите номер карты")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
            /* System.Diagnostics.Process Go = new System.Diagnostics.Process();
             Go.StartInfo.FileName = textBox1.Text;
             Go.Start();*/
        }
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "введите номер карты";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }

        }
        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }
    }
}
