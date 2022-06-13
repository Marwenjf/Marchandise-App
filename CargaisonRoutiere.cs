namespace transport
{
    class CargaisonRoutiere : Cargaison
    {
        public CargaisonRoutiere(int distance) : base(distance)
        {
        }

        public override double cout()
        {
            if (getVolumeTotal() < 380000)
            {
                return 4*distance*getPoidsTotal();
            }
            else
            {
                return 6*distance*getPoidsTotal();
            }
        }
        public override string ToString()
        {
            return "Cargaison Routière Distance: "+distance;
        }
    }
}