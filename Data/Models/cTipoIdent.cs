﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Data.Models
{
    public class cTipoIdent
    {
        public String codigo { get; set; }
        public String nombre { get; set; }        

        public cTipoIdent()
        {
        }

        public List<cTipoIdent> CargueInicial()
        { 
            return new List<cTipoIdent>()
            {
                new cTipoIdent{codigo="CC", nombre="CEDULA" },
                new cTipoIdent{codigo="PAS", nombre="PASAPAROTE" },
                new cTipoIdent{codigo="NIT", nombre="NIT" },
                new cTipoIdent{codigo="CEX", nombre="CEDULA EXTRANJERIA" },
                new cTipoIdent{codigo="TI", nombre="TARJETA DE IDENTIDAD" }
            };
        }

    }
}
