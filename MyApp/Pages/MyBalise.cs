using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Pages
{
    public class MyBalise : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "a");
            builder.AddAttribute(1, "href", "www.google.com");
            builder.AddContent(2, "Aller chez Google");
            builder.CloseComponent();
            //<a href="www.google.com"> Aller chez Google </a>

            base.BuildRenderTree(builder);
        }
    }
}
