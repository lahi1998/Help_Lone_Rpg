using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IWizard
    {
        void ThrowFrostNova();
        void ThrowMagicMisile();
        void Teleport(int x, int y);
    }
}
