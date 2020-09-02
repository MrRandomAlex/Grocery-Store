using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class Achat
    {
        public int quantite;
        public float montant;
        private Produit produit;



        //Constructeur
        public Achat()
        {
            this.produit = null;
            this.quantite = 0;
            this.montant = 100f;

        }
        //constructeur de base avec param
        public Achat(Produit pProduit, int pQuantite, float pMontant)
        {
            this.produit = pProduit;
            this.quantite = pQuantite;
            this.montant = pMontant;
        }
        //assigner produit
        public Produit Produce
        {
            get
            {
                return this.produit;
            }
            set
            {
                this.produit = value;
            }
        }
        //assigner la quantité
        public int Quantité
        {
            get
            {
                return this.quantite;
            }
            set
            {
                if (value > 0)
                {
                    this.quantite = value;
                }

            }
        }

    }
}
