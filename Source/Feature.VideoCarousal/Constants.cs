using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feature.VideoCarousal
{
    public static class Constants
    {
        public struct VideoCarousel
        {
            public struct Fields
            {
                public struct Thumbnail
                {
                    public static readonly ID id = new ID("{12B44A2B-7942-4C2C-9B21-238763740598}");
                }
                public struct VideoLink
                {
                    public static readonly ID id = new ID("{BF35A4FA-9A6E-45A3-B987-2E49E37937F2}");
                }
            }
        }
    }
}