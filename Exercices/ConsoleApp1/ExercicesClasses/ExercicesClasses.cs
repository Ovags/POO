using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices.ExercicesClasses
{
    internal class Voiture
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string SousModele { get; set; }
        public int NombreDePortes { get; 
            set
            {
                if (value < 0)
                {
                    value = 0;
                    throw new ArgumentException("Connard");
                }
            }
        }

        public Voiture()
        {
            Marque = "Dacia";
            Modele = "Sans des roues";
            NombreDePortes = 0;
        }

        public Voiture(string marque, string modele, int nombreDePortes)
        {
            Marque = marque;
            Modele= modele;
            NombreDePortes= nombreDePortes;
        }

        public void Demarrer()
        {
            Console.WriteLine("Vroum");
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"{Marque} {Modele} : {NombreDePortes}");
        }
    }

    internal class CompteBancaire
    {
        public string NumeroCompte { get; init; }
        private float _solde;

        public CompteBancaire(string numeroCompte, float solde)
        {
            NumeroCompte = numeroCompte;
            _solde = solde;
        }

        public float Deposer(float val) {
            _solde += val;
            return _solde;
        }

    }
}
