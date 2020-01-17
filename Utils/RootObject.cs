using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QnABot.Utils
{
    public class RootObject
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string SlackData { get; set; }
        public string VideoUrl { get; set; }
        public string CtaLink { get; set; }
    }
}
