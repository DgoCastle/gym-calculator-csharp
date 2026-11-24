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
    public partial class _1REPMAX : UserControl
    {
        public _1REPMAX()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double repeticiones = 0,peso = 0,resultado;

            repeticiones = Convert.ToDouble(txtReps.Text);
            peso = Convert.ToDouble(txtPeso.Text);

            resultado = peso * (1+0.0333 * repeticiones);

            lbMaxRep.Text = resultado.ToString();

            //GunaMessageBox.Show("  Selecciona primero una opción.", "Atención", Castillo_Diego_S13T1.MessageDialogIcon.None, this.FindForm());


        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double m, d,angulo,s,potencia,fuerza,fuerzaE,W;
            const double gravedad=9.81 ;
            
            m       = Convert.ToDouble(txtCarga.Text);
            d       = Convert.ToDouble(txtDist.Text);
            angulo  = Convert.ToDouble(txtinclinacion.Text);
            s       = Convert.ToDouble(txtTiempo.Text);

            double RAD = angulo * Math.PI / 180;

            fuerza = m * gravedad;
            fuerzaE = (m * gravedad) * (RAD);
            W = ((m * gravedad) * (RAD)) * d;
            potencia = ((m * gravedad) * (RAD)) * d / s;


            lbFuerza.Text = fuerza.ToString();
            lbFuerzaE.Text = fuerzaE.ToString();
            w.Text = W.ToString();
            lbPotencia.Text = potencia.ToString();

        }
    }
}
