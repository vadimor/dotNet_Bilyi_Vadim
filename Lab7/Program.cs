using Lab7.Model;
using Lab7.Provider;
using Lab7.Service;

namespace Lab7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var studCreator = new StudentCreatorService(new StudentCreatorProvider());
            var studCollection = new CollectionService<Student>();
            var ui = new UIService();
            var list = studCreator.GetStudent();
            for (var i = 0; i < list.Capacity; i++)
            {
                studCollection.Add(list[i]);
            }

            ui.PrintAllStudentByFaculty(studCollection, "KIT");
        }
    }
}
