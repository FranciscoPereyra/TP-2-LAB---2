using System;

namespace TP_2_LAB___2
{
    [Serializable]
    class Habitacion : Propiedad
    {
        private int cantidadEstrella;
        double precioFinal = 0;

        public Habitacion(double precioBase, string nombre, int numeroPropiedad, string tipoPropiedad, string localidad, int _cantidadEstrella) : base(precioBase, nombre, numeroPropiedad, tipoPropiedad, localidad)
        {
            cantidadEstrella = _cantidadEstrella;
        }

        public int CantidadEstrella
        {
            get { return cantidadEstrella; }
        }

        //public double PrecioDosEstrellas(int dias, int tipoHabitacion, double precioBase)
        //{
        //    if (tipoHabitacion == 1)
        //    {
        //        precioFinal = precioBase * dias;
        //    }
        //    if (tipoHabitacion == 2)
        //    {
        //        precioFinal = (precioBase * dias) * 0.8;
        //    }
        //    if (tipoHabitacion == 3)
        //    {
        //        precioFinal = (precioBase * dias) * 1.5;
        //    }
        //    return precioFinal;
        //}

        //public double CalcPrecioTresEstrellas(int dias, int tipoHabitacion, double precioBase)
        //{
        //     return precioFinal*1.4;
        //}

        public double PrecioPorEstrellas(int cantEstrellas, int dias, int tipoHabitacion, double precioBase)
        {

            if (cantEstrellas==2 && tipoHabitacion == 1)
            {
                precioFinal = precioBase * dias;
            }
            if (cantEstrellas == 2 && tipoHabitacion == 2)
            {
                precioFinal = (precioBase * dias) * 0.8;
            }
            if (cantEstrellas == 2 && tipoHabitacion == 3)
            {
                precioFinal = (precioBase * dias) * 1.5;
            }

            //para 3 estrellas
            if (cantEstrellas == 3 && tipoHabitacion == 1)
            {
                precioFinal = (precioBase * dias) + ((precioBase * dias)*0.4);
            }

            if (cantEstrellas == 3 && tipoHabitacion == 2)
            {
                precioFinal = ((precioBase * dias) + ((precioBase * dias) * 0.4) * 0.8);
            }

            if (cantEstrellas == 3 && tipoHabitacion == 3)
            {
                precioFinal = ((precioBase * dias) + ((precioBase * dias) * 0.4) * 1.5);
            }

            return (precioFinal + (precioFinal*0.03));
        }




 
    }
}
