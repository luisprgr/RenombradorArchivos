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
    public partial class UserControlEliminar : UserControl
    {
        InicioControl control;
        public UserControlEliminar(InicioControl control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            control.nuevoNombreConRemplazo(textBoxEliminar.Text, "");
            control.getNombresArchivos();
        }
    }
}
