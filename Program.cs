using System;
using System.Text;
using System.IO;

namespace LukaszGadek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }            
        }
        private static bool MainMenu()
        {
            Console.WriteLine("************************************"); 
            Console.WriteLine("Zaliczenie Programowanie 1.");
            Console.WriteLine("Informatyka Niestacjonarne");
            Console.WriteLine("Data: 03.02.2024 Autor: Łukasz Gadek");
            Console.WriteLine("************************************");
            Console.WriteLine("\nMenu polecen:\n");
            Console.WriteLine("1. Zadanie 1");
            Console.WriteLine("2. Zadanie 2");
            Console.WriteLine("3. Zadanie 3");
            Console.WriteLine("4. Zadanie 4");
            Console.WriteLine("5. Koniec programu");
            Console.Write("\nWybierz opcje:");

            switch (Console.ReadLine())
            {
                case "1":
                    TaskOne();
                    return true;
                case "2":
                    TaskTwo();
                    return true;
                case "3":
                    TaskThree();
                    return true;
                case "4":
                    TaskFour();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
        private static void TaskOne()
        {
            Console.Clear();
            Console.WriteLine("Zadanie 1.");
            TheEnd();
        }
        private static void TaskTwo()
        {
            Console.Clear();
            Console.WriteLine("Zadanie 2.");
            TheEnd();
        }
        private static void TaskThree()
        {
            Console.Clear();
            Console.WriteLine("Zadanie 3.");
            TheEnd();
        }
        private static void TaskFour()
        {
            Console.Clear();
            Console.WriteLine("Zadanie 4.");
            TheEnd();
        }
        private static void TheEnd()
        {
            Console.WriteLine("\r\nWcisnij ENTER by powrocic do glownego MENU");
            Console.ReadKey();
            Console.Clear();
        }
    }
}