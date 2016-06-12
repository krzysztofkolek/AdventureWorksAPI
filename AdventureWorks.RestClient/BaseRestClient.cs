namespace AdventureWorks.RestClient
{ 
    using RestSharp;
    using RestSharp.Deserializers;
    using System;
    using System.Net;

    public class BaseRestClient<T>
        where T : class, new()
    {
        private String _url { get; set; }
        private ClientData _data { get; set; }
        private IRestResponse _response { get; set; }
        private Method _method { get; set; }

        public BaseRestClient(String url, ClientData data)
        {
            _url = url;
            _data = data;
        }

        public BaseRestClient(String url, ClientData data, Method method)
        {
            _url = url;
            _data = data;
            _method = method;
        }

        public BaseRestClient<T> SetUrl(String url)
        {
            _url = url;
            return this;
        }
        public BaseRestClient<T> SetData(ClientData data)
        {
            _data = data;
            return this;
        }

        public BaseRestClient<T> SetMethod(Method method)
        {
            _method = method;
            return this;
        }

        public virtual BaseRestClient<T> ExecutePost()
        {
            var client = new RestClient(_url);
            var request = new RestRequest(_method);

            if (_data.Token != null)
            {
                request.AddHeader(_data.TokenKey, _data.TokenFull);
            }

            if (_data.Headers != null)
            {
                foreach (var header in _data.Headers)
                {

                    request.AddHeader(header.Key, header.Value);
                }
            }

            if (_data.Parameters != null)
            {
                request.AddParameter(_data.Parameters.Name, _data.Parameters.Value, _data.Parameters.Type);
            }

            _response = client.Execute(request);

            if (_response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception("Unauthorized");
            }
            else if (_response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("REST exception");
            }

            return this;
        }

        public virtual T GetRestResult()
        {
            if (_response != null)
            {
                T model = new JsonDeserializer().Deserialize<T>(_response);
                return model;
            }
            return null;
        }

        public virtual T ExecuteAndGetRestResult()
        {
            return ExecutePost().GetRestResult();
        }

        public static ClientDataAuth Authorizatize(string url, string login, string password)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "multipart/form-data; boundary=---011000010111000001101001");

            var loginString = String.Format("-----011000010111000001101001\r\nContent-Disposition: form-data; name=\"UserName\"\r\n\r\n{0}\r\n-----011000010111000001101001\r\nContent-Disposition: form-data; name=\"Password\"\r\n\r\n{1}\r\n-----011000010111000001101001--", login, password);
            request.AddParameter("multipart/form-data; boundary=---011000010111000001101001", loginString, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return new JsonDeserializer().Deserialize<ClientDataAuth>(response);
            }
            return null;
        }
    }
}
