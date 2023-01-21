using System;
namespace DelegatesAndExecptions
{
	public class MyExceptions
	{
        public static void Exceptions()
        {
            var console = string.Empty;
            while (console != "exit")
            {
                try
                {

                    Console.Write("Введите номер ошибки: ");
                    console = Console.ReadLine();
                    switch (console)
                    {
                        case "1":
                            int zero = 0;
                            int zeroEx = 1 / zero;
                            break;
                        case "2":
                            throw new Exception("Не люблю цифру 2, попробуй еще раз!:)");
                            break;
                        case "3":
                            object name = "Tim";
                            int c = (int)name;
                            break;
                        case "4":
                            string[] array = new string[1];
                            var arrayEWx = array[2];
                            break;
                        case "5":
                            string filePath = "";
                            File.Open(filePath, FileMode.Open);
                            break;
                        case "exit":
                            Console.WriteLine("Завершение программы...");
                            break;
                        default:
                            throw new Exception("Некорректное значение!\nДоступные команды: 1 - 4, exit");
                            break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Возникло исключение DivideByZeroException");
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Возникло исключение InvalidCastException");
                }
                catch (Exception ex)
                {
                    if (ex is IndexOutOfRangeException)
                        Console.WriteLine("Возникло исключение IndexOutOfRangeException");
                    else
                        Console.WriteLine(ex.Message + $"\nТип исключения: {ex.GetType()}");
                        
                }
            }
		}
	}
}

