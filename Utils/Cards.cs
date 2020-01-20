using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.BotBuilderSamples.Utils
{
    public static class  Cards
    {
        public static HeroCard GetHeroCard(QnABot.Utils.RootObject qnaAnswerData)
        {
            var heroCard = new HeroCard
            {
                Title = qnaAnswerData.Title,
                Subtitle = qnaAnswerData.SubTitle,
                Text = qnaAnswerData.Description,
                Images = new List<CardImage> { new CardImage(qnaAnswerData.ImageUrl) },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Get Started", value: qnaAnswerData.CtaLink) },
            };

            return heroCard;
        }
        public static string GetSlackCard(QnABot.Utils.RootObject qnaAnswerData)
        {
            string heading = "*" + qnaAnswerData.Title + "* \n\n";
            string desc = "_" + qnaAnswerData.Description + "_ \n\n";
            return heading + qnaAnswerData.YouTubeUrl + "\n\n" + desc + "> " + qnaAnswerData.CtaLink;

        }
        public static VideoCard GetVideoCard(QnABot.Utils.RootObject qnaAnswerData)
        {
            var videoCard = new VideoCard
            {
                Title = qnaAnswerData.Title,
                Subtitle = qnaAnswerData.SubTitle,
                Text = qnaAnswerData.Description,
                Image = new ThumbnailUrl
                {
                    Url = qnaAnswerData.ImageUrl,
                },
                Media = new List<MediaUrl>
                {
                    new MediaUrl()
                    {
                        Url = qnaAnswerData.VideoUrl,
                    },
                },
                Buttons = new List<CardAction>
                {
                    new CardAction()
                    {
                        Title = "Learn More",
                        Type = ActionTypes.OpenUrl,
                        Value =  qnaAnswerData.CtaLink,
                    },
                },
            };

            return videoCard;
        }
    }
}
