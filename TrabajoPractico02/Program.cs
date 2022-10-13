using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEj01; 

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione:");
            Console.WriteLine("1 - Calcular distancia entre 2 puntos");
            Console.WriteLine("2 - Calcular perimetro y area de un triangulo");
            Console.WriteLine("3 - Calcular perimetro y area de un circulo");
            double opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Fachada fachada = new();
            switch (opcion)
            {
                case 1:
                    {
                        Console.Write("Ingrese la coordenada X del Punto 1: ");
                        double p1X = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del Punto 1: ");
                        double p1Y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada X del Punto 2: ");
                        double p2X = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del Punto 2: ");
                        double p2Y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine ("La distancia entre los puntos es: " + fachada.DistanciaEntrePuntos(p1X,p1Y,p2X,p2Y));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Ingrese la coordenada X del Punto 1: ");
                        double pt1X = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del Punto 1: ");
                        double pt1Y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada X del Punto 2: ");
                        double pt2X = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del Punto 2: ");
                        double pt2Y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada X del Punto 3: ");
                        double pt3X = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del Punto 3: ");
                        double pt3Y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El perímetro del triángulo es: " + fachada.PerimetroTriangulo(pt1X, pt1Y, pt2X, pt2Y,pt3X,pt3Y));
                        Console.WriteLine("El área del triángulo es: " + fachada.AreaTriangulo(pt1X, pt1Y, pt2X, pt2Y, pt3X, pt3Y));
                        break;
                    }
                case 3:
                    {
                        Console.Write("Ingrese la coordenada X del Centro: ");
                        double cX = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del Centro: ");
                        double cY = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el radio del circulo: ");
                        double cRadio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El perímetro del circulo es: " + fachada.PerimetroCirculo(cX, cY, cRadio));
                        Console.WriteLine("El area del circulo es: " + fachada.AreaCirculo(cX, cY, cRadio));
                    }

                break;
            }    

        }
    }
}
