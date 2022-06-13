namespace transport
{
    class CargaisonAerienne:Cargaison
    {
        public CargaisonAerienne(int distance) : base(distance)
        {
        }

        public override double cout()
        {
            if (getVolumeTotal() < 80000)
            {
                return 10*distance*getPoidsTotal();
            }
            else
            {
                return 12*distance*getPoidsTotal();
            }
        }

        public override string ToString()
        {
            return "Cargaison Aérienne Distance: "+distance;
        }
    }
}