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
                    ShowList(surnames);
                    Console.Read();
                    break;
                case 2:
                    surnames.Sort();
                    surnames.Reverse();
                    Console.WriteLine("Сортирвка Я-А выполнена!");
                    ShowList(surnames);
                    Console.Read();
                    break;
            }

            void ShowList(List<string> surnames)
            {
                for (int i = 0; i < surnames.Count; i++)
                {
                    if (i < surnames.Count - 1)
                        Console.Write($"{surnames[i]}, ");
                    else
                        Console.Write($"{surnames[i]}.");

                }
            }
        }
    }
}
