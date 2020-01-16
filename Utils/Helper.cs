using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QnABot.Utils
{
    public static class Helper
    {
        public static bool IsValidJson(this string value)
        {
            try
            {
                var json = JContainer.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
