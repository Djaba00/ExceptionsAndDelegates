using System;

namespace Event
{

    public class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            sort.SortEvent += SortListRun;

            List<string> surnames = new List<string>() { "Яковлев", "Симонов", "Дубровин", "Воронин", "Акимов" };

            try
            {
                sort.Read(surnames);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SortListRun(List<string> surnames, int number)
        {
            switch (number)
            {
                case 1:
                    surnames.Sort();
                    Console.WriteLine("Сортирвка А-Я выполнена!");
                    Console.ReadKey();
                    break;
                case 2:
                    surnames.Reverse();
                    Console.WriteLine("Сортирвка Я-А выполнена!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
