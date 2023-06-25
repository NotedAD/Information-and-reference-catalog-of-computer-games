using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_and_reference_catalog_of_computer_games
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                string query = "SELECT * FROM account ORDER BY login";
                MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection());

                db.openConnection();

                {
                    int.TryParse(age.Text, out int ageSrav);
                    if (login.Text == "" || pass.Text == "" || age.Text == "" || retrPass.Text == "")
                    {
                        MessageBox.Show("Вы не ввели данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (login.Text.Length > 20)
                        {
                            MessageBox.Show("Слишком длинный логин!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (ageSrav < 10 || ageSrav > 99)
                            {
                                MessageBox.Show("Вы ввели некорректный возраст!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (pass.Text.Length >= 6)
                                {
                                    bool en = true;
                                    bool symbol = false;
                                    bool number = false;

                                    for (int i = 0; i < pass.Text.Length; i++)
                                    {
                                        if (pass.Text[i] >= 'А' && pass.Text[i] <= 'Я') en = false;
                                        if (pass.Text[i] >= '0' && pass.Text[i] <= '9') number = true;
                                        if (pass.Text[i] == '_' || pass.Text[i] == '-' || pass.Text[i] == '!') symbol = true;
                                    }
                                    if (!en)
                                        MessageBox.Show("Доступна только английская раскладка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    else if (!symbol)
                                        MessageBox.Show("Добавьте один из следующих символов: _, -, !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    else if (!number)
                                        MessageBox.Show("Добавьте хотя бы одну цифру", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    if (en && symbol && number)
                                    {
                                        if (retrPass.Text == pass.Text)
                                        {
                                            try
                                            {
                                                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                                                {
                                                    ApplyExecuteResults();
                                                }
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Логин занят!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }

                                    }
                                    else MessageBox.Show("Пароли не совпадают!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show("Пароль слишком короткий, минимум 6 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                db.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не запустили сервер либо у вас не база данных создана!");
            }

        }

        private void ApplyExecuteResults()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `account` (`login`, `password`, `age`) VALUES (@login, @pass, @age)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass.Text;
            command.Parameters.Add("@age", MySqlDbType.Int64).Value = age.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Authorization authorization = new Authorization();
                authorization.Show();
                Close();
            }
            else MessageBox.Show("Ошибка созадния аккаунта", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            db.closeConnection();
        }
    }
}