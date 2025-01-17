using System;

namespace ZooSim
{
    // Класс, описывающий сущность "Лев"
    public class Lion
    {
        public event Action LionHungry; // Событие, когда лев голоден
        private int walkingHours;

        public void Walk(int hours)
        {
            walkingHours += hours;
            Console.WriteLine($"Лев гуляет {hours} час(ов). Всего гулял: {walkingHours} час(ов).");

            // Если лев гулял более 5 часов, он голоден
            if (walkingHours > 5)
            {
                OnLionHungry();
            }
        }

        protected virtual void OnLionHungry()
        {
            LionHungry?.Invoke(); // Вызываем событие
        }

        public void ResetWalkingHours()
        {
            walkingHours = 0;
            Console.WriteLine("Часы прогулки льва сброшены.");
        }
    }
}