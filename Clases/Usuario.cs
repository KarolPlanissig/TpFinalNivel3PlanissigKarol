using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        //     [Id][int] IDENTITY(1,1) NOT NULL,
        // [email] [varchar] (100) NOT NULL,
        // [pass] [varchar] (20) NOT NULL,
        // [nombre] [varchar] (50) NULL,
        // [apellido][varchar] (50) NULL,
        // [urlImagenPerfil][varchar] (500) NULL,
        // [admin][bit] NOT NULL DEFAULT 0

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Apellido { get; set; }
        public string ImagenPerfil { get; set; }
        public bool Admin { get; set; }
    }
}
