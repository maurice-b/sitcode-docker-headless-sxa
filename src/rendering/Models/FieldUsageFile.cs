using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MySitecoreProject.Models
{
    public class FieldUsageFile : HeadingAndDescription
    {
        public FileField File { get; set; } = default!;
    }
}
