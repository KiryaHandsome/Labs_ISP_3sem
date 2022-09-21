using System;
using Domain;
using _Serializer;

namespace _153504_Pryhozhy_Lab5 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Station> stations = new List<Station>();
            string[] directions = new string[]{ "Minsk", "Gomel", "Grodno" };
            for (int i = 0; i < 3; i++)
            {
                var s = new Station(i * 123, i % 2 == 0); 
                s.AddDirection(directions[i]);
                stations.Add(s);    
            }
            Serializer serializer = new Serializer();
            serializer.SerializeByXML(stations, "XML.xml");
        }
    }
}