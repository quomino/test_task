using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace test_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginField.Text = "номер карты";
            loginField.ForeColor = Color.Gray;

            passField.Text = "пароль";
            passField.ForeColor = Color.Gray;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "номер карты")
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
                loginField.Text = "номер карты";
                loginField.ForeColor = Color.Gray;
            }
        }
        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }
        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "пароль";
                passField.ForeColor = Color.Gray;
            }
        }
        
        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DatabaseClass db = new DatabaseClass();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE us_login = @loginU AND us_password = @passU", db.getConnection());
            command.Parameters.Add("@loginU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginUser;
            command.Parameters.Add("@passU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passUser;

            //command.ExecuteScalar().ToString()

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm main_menu = new MainForm();
                main_menu.Show();
            }
            else MessageBox.Show("нет пользователей. Перейдите к регистрации");
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }

        public string loginForMainForm()
        {
            return loginField.Text; 
        }
    }
}
