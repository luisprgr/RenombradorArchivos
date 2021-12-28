using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenombrarArchivos.Model;

namespace RenombrarArchivos.Control
{
    public class InicioControl
    {
        private Archivos editar = null;

        public InicioControl()
        {
            editar = Archivos.getArchivos();
        }

        public void setDireccion(string direccion)
        {
            editar.setDireccion(@direccion);
        }

        public List<string> getNombresArchivos()
        {
            return editar.getNombresArchivos();
        }

        public void nuevoNombreConRemplazo(string textAnterior, string textNuevo)
        {
            editar.nuevoNombreConRemplazo(@textAnterior,@textNuevo);
        }

        public void nuevoNombreInicio(string text)
        {
            editar.nuevoNombreInicio(@text);
        }

        public void nuevoNombreFin(string text)
        {
            editar.nuevoNombreFin(@text);
        }

    }
}
