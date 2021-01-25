using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace aspCoew.Middle.filter
{
    public class ControllerActionFilter:Attribute,IFilterFactory
    {
        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            return new InternalAddHeaderFilter();
        }

        private class InternalAddHeaderFilter : IResultFilter
        {
            public void OnResultExecuting(ResultExecutingContext context)
            {
                Console.WriteLine("----");
            }

            public void OnResultExecuted(ResultExecutedContext context)
            {
            }
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}