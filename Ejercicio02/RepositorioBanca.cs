using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class RepositorioBanca
    {
        Banca[] array = new Banca[5];
        int count = 0;

        //Metodo
        internal Banca Obtener(string pNumero)
        { //Implementar algoritmo de búsqueda secuencial. 
            return array[int.Parse(pNumero)];
        }
        internal void Agregar(Banca pBanca)
        {
            
            array[count] = pBanca;
            count++;
            
        }
    }

  
}