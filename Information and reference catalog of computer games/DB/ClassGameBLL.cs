using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_and_reference_catalog_of_computer_games
{
    internal class ClassGameBLL
    {
        #region Save Items
        public bool SaveItem(Image img, string name, string description, string price, string date, string age_limit, bool preorder, string country)
        {
            try
            {
                ClassGameDB objdal = new ClassGameDB();
                return objdal.AddItemsToTable(img, name, description, price, date, age_limit, preorder, country);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        #endregion

        #region Get Items
        public DataTable GetItems(bool isAscending)
        {
            try
            {
                ClassGameDB objdal = new ClassGameDB();
                return objdal.ReadItemsTable(isAscending);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion
    }
}
