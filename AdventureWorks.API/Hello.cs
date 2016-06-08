namespace AdventureWorks.API
{
    using Nancy;

    public class HelloModule:NancyModule
    {
        public HelloModule()
        {
            Get["/Hello"] = _ => "Hello";
        }
    }
}
