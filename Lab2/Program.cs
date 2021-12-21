using Lab1;

namespace Lab2
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
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(a[1]);
            System.Console.WriteLine(a.Find(stud));
            System.Console.WriteLine(a.Find(new DataStud()));
            System.Console.Read();
        }
    }
}
