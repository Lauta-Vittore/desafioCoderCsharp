using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioUno
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }

        // Constructor
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }
    }


}
