using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RenombrarArchivos.Control;

namespace RenombrarArchivos.Visual
{
    public partial class UserControlRemplazar : UserControl
    {
        InicioControl control;
        public UserControlRemplazar(InicioControl control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void buttonRemplazar_Click(object sender, EventArgs e)
        {
            control.nuevoNombreConRemplazo(textBoxRemplazarTextoAnterior.Text, textBoxRempazarTextoNuevo.Text);
        }
    }
}
