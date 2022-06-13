namespace transport
{
    class Marchandise
    {
        private static int nbMarchandises;
        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        private double poids;
        public double Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        private double volume;
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Marchandise(double poids,double volume)
        {
            this.numero = ++nbMarchandises; this.poids = poids; this.volume = volume;
        }

        public override string ToString()
        {
            return "Numéro= "+numero+", Poids= "+poids+", Volume= "+volume;
        }
    }
}