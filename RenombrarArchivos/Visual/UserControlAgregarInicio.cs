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
    public partial class UserControlAgregarInicio : UserControl
    {
        InicioControl control;
        public UserControlAgregarInicio(InicioControl control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void buttonAgregarInicio_Click(object sender, EventArgs e)
        {
            control.nuevoNombreInicio(textBoxAgregarInicio.Text);
        }
    }
}
