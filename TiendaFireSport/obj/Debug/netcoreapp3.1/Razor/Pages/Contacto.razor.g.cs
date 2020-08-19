#pragma checksum "C:\Net2020\TiendaBlazor\TiendaFireSport\TiendaFireSport\Pages\Contacto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41534b2db3d314a0137ed22a1a0fe425d257bab0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/contacto")]
    public partial class Contacto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<main id=\"main\">\r\n\r\n        <section class=\"section pb-5\">\r\n            <div class=\"container\">\r\n\r\n                <div class=\"row mb-5 align-items-end\">\r\n                    <div class=\"col-md-6\" data-aos=\"fade-up\">\r\n                        <h2>Contactenos</h2>\r\n                        <p class=\"mb-0\">\r\n                            Nuestras políticas de venta no tenemos devoluciones. El mal uso del producto no garantiza cambio.\r\n                        </p>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 mb-5 mb-md-0\" data-aos=\"fade-up\">\r\n\r\n                        <form action=\"forms/contact.php\" method=\"post\" role=\"form\" class=\"php-email-form\">\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    <label for=\"name\">Nombre</label>\r\n                                    <input type=\"text\" name=\"name\" class=\"form-control\" id=\"name\" data-rule=\"minlen:4\" data-msg=\"Please enter at least 4 chars\">\r\n                                    <div class=\"validate\"></div>\r\n                                </div>\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    <label for=\"name\">Email</label>\r\n                                    <input type=\"email\" class=\"form-control\" name=\"email\" id=\"email\" data-rule=\"email\" data-msg=\"Please enter a valid email\">\r\n                                    <div class=\"validate\"></div>\r\n                                </div>\r\n                                <div class=\"col-md-12 form-group\">\r\n                                    <label for=\"name\">Asunto</label>\r\n                                    <input type=\"text\" class=\"form-control\" name=\"subject\" id=\"subject\" data-rule=\"minlen:4\" data-msg=\"Please enter at least 8 chars of subject\">\r\n                                    <div class=\"validate\"></div>\r\n                                </div>\r\n                                <div class=\"col-md-12 form-group\">\r\n                                    <label for=\"name\">Mensaje</label>\r\n                                    <textarea class=\"form-control\" name=\"message\" cols=\"30\" rows=\"10\" data-rule=\"required\" data-msg=\"Please write something for us\"></textarea>\r\n                                    <div class=\"validate\"></div>\r\n                                </div>\r\n\r\n                                <div class=\"col-md-12 mb-3\">\r\n                                    <div class=\"loading\">Leyendo</div>\r\n                                    <div class=\"error-message\"></div>\r\n                                    <div class=\"sent-message\">Su mensaje ha sido enviado. Gracias!</div>\r\n                                </div>\r\n\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    <input type=\"submit\" class=\"readmore d-block w-100\" value=\"Enviar mensaje\">\r\n                                </div>\r\n                            </div>\r\n\r\n                        </form>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"col-md-4 ml-auto order-2\" data-aos=\"fade-up\">\r\n                        <ul class=\"list-unstyled\">\r\n                            <li class=\"mb-3\">\r\n                                <strong class=\"d-block mb-1\">Atendemos</strong>\r\n                                <span>\r\n                                    Lunea a Sábado 9:00 am - 8:00 pm<br>\r\n                                    Domingo 10:00 am - 2:00 pm\r\n                                </span>\r\n                            </li>\r\n                            <li class=\"mb-3\">\r\n                                <strong class=\"d-block mb-1\">Telefóno</strong>\r\n                                <span>+571 310 202 9357</span><br>\r\n                                <span>+571 322 756 8716</span>\r\n                            </li>\r\n                            <li class=\"mb-3\">\r\n                                <strong class=\"d-block mb-1\">Email</strong>\r\n                                <span>firesportcolombia@gmail.com</span>\r\n                            </li>\r\n\r\n                        </ul>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </section>\r\n\r\n    </main>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
