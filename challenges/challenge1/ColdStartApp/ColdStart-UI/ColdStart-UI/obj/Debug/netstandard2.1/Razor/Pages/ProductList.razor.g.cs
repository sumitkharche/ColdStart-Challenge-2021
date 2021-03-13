#pragma checksum "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f0bfc65742e71e71f93f92335feae3b4f57cb5"
// <auto-generated/>
#pragma warning disable 1591
namespace ColdStart_UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using ColdStart_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using ColdStart_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "bg-white py-8");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container mx-auto flex flex-wrap pt-4 pb-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h1 class=\"w-full my-2 text-5xl font-bold leading-tight text-center text-gray-800\">\r\n            Our Ice Creams\r\n        </h1>\r\n        ");
            __builder.AddMarkupContent(7, "<div class=\"w-full mb-4\">\r\n            <div class=\"h-1 mx-auto gradient w-64 opacity-25 my-0 py-0 rounded-t\"></div>\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
         if (catalogs == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.AddMarkupContent(9, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
             foreach (var catalog in catalogs)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "w-full md:w-1/3 p-6 flex flex-col flex-shrink");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "flex-1 bg-white rounded-t rounded-b-none overflow-hidden shadow");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "flex flex-wrap no-underline hover:no-underline");
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "w-full font-bold text-xl text-gray-800 px-6");
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.AddContent(23, 
#nullable restore
#line 25 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
                                 catalog.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "text-gray-800 text-base px-6 mb-5");
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.AddContent(29, 
#nullable restore
#line 28 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
                                 catalog.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "img");
            __builder.AddAttribute(33, "class", "h-60 ml-32 mr-3");
            __builder.AddAttribute(34, "src", 
#nullable restore
#line 30 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
                                                               catalog.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "alt", "cold start logo");
            __builder.AddAttribute(36, "style", "width: 128px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(40);
            __builder.AddAttribute(41, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "flex-none mt-auto bg-white rounded-b rounded-t-none overflow-hidden shadow p-6");
                __builder2.AddMarkupContent(45, "\r\n                                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "flex items-center justify-start");
                __builder2.AddMarkupContent(48, "\r\n                                    ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "mx-auto lg:mx-0 hover:underline gradient text-white font-bold rounded-full py-4 px-8 shadow-lg focus:outline-none focus:shadow-outline transform transition hover:scale-105 duration-300 ease-in-out");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
                                                        ()=>PreOrderIceCreame(@catalog.Id, @context.User.Identity.Name)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(52, "\r\n                                        Pre-order Now\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 46 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge1\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\ProductList.razor"
       

    private Catalog[] catalogs;

    protected override async Task OnInitializedAsync()
    {
        catalogs = await Http.GetFromJsonAsync<Catalog[]>("api/catalogs");
    }

    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    private async Task PreOrderIceCreame(int icecreamId, string userName)
    {
        var order = new Order()
        {
            Id = Guid.NewGuid().ToString(),
            User = userName,
            Date = DateTime.Now,
            IcecreamId = icecreamId,
            Status = "New",
            DriverId = null,
            FullAddress = "1 Microsoft Way, Redmond, WA 98052, USA",
            LastPosition = null
        };
        var response = await Http.PostAsJsonAsync("/api/order", order);
        if (response.IsSuccessStatusCode)
        {
            toastService.ShowSuccess("Your pre-order is successfully submitted!");
        }
        else
        {
            toastService.ShowError("There is some error while submitting your pre-order");
        }
    }

    public class Order
    {
        public string Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int IcecreamId { get; set; }
        public string Status { get; set; }
        public string DriverId { get; set; }
        public string FullAddress { get; set; }
        public string LastPosition { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
