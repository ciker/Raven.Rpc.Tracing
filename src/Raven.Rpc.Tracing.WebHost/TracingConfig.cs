﻿using Raven.Rpc.Tracing.ContextData;
using Raven.Rpc.Tracing.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;

namespace Raven.Rpc.Tracing.WebHost
{
    public static class TracingConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="tracingRecord"></param>
        public static void UseTracingContext(ITracingRecord tracingRecord)
        {
            ServiceContainer.Register<IHttpHelper>(new HttpContextHelper());
            ServiceContainer.Register<ITracingRecord>(tracingRecord);
            ServiceContainer.Register<IInitRequestScopeContext>(new InitRequestScopeContext());
        }

    }
}
