using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Creador
    {
        public const int QuieroVino_tinto = 1;
        public const int Quiero_Cerveza = 2;

        public static BebidaAlcoholica OrdenBebida(int orden) 
        { 
            switch(orden)
            {
                case QuieroVino_tinto:
                    return new VinoTinto();
                case Quiero_Cerveza:
                    return new Cerveza();

                default: return null;
            }

        }


    }
}
