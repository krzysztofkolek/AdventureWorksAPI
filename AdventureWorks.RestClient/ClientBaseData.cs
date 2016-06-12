namespace AdventureWorks.RestClient
{
    using System;

    public abstract class ClientBaseData
    {
        public String Token { get; set; }
        public String TokenKey {
            get { return "Authorization"; }
        }

        public String TokenFull
        {
            get { return "Token " + Token; }
        }

        public ClientBaseData(String token)
        {
            Token = token;
        }
    }
}
