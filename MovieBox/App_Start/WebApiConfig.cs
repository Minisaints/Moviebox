﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MovieBox
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
<<<<<<< HEAD
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
=======
                defaults: new {id = RouteParameter.Optional}
            );
        }
    }
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
