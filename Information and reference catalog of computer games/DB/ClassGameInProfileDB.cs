using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Information_and_reference_catalog_of_computer_games
{

    internal class ClassGameInProfileDB
    {
        public string idAccount;

        public ClassGameInProfileDB(string idAccount)
        {
            this.idAccount = idAccount;
        }

        #region Read Items Table

        public DataTable ReadItemsTable()
        {
            DB db = new DB();

            string query = $"SELECT games.image, games.name FROM buy_games " +
                $"LEFT JOIN games ON games.id_games = buy_games.id_games " +
                $"WHERE id_account = {idAccount}";
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
