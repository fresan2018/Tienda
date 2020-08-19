#pragma checksum "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\Pages\Work.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c6429ae8894cefdf37c92059f6e91503f8d084"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaFireSport.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using TiendaFireSport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using TiendaFireSport.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using TiendaFireSport.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using TiendaFireSport.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\_Imports.razor"
using TiendaFireSport.Repositorios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/works")]
    public partial class Work : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "main");
            __builder.AddAttribute(1, "id", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<TiendaFireSport.Shared.ListadoProductos>(3);
            __builder.AddAttribute(4, "Productos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<TiendaFireSport.Entidades.Producto>>(
#nullable restore
#line 4 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\Pages\Work.razor"
                                 Productos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ComprarProducto", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TiendaFireSport.Entidades.Producto>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TiendaFireSport.Entidades.Producto>(this, 
#nullable restore
#line 4 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\Pages\Work.razor"
                                                             ComprarProducto

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    \r\n    ");
            __builder.OpenComponent<TiendaFireSport.Shared.Testimonial>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\Pages\Work.razor"
      
 private List<Producto> Productos;
    protected override void OnInitialized()
    {
        Productos = repositorio.ObtenerProductos();
    }
    protected void ComprarProducto(Producto producto)
    {
        Productos.Add(new Producto() { Id = 7, Nombre = "Dep 158", Categoria = "nuevo", Imagen = "img_7.jpg", Preciold = 70000, Precio = 49900, Color = "Fucsia y negro" });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
