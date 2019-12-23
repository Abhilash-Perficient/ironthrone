using Feature.VideoCarousal.Models;
using Sitecore.Data.Items;
using Sitecore.XA.Feature.Composites.Repositories;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System.Collections.Generic;
using Sitecore.Data.Fields;

namespace Feature.VideoCarousal.Repositories
{
    public class VideoCarouselRepository : CarouselRepository, IVideoCarouselRepository
    {
        public override IRenderingModelBase GetModel()
        {
            VideoCarouselRenderingModel videoCarouselRenderingModel = new VideoCarouselRenderingModel();
            this.FillBaseProperties((object)videoCarouselRenderingModel);
            videoCarouselRenderingModel.JsonDataProperties = this.GetJsonProperties();
            videoCarouselRenderingModel.Settings = this.GetSettings();
            videoCarouselRenderingModel.MediaUrls = this.GetThumbnailUrls(videoCarouselRenderingModel);
            return (IRenderingModelBase)videoCarouselRenderingModel;
        }
        protected List<string> GetThumbnailUrls(VideoCarouselRenderingModel model)
        {
            List<string> urls = new List<string>();
            if(model.CompositeItems.Count > 0)
            {
                foreach(var ele in model.CompositeItems)
                {
                    Item itm = Sitecore.Context.Database.GetItem(ele.Value.ID);
                    ImageField imgField = itm.Fields[Constants.VideoCarousel.Fields.Thumbnail.id];
                    urls.Add(Sitecore.Resources.Media.MediaManager.GetMediaUrl(imgField.MediaItem));
                }
            }
            return urls;
        }
    }
}