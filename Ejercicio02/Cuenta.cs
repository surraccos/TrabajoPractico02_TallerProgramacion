using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Cuenta
    {
        //Atributos de la clase
        public double iSaldo;
        public Moneda iMoneda;

        //Propiedades 
        public double Saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }

        //Constructor
        public Cuenta(Moneda pMoneda)
        {
            iSaldo = 0;
            iMoneda = pMoneda;
        }

        public Cuenta (double pSaldoInicial, Moneda pMoneda)
        {
            iSaldo = pSaldoInicial;
            iMoneda = pMoneda;
        }

        //Metodos
        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo = iSaldo + pSaldo;
        }

        public Boolean DebitarSaldo(double pSaldo)
        {
            if (iSaldo <= pSaldo)
            {
                this.iSaldo = iSaldo - pSaldo;
                return true;
            }
            else return false;
        }

        public Double ConvertirADolar(double pMonto)
        {
            return pMonto / iMoneda.iValor;
        }
        public Double ConvertirAPesos(double pMonto)
        {
            return pMonto*iMoneda.iValor;
        }

    }
}
