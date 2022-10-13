using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Moneda
    {
        //Atributos de la clase
        public string iCodigoISO;
        public string iNombre;
        public string iSimbolo;
        public double iValor; 

        //Propiedades 
        public string CodigoISO
        {
            get { return this.iCodigoISO; }
            set { this.iCodigoISO = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public string Simbolo
        {
            get { return this.iSimbolo; }
            set { this.iSimbolo = value; }
        }

        public double Valor
        {
            get { return this.iValor; }
            set { this.iValor = value; }
        }

        //Constructor Moneda
        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            iNombre = pNombre;
            iSimbolo = pSimbolo;
            iCodigoISO=pCodigoISO;
            if (pNombre == "Dolar")
            { iValor = 280; }

        }

        //Métodos 
        
    }
}
