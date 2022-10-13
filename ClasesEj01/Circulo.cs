namespace ClasesEj01
{
    public class Circulo
    {

        //Atributos de la clase
        public double iRadio;
        public Punto iCentro;

        //Propiedades
        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        public double Area
        {
            get { return this.CalcularArea(); }
            set { this.iRadio = Math.Pow((value / Math.PI), 0.5); }
        }


        public double Perimetro
        {
            get { return this.CalcularPerimetro(); }
            set { this.iRadio = (value / (2 * Math.PI)); }
        }

        //Constructor Circulo a partir de coordenadas
        public Circulo(double pX, double pY, double pRadio)
        {
            iCentro = new Punto(pX, pY);
            iRadio = pRadio;
        }

        //Constructor Circulo a partir del punto
        public Circulo(Punto pPunto, double pRadio)
        {
            iCentro = pPunto;
            iRadio = pRadio;
        }

        //Métodos: Calculo de Perímetro y área
        public double CalcularPerimetro()
        {
            return (2 * Math.PI * this.iRadio);
        }

        public double CalcularArea()
        {
            return (Math.PI * Math.Pow(this.iRadio, 2));
        }



    }
}
