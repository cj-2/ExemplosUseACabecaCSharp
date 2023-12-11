using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverrideTest
{
    internal class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this); // Estamos passando esse objeto Locksmith
            Jewels? safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        private string? writtenDownCombination = null;
        public void WriteDownComination(string combination)
        {
            writtenDownCombination = combination;
        }

        virtual public void ReturnContents(Jewels? safeContents, Owner owener)
        {
            owener.ReceiveContents(safeContents);
        }
    }
}
