using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

    /*
     Exercice 4 : Utilisation d'une classe avec des objets en paramètre
        1. Crée une classe Produit avec les propriétés suivantes :
            ○ Nom (string)
            ○ Prix (decimal)
        2. Crée une classe Panier qui contient une liste de produits. Cette classe aura
        les méthodes suivantes :
            ○ AjouterProduit(Produit p) : Ajoute un produit au panier.
            ○ SupprimerProduit(Produit p) : Supprime un produit du panier.
            ○ AfficherPanier() : Affiche tous les produits du panier et le prix
        total.
        3. Dans le programme principal, crée plusieurs objets de type Produit,
        ajoute-les à un panier et affiche le contenu du panier.
        4. Affiche le montant total du produit
     */
    public class Produit
    {        
        public string Nom {  get; set; }
        public double Prix { get; set; }
        public Produit(string Nom, double Prix)
        {
            this.Nom = Nom;
            this.Prix = Prix;
        }
    }

    public class Panier
    {
        public List<Produit> listeProduits = new List<Produit>();

        public void AjouterProduit(Produit p){
            listeProduits.Add(p);
        }

        public void SupprimerProduit(Produit p)
        {
            listeProduits.Remove(p);
        }

        public void AfficherPanier()
        {
            double total = 0;
            foreach (var produit in listeProduits) 
            { 
                Console.WriteLine($"{produit.Nom} : {produit.Prix}");
                total += produit.Prix;
            }
            Console.WriteLine($"Total : {total}");
        }
    }

    /*
    Exercice 5 : Création d’une application de gestion de bibliothèque
        Crée une classe Livre avec :
            ● Id, Titre, Auteur, Annee
        Crée une classe Bibliotheque avec :
            ● une liste de Livre
            ● une méthode AjouterLivre(Livre livre)
            ● une méthode RetirerLivre(Id)
            ● une méthode AfficherLivres()
            ● une méthode RechercherLivre(string recherche)
        Dans le programme principal, ajoute plusieurs livres et permet à l’utilisateur :
            ● de rechercher un livre par titre, auteur ou année.
            ● d’ajouter un nouveau livre
            ● de supprimer un livre
            ● d’afficher tous les livres disponibles
    */
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int Annee { get; set; }
        public string ToString()
        {
            return $"{Titre} - {Auteur} {Annee}";
        }
    }

    public class Bibliotheque
    {
        private List<Livre> _listeLivres = new List<Livre>();
        public void AjouterLivre(Livre livre)
        {
            _listeLivres.Add(livre);
        }

        public bool RetirerLivre(int Id)
        {
            Livre livreARetirer = _listeLivres.Find(livre => livre.Id == Id);
            if (livreARetirer is null) return false; 
            _listeLivres.Remove(livreARetirer);
            return true;    
        }

        public void AfficherLivres()
        {
            foreach (Livre livre in _listeLivres) Console.WriteLine(livre.ToString());
        }

        public Livre RechercherLivre(string recherche)
        {
            _listeLivres.Find(
                delegate (Livre livre)
                {
                    return livre.Titre.Contains(recherche);
                }
                );
        }
    }
}
