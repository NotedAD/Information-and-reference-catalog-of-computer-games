using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Information_and_reference_catalog_of_computer_games
{
    internal class ClassGameDB
    {
        #region Add Items To Table

        public bool AddItemsToTable(Image img, string name, string description, string price, string date, string age_limit, bool preorder, string country)
        {
            DB db = new DB();

            db.openConnection();

            string query = "INSERT INTO games(name, description, price, date_release, age_limit, image, preorder, country) VALUES (@name, @description, @price, @date, @ageLimit, @image, @preorder, @country)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@name", name.Trim());
                    cmd.Parameters.AddWithValue("@description", description.Trim());
                    cmd.Parameters.AddWithValue("@price", price.Trim());
                    cmd.Parameters.AddWithValue("@date", date.Trim());
                    cmd.Parameters.AddWithValue("@ageLimit", age_limit.Trim());
                    cmd.Parameters.AddWithValue("@preorder", preorder);
                    cmd.Parameters.AddWithValue("@country", country);
                    MemoryStream ms = new MemoryStream();

                    if (img != null)
                    {
                        img.Save(ms, img.RawFormat);
                    }

                    cmd.Parameters.AddWithValue("@image", ms.ToArray());

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Название с такой игрой уже есть! Вы ввели большой размер текста в описание!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion 

        #region Read Items Table

        public DataTable ReadItemsTable(bool isAscending)
        {
            DB db = new DB();

            string sort = isAscending ? "ASC" : "DESC";


            string query = $"SELECT * FROM games ORDER BY date_release {sort}";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {

                throw;
            }
        }

        #endregion

    }
}
