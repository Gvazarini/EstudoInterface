using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class BrazilTaxSerice : ITaxService 
    {
        public double Tax(double ammount)
        {
            if (ammount <= 100)
            {
                return ammount *0.2;
            }
            else
            {
                return ammount * 0.15;
            }
        }
    }
}
