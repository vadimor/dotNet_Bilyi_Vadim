using System;
using System.IO;
using System.Xml.Serialization;

namespace Lab3
{
    public class MySerializer<T> where T: new()
    {
        public MySerializer() {
            if (typeof(T).IsDefined(typeof(SerializableAttribute), false) == false)
            {
                Console.WriteLine("Type haven`t Serializable attribute");
            }
        }
        public void Serialization(Lab2.MyCollection<T> collection, String fileName) {

            if (typeof(T).IsDefined(typeof(SerializableAttribute), false) == false) {
                Console.WriteLine("Type haven`t Serializable attribute");
                return;
            }

            var formatter = new XmlSerializer(typeof(T[]));
            using (var file = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(file,collection.ToArray());
            }
        }
        public void Deserialization(Lab2.MyCollection<T> collection, String fileName)
        {

            if (typeof(T).IsDefined(typeof(SerializableAttribute), false) == false)
            {
                Console.WriteLine("Type haven`t Serializable attribute");
                return;
            }

            var formatter = new XmlSerializer(typeof(T[]));
            using (var file = new FileStream(fileName, FileMode.Open))
            {
                collection.SetArray((T[]) formatter.Deserialize(file));
            }
        }
    }
}
