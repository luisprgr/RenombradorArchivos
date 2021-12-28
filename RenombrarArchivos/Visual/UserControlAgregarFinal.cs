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
    public partial class UserControlAgregarFinal : UserControl
    {
        InicioControl control;
        public UserControlAgregarFinal(InicioControl control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void buttonAgregarFinal_Click(object sender, EventArgs e)
        {
            control.nuevoNombreFin(textBoxAgregarFinal.Text);
        }
    }
}
