namespace desafioUno
{
    using System;

    class Program
    {
        static void Main()
        {
            // Crear instancia de la clase Usuario
            Usuario nuevoUsuario = new Usuario(1, "Juan", "Pérez", "juanperez", "contraseña123", "juan.perez@example.com");
            Console.WriteLine($"Usuario: {nuevoUsuario.Nombre} {nuevoUsuario.Apellido}, Usuario: {nuevoUsuario.NombreUsuario}, Mail: {nuevoUsuario.Mail}");

            // Crear instancia de la clase Producto
            Producto nuevoProducto = new Producto(101, "Laptop", 500.00m, 750.00m, 10, 1);
            Console.WriteLine($"Producto: {nuevoProducto.Descripcion}, Costo: {nuevoProducto.Costo}, Precio de Venta: {nuevoProducto.PrecioVenta}, Stock: {nuevoProducto.Stock}");

            // Crear instancia de la clase ProductoVendido
            ProductoVendido nuevoProductoVendido = new ProductoVendido(1001, 101, 2, 2001);
            Console.WriteLine($"Producto Vendido: ID Producto: {nuevoProductoVendido.IdProducto}, Stock: {nuevoProductoVendido.Stock}, ID Venta: {nuevoProductoVendido.IdVenta}");

            // Crear instancia de la clase Venta
            Venta nuevaVenta = new Venta(2001, "Venta de dos laptops", 1);
            Console.WriteLine($"Venta: {nuevaVenta.Id}, Comentarios: {nuevaVenta.Comentarios}, ID Usuario: {nuevaVenta.IdUsuario}");
        }
    }

}