﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Battleships.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
