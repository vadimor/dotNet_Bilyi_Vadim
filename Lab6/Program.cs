using System;
using System.Linq;
using Lab5;
using Lab4;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyCollection<DataStudLab4>();
            collection.Add(new DataStudLab4() { Name = "Lila" });
            collection.Add(new DataStudLab4() { Name = "Dima", Birthday = new DateTime(2002, 1, 2) });
            collection.Add(new DataStudLab4() { Name = "Deny", Birthday = new DateTime(2002, 10, 2) });
            collection.Add(new DataStudLab4() { Name = "Vika" });
            collection.Add(new DataStudLab4() { Name = "Andrey" });
            collection.Add(new DataStudLab4() { Name = "Danil", Birthday = new DateTime(2001, 1, 2) });
            var result1 = (from DataStudLab4 t in collection
                          where t.Name.ToUpper().StartsWith("D")
                          select t).Min<DataStudLab4>(t => t.Course);
            Console.WriteLine(result1);
        }
    }
}
