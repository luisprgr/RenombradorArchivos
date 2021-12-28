using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenombrarArchivos.Model
{
    class Archivos
    {
        private static Archivos instancia = null;
        private string direccion = "";
        List<string> archivos;

        private Archivos()
        {
        }

        public static Archivos getArchivos()
        {
            if(instancia == null)
            {
                instancia = new Archivos();
            }
            return instancia;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public List<string> getNombresArchivos()
        {
            DirectoryInfo dInfo = new DirectoryInfo(@direccion);
            List<string> archivos = new List<string>();
            foreach (var item in dInfo.GetFiles())
            {
                archivos.Add(item.Name);
            }
            this.archivos = archivos;
            return archivos;
        }

        public void nuevoNombreConRemplazo(string textAnterior, string textNuevo)
        {
            string nuevoNombre = "";
            foreach (var archivo in archivos)
            {
                nuevoNombre = archivo.Replace(textAnterior,textNuevo);
                File.Move(@direccion + archivo, @direccion + nuevoNombre);
            }
        }

        public void nuevoNombreInicio(string text)
        {
            string nuevoNombre = "";
            foreach (var archivo in archivos)
            {
                nuevoNombre = text + archivo;
                File.Move(@direccion + archivo, @direccion + nuevoNombre);
            }
        }

        public void nuevoNombreFin(string text)
        {
            string nuevoNombre = "";
            foreach (var archivo in archivos)
            {
                nuevoNombre = archivo + text;
                File.Move(@direccion + archivo, @direccion + nuevoNombre);
            }
        }

    }
}
