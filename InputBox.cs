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
    public partial class InputBox : Form
    {
        public InputBox(string title, string caption, string defaultValue)
        {
            InitializeComponent();
            this.Text = title;
            lblName.Text = caption;
            txtValue.Text = defaultValue;
        }

        public string value
        {
            get
            {
                return txtValue.Text;
            }
        }

    }
}
