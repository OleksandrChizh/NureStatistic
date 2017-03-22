using System;

namespace NureStatistic.Web.Exceptions
{
    public class WebRequestException : Exception
    {
        public WebRequestException(string message, string url)
            : base($"{message}. Url: {url}")
        {
        }
    }
}
