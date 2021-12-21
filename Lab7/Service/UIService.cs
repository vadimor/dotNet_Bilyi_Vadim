using System.Collections.Generic;
using System.Linq;
using Lab7.Model;

namespace Lab7.Service
{
    public class UIService
    {
        public void PrintAllStudentFullName(IEnumerable<Student> collection)
        {
            collection.Select((s) =>
            {
                var str = $"{s.FirstName} {s.SecondName}";
                System.Console.WriteLine(str);
                return str;
            }).ToList();
        }

        public void PrintAllStudentByFaculty(IEnumerable<Student> collection, string faculty)
        {
            var list = from t in collection where t.Faculty.Equals(faculty) select t;
            PrintAllStudentFullName(list);
        }

        public void PrintCountStudentByGroup(IEnumerable<Student> collection, string studentGroup)
        {
            var count = (from t in collection where t.Group.Equals(studentGroup) select t).Count();
            System.Console.WriteLine(count);
        }
    }
}
