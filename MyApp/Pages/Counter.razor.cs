using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace MyApp.Pages
{
    public class CounterBase : ComponentBase, IDisposable
    {

        protected int currentCount = 0;

        [Inject] protected IJSRuntime JSRuntime { get; set; }

        protected bool Loading { get; private set; }
        public string Color { get; private set; }
        [Parameter] public int InitialCount { get; set; }

        protected async Task IncrementCount(MouseEventArgs e)
        {
            if (e.AltKey)
            {
                currentCount += 4;
            }
            else
            {
                currentCount++;
            }
            if (currentCount > 20)
            {
                Color = "red";  
            }
            else
            {
                Color = "blue";
            }
            if (currentCount>=18)
            {
                await JSRuntime.InvokeVoidAsync("displayAlert", currentCount);
            }
        }

        [JSInvokable]
        public async Task IncrementByThree()
        {
            currentCount += 3;
            await InvokeAsync(StateHasChanged);
        }

        protected override void OnInitialized()
        {
            

            Console.WriteLine("OnInitialized BEGIN");

            //Loading = true;
            //_ = Task.Delay(5000).ContinueWith(_ => { Loading = false; InvokeAsync(StateHasChanged); });
            base.OnInitialized();

            Console.WriteLine("OnInitialized END");

        }


        protected override void OnParametersSet()
        {
            Console.WriteLine("OnParametersSet BEGIN");
            currentCount = InitialCount;
            base.OnParametersSet();

            Console.WriteLine("OnParametersSet END");

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var thisRef = DotNetObjectReference.Create(this);
                await JSRuntime.InvokeVoidAsync("StoreCounterComponent", thisRef);
            }


            Console.WriteLine("OnAfterRender BEGIN");
            await base.OnAfterRenderAsync(firstRender);
            Console.WriteLine("OnAfterRender END");
        }

        protected override bool ShouldRender()
        {
            Console.WriteLine("ShouldRender BEGIN");


            Console.WriteLine("ShouldRender END");

            return base.ShouldRender();

        }

        public override async Task SetParametersAsync(ParameterView parameters)
        {
            Console.WriteLine("SetParametersAsync BEGIN");

            await base.SetParametersAsync(parameters);

            Console.WriteLine("SetParametersAsync END");

        }

    

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}
