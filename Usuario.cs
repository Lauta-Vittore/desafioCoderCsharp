using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioUno
{

    public class Usuario
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        public string Mail { get; set; }

        // Constructor
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
    }



}
