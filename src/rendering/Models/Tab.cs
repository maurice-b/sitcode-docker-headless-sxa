using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MySitecoreProject.Models
{
    public class Tab
    {
        public TextField Title { get; set; } = default!;

        public RichTextField Content { get; set; } = default!;
    }
}
