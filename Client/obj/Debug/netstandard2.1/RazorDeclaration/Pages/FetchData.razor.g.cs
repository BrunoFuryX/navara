#pragma checksum "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9896bb9c9747d87c8590129f76924078e67758"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorNavara.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using BlazorNavara.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\_Imports.razor"
using BlazorNavara.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\Pages\FetchData.razor"
using BlazorNavara.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "c:\Users\Maazo\Documents\Bruno Faculdade\BlazorNavara\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
