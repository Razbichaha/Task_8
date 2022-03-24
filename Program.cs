using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество старушек ожидающих очередь");
            int receptionTimeMin = 10;
            string temp = Console.ReadLine();
            int numberOfWaiting;
            if (int.TryParse(temp, out numberOfWaiting))
            {
                if (numberOfWaiting != 0)
                {
                    int hour = numberOfWaiting * receptionTimeMin / 60;
                    int minute = numberOfWaiting * receptionTimeMin % 60;
                    Console.WriteLine("Время ожидания - " + hour + " час " + minute + " минут");
                }
                else
                {
                    Console.WriteLine("Поздравляем очереди нет вы можете пройти");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не корректные данные \nв следующий раз будте внимательны\nвводите колличество ожидающих бабулек");
            }

        
        }
    }
}
