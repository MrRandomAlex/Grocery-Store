using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class Facture
    {
        public float mntTPS;
        public float totalFacture;
        private string noFacture;
        public DateTime dateFacture;
        public Client client;
        public List<Achat> achats;
        public float sousTotal;
        public float mntTVQ;
        //Constructeur
        public Facture()
        {
            this.mntTPS = 0;
            this.totalFacture = 0;
            this.noFacture = "0";
            this.dateFacture = DateTime.Now;
            this.client = null;
            this.achats = null;
            this.sousTotal = 0;
            this.mntTVQ = 0;
        }
        //constructeur de base avec param
        public Facture(float pMntTPS, float pTotalFacture, string pNoFacture, DateTime pDateFacture, Client pClient, List<Achat> pAchats, float pSousTotal, float pMntTVQ)
        {
            this.mntTPS = pMntTPS;
            this.totalFacture = pTotalFacture;
            this.noFacture = pNoFacture;
            this.dateFacture = pDateFacture;
            this.client = pClient;
            this.achats = pAchats;
            this.sousTotal = pSousTotal;
            this.mntTVQ = pMntTVQ;
        }
        //calcul du no facture
        public string numFacture()
        {
            var rand = new Random();
            this.noFacture = rand.Next(100000, 999999).ToString();
            return noFacture;
            
        }
        //calculer le tps
        public float CalculerTPS(float prix)
        {
            this.mntTPS = prix * 0.05f;
            return mntTPS;
        }
        //calculer tvq
        public float CalculerTVQ(float prix)
        {
            
            this.mntTVQ = prix * 0.09975f;
            return mntTVQ;
        }
        //calculer total
        public float CalculerTotalFact(float TVQ, float TPS)
        {
            
            totalFacture = this.sousTotal+TPS+TVQ;
            return totalFacture;
        }
        
        //afficher facture
        public void AfficherFacture()
        {
            Console.WriteLine("---------------------IGA---------------------");
            foreach (Achat achat in achats)
            {
                Console.WriteLine(achat.quantite.ToString() + "              " + achat.Produce.description.ToString() + "              "+achat.montant.ToString()+"$");
            }
            
            Console.WriteLine();
            Console.WriteLine("Sous total : " + this.sousTotal+ "$");
            Console.WriteLine("Montant TPS : " + this.mntTPS +"$");
            Console.WriteLine("Montant TVQ : " +  this.mntTVQ +"$");
            Console.WriteLine("Total Facture : " + this.totalFacture + "$");
            Console.WriteLine("Numéro Facture : " + numFacture());
            Console.WriteLine("Date : " + dateFacture);
            Console.WriteLine("---------------------------------------------");
            
            
        }
    }
}
