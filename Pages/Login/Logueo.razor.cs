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
        string userName = "admin";
        string password = "admin";
        EventConsole console;


        void OnLogin(LoginArgs args, string name)
        {
            console.Log($"{name} -> Username: {args.Username} and password: {args.Password}");
        }

        void OnRegister(string name)
        {
            console.Log($"{name} -> Register");
        }

        void OnResetPassword(string value, string name)
        {
            console.Log($"{name} -> ResetPassword for user: {value}");
        }

    }
}
