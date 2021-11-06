using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Data.Models
{
    public class cUsuario
    {
        public Int64 id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String tipoidentid { get; set; }
        public String numident { get; set; }
        public String ubicacionid { get; set; }
        public String direccion { get; set; }
        public String barrio { get; set; }
        public String latitud { get; set; }
        public String longitud { get; set; }
    }
}
