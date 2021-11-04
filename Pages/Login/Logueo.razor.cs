using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace portal_pets.Pages.Login
{
    public partial class Logueo : ComponentBase
    {
        [Inject] public NavigationManager _nav {get;set;}


        string userName = "admin";
        string password = "admin";
        //EventConsole console;
        public String _Mensaje { get; set; }


        protected async override Task OnInitializedAsync()
        {
            _Mensaje = "";
        }


        void OnLogin(LoginArgs args, string name)
        {
            _Mensaje = "Se Logueo";
        }

        void OnRegister(string name)
        {
            //_Mensaje = "Ingreso a Registrarse";
            _nav.NavigateTo("registrar", true);
        }

        void OnResetPassword(string value, string name)
        {
            //_Mensaje = "Ingreso a recordar contraseña";
            _nav.NavigateTo("recordar", true);
        }

    }
}
