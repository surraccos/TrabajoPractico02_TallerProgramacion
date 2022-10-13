using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Banca
    {
        //
        public Cuenta iCuentaEnPesos;
        public Cuenta iCuentaEnDolares;
        public string iTitular;
        public string iNumero;

        //Propiedades
        public Cuenta CuentaEnPesos
        {
            get{ return this.iCuentaEnPesos;}
            set{ this.iCuentaEnPesos = value;}
        }

        public Cuenta CuentaEnDolares
        {
            get { return this.iCuentaEnDolares; }
            set { this.iCuentaEnDolares = value; }
        }

        public string Numero
        {
            get { return this.iNumero; }
            set { this.iNumero = value; }
        }

        public string Titular
        {
            get { return this.iTitular; }
            set { this.iTitular = value; }
        }

        //Constructor Banca
        public Banca(string pNumero, string pTitular)
        {
            var dolar = new Moneda("USD","Dolar","USD");
            var peso = new Moneda("ARS", "Peso Argentino", "ARS");
            iCuentaEnDolares = new Cuenta(dolar);
            iCuentaEnPesos = new Cuenta(peso);
            iTitular = pTitular;
            iNumero = pNumero;
        }

        //Métodos:
        public Double ComprarPesos(double pMonto)
        {
            var montoEnDolares = iCuentaEnDolares.ConvertirADolar(pMonto);
            if (iCuentaEnDolares.iSaldo >= montoEnDolares)
            {
                iCuentaEnDolares.iSaldo -= montoEnDolares;
                iCuentaEnPesos.iSaldo += pMonto;
                return iCuentaEnPesos.iSaldo;
            }
            else return 0;
        }

        public Double ComprarDolares(double pMonto)
        {
            var montoEnPesos = iCuentaEnPesos.ConvertirAPesos(pMonto);
            if (iCuentaEnPesos.iSaldo >= montoEnPesos)
            {
                iCuentaEnPesos.iSaldo -= montoEnPesos;
                iCuentaEnDolares.iSaldo += pMonto;
                return iCuentaEnDolares.iSaldo;
            }
            else return 0;
        }
    }
}


