using System;

namespace OtherCicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            string lang = "ru";

            switch (lang)
            {
                case "ru":
                    Console.WriteLine("Привет мир!");
                    break;
                case "en":
                    Console.WriteLine("Hello world!");
                    break;
                default:
                    Console.WriteLine("Локализация не найдена");
                    break;
                case "fr":
                    Console.WriteLine("Bonjour le monde!");
                    break;
                case "jp":
                    Console.WriteLine("こんにちは。");
                    break;

            }



        }
    }
}
