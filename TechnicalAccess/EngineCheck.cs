using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forklift.Inspection
{
    class EngineCheck : Inspection
    {
        public override void PerformCheck()
        {
            Console.WriteLine("🔧 Sprawdzanie silnika...");
            Console.WriteLine("✅ Poziom oleju: OK");
            Console.WriteLine("✅ Brak wycieków oleju");
            Console.WriteLine("✅ Silnik uruchamia się poprawnie\n");
        }
    }
}
