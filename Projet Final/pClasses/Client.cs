using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class Client
    {
        public int noClient;
        public string nomClient;
        public string prenomClient;
        public string adresseClient;
        public string villeClient;
        public string provClient;
        private string teleClient;
        //Constructeur
        public Client()
        {
            this.noClient = 0;
            this.nomClient = "aucun";
            this.prenomClient = "aucun";
            this.adresseClient = "aucun";
            this.villeClient = "aucun";
            this.provClient = "aucun";
            this.teleClient = "1234567890";
        }
        //constructeur de base avec param
        public Client(int pNoCLient,string pNomClient, string pPrenomClient, string pAdresseClient,string pVilleClient, string pProvClient, string pTeleClient)
        {
            this.noClient = pNoCLient;
            this.nomClient = pNomClient;
            this.prenomClient = pPrenomClient;
            this.adresseClient = pAdresseClient;
            this.villeClient = pVilleClient;
            this.provClient = pProvClient;
            this.teleClient = pTeleClient;
        }
        public string NoTelephone
        {
            get
            {
                return this.teleClient;
            }
            set
            {
                bool estValide = true;
                if (value.Length == 10)
                {
                    
                    foreach (char Lettre in value)
                    {


                        if (!char.IsNumber(Lettre))
                        {
                            estValide = false;
                            break;
                            
                        }

                    }
                }
                else
                {
                    estValide = false;
                }

                if (estValide == true)
                {
                    teleClient = value;
                }
                else
                {
                    teleClient = "XXX";
                }

            }

        }
        public void AfficherClient()
        {
            Console.WriteLine("Numéro de client : "+noClient);
            Console.WriteLine("Prénom : " + prenomClient);
            Console.WriteLine("Nom : " + nomClient);
            Console.WriteLine("Adresse Client : " + adresseClient);
            Console.WriteLine("Ville Client : " + villeClient);
            Console.WriteLine("Province Client : " + provClient);
            Console.WriteLine("Telephone Client : " + teleClient);
        }
    }
}
