using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
    public class PromoCijenaPlacanje : INacinPlacanja
    {
        public double OdrediCijenu(double osnovnaCijena)
        {
            return 0.7 * osnovnaCijena;
        }
    }
}
