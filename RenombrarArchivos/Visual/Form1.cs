using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RenombrarArchivos.Control;


namespace RenombrarArchivos.Visual
{
    public partial class Form1 : Form
    {
        private String ruta = "";

        private InicioControl control = null;

        private UserControlInicio inicio = null;
        private UserControlAgregarFinal agregarFinal = null;
        private UserControlAgregarInicio agregarInicio = null;
        private UserControlEliminar eliminar = null;
        private UserControlRemplazar remplazar = null;

        public Form1()
        {
            InitializeComponent();
            control = new InicioControl();
            inicio = new UserControlInicio();
            panel3.Controls.Add(inicio);
            inicio.BringToFront();
        }

        private void abrirDirectorio_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                ruta = @dialogo.SelectedPath + @"\";
                control.setDireccion(@ruta);
                listBox1.DataSource = control.getNombresArchivos();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            listBox1.DataSource = control.getNombresArchivos();
        }

        private void buttonEliminarPartNomb_Click(object sender, EventArgs e)
        {
            this.eliminar = new UserControlEliminar(control);
            panel3.Controls.Add(this.eliminar);
            this.eliminar.BringToFront();
        }

        private void buttonRempPartNomb_Click(object sender, EventArgs e)
        {
            this.remplazar = new UserControlRemplazar(control);
            panel3.Controls.Add(this.remplazar);
            this.remplazar.BringToFront();
        }

        private void buttonTextInicio_Click(object sender, EventArgs e)
        {
            this.agregarInicio = new UserControlAgregarInicio(control);
            panel3.Controls.Add(this.agregarInicio);
            this.agregarInicio.BringToFront();
        }

        private void buttonTextFinal_Click(object sender, EventArgs e)
        {
            this.agregarFinal = new UserControlAgregarFinal(control);
            panel3.Controls.Add(this.agregarFinal);
            this.agregarFinal.BringToFront();
        }
    }
}
