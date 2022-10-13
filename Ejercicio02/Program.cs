using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio02
{
    public class Program
    {
        static void Main(string[] args)
        { //implementar un ciclo donde se evalúe una entrada 
            Console.WriteLine("Presione:");
            Console.WriteLine("Gestion de cuentas");
            Console.WriteLine("        1. Crear cuenta unificada");

            Console.WriteLine("Operaciones");
            Console.WriteLine("        2. Pagar con débito");
            Console.WriteLine("        3. Pagar en cuotas");
            Console.WriteLine("        4. Depositar dinero");
            Console.WriteLine("        5. Extraer dinero");

            Console.WriteLine("Transferencias");
            Console.WriteLine("        6. Transferir dolares a pesos");
            Console.WriteLine("        7. Transferir pesos a dolares");
            double opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Fachada fachada = new Fachada();

            Console.WriteLine("Ingrese su DNI: ");
            string dni = Convert.ToString(Console.ReadLine());            

            switch (opcion)
            {
                case 1:
                    {
                        Console.Write("Ingrese el nombre y apellido del titular: ");
                        string NombreApellido = Convert.ToString(Console.ReadLine());
                        fachada.crearCuentaUnificada(dni, NombreApellido);
                        Console.WriteLine("Se ha creado con éxito una cuenta en pesos y una cuenta en dólares");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main(args);
                        break;
                    }
                case 2:
                    {
                        
                        Console.WriteLine("Indique la cuenta sobre la que desea operar: ");
                        Console.WriteLine("     1. Cuenta en Pesos: ");
                        Console.WriteLine("     2. Cuenta en Dolares: ");
                        double op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.Write("Indique el monto a pagar en pesos: ");
                        double monto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Un momento por favor... ");
                        if (fachada.pagarConDebito(monto, dni, op) == true)   //Verifica que la operación haya sido exitosa
                            Console.WriteLine("Pago realizado con éxito");
                        else 
                            Console.WriteLine("El saldo en la cuenta no es suficiente");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main(args);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Indique la cuenta sobre la que desea operar: ");
                        Console.WriteLine("     1. Cuenta en Pesos: ");
                        Console.WriteLine("     2. Cuenta en Dolares: ");
                        double op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.Write("Indique el monto a depositar en la moneda correspondiente: ");
                        double monto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Un momento por favor... ");
                        var saldo = fachada.depositarDinero(monto, dni, op);  //Devuelve el saldo de la cuenta
                        Console.WriteLine("Depósito exitoso. Saldo actual en la cuenta: "+saldo);
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main(args);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Indique la cuenta sobre la que desea operar: ");
                        Console.WriteLine("     1. Cuenta en Pesos: ");
                        Console.WriteLine("     2. Cuenta en Dolares: ");
                        double op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.Write("Indique el monto a extraer en la moneda correspondiente: ");
                        double monto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Un momento por favor... ");
                        if (fachada.extraerDinero(monto, dni, op) == true)   //Verifica que la operación haya sido exitosa
                            Console.WriteLine("Extracción Exitosa");
                        else
                            Console.WriteLine("El saldo en la cuenta no es suficiente, intente con uno monto menor.");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main(args);
                        break;
                    }
                case 6:
                    {
                        Console.Write("Cantidad de pesos a comprar: $");
                        
                        double monto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Un momento por favor... ");
                        
                        if (fachada.ComprarPesos(monto,dni)==true)   //Verifica que la operación haya sido exitosa
                            Console.WriteLine("Se han comprado: "+monto + " pesos exitosamente");
                        else
                            Console.WriteLine("El saldo en la cuenta no es suficiente, intente con uno monto menor.");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main(args);

                        break; 
                    }

                case 7:
                    {
                        Console.Write("Cantidad de dolares a comprar: USD ");

                        double monto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Un momento por favor... ");

                        if (fachada.ComprarDolares(monto, dni) == true)   //Verifica que la operación haya sido exitosa
                            Console.WriteLine("Se han comprado: " + monto + " dolares exitosamente");
                        else
                            Console.WriteLine("El saldo en la cuenta no es suficiente, intente con uno monto menor.");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main(args);
                        break;
                    }
                    



            }
        }
    }
}