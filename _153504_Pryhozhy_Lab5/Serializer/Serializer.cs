using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Domain;

namespace _Serializer
{
    public class Serializer : ISerializer
    {
        public IEnumerable<Station> DeSerializeByJSON(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Station> DeSerializeByLINQ(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Station> DeSerializeByXML(string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeByJSON(IEnumerable<Station> value, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeByLINQ(IEnumerable<Station> value, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeByXML(IEnumerable<Station> value, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Station>));
            using(FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fileStream, value.ToList());
            }
        }
    }
}
