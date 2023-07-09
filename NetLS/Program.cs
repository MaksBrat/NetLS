using System;

namespace SquareCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розміри квадрата (сторона):");
            double squareSize = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть координати точки (x, y):");
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            if (IsPointInsideSquare(squareSize, pointX, pointY))
            {
                Console.WriteLine("Точка знаходиться всередині квадрата.");
            }
            else
            {
                Console.WriteLine("Точка знаходиться поза квадратом.");
            }
        }

        static bool IsPointInsideSquare(double squareSize, double pointX, double pointY)
        {
            // перевіряємо чи точка знаходиться всередині квадрата
            if (pointX >= 0 && pointX <= squareSize && pointY >= 0 && pointY <= squareSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
