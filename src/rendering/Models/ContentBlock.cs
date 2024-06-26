using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MySitecoreProject.Models
{
    public class ContentBlock : HeadingOnly
    {
        public RichTextField Content { get; set; } = default!;
    }
}
