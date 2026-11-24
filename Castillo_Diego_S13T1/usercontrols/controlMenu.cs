using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castillo_Diego_S13T1.usercontrols
{
    public partial class controlMenu : UserControl
    {
        public controlMenu()
        {
            InitializeComponent();
        }

    
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = guna2ComboBox1.SelectedItem.ToString();
        }
    }
}
