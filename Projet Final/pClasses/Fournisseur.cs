using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class Fournisseur
    {
        public int noFournisseur;
        public string nomFournisseur;
        public string contactFournisseur;
        public string teleFournisseur;

        //Constructeur
        public Fournisseur()
        {
            this.noFournisseur = 0;
            this.nomFournisseur = "aucun";
            this.contactFournisseur = "aucun@gmail.com";
            this.teleFournisseur = "1234567890";
        }
        //constructeur de base avec param
        public Fournisseur(int pNoFournisseur,string pNomFournisseur,string pContactFournisseur, string pTeleFournisseur)
        {
            this.noFournisseur = pNoFournisseur;
            this.nomFournisseur = pNomFournisseur;
            this.contactFournisseur = pContactFournisseur;
            this.teleFournisseur = pTeleFournisseur;
        }
        //afficher le fournisseur
        public void AfficherFournisseur()
        {
            Console.WriteLine("Numéro du Fournisseur : " + noFournisseur);
            Console.WriteLine("Nom du fournisseur : " + nomFournisseur);
            Console.WriteLine("Contact fournisseur : "+contactFournisseur);
            Console.WriteLine("Telephone Client : " + teleFournisseur);
        }
    }
}
