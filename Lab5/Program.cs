using System;
using Lab4;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
               var menu = new MyMenu(new MyCollection<DataStudLab4>());
               menu.Collection.Add(new DataStudLab4());
               menu.Collection.Add(new DataStudLab4("Vika", "Vasiliv", "Dmitrovich"));
               menu.Collection.Add(new DataStudLab4("Illa", "Vasiliv", "Dmitrovich"));
               menu.Collection.Add(new DataStudLab4("Kiril", "Vasiliv", "Dmitrovich", new DateTime(1955,12,1), new DateTime(2020,12,1), "119a", 123, 63.1f, "KIT"));
               Console.WriteLine(menu.AverageAge(a));
               Console.WriteLine(menu.AverageAcademicPreformance(a));
               menu.PrintTable();
               menu.Collection.Delete(a);
               Console.WriteLine("\n\n\n");
               menu.PrintTable();
               Console.WriteLine(menu.AverageAge(a));
        }

        static bool a(DataStudLab4 b)
        {
            if (b.Surname.CompareTo("Vasiliv") == 0)
            {
                return true;
            }
            return false;
        }
    }
}
