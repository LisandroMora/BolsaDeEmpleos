// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp_Vacantes.Pages.Vacantes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using WebApp_Vacantes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using WebApp_Vacantes.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using apiVacantes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crear-vacante")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\prog3\otroproyectoweb\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Create.razor"
       

    Trabajos trabajos = new Trabajos();

    async Task CrearVacante()
    {
        await Http.PostAsJsonAsync("api/Vacantes", trabajos);
        NavigationManager.NavigateTo("Vacantes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
