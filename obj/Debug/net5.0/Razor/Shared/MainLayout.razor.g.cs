#pragma checksum "C:\Ancourd\Developing\tss_portal\tss_portal_pets\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ab9459f16f665a57b8234d2fa567519cc1a7b9"
// <auto-generated/>
#pragma warning disable 1591
namespace portal_pets.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using portal_pets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using portal_pets.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\_Imports.razor"
using portal_pets.Data.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-bkv08k92f5");
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "sidebar");
                __builder2.AddAttribute(15, "b-bkv08k92f5");
                __builder2.OpenComponent<portal_pets.Shared.NavMenu>(16);
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "main");
            __builder.AddAttribute(20, "b-bkv08k92f5");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "content px-4");
            __builder.AddAttribute(23, "b-bkv08k92f5");
            __builder.AddContent(24, 
#nullable restore
#line 20 "C:\Ancourd\Developing\tss_portal\tss_portal_pets\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
