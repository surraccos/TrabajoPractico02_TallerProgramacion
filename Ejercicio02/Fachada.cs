using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    
    public class Fachada
    {
        RepositorioBanca RB = new();
        public Boolean crearCuentaUnificada(string pNombreApellido, string pDNI)
        {
            Banca B = new(pDNI, pNombreApellido);
            RB.Agregar(B);
            return true;
        }

        public Boolean pagarConDebito(double pMonto, string pDNI, double pCuenta)
        {
            Banca B = RB.Obtener(pDNI);
            if (pCuenta == 2)
            {
                double montoEnDolares = pMonto / B.CuentaEnDolares.iMoneda.iValor;
                return B.CuentaEnDolares.DebitarSaldo(montoEnDolares); //Devuelve el resultado de si fué exitoso o no
            }
            else 
                return B.CuentaEnPesos.DebitarSaldo(pMonto);
            
        }
        public double depositarDinero(double pMonto, string pDNI, double pCuenta)
        {
            Banca B = RB.Obtener(pDNI);
            if (pCuenta == 2)
            {
                B.CuentaEnDolares.AcreditarSaldo(pMonto);
                return B.CuentaEnDolares.Saldo;
            }
            else
            {
                B.CuentaEnPesos.AcreditarSaldo(pMonto);
                return B.CuentaEnPesos.Saldo;
            }

        }
        public Boolean extraerDinero(double pMonto, string pDNI, double pCuenta)
        {
            Banca B = RB.Obtener(pDNI);
            if (pCuenta == 2)
                return B.CuentaEnDolares.DebitarSaldo(pMonto); //Devuelve el resultado de si fué exitoso o no
            else
                return B.CuentaEnPesos.DebitarSaldo(pMonto); //Devuelve el resultado de si fué exitoso o no

        }

        public Boolean ComprarPesos(double pMonto,string pDNI)
        {
            Banca B = RB.Obtener(pDNI);
            var res = B.ComprarPesos(pMonto);
            if (res > 0)
                return true;
            else return false; 

        }
        public Boolean ComprarDolares(double pMonto, string pDNI)
        {
            Banca B = RB.Obtener(pDNI);
            var res = B.ComprarPesos(pMonto);
            if (res > 0)
                return true;
            else return false;

        }
    }
}
