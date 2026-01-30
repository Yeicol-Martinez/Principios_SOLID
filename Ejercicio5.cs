using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Practica_1
{
    /* public class EnvioDeCorreo
    {
        private SmtpCliente smtpCliente;
        public EnvioDeCorreo()
        {
            smtpCliente = new SmtpCliente(); // Dependencia concreta
        }
        public void EnviarCorreo(string destino, string mensaje)
        {
            smtpCliente.Enviar(destino, mensaje)
        }
    }
    public class SmtpCliente
    {
        public void Enviar(string destino, string mensaje)
        {
            // Lógica para enviar correo
        }
    } */


    // Crear interfaz (abstracción)
    public interface IClienteCorreo
    {
        void Enviar(string destino, string mensaje);
    }

    // Implementación concreta de la interfaz
    public class SmtpCliente : IClienteCorreo
    {
        public void Enviar(string destino, string mensaje)
        {
            Console.WriteLine($"Enviando correo a {destino}: {mensaje}");
            // Lógica para enviar correo por SMTP
        }
    }

    // Clase de alto nivel que depende de la abstracción
    public class EnvioDeCorreo
    {
        private readonly IClienteCorreo _clienteCorreo;

        // Inyección de dependencias por constructor
        public EnvioDeCorreo(IClienteCorreo clienteCorreo)
        {
            _clienteCorreo = clienteCorreo;
        }

        public void EnviarCorreo(string destino, string mensaje)
        {
            _clienteCorreo.Enviar(destino, mensaje);
        }
    }
}
