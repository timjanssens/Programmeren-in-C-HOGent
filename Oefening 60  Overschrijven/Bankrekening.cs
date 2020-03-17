using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_60__Overschrijven
{
    class Bankrekening
    {
        private decimal _saldo;
        public void Stort(decimal bedrag) 
        { 
            _saldo = _saldo + bedrag; 
        }
        public void HaalAf(decimal bedrag)
        { 
            _saldo = _saldo - bedrag; 
        }
        public decimal Saldo()
        { 
            return _saldo; 
        }        //...SchrijfOver... 

        public void SchrijfOver(Bankrekening r2op, decimal bedrag)
        {
            r2op.Stort(bedrag);
            this.HaalAf(bedrag);
        }

    }
}
