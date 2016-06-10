namespace RestClient
{
    using System;

    public abstract class BaseRestClient<T>
        where T: class 
    {
        private String _url { get; set; }

        public BaseRestClient<T> SetUrl(String url)
        {
            _url = url;
            return this;
        }

        public abstract T GetRestResult();
    }
}
