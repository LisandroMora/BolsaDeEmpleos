#pragma checksum "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847e1f0e5f1ad6345746d6ac7c54cd590c05c9a4"
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
#nullable restore
#line 13 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
           [Authorize(Roles = "admin, postulante")]

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
           [Authorize(Roles = "admin, postulante")]

#line default
#line hidden
#nullable disable
    public partial class FormVacante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                  Trabajos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                            OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-control");
                __builder2.AddMarkupContent(8, "<label>Categoria: </label>\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateInputNumber_0(__builder2, 9, 10, 
#nullable restore
#line 10 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                       Trabajos.IdCategoria

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.IdCategoria = __value, Trabajos.IdCategoria)), 12, () => Trabajos.IdCategoria);
                __builder2.AddMarkupContent(13, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_1(__builder2, 14, 15, 
#nullable restore
#line 11 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.IdCategoria

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddMarkupContent(19, "<label>Fecha: </label>\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateInputDate_2(__builder2, 20, 21, 
#nullable restore
#line 15 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                     Trabajos.Fecha

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.Fecha = __value, Trabajos.Fecha)), 23, () => Trabajos.Fecha);
                __builder2.AddMarkupContent(24, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_3(__builder2, 25, 26, 
#nullable restore
#line 16 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddMarkupContent(30, "<label>Ubicacion: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                     Trabajos.Ubicacion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.Ubicacion = __value, Trabajos.Ubicacion))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trabajos.Ubicacion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_4(__builder2, 36, 37, 
#nullable restore
#line 21 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.Ubicacion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddMarkupContent(41, "<label>Posicion: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                     Trabajos.Posicion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.Posicion = __value, Trabajos.Posicion))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trabajos.Posicion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_5(__builder2, 47, 48, 
#nullable restore
#line 26 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.Posicion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddMarkupContent(52, "<label>Empresa: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                     Trabajos.Empresa

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.Empresa = __value, Trabajos.Empresa))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trabajos.Empresa));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_6(__builder2, 58, 59, 
#nullable restore
#line 31 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.Empresa

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddMarkupContent(63, "<label>Tipo: </label>\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateInputNumber_7(__builder2, 64, 65, 
#nullable restore
#line 35 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                       Trabajos.IdTipo

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.IdTipo = __value, Trabajos.IdTipo)), 67, () => Trabajos.IdTipo);
                __builder2.AddMarkupContent(68, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_8(__builder2, 69, 70, 
#nullable restore
#line 36 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.IdTipo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddMarkupContent(74, "<label>Descripcion: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                     Trabajos.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.Descripcion = __value, Trabajos.Descripcion))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trabajos.Descripcion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_9(__builder2, 80, 81, 
#nullable restore
#line 41 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddMarkupContent(85, "<label>Email: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(86);
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                     Trabajos.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.Email = __value, Trabajos.Email))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trabajos.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_10(__builder2, 91, 92, 
#nullable restore
#line 46 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddMarkupContent(96, "<label>Como Aplicar: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                     Trabajos.ComoAplicar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trabajos.ComoAplicar = __value, Trabajos.ComoAplicar))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trabajos.ComoAplicar));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n            ");
                __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante.TypeInference.CreateValidationMessage_11(__builder2, 102, 103, 
#nullable restore
#line 51 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                      ()=>Trabajos.ComoAplicar

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddMarkupContent(107, "<label>Logo: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(108);
                __builder2.AddAttribute(109, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                  OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(110, "Value", 
#nullable restore
#line 55 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                                                  selectedFiles

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(111, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedFiles = __value, selectedFiles));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n    ");
                __builder2.OpenElement(113, "button");
                __builder2.AddAttribute(114, "type", "submit");
                __builder2.AddAttribute(115, "class", "btn btn-success");
                __builder2.AddContent(116, 
#nullable restore
#line 58 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
                                                   TextBtn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(118);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\lisan\OneDrive\Escritorio\TAREAS C5\Prog 3\BolsaDeEmpleos\WebApp-Vacantes\WebApp-Vacantes\Pages\Vacantes\FormVacante.razor"
       
    [Parameter] public Trabajos Trabajos { get; set; } = new Trabajos();
    [Parameter] public string TextBtn { get; set; } = "Guardar Cambios";
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public IBrowserFile selectedFiles { get; set; }


    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.File;
        this.StateHasChanged();
        OnSubmitFile();
    }

    private async void OnSubmitFile()
    {
        Stream stream = selectedFiles.OpenReadStream();
        var path = $"{env.WebRootPath}\\logos\\{selectedFiles.Name}";
        Trabajos.UrlString = selectedFiles.Name;
        FileStream fs = File.Create(path);
        await stream.CopyToAsync(fs);
        stream.Close();
        fs.Close();
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
    }
}
namespace __Blazor.WebApp_Vacantes.Pages.Vacantes.FormVacante
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
