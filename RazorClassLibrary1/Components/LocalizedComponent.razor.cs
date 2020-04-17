using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;

namespace RazorClassLibrary1.Components
{
    public partial class LocalizedComponent : ComponentBase
    {
        [Inject]
        public IStringLocalizer<LocalizedComponent> Localizer { get; set; }
        //public IStringLocalizer Localizer { get; set; }

        public string Title { get; set; }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            Title = Localizer["key1"];
            return base.OnAfterRenderAsync(firstRender);
        }

        protected override bool ShouldRender()
        {
            return base.ShouldRender();
        }
    }
}
