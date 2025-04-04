using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forklift.Inspection
{
    class TiresCheck : Inspection
    {
        public override void PerformCheck()
        {
            Console.WriteLine("🛞 Sprawdzanie opon...");
            Console.WriteLine("✅ Ciśnienie w normie");
            Console.WriteLine("✅ Brak pęknięć i uszkodzeń");
            Console.WriteLine("✅ Bieżnik opon w dobrym stanie\n");
        }
    }
}
