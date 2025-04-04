using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forklift.Inspection
{
      class TechnicalAccess
    {
        public void Access()
        {
            while (true)
            {
                Console.WriteLine("===== WERYFIKACJA STANU TECHNICZNEGO WÓZKA WIDŁOWEGO =====");
                Console.WriteLine("1. Sprawdzenie silnika");
                Console.WriteLine("2. Sprawdzenie układu hydraulicznego");
                Console.WriteLine("3. Sprawdzenie opon");
                Console.WriteLine("4. Sprawdzenie hamulców");
                Console.WriteLine("5. Wykonaj pełny przegląd");
                Console.WriteLine("6. Wyjście");
                Console.Write("Wybierz opcję: ");

                string choice = Console.ReadLine();
                Inspection inspection = null;

                switch (choice)
                {
                    case "1":
                        inspection = new EngineCheck();
                        break;
                    case "2":
                        inspection = new HydraulicsCheck();
                        break;
                    case "3":
                        inspection = new TiresCheck();
                        break;
                    case "4":
                        inspection = new BrakesCheck();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("🔍 Wykonywanie pełnego przeglądu technicznego...\n");
                        new EngineCheck().PerformCheck();
                        new HydraulicsCheck().PerformCheck();
                        new TiresCheck().PerformCheck();
                        new BrakesCheck().PerformCheck();
                        Console.WriteLine("✅ Przegląd zakończony!\n");
                        Console.ReadKey();
                        continue;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("⚠️ Niepoprawny wybór. Spróbuj ponownie.");
                        continue;
                }

                Console.Clear();
                inspection.PerformCheck();
                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
        
