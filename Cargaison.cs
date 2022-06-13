using System;
using System.Collections.Generic;
using System.Linq;

namespace transport
{
    abstract class Cargaison
    {
        protected int distance;
        protected List<Marchandise> marchandises = new List<Marchandise>();
        public Cargaison(int distance)
        {
            this.distance = distance;
        }
        public void Add(Marchandise marchandise)
        {
            marchandises.Add(marchandise);
        }
        public void Afficher()
        {
            marchandises.ForEach(
                marchandise => Console.WriteLine(marchandise.ToString())
            );
        }
        public Marchandise consulterMarchandise(int num)
        {
            foreach (Marchandise marchandise in marchandises)
            {
                if (marchandise.Numero == num) return marchandise;
            }
            //return marchandises.Single(marchandise=>marchandise.Numero == num);
            throw new Exception("Marchandise Introuvalble");
        }
        public double getVolumeTotal()
        {
            double somme = 0;
            somme = marchandises.Sum(m => m.Volume);
            /*foreach (Marchandise marchandise in marchandises)
            {
                somme += marchandise.Volume;
            }*/
            return somme;
        }

        public double getPoidsTotal()
        {
            double somme = 0;
            somme = marchandises.Sum(m => m.Poids);
            /*foreach (Marchandise marchandise in marchandises)
            {
                somme += marchandise.Poids;
            }*/
            return somme;
        }
        public List<Marchandise> getMarchandises()
        {
            return marchandises;
        }
        public abstract double cout();
    }
}