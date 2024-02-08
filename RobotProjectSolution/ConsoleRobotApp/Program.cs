using RobotLibrary2;
using System;
using System.Threading;

namespace RobotLibrary
{
    public class Program
    {
        public static void Main()
        {
            Robot[] robots = new Robot[3];

            // 3 робота
            for (int i = 0; i < 3; i++)
            {
                robots[i] = new Robot(0, 0);
            }

            // Создаем потоки для каждого робота
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                int robotNumber = i + 1; // Номер робота для вывода
                threads[i] = new Thread(() =>
                {

                    // 10 шагов на робота
                    for (int j = 0; j < 10; j++)
                    {
                        robots[robotNumber - 1].Move(robotNumber);
                        Thread.Sleep(100); 
                    }
                });

                // номер робота как параметр в замыкание
                threads[i].Start();
            }

            // Ожидаем завершения всех потоков
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }
    }
}
