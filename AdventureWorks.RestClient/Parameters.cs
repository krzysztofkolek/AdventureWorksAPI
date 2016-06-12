namespace AdventureWorks.RestClient
{
    using System;
    using RestSharp;

    public class Parameters
    {
        public String Name { get; set; }
        public object Value { get; set; }
        public ParameterType Type { get; set; }
    }
}
