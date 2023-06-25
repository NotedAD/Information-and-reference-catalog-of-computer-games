using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Information_and_reference_catalog_of_computer_games
{

    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = textBox1.Text;
            string passUser = textBox2.Text;

            DB db = new DB();
            try
            {
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `account` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    string queryAccount = $"SELECT id_account FROM account WHERE login = '{loginUser}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(queryAccount, db.getConnection());
                    Main main = new Main();

                    db.openConnection();

                    main.idInfo = mySqlCommand.ExecuteScalar().ToString();

                    db.closeConnection();

                    MessageBox.Show("Добро пожаловать " + loginUser, "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main.isAdmin = loginUser;
                    Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не запустили сервер либо у вас не база данных создана!");
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            Hide();
            registrationForm.Show();
        }
    }
}
