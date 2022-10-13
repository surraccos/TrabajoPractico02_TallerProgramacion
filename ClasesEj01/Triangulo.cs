namespace ClasesEj01
{
    public class Triangulo
    {
        //Atributos de la clase
        public Punto iPunto1;
        public Punto iPunto2;
        public Punto iPunto3;

        //Propiedades
        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
            set { this.iPunto3 = value; }
        }

        public double Area
        {
            get
            {
                return this.CalcularArea();
            }
            set
            {
                return
                    ;
            }
        }

        public double Perimetro
        {
            get
            {
                return CalcularPerimetro();
                ;
            }
            set
            {
                return
                    ;
            }
        }




        //Constructor Triangulo a partir de los puntos
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            iPunto1 = pPunto1;
            iPunto2 = pPunto2;
            iPunto3 = pPunto3;
        }

        //Métodos 
        public double CalcularArea()
        //Mediante la formula de Herón
        //s = (a+b+c)/2
        //Área = √(s·(s-a)·(s-b)·(s-c))
        {
            var s = CalcularPerimetro() / 2;
            var a = iPunto1.CalcularDistanciaDesde(iPunto3);
            var b = iPunto2.CalcularDistanciaDesde(iPunto1);
            var c = iPunto3.CalcularDistanciaDesde(iPunto2);
            return Math.Pow((s * (s - a) * (a - b) * (s - c)), 0.5);

        }

        public double CalcularPerimetro()
        {
            return
                iPunto1.CalcularDistanciaDesde(iPunto3)
                + iPunto2.CalcularDistanciaDesde(iPunto1)
                + iPunto3.CalcularDistanciaDesde(iPunto2);
        }
    }
}
