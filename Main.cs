using InventoryManager.storemanagerDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void TabItems_Click(object sender, EventArgs e)
        {
            inventoryTab1.BringToFront();
        }

        private void TabOrders_Click(object sender, EventArgs e)
        {
            ordersTab1.BringToFront();
            ordersTab1.orderListRefresh();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

    }
}
