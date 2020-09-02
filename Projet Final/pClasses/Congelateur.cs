using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class Congelateur : Rayon
    {
        public float degresMin;
        public float degresMax;
        //constructeur de base

        public Congelateur()
        {
            this.degresMax = -23.3333f;
            this.degresMin = -28.8889f;
        }
        //constructeur de base avec param
        public Congelateur(float pDegresMin,float pDegresMax, int pNoRayon, string pNomRayon, float pSuperficie)
            : base(pNoRayon, pNomRayon, pSuperficie)
        {
            this.degresMax = pDegresMax;
            this.degresMin = pDegresMin;
        }

    }
}
