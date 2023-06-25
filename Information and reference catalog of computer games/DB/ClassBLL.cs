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
    internal class ClassBLL
    {

        #region Save Items
        public bool SaveItem(Image img, string title, string subtitle)
        {
            try
            {
                ClassDB objdal = new ClassDB();
                return objdal.AddItemsToTable(img, title, subtitle);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        #endregion

        #region Get Items
        public DataTable GetItems()
        {
            try
            {
                ClassDB objdal = new ClassDB();
                return objdal.ReadItemsTable();
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
