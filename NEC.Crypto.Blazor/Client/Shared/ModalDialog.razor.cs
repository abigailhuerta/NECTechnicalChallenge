using Microsoft.AspNetCore.Components;

namespace NEC.Crypto.Blazor.Client.Shared
{
    public partial class ModalDialog : ComponentBase 
    {
        [Parameter]
        public RenderFragment Header { get; set; }
        [Parameter]
        public RenderFragment Body { get; set; }
        [Parameter]
        public RenderFragment Footer { get; set; }

        [Parameter]
        public EventCallback  OnClose { get; set; }

        [Parameter]
        public bool Show { get; set; }

    }
}
