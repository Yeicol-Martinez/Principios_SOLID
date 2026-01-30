using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_1
{
    /*  public class Vehiculo
    {
        public virtual void Conducir()
        {
            // Logica de conduccion
        }
    }

    public class  Bicicleta : Vehiculo
    {
        public override void Conducir()
        {
            // Conducir bicicleta
        }
    }

    public class Coche : Vehiculo
    {
        public override void Conducir()
        {
            // Conducir coche
        }

        public void AbrirMaletero()
        {
            // Logica para abrir el maletero
        }
    } */


    public class Vehiculo
    {
        public virtual void Conducir()
        {
            // Lógica de conducción base
        }
    }

    public interface IVehiculoConMaletero
    {
        void AbrirMaletero();
    }

    public class Bicicleta : Vehiculo
    {
        public override void Conducir()
        {
            // Conducir bicicleta
        }
    }

    public class Coche : Vehiculo, IVehiculoConMaletero
    {
        public override void Conducir()
        {
            // Conducir coche
        }

        public void AbrirMaletero()
        {
            // Lógica para abrir maletero
        }
    }
}
