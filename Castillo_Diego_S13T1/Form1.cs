using Castillo_Diego_S13T1.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castillo_Diego_S13T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirEnPanel(UserControl control)
        {
            panelDesktop.Controls.Clear(); // Limpia los controles actuales dentro del panel, para que no se acumulen
            control.Dock = DockStyle.Fill; // Hace que el control ocupe todo el espacio del panel
            panelDesktop.Controls.Add(control);// Agrega el nuevo control al panel
            control.BringToFront(); // Trae el control al frente para asegurarse de que sea visible
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new controlMenu());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new _1REPMAX());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirEnPanel(new _1REPMAX());
        }
    }
}
