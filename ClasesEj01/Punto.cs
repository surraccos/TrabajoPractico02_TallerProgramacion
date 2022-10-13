namespace ClasesEj01
{

    public class Punto
    {
        //Atributos de la clase
        public double iX;
        public double iY;

        //Propiedades X e Y
        public double X
        {
            get { return this.iX; }
            set { this.iX = value; }
        }

        public double Y
        {
            get { return this.iY; }
            set { this.iY = value; }
        }

        //Constructor Punto
        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        //Métodos 
        //Método de calcular distancia desde ese punto

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(pPunto.X - X, 2) + Math.Pow(pPunto.Y - Y, 2));
        }

    }
}