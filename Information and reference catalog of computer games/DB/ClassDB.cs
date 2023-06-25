using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
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

namespace Information_and_reference_catalog_of_computer_games
{
    internal class ClassDB
    {
        #region Add Items To Table

        public bool AddItemsToTable(Image img, string title, string subtitle)
        {
            DB db = new DB();

            db.openConnection();

            string query = "INSERT INTO news(title, sub_title, image) VALUES (@title, @subtitle, @image)";

            try
            {
                using(MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    if(title == null || subtitle == null || img == null)
                    {
                        MessageBox.Show("Вы не ввели данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@title", title.Trim());
                        cmd.Parameters.AddWithValue("@subtitle", subtitle.Trim());
                        MemoryStream ms = new MemoryStream();

                        if (img != null)
                        {
                            img.Save(ms, img.RawFormat);
                        }

                        cmd.Parameters.AddWithValue("@image", ms.ToArray());

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {

                throw;
            }
        }

        #endregion 

        #region Read Items Table

        public DataTable ReadItemsTable()
        {
            DB db = new DB();

            db.openConnection();

            string query = "SELECT * FROM news";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            try
            {
                using(MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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
