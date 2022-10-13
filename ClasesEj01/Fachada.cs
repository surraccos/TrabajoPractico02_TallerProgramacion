using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEj01
{
    public class Fachada
    {
        public double DistanciaEntrePuntos(double p1X, double p1Y, double p2X, double p2Y)
        {
            Punto P1 = new(p1X, p1Y);
            Punto P2 = new(p2X, p2Y);
            return P2.CalcularDistanciaDesde(P1);
        }

        public double PerimetroTriangulo(double pt1X, double pt1Y, double pt2X, double pt2Y, double pt3X, double pt3Y)
        {
            Punto P1 = new(pt1X, pt1Y);
            Punto P2 = new(pt2X, pt2Y);
            Punto P3 = new(pt3X, pt3Y);
            Triangulo T = new(P1, P2, P3);
            return T.CalcularPerimetro();
        }

        public double AreaTriangulo(double pt1X, double pt1Y, double pt2X, double pt2Y, double pt3X, double pt3Y)
        {
            Punto P1 = new(pt1X, pt1Y);
            Punto P2 = new(pt2X, pt2Y);
            Punto P3 = new(pt3X, pt3Y);
            Triangulo T = new(P1, P2, P3);
            return T.CalcularArea();
        }

        public double AreaCirculo(double cX, double cY, double cRadio)
        {
            Punto P1 = new(cX, cY);
            Circulo C = new(P1, cRadio);
            return C.CalcularArea();
        }

        public double PerimetroCirculo(double cX, double cY, double cRadio)
        {
            Punto P1 = new(cX, cY);
            Circulo C = new(P1, cRadio);
            return C.CalcularPerimetro();
        }
    }
}
