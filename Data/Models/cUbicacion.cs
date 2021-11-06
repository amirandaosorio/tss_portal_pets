using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace portal_pets.Data.Models
{
    public class cUbicacion
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String padre { get; set; }
        public Int32 tipo { get; set; } // 1=Pais, 2 =Provincia, 3=Ciudad 4=Barrio
        

        public cUbicacion()
        {
        }

        public List<cUbicacion> CargueInicial()
        { 
            return new List<cUbicacion>()
            {
            new cUbicacion() { codigo = "170", nombre = "COLOMBIA", padre="0", tipo=1 },
            new cUbicacion() { codigo = "862", nombre = "VENEZUELA", padre="0", tipo=1 },
            new cUbicacion() { codigo = "862001", nombre = "DISTRITO CAPITAL", padre="862", tipo=2 },
            new cUbicacion() { codigo = "862001001", nombre = "CARACAS", padre="001", tipo=3 },

            new cUbicacion() { codigo = "17066", nombre = "RISARALDA", padre="170", tipo=2 },
            new cUbicacion() { codigo = "17076", nombre = "VALLE DEL CAUCA", padre="170", tipo=2 },
            new cUbicacion() { codigo = "17063", nombre = "QUINDIO", padre="170", tipo=2 },
            new cUbicacion() { codigo = "17066001", nombre = "PEREIRA", padre="66", tipo=3 },
            new cUbicacion() { codigo = "17066170", nombre = "DOSQUEBRADAS", padre="66", tipo=3 },
            new cUbicacion() { codigo = "17066682", nombre = "SANTA ROSA DE CABAL", padre="66", tipo=3 },
            new cUbicacion() { codigo = "17066400", nombre = "LA VIRGINIA", padre="66", tipo=3 },
            new cUbicacion() { codigo = "17076147", nombre = "CARTAGO", padre="76", tipo=3 },
            new cUbicacion() { codigo = "17063001", nombre = "ARMENIA", padre="63", tipo=3 },
            new cUbicacion() { codigo = "17066440", nombre = "MARSELLA", padre="66", tipo=3 }
            };
        }




    }
}
