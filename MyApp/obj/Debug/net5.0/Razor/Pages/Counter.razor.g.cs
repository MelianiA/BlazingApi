#pragma checksum "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8bec1cede7b642edb9a9aec1e1c66ca78d582b6"
// <auto-generated/>
#pragma warning disable 1591
namespace MyApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using MyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using MyApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using MyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\_Imports.razor"
using MyApp.Services;

#line default
#line hidden
#nullable disable
    public partial class Counter : CounterBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Nombre Magique ! </h1>");
#nullable restore
#line 4 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
 if (Loading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading ...</p>");
#nullable restore
#line 7 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<h4> Counter  </h4>\r\n        ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, " Current count: ");
            __builder.AddContent(6, 
#nullable restore
#line 12 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
                            currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "disabled", 
#nullable restore
#line 15 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
                            currentCount>=20

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "style", "color:" + (
#nullable restore
#line 16 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
                              Color

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(13, "onclick", 
#nullable restore
#line 18 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
                                          true

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n           Click me\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.AddMarkupContent(16, "<button class=\"btn btn-primary\" onclick=\"Increment3()\">\r\n            Increment 3\r\n        </button>");
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\alyf\Desktop\Script c#\ApprentissageBlazor\MyApp\MyApp\Pages\Counter.razor"
  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
