using System;
using Lab1;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyCollection<DataStud>();
            var stud = new DataStud("Yam", "Xen", "Len");
            a.Add(new DataStud());
            a.Add(new DataStud("Vika", "Vasiliv", "Dmitrovich"));
            a.Add(new DataStud("Illa", "Vasiliv", "Dmitrovich"));
            a.Add(stud);
            a.Add(new DataStud("Kiril", "Vasiliv", "Dmitrovich"));
            var ser = new MySerializer<DataStud>();
            ser.Serialization(a, "SaveLab3.xml");

            a.SetArray(new DataStud[0]);
            a.Add(stud);
            a[0].Name = "DADDAD";
            Console.WriteLine(a);
            Console.WriteLine("--------------------");
            ser.Deserialization(a, "SaveLab3.xml");
            Console.WriteLine(a);
            Console.WriteLine("--------------------");
            a.Delete(2);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
