namespace AdventureWorks.Repository.Test.Model.dbo
{
    using System;

    public class DatabaseLog
    {
        public String DatabaseUser;
        public String Event;
        public String Object;
        public DateTime PostTime;
        public String Schema;
        public String Tsql;
        public String XmlEvent;
    }
}
