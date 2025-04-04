using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forklift
{
    class Language
    {
        public string Lang { get; private set; } = "Polski";

        public void ChangeLanguage()
        {
            Console.Clear();
            Console.WriteLine("=== JĘZYK ===");
            Console.WriteLine("1. Polski");
            Console.WriteLine("2. English");
            Console.Write("Wybierz język: ");

            string langChoice = Console.ReadLine();
            if (langChoice == "1")
            {
                Lang = "Polski";
            }
            else if (langChoice == "2")
            {
                Lang = "English";
            }
            else
            {
                Console.WriteLine("Niepoprawny wybór.");
            }
            Console.WriteLine("Obecny język: " + Lang);
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić...");
            Console.ReadKey();
        }
    }
}
