using EPiServer.Core;

namespace EpiserverImageProcessorCache.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
