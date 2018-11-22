using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace InventoryManager
{
    public partial class reportsTab : UserControl
    {
        private string myConString = "SERVER=127.0.0.1;" +
                    "DATABASE=storemanager;" +
                    "UID=root;" +
                    "PASSWORD=root;";

        public reportsTab()
        {
            InitializeComponent();
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            using (var connection = new MySqlConnection(myConString))
            {
                connection.Open();
                string query = string.Format("SELECT " +
                                            "orderInventories.id as oiid, " +
                                            "inventories.id as id, " +
                                            "orderInventories.qty as qty, " +
                                            "categories.name as item, " +
                                            "inventories.name as ModelName, " +
                                            "inventories.modelnumber as ModelNumber, " +
                                            "inventories.description as Description, " +
                                            "inventories.price as Price, " +
                                            "inventories.price*orderInventories.qty as TotalPrice " +
                                          "FROM orderInventories " +
                                            "inner join inventories on inventories.id=orderInventories.inventory " +
                                            "inner join categories on categories.id=inventories.category " +
                                          "where " +
                                             "orderInventories.order={0}", 3);
                using (var da = new MySqlDataAdapter(query, connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
