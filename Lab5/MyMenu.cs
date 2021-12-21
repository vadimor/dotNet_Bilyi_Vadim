using System;


namespace Lab5
{
    class MyMenu
    {
        public MyCollection<Lab4.DataStudLab4> Collection{ set; get; }

        public void PrintTable()
        {
            Console.WriteLine("{0,-10} |{1,-10} |{2,-10} |{3,-13} |{4,-15}", "Name", "Surname", "Patronymic", "Date of Birth", "Group");
            Lab4.DataStudLab4 temp;
            foreach (var item in Collection)
            {
                temp = ((Lab4.DataStudLab4)item);
                Console.WriteLine("{0,-10} |{1,-10} |{2,-10} |{3,-13} |{4,-15}", temp.Name, temp.Surname, temp.Patronimic, $"{temp.Birthday.Day}.{temp.Birthday.Month}.{temp.Birthday.Year}", temp.IndexGroup);
            }
        }

        public delegate bool DelegateAverage(Lab4.DataStudLab4 item);
        public float AverageAge(DelegateAverage method)
        {
            var count = 0;
            float averageAge = 0;
            for (var i = 0; i < Collection.Size; i++)
            {
                if (method(Collection[i]))
                {
                    count++;
                    averageAge += float.Parse(Collection[i].Old.Split('.')[2].Split(' ')[0]);
                }
            }

            if (count < 1)
            {
                return 0;
            }

            return averageAge / (float)count;
        }

        public float AverageAcademicPreformance(DelegateAverage method)
        {
            var count = 0;
            float averageAcademicPreformance = 0;
            for (var i = 0; i < Collection.Size; i++)
            {
                if (method(Collection[i]))
                {
                    count++;
                    averageAcademicPreformance += Collection[i].AcademicPreformance;
                }
            }

            if (count < 1)
            {
                return 0;
            }

            return averageAcademicPreformance / (float)count;
        }

        public MyMenu(MyCollection<Lab4.DataStudLab4>collection)
        {
            Collection = collection;
        }
    }
}
