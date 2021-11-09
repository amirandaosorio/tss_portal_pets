using Microsoft.AspNetCore.Components;
using portal_pets.Data.Enumerables;
using portal_pets.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Pages.Login.Registrarse
{
    public partial class Registrar : ComponentBase
    {
        [Inject] public NavigationManager _nav { get; set; }

        public cUsuario _registro { get; set; }
        public List<cUbicacion> _lstUbPais { get; set; } = new List<cUbicacion>();
        public List<cUbicacion> _lstUbProv { get; set; } = new List<cUbicacion>();
        public List<cUbicacion> _lstUbCiud { get; set; } = new List<cUbicacion>();
        public List<cTipoIdent> _lstTipoident { get; set; } = new List<cTipoIdent>();

        public String _idpais { get; set; }
        public String _idprovincia { get; set; }
        public String _idTipoident { get; set; }


        protected async override Task OnInitializedAsync()
        {
            _registro = new cUsuario();
            cUbicacion infUbicacion = new cUbicacion();
            cTipoIdent infoIdent = new cTipoIdent();

            _lstUbPais = infUbicacion.CargueInicial().Where(w=>w.tipo==(int)eTipoUbicacion.PAIS).ToList();
            _lstUbProv = infUbicacion.CargueInicial().Where(w => w.tipo == (int)eTipoUbicacion.PROVINCIA).ToList();
            _lstUbCiud = infUbicacion.CargueInicial().Where(w => w.tipo == (int)eTipoUbicacion.CIUDAD).ToList();

            _lstTipoident = infoIdent.CargueInicial();
        }


        public async Task Grabar()
        {

        }


        public async Task Cancelar()
        {
            _nav.NavigateTo("/", true);
        }



    }
}
