using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество старушек ожидающих очередь");
            int receptionTimeMinute = 10;
            string userInput = Console.ReadLine();
            int numberOfWaiting;
            if (int.TryParse(userInput, out numberOfWaiting))
            {
                if (numberOfWaiting != 0)
                {
                    byte minutesInOneHour = 60;
                    int waitingForHours = numberOfWaiting * receptionTimeMinute / minutesInOneHour;
                    int waitingForminutes = numberOfWaiting * receptionTimeMinute % minutesInOneHour;
                    Console.WriteLine("Время ожидания - " + waitingForHours + " час " + waitingForminutes + " минут");
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
