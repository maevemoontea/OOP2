using System;
using System.IO;
using System.Text;


namespace OOP2
{
    class Program
    {
        static string baseDirPath = "";
        static string resultDirPath = "";

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SayHello();
            TakeData();
            SayGoodbay();
        }
        static void SayHello()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   *              ООП-2              *                  ");
            Console.WriteLine("   *        Лабораторна Робота       *                  ");
            Console.WriteLine("   *        Сичевської Альони        *                  ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Програма виконує обхід заданого каталогу у пошуках файлів зображень та створює копію структури каталогів із розміщенням замість файлів зображень файлів -- результатів обробки зображень. \n\n");

            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void TakeData()
        {
            string path = "";
            Console.WriteLine("Вкажіть директорію, в якій шукати зображення для обробки. Наприклад: \n D:\\some_folder \n");
            path = Console.ReadLine();
            baseDirPath = SetDirectory(path);

            Console.WriteLine("Вкажіть директорію, в яку розмістити результат: \n");
            path = Console.ReadLine();
            resultDirPath = SetDirectory(path);
        }
        static string SetDirectory(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                return path;
            }
            else
            {
                Console.WriteLine("Вкажіть іншу директорію. Вказана не існує!");
                path = Console.ReadLine();
                return SetDirectory(path);
            }
        }
        static void SayGoodbay()
        {
            Console.WriteLine("\n Good luck! \n\n Press any key to exit");
            Console.ReadKey();
        }
    }
}
