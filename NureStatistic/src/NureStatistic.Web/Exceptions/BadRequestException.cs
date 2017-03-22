using System;

namespace NureStatistic.Web.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string url)
            : base($"Bad request. Url: {url}")
        {
        }
    }
}
