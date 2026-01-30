/*
    public class Pedido
{
    public void CrearPedido(string cliente, string producto)
    {
        // Lógica para crear un pedido
        Console.WriteLine($"Pedido creado para el cliente {cliente} con el producto {producto}.");
    }

    public void EnviarPedido(string cliente, string direccion)
    {
        // Lógica para enviar el pedido
        Console.WriteLine($"Pedido enviado a la direccion {direccion} para el cliente {cliente}.");
    }
    public void ImprimirFactura(string cliente, string producto)
    {
        // Lógica para imprimir la factura
        Console.WriteLine($"Factura impresa para el cliente {cliente} con el producto {producto}.");

    }
} 
*/

public class  Pedido
{
    public string clentes;
    public string productos;
    public string direccion;
}

public class CrearPedido
{
    public void Crear(Pedido pedido)
    {
        // Lógica para crear un pedido
        Console.WriteLine($"Pedido creado para el cliente {pedido.clentes} con el producto {pedido.productos}.");
    }
}

public class EnviarPedido
{
    public void Enviar(Pedido pedido)
    {
        // Lógica para enviar el pedido
        Console.WriteLine($"Pedido enviado a la direccion {pedido.direccion} para el cliente {pedido.clentes}.");
    }
}

public class ImprimirFactura
{
    public void Imprimir(Pedido pedido)
    {
        // Lógica para imprimir la factura
        Console.WriteLine($"Factura impresa para el cliente {pedido.clentes} con el producto {pedido.productos}.");
    }
}