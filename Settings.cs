using System;
using System.Collections.Generic;

namespace Forklift
{
    class Settings
    {
        public string Language { get; private set; } = "Polski";
        public int SpeedLimit { get; private set; } = 10;
        public int Light { get; private set; } = 10;
        public int SpeedRotation { get; private set; } = 10;

        public void ShowSettings()
        {
            Console.Clear();
            Console.WriteLine("=== USTAWIENIA ===");
            DisplayTable();

            Console.Write("Podaj nowy limit prędkości: ");
            if (int.TryParse(Console.ReadLine(), out int newSpeed))
            {
                SpeedLimit = newSpeed;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość!");
            }

            Console.Write("Podaj nową jasność wyświetlacza: ");
            if (int.TryParse(Console.ReadLine(), out int newLight))
            {
                Light = newLight;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość!");
            }

            Console.Write("Podaj nową prędkość obrotu kierownicy: ");
            if (int.TryParse(Console.ReadLine(), out int newSpeedRotation))
            {
                SpeedRotation = newSpeedRotation;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość!");
            }

            Console.Clear();
            Console.WriteLine("Nowe ustawienia:");
            DisplayTable();
        }

        private void DisplayTable()
        {
            Console.WriteLine("+------------------------+----------------+");
            Console.WriteLine("| Parametr               | Wartość        |");
            Console.WriteLine("+------------------------+----------------+");
            Console.WriteLine($"| Limit prędkości       | {SpeedLimit} km/h   |");
            Console.WriteLine($"| Jasność wyświetlacza  | {Light}            |");
            Console.WriteLine($"| Prędkość kierownicy   | {SpeedRotation}            |");
            Console.WriteLine("+------------------------+----------------+");
        }
    }
}

    

