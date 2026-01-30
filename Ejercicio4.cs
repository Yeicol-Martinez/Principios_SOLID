using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_1
{
    /* public interface ITrabajo
    {
        void Trabajar();
        void Descansar();
        void Comer();
    }

    public class Programador : ITrabajo
    {
        public void Trabajar()
        {
            // Escribiendo código...
        }
        public void Descansar()
        {
            // Descansando...
        }
        public void Comer()
        {
            // Comiendo...
        }
    }

    public class Gerente : ITrabajo
    {
        public void Trabajar()
        {
            // Gestionando proyectos...
        }
        public void Descansar()
        {
            // Descansando...
        }
        public void Comer()
        {
            // Comiendo...
        }
    } */

    public interface ITrabajar
    {
        void Trabajar();
    }

    public interface IDescansar
    {
        void Descansar();
    }

    public interface IComer
    {
        void Comer();
    }

    // Las clases solo implementan lo que necesitan
    public class Programador : ITrabajar, IDescansar, IComer
    {
        public void Trabajar()
        {
            // Escribiendo código...
        }

        public void Descansar()
        {
            // Descansando...
        }

        public void Comer()
        {
            // Comiendo...
        }
    }

    public class Gerente : ITrabajar, IDescansar, IComer
    {
        public void Trabajar()
        {
            // Gestionando proyectos...
        }

        public void Descansar()
        {
            // Descansando...
        }

        public void Comer()
        {
            // Comiendo...
        }
    }
}
