using portal_pets.Data.Request;
using portal_pets.Data.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Data.Personal
{
    public class infoBrowser
    {
        public LoginRequest user { get; set; }
        public List<infoRoles> roles { get; set; }
        public List<infoMenu> menus { get; set; }
    }

    public class infoDataMenu
    {
        public List<infoMenu> menus { get; set; }
    }

    public class infoMenu
    {
        public String type { get; set; }
        public String url { get; set; }
        public String icono { get; set; }
        public String code { get; set; }
        public String option { get; set; }
        public String parent { get; set; }
        public Int32 state { get; set; }
        public String id { get; set; }
        public String idparent { get; set; }
        public String permission { get; set; }
    }


    public class infoRoles
    {
        public String user { get; set; }
        public String rol { get; set; }

    }


}
