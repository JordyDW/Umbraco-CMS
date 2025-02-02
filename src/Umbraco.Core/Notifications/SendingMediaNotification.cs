using Umbraco.Cms.Core.Models.ContentEditing;
using Umbraco.Cms.Core.Web;

namespace Umbraco.Cms.Core.Notifications
{
    public class SendingMediaNotification : INotification
    {
        public IUmbracoContext UmbracoContext { get; }

        public MediaItemDisplay Media { get; }

        public SendingMediaNotification(MediaItemDisplay media, IUmbracoContext umbracoContext)
        {
            Media = media;
            UmbracoContext = umbracoContext;
        }
    }
}
