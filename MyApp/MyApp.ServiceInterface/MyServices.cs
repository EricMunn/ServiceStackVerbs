using System;
using ServiceStack;
using MyApp.ServiceModel;

namespace MyApp.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = request };
        }
    }
}
