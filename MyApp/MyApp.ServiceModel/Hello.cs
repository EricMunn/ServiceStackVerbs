using ServiceStack;

namespace MyApp.ServiceModel
{
    [Route("/hello","GET POST")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Foo { get; set; }
        public string Bar { get; set; }
    }

    public class HelloResponse
    {
        public Hello Result { get; set; }
    }
}
