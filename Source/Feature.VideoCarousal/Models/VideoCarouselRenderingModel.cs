using Sitecore.XA.Feature.Composites.Models;
using System.Collections.Generic;

namespace Feature.VideoCarousal.Models
{
    public class VideoCarouselRenderingModel : CarouselRenderingModel
    {
        public List<string> MediaUrls { get; set; }
    }
}