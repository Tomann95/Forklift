using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forklift.Inspection
{
    class HydraulicsCheck : Inspection
    {
        public override void PerformCheck()
        {
            Console.WriteLine("🔩 Sprawdzanie układu hydraulicznego...");
            Console.WriteLine("✅ Brak wycieków");
            Console.WriteLine("✅ Ciśnienie oleju w normie");
            Console.WriteLine("✅ Podnoszenie działa prawidłowo\n");
        }
    }
}
