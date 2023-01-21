using System;
namespace Event
{

    public class Sort
	{

        public delegate void SortList(List<string> surnames, int number);
        public event SortList SortEvent;

        public void Read(List<string> surnames)
        {
            Console.Write("Выберите тип сортировки(1-2): ");

            int type = Convert.ToInt32(Console.ReadLine());

            if (type != 1 && type != 2)
                throw new Exception("Недопустимое значение!");

            OnSortCompleted(surnames, type);
        }

        protected virtual void OnSortCompleted(List<string> surnames, int number)
        {
            SortEvent?.Invoke(surnames, number);
        }
    }

    
}

