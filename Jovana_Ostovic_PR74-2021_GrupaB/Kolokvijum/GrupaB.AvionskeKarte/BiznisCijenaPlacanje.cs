using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
    public class BiznisCijenaPlacanje : INacinPlacanja
    {
        public double OdrediCijenu(double osnovnaCijena)
        {
            return 2.2 * osnovnaCijena;
        }
    }
}
