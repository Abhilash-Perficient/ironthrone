using Sitecore.XA.Foundation.Variants.Abstractions.Pipelines.ResolveVariantTokens;
using System.Web.UI;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Feature.VideoCarousal.Pipelines
{
    public class ResolveVideoPath : ResolveVariantTokensProcessor
    {
        public override string Token => "$videofield";

        public override void ResolveToken(ResolveVariantTokensArgs args)
        {
            if(args.ResultControl != null)
            {
                LiteralControl videogallery = new LiteralControl();
                string startstr = @"<video class='videocomponent' controls><source src=";
                videogallery.Text += startstr;
                LinkField videoitm = args.ContextItem.Fields[Constants.VideoCarousel.Fields.VideoLink.id];
                MediaItem itm = new MediaItem(videoitm.TargetItem);
                string videolnk = Sitecore.StringUtil.EnsurePrefix('/',Sitecore.Resources.Media.MediaManager.GetMediaUrl(itm));
                videogallery.Text += videolnk;
                string strend = @"type='video/mp4'></video>";
                videogallery.Text += strend;
                args.ResultControl.Controls.Add(videogallery);
            }            
        }
    }
}