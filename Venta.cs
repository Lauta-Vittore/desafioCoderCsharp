using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioUno
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }

        // Constructor
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;
        }
    }


}
