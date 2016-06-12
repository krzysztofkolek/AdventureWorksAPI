
namespace AdventureWorks.RestClient
{
    using System;
    using System.Collections.Generic;

    public class ClientData : ClientBaseData
    {
        public Dictionary<String, String> Headers { get; set; }
        public Parameters Parameters { get; set; }


        public ClientData(string token)
            : base(token)
        {
        }

        public ClientData(string token, Dictionary<String, String> headers, Parameters parameters)
            : base(token)
        {
            Headers = headers;
            Parameters = parameters;
        }

        public ClientData SetHeaders(Dictionary<String, String> headers)
        {
            Headers = headers;
            return this;
        }

        public ClientData SetParameters(Parameters parameters)
        {
            Parameters = parameters;
            return this;
        }
    }
}
