﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class VinoTinto : BebidaAlcoholica
    {
        public override int GradodeAlcohol()
        {
            return 20;
        }
    }
}
