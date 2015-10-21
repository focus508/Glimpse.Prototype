using System;
using System.Collections.Generic;
using Glimpse.Agent.Messages;

namespace Glimpse.Agent.Internal.Inspectors.Mvc
{
    public interface IExceptionProcessor
    {
        IEnumerable<ExceptionDetails> GetErrorDetails(Exception ex);
    }
}