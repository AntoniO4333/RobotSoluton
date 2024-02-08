
using System.Drawing;

namespace RobotLibrary
{
    /// <summary>
    /// Класс робота, который двигается в случайном направлении.
    /// </summary>
    public class Robot
    {
        private (int, int) coord;
        private int dir;
        private string name;

        /// <summary>
        /// Робот с координатами x, y
        /// </summary>
        /// <param name="x">движение робота по горизонтали</param>
        /// <param name="y">движение робота по вертикали</param>
        public Robot(int x, int y)
        {
            coord = (x, y);
        }
        /// <summary>
        /// направление и координаты робота
        /// </summary>
        /// <returns>Возвращает направления и координаты робота</returns>
        public override string ToString()
        {
            return $"{DirName(dir)} ({coord.Item1} , {coord.Item2})";
        }

        /// <summary>
        /// Направление задается случайно
        /// </summary>
        private void RandomizeDirection()
        {
            Random random = new Random();
            dir = random.Next(4); // Ген случ направления (0-3)
        }

        /// <summary>
        /// Название направления
        /// </summary>
        /// <param name="dir">Переменная, задающая направление</param>
        /// <returns></returns>
        private static string DirName(int dir)
        {
            switch (dir)
            {
                case 0: return "вверх";
                case 1: return "вправо";
                case 2: return "вниз";
                case 3: return "влево";
                default: return "неопределенное направление";
            }
        }

        /// <summary>
        /// В зависимости от направления dir робот перемещается в определенном направлении
        /// </summary>
        public void Move()
        {
            RandomizeDirection();
            switch (dir)
            {
                case 0: // Вверх
                    coord.Item2++;
                    break;
                case 1: // Вправо
                    coord.Item1++;
                    break;
                case 2: // Вниз
                    coord.Item2--;
                    break;
                case 3: // Влево
                    coord.Item1--;
                    break;
            }
            Console.WriteLine(ToString());
        }  
    }
}
