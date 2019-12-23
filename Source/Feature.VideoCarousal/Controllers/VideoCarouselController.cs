using Feature.VideoCarousal.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;
using System.Web.Mvc;

namespace Feature.VideoCarousal.Controllers
{
    public class VideoCarouselController : StandardController
    {
        public IVideoCarouselRepository VideoCarouselRepository { get; set; }
        
        public VideoCarouselController(IVideoCarouselRepository videoCarouselRepository)
        {
            this.VideoCarouselRepository = videoCarouselRepository;
        }

        protected override object GetModel()
        {
            return (object)this.VideoCarouselRepository.GetModel();
        }
    }
}