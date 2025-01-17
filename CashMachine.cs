using System;
namespace ZooSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            ZooWorker zooWorker = new ZooWorker();

            // Подписываемся на событие "Лев голоден"
            lion.LionHungry += () => zooWorker.FeedLion();

            // Симуляция дня льва
            for (int hour = 1; hour <= 10; hour++)
            {
                Console.WriteLine($"Час {hour}:");
                lion.Walk(1); // Лев гуляет по 1 часу за раз

                if (hour == 10) // В конце дня сбрасываем часы прогулки
                {
                    lion.ResetWalkingHours();
                }

                Console.WriteLine();
            }
        }
    }
}
