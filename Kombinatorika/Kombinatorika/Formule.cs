using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kombinatorika
{
    class Formule
    {
        public int Permutacije(int n)
        {
            int nRjesenje=1;
            for (int i = 1; i <= n; i++)
            {
                nRjesenje = nRjesenje * i;
            }
            return nRjesenje;
        }
    }
    
    
}
