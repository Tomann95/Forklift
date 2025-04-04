using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forklift.Inspection
{
    class BrakesCheck : Inspection
    {
        public override void PerformCheck()
        {
            Console.WriteLine("🚦 Sprawdzanie hamulców...");
            Console.WriteLine("✅ Hamulce działają poprawnie");
            Console.WriteLine("✅ Brak wycieków płynu hamulcowego");
            Console.WriteLine("✅ Dźwignia hamulca ręcznego sprawna\n");
        }
    }
}
