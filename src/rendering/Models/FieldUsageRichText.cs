using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MySitecoreProject.Models
{
    public class FieldUsageRichText : HeadingAndDescription
    {
        public RichTextField Sample { get; set; } = default!;

        public RichTextField Sample2 { get; set; } = default!;
    }
}
