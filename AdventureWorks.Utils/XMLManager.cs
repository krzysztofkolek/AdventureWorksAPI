namespace AdventureWorks.Utils
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    public class XMLManager<T>
        where T : class, new()
    {
        private XmlSerializer _serializer { get; set; }

        public XMLManager()
        {
            _serializer = new XmlSerializer(typeof(T));
        }

        public void Serialize(T input, String path)
        {
            using (var writer = new FileStream(path, FileMode.Create))
            {
                _serializer.Serialize(writer, input);
            }
        }

        public T Deserialize(String path)
        {
            T type;
            using (var reader = XmlReader.Create(path))
            {
                type = _serializer.Deserialize(reader) as T;
            }
            return type;
        }
    }
}
