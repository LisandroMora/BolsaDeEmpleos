#pragma checksum "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7037c262d0057af02d9d41542b11ea307dfb97dd"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp_Vacantes.Pages.Vacantes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using WebApp_Vacantes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using WebApp_Vacantes.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using apiVacantes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar-vacante/{IdVacante:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit</h3>\r\n\r\n");
            __builder.OpenComponent<WebApp_Vacantes.Pages.Vacantes.FormVacante>(1);
            __builder.AddAttribute(2, "TextBtn", "Editar Vacante");
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Edit.razor"
                                                      EditarVacante

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Trabajos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<apiVacantes.Models.Trabajos>(
#nullable restore
#line 7 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Edit.razor"
                                                                                trabajo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Edit.razor"
       
    [Parameter] public int IdVacante { get; set; }
    Trabajos trabajo = new Trabajos();

    protected override async Task OnParametersSetAsync()
    {
        trabajo = await Http.GetFromJsonAsync<Trabajos>($"api/Vacantes/{IdVacante}");
    }


    async Task EditarVacante()
    {
        await Http.PutAsJsonAsync($"api/Vacantes/{IdVacante}", trabajo);
        Navigator.NavigateTo("Vacantes");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
