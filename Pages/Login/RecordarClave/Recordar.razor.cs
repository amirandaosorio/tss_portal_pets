using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Pages.Login.RecordarClave
{
    public partial class Recordar : ComponentBase
    {
        public class Model
        {
            public string Email { get; set; }
        }
        public Model model { get; set; }
        public Boolean popup { get; set; }


        protected async override Task OnInitializedAsync()
        {
            model = new Model();
        }


        void OnSubmit(Model model)
        {
            //Log("Submit", JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true }));
        }

        void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
        {
            //Log("InvalidSubmit", JsonSerializer.Serialize(args, new JsonSerializerOptions() { WriteIndented = true }));
        }

    }
}
