using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateRectangle
{
    class Program
    {

       
        static void DrawRectangle(int height, int weight)
        {
            Console.WriteLine("Задайте символ, которым рисовать контур прямоугольника => ");
            char x = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("-",30);

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= weight; j++)
                {


                    if (i == 1 & j == 1) Console.Write(x);
                    else if (i == 1 & (j > 1 & j < weight)) Console.Write(x);
                    else if (i == 1 & j == weight) Console.Write(x);
                    else if (i == 1 & (j > 1 & j < weight)) Console.Write(x);
                    else if ((i > 1 & i < height) & j == 1) Console.Write(x);
                    else if (i == height & j == 1) Console.Write(x);
                    else if (i == 1 & (j > 1 & j < weight)) Console.Write(x);
                    else if ((i > 1 & i < height) & (j > 1 & j < weight)) Console.Write(" ");
                    else if ((i > 1 & i < height) & (j == weight)) Console.Write(x);
                    else if (i == height & (j > 1 & j < weight)) Console.Write(x);
                    else if (i == height & j == weight) Console.Write(x);






                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите высоту прямоугольника => ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника => ");
            int y = Convert.ToInt32(Console.ReadLine());

           

            DrawRectangle(x, y);
            Console.ReadKey();



        }
    }
}
