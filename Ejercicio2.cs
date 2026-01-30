using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_1
{
    /* public class CalculadoraDeDescuentos
    {
        public double CalcularDescuento(double precio, string tipoCliente)
        {
            if (tipoCliente == "Regular")
            {
                return precio * 0.05;
            }
            else if (tipoCliente == "Premium")
            {
                return precio * 0.1;
            }
            else
            {
                 return 0;
            }

        }
    }  */


    public abstract class Descuento
    {
        public abstract double Calcular(double precio);
    }

    public class DescuentoRegular : Descuento
    {
        public override double Calcular(double precio)
        {
            return precio * 0.05;
        }
    }

    public class DescuentoPremium : Descuento
    {
        public override double Calcular(double precio)
        {
            return precio * 0.10;
        }
    }

    public class CalculadoraDeDescuentos
    {
        public double CalcularDescuento(double precio, Descuento descuento)
        {
            return descuento.Calcular(precio);
        }
    }
}


