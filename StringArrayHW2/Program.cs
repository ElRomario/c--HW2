using System;
/*C# 03 (20 сентября 2023)
Массивы и строки
Срок: к следующему занятию, понедельнику 25 сентября

1. Пользователь вводит три измерения: длину, ширину и высоту. Создайте
трёхмерный прямоугольный массив такого размера.
Заполните его случайными числами от -5 до +5. Распечатайте массив по слоям:
сначала первый этаж, потом второй этаж, и так далее.

Найдите сумму и среднее арифметическое всех элементов, минимальный
и максимальный элемент.
    
2. Пользователь вводит предложение. Распечатайте предложение
в стиле магистра Йоды: первое слово станет последним, второе предпоследним и
так далее.
    
You must not fear -> fear not must You
*/
namespace StringArrayHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height:");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter width:");
            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter length:");
            int length = Int32.Parse(Console.ReadLine());

            int[,,] rectangle = new int[height, width, length];

            Random random =new();

            for(int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        rectangle[i, j, k] = random.Next(-5, 6);
                    }
                }
            }
            Print(rectangle);
            static void Print(int[, ,] rectangle)
            {
                
                for (int i = 0; i < rectangle.GetLength(0); i++)
                {
                    Console.WriteLine($"{i + 1} floor");
                    for (int j = 0; j < rectangle.GetLength(1); j++)
                    {
                        Console.WriteLine(" ");
                        for (int k = 0; k < rectangle.GetLength(2); k++)
                        {  
                            Console.WriteLine(rectangle[i,j,k]);
                            Console.WriteLine(" ");
                        }
                    }
                    
                }
            }
        }
    }
}
