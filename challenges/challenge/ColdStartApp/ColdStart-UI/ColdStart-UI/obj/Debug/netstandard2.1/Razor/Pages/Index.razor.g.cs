#pragma checksum "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17a545ba8b8472734aa37a7cd47c1a16a32b1fb4"
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
#line 1 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using ColdStart_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using ColdStart_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-12");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container px-3 mx-auto flex flex-wrap flex-col md:flex-row items-center");
            __builder.AddMarkupContent(5, "\r\n        \r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "flex flex-col w-full md:w-2/5 justify-center items-start text-center md:text-left");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(9);
            __builder.AddAttribute(10, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n                    ");
                __builder2.OpenElement(12, "p");
                __builder2.AddAttribute(13, "class", "leading-normal text-2xl mb-8");
                __builder2.AddMarkupContent(14, "\r\n                        Welcome, ");
                __builder2.AddContent(15, 
#nullable restore
#line 9 "C:\My Projects\ColdStart-Challenge-2021\challenges\challenge\ColdStartApp\ColdStart-UI\ColdStart-UI\Pages\Index.razor"
                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(16, "!\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<h1 class=\"my-4 text-5xl font-bold leading-tight\">\r\n                Delicious Ice Creams from ColdStart\r\n            </h1>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(20);
            __builder.AddAttribute(21, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.AddMarkupContent(23, "<p class=\"leading-normal text-2xl mb-8\">\r\n                        Sign in to pre order the delicious Ice Creams.\r\n                    </p>\r\n                    ");
                __builder2.AddMarkupContent(24, @"<button class=""mx-auto lg:mx-0 text-black font-bold rounded-full mb-2 py-4 px-8 shadow-lg focus:outline-none focus:shadow-outline transform transition hover:scale-105 duration-300 ease-in-out"">
                        <a href=""/.auth/login/github"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" role=""img"" aria-labelledby=""asuzxfg86b4oycrtmdfrqwd7o6b2l02a"" style=""display: inherit"">
                                <title id=""asuzxfg86b4oycrtmdfrqwd7o6b2l02a"">github</title>
                                <path d=""M12 2C6.475 2 2 6.475 2 12a9.994 9.994 0 006.838 9.488c.5.087.687-.213.687-.476 0-.237-.013-1.024-.013-1.862-2.512.463-3.162-.612-3.362-1.175-.113-.288-.6-1.175-1.025-1.413-.35-.187-.85-.65-.013-.662.788-.013 1.35.725 1.538 1.025.9 1.512 2.338 1.087 2.912.825.088-.65.35-1.087.638-1.337-2.225-.25-4.55-1.113-4.55-4.938 0-1.088.387-1.987 1.025-2.688-.1-.25-.45-1.275.1-2.65 0 0 .837-.262 2.75 1.026a9.28 9.28 0 012.5-.338c.85 0 1.7.112 2.5.337 1.912-1.3 2.75-1.024 2.75-1.024.55 1.375.2 2.4.1 2.65.637.7 1.025 1.587 1.025 2.687 0 3.838-2.337 4.688-4.562 4.938.362.312.675.912.675 1.85 0 1.337-.013 2.412-.013 2.75 0 .262.188.574.688.474A10.016 10.016 0 0022 12c0-5.525-4.475-10-10-10z""></path>
                            </svg>
                            Sign in with GitHub
                        </a>
                    </button>
                    ");
                __builder2.AddMarkupContent(25, @"<button class=""mx-auto lg:mx-0  text-red-500 font-bold rounded-full mb-2 py-4 px-8 shadow-lg focus:outline-none focus:shadow-outline transform transition hover:scale-105 duration-300 ease-in-out"">
                        <a href=""/.auth/login/google"">
                            <img style=""padding-right:10px; display:inherit"" src=""https://secure.meetupstatic.com/s/img/09976452261947836380738/logo_google.svg"" alt=""Continue with Google"">
                            Sign in with Google
                        </a>
                    </button>
                    ");
                __builder2.AddMarkupContent(26, @"<button class=""mx-auto lg:mx-0  text-blue-400 font-bold rounded-full mb-2 py-4 px-8 shadow-lg focus:outline-none focus:shadow-outline transform transition hover:scale-105 duration-300 ease-in-out"">
                        <a href=""/.auth/login/twitter"">
                            <img style=""padding-right:8px; display:inherit;width:29px "" src=""twitter-logo.png"" alt=""Continue with Twitter"">
                            Sign in with Twitter
                        </a>
                    </button>
                    ");
                __builder2.AddMarkupContent(27, @"<button class=""mx-auto lg:mx-0  text-blue-700 font-bold rounded-full mb-2 py-4 px-8 shadow-lg focus:outline-none focus:shadow-outline transform transition hover:scale-105 duration-300 ease-in-out"">
                        <a href=""/.auth/login/facebook"">
                            <img style=""padding-right:8px; display:inherit;width:29px "" src=""facebook-logo.png"" alt=""Continue with Facebook"">
                            Sign in with Facebook
                        </a>
                     </button>
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        \r\n        ");
            __builder.AddMarkupContent(30, "<div class=\"w-full md:w-3/5 py-6 text-center\">\r\n            <img class=\"w-full md:w-4/5 z-50\" src=\"COLDSTART-TRUCK-400x300.png\">\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.AddMarkupContent(33, "<div class=\"relative -mt-12 lg:-mt-24\">\r\n    <svg viewBox=\"0 0 1428 174\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\">\r\n        <g stroke=\"none\" stroke-width=\"1\" fill=\"none\" fill-rule=\"evenodd\">\r\n            <g transform=\"translate(-2.000000, 44.000000)\" fill=\"#FFFFFF\" fill-rule=\"nonzero\">\r\n                <path d=\"M0,0 C90.7283404,0.927527913 147.912752,27.187927 291.910178,59.9119003 C387.908462,81.7278826 543.605069,89.334785 759,82.7326078 C469.336065,156.254352 216.336065,153.6679 0,74.9732496\" opacity=\"0.100000001\"></path>\r\n                <path d=\"M100,104.708498 C277.413333,72.2345949 426.147877,52.5246657 546.203633,45.5787101 C666.259389,38.6327546 810.524845,41.7979068 979,55.0741668 C931.069965,56.122511 810.303266,74.8455141 616.699903,111.243176 C423.096539,147.640838 250.863238,145.462612 100,104.708498 Z\" opacity=\"0.100000001\"></path>\r\n                <path d=\"M1046,51.6521276 C1130.83045,29.328812 1279.08318,17.607883 1439,40.1656806 L1439,120 C1271.17211,77.9435312 1140.17211,55.1609071 1046,51.6521276 Z\" id=\"Path-4\" opacity=\"0.200000003\"></path>\r\n            </g>\r\n            <g transform=\"translate(-4.000000, 76.000000)\" fill=\"#FFFFFF\" fill-rule=\"nonzero\">\r\n                <path d=\"M0.457,34.035 C57.086,53.198 98.208,65.809 123.822,71.865 C181.454,85.495 234.295,90.29 272.033,93.459 C311.355,96.759 396.635,95.801 461.025,91.663 C486.76,90.01 518.727,86.372 556.926,80.752 C595.747,74.596 622.372,70.008 636.799,66.991 C663.913,61.324 712.501,49.503 727.605,46.128 C780.47,34.317 818.839,22.532 856.324,15.904 C922.689,4.169 955.676,2.522 1011.185,0.432 C1060.705,1.477 1097.39,3.129 1121.236,5.387 C1161.703,9.219 1208.621,17.821 1235.4,22.304 C1285.855,30.748 1354.351,47.432 1440.886,72.354 L1441.191,104.352 L1.121,104.031 L0.457,34.035 Z\"></path>\r\n            </g>\r\n        </g>\r\n    </svg>\r\n</div>\r\n");
            __builder.OpenComponent<ColdStart_UI.Pages.ProductList>(34);
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.AddMarkupContent(36, "<svg class=\"wave-top\" viewBox=\"0 0 1439 147\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\">\r\n    <g stroke=\"none\" stroke-width=\"1\" fill=\"none\" fill-rule=\"evenodd\">\r\n        <g transform=\"translate(-1.000000, -14.000000)\" fill-rule=\"nonzero\">\r\n            <g class=\"wave\" fill=\"#f8fafc\">\r\n                <path d=\"M1440,84 C1383.555,64.3 1342.555,51.3 1317,45 C1259.5,30.824 1206.707,25.526 1169,22 C1129.711,18.326 1044.426,18.475 980,22 C954.25,23.409 922.25,26.742 884,32 C845.122,37.787 818.455,42.121 804,45 C776.833,50.41 728.136,61.77 713,65 C660.023,76.309 621.544,87.729 584,94 C517.525,105.104 484.525,106.438 429,108 C379.49,106.484 342.823,104.484 319,102 C278.571,97.783 231.737,88.736 205,84 C154.629,75.076 86.296,57.743 0,32 L0,0 L1440,0 L1440,84 Z\"></path>\r\n            </g>\r\n            <g transform=\"translate(1.000000, 15.000000)\" fill=\"#FFFFFF\">\r\n                <g transform=\"translate(719.500000, 68.500000) rotate(-180.000000) translate(-719.500000, -68.500000) \">\r\n                    <path d=\"M0,0 C90.7283404,0.927527913 147.912752,27.187927 291.910178,59.9119003 C387.908462,81.7278826 543.605069,89.334785 759,82.7326078 C469.336065,156.254352 216.336065,153.6679 0,74.9732496\" opacity=\"0.100000001\"></path>\r\n                    <path d=\"M100,104.708498 C277.413333,72.2345949 426.147877,52.5246657 546.203633,45.5787101 C666.259389,38.6327546 810.524845,41.7979068 979,55.0741668 C931.069965,56.122511 810.303266,74.8455141 616.699903,111.243176 C423.096539,147.640838 250.863238,145.462612 100,104.708498 Z\" opacity=\"0.100000001\"></path>\r\n                    <path d=\"M1046,51.6521276 C1130.83045,29.328812 1279.08318,17.607883 1439,40.1656806 L1439,120 C1271.17211,77.9435312 1140.17211,55.1609071 1046,51.6521276 Z\" opacity=\"0.200000003\"></path>\r\n                </g>\r\n            </g>\r\n        </g>\r\n    </g>\r\n</svg>\r\n\r\n");
            __builder.OpenComponent<ColdStart_UI.Pages.Footer>(37);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
