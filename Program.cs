using Forklift.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forklift
{
    class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("=====MENU WÓZKA WIDŁOWEGO=====");
                Console.WriteLine();
                Console.WriteLine("1. Ogólne");
                Console.WriteLine("2. Ustawienia");
                Console.WriteLine("3. Język");
                Console.WriteLine("4. Weryfikacja stanu technicznego wózka widłowego");
                Console.WriteLine("5. Wyjście");
                Console.Write("Wybierz opcję: ");

                string choice = Console.ReadLine();

                GeneralInfo generalInfo = new GeneralInfo();
                Settings settings = new Settings();
                TechnicalAccess technicalAccess = new TechnicalAccess();
                Language language = new Language();



                switch (choice)
                {
                    case "1":
                        generalInfo.ShowGeneralInfo();
                        break;
                    case "2":
                        settings.ShowSettings();
                        break;
                    case "3":
                        language.ChangeLanguage();
                        break;
                    case "4":
                        technicalAccess.Access();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Niepoprawny wybór!");
                        break;
                }
            }
        }
    }
}
        
    

    

