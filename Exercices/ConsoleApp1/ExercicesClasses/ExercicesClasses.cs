using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices.ExercicesClasses
{
    /*
       Exercice 1 : Création d'une classe simple
        1. Crée une classe Voiture avec les propriétés suivantes :
            ○ Modele(string)
            ○ Marque(string)
            ○ NombreDePorte(int)
        2. Utilise des propriétés avec un mécanisme de lecture/écriture (get/set) pour
        encapsuler ces données.
        3. Crée une méthode AfficherDetails() qui affiche les informations de la
        voiture sous la forme : "Marque Modele, NombreDePorte".
        4. Dans le programme principal, instancie plusieurs objets de la classe
        Voiture et affiche leurs détails.

      Exercice 2 : Encapsulation et validation
        1. Modifie la classe Voiture pour que la propriété NombreDePorte ait une
        règle d'encapsulation :
            ○ Le nombre de porte ne peut pas être inférieur à 2 ni supérieur à 5.
        2. Si une tentative est faite pour assigner une valeur en dehors de cette plage,
        un message d'erreur doit être affiché.
        3. Teste cette fonctionnalité en essayant de définir un nombre de porte
        invalide dans le programme principal.
     */
    internal class Voiture
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string SousModele { get; set; }
        public int NombreDePortes { get; 
            set
            {
                if (value < 2 || value > 5)
                    Console.WriteLine("Le nombre de portes n'est pas correct");
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

    /*
     Exercice 3 : Classe et méthodes
        1. Crée une classe CompteBancaire avec les propriétés suivantes :
            ○ NumeroCompte (string, en lecture seule après l'initialisation)
            ○ Solde (decimal, privé, initialisé à 0)
        2. Crée une méthode publique Deposer qui ajoute de l'argent au solde et une
        méthode Retirer qui permet de retirer de l'argent du compte, à condition
        que le solde soit suffisant. En cas de solde insuffisant, affiche un message
        d'erreur.
        3. Crée une méthode AfficherSolde pour afficher le numéro de compte et le
        solde actuel.
        4. Dans le programme principal, instancie un compte bancaire et fais des
        dépôts et retraits pour vérifier le bon fonctionnement.
     */

    internal class CompteBancaire
    {
        public string NumeroCompte { get; init; }
        private float _solde;

        public CompteBancaire(string numeroCompte, float solde)
        {
            NumeroCompte = numeroCompte;
            _solde = solde;
        }

        public float Deposer(float val) 
        {
            _solde += val;
            return _solde;
        }

        public float Retirer(float val)
        {
            if (_solde < val)
                Console.WriteLine("Retrait impossible, solde insuffisant");
            else _solde -= val;
            return _solde;
        }
    }
}
