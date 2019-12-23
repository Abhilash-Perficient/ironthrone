using Feature.VideoCarousal.Controllers;
using Feature.VideoCarousal.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feature.VideoCarousal
{
    public class VideoCarousalConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IVideoCarouselRepository, VideoCarouselRepository>();
            //serviceCollection.AddTransient<VideoCarouselController>();
            serviceCollection.AddTransient<VideoCarouselController>();
        }
    }
}