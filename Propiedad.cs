using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TP_2_LAB___2
{
    [Serializable]
    class Propiedad
    {
        private string direccion;
        private string localidad;
        private int numeroPropiedad;
        protected double precioBase;
        protected string tipoPropiedad;
        private bool wifi;
        private bool ac;
        private List<string> fotos;

        public Propiedad(double _precioBase, string _direccion, int _numeroPropiedad, string _tipoPropiedad, string _localidad)
        {
            precioBase = _precioBase;
            direccion = _direccion;
            numeroPropiedad = _numeroPropiedad;
            tipoPropiedad = _tipoPropiedad;
            localidad = _localidad;
            fotos = new List<string>();
        }

        public double PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Numero
        {
            get { return numeroPropiedad; }
            set { numeroPropiedad = value; }
        }

        public string TipoPropiedad
        {
            get { return tipoPropiedad; }
            set { tipoPropiedad = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public void AgregarFoto(string unaFoto)
        {
            fotos.Add(unaFoto);
        }

        public virtual void CalcularCosto()
        { }
    }
}
