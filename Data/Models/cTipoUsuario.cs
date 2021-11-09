using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Data.Models
{
    public class cTipoUsuario
    {
        public Int64 id { get; set; }
        public Int64 usuarioid { get; set; }
        public Int32 tipo { get; set; } // eTipoUsuario
    }
}
