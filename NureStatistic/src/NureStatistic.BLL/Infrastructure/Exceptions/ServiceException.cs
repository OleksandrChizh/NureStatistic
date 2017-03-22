using System;

namespace NureStatistic.BLL.Infrastructure.Exceptions
{
    public class ServiceException : Exception
    {
        protected ServiceException(string message, string target) : base(message)
        {
            Target = target;
        }

        public string Target { get; protected set; }
    }
}
