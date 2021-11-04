using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Pages.Login.RecordarClave
{
    public partial class Recordar : ComponentBase
    {
       <div>
            <h1>AutoComplete</h1>
            <RadzenAutoComplete Data = @customers TextProperty="CompanyName"
                            Style="margin-bottom: 20px" Change=@(args => OnChange(args, "AutoComplete")) />     
       </div>
    }
}
