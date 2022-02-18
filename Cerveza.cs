using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Cerveza : BebidaAlcoholica
    {
        public override int GradodeAlcohol()
        {
            return 5;
        }
    }
}
