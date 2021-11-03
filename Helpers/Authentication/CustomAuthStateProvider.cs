using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using portal_pets.ClasPersonal;
using portal_pets.Data.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace portal_pets.Helpers.Authentication
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private NavigationManager _navegacion { get; set; }
        private ILocalStorageService sesion;
        private ProtectedSessionStorage _storage { get; set; }


        public CustomAuthStateProvider(ILocalStorageService _sesion, ProtectedSessionStorage storage, NavigationManager navegacion)
        {
            sesion = _sesion;
            _storage = storage;
            _navegacion = navegacion;
        }

        public CustomAuthStateProvider()
        {
        }

        //public override Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    var identity = new ClaimsIdentity(new[]
        //    {
        //        new Claim(ClaimTypes.Name, "mrfibuli"),
        //    }, "Fake authentication type");

        //    //var user = new ClaimsPrincipal(identity);
        //    var user = new ClaimsPrincipal();

        //    return Task.FromResult(new AuthenticationState(user));
        //}



        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            ClaimsPrincipal user = new ClaimsPrincipal();
            try
            {
                var datosUsuario = await _storage.GetAsync<infoBrowser>("data");
                General.userLogueado = datosUsuario.Value;

                if (General.userLogueado != null && General.userLogueado.user.expiration < DateTime.Now)
                    MarkUserAsLoggedOut();
                else
                {
                    if (General.userLogueado != null)
                    {
                        identity = setClaims(General.userLogueado);
                    }
                }
                user = new ClaimsPrincipal(identity);
            }
            catch (Exception) { }
            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarKUserAsAuthenticated(infoBrowser _data)
        {
            var identity = setClaims(_data);
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            _storage.DeleteAsync("data");
            _storage.DeleteAsync("dataMenu");
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
            _navegacion.NavigateTo("/", true);
        }

        private ClaimsIdentity setClaims(infoBrowser _data)
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            if (_data != null)
            {
                identity = new ClaimsIdentity(new[] {
                            new Claim(ClaimTypes.Name, _data.user.name.Substring(0,1)+"."+_data.user.lastname.Substring(0,1)+"."),//_data.user.nombrefull),
                            new Claim(ClaimTypes.Actor, _data.user.name.Substring(0,1).ToUpper()+_data.user.lastname.Substring(0,1).ToUpper()),
                            new Claim(ClaimTypes.SerialNumber, _data.user.user.ToString()),
                            new Claim(ClaimTypes.Sid, _data.user.token),
                            new Claim(ClaimTypes.Email, _data.user.email),
                            new Claim(ClaimTypes.MobilePhone, _data.user.phone),
                            new Claim(ClaimTypes.NameIdentifier, _data.user.iduser),
                            new Claim(ClaimTypes.SerialNumber, _data.user.typedoc+"-"+_data.user.numdoc)
                    }, "apiauth_type");
                foreach (var reg in _data.roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, reg.rol));
                }
            }
            return identity;
        }





    }
}
