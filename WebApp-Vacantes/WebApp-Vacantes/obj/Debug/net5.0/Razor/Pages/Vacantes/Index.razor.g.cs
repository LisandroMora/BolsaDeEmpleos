#pragma checksum "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e3c6631b18fce474ea06aa68f5bbc0ce9ad398"
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
#line 1 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using WebApp_Vacantes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using WebApp_Vacantes.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using apiVacantes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vacantes")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Vacantes</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div><a class=\"btn btn-primary\" href=\"crear-vacante\">Post a Job</a></div>");
#nullable restore
#line 14 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
 if (trabajos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>Cargando...</p>");
#nullable restore
#line 17 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
}
else if (trabajos.Length == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p>No hay vacantes disponibles</p>");
#nullable restore
#line 21 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>Ubicacion</th>\r\n                <th>Posicion</th>\r\n                <th>Empresa</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 34 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
             foreach (var trabajo in trabajos.Reverse())
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "th");
            __builder.AddContent(10, 
#nullable restore
#line 37 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
                         trabajo.Ubicacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "th");
            __builder.AddContent(13, 
#nullable restore
#line 38 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
                         trabajo.Posicion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "th");
            __builder.AddContent(16, 
#nullable restore
#line 39 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
                         trabajo.Empresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "th");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "btn btn-success");
            __builder.AddAttribute(21, "href", "/editar-vacante/" + (
#nullable restore
#line 41 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
                                                                          trabajo.IdTrabajo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-danger");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
                                                                   () => BorrarVacante(trabajo.IdTrabajo)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Jenners\Desktop\Documentos\Cooia\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\Index.razor"
       
    Trabajos[] trabajos { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await CargarVacantes();
    }

    async Task CargarVacantes()
    {
        trabajos = await Http.GetFromJsonAsync<Trabajos[]>("/api/Vacantes");
    }




    async Task BorrarVacante(int id)
    {
        var Vacante = trabajos.First(x => x.IdTrabajo == id);
        if (await JS.InvokeAsync<bool>("confirm", $"Seguro que desea eliminar la vacante {Vacante.Descripcion}?"))
        {
            await Http.DeleteAsync($"api/Vacantes/{Vacante.IdTrabajo}");
            await CargarVacantes();
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
