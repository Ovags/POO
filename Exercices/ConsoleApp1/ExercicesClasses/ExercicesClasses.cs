using System;
using System.Collections.Generic;
using System.Globalization;
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
        public int NombreDePortes
        {
            get;
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
            Modele = modele;
            NombreDePortes = nombreDePortes;
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
        public string Nom { get; set; }
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

        public void AjouterProduit(Produit p)
        {
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
        public string Id { get; set; }
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

        public bool RetirerLivre(string Id)
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
            return _listeLivres.Find(livre =>
                livre.Titre.Contains(recherche) ||
                livre.Auteur.Contains(recherche) ||
                livre.Id.Contains(recherche)
            );
        }
    }
}

/*
 Projet : Programme de gestion de chambres d’hôtels
    Écris un programme qui permet à un propriétaire d’hôtel de gérer ses chambres.
    Fonctionnalités à implémenter
        1. Chambres
            ○ Ajouter une chambre.                                                  OK
            ○ Lister toutes les chambres (afficher numéro, type, prix, capacité).   OK
            ○ Rechercher des chambres par type (ex: toutes les “Double”).           OK
        2. Disponibilités
            ○ Saisir une période Arrivée–Départ et afficher les chambres libres.    OK
        3. Réservations
            ○ Créer une réservation si la chambre est libre sur la période.         OK
            ○ Lister les réservations (toutes ou par numéro de chambre).            OK
            ○ Annuler une réservation future.                                       OK
    Contraintes métier
        - Chaque chambre possède un numéro UNIQUE                                   OK
        - Le prix d’une chambre est toujours supérieur à 0€.                        OK
        - La capacité d’une chambre est au minimum d’une personne.                  OK
        - Lors d’une réservation, la date de sortie ne doit pas être antérieure à   
        la date d’entrée                                                            NOK
        - Deux réservations ne peuvent pas se chevaucher pour une même chambre      NOK
        - On ajoute pas de réservation si la chambre n’existe pas                   OK
 */

public class Hotel
{
    public List<Chambre> Chambres = new();
    public List<Reservation> Reservations = new();
    public Dictionary<string, int> TypesChambres = new();

    public Chambre AjouterChambre(int numeroChambre, decimal prix, string typeChambre, int capacite)
    {
        if (prix < 0 || capacite < 1) return null;
        if (!TypesChambres.ContainsKey(typeChambre))
            TypesChambres.Add(typeChambre, capacite);

        Chambre nouvelleChambre = new Chambre(numeroChambre, prix, typeChambre, capacite);

        Chambres.Add(nouvelleChambre);

        return (nouvelleChambre);
    }

    public void ListerChambres()
    {
        foreach (var chambre in Chambres) Console.WriteLine(chambre);
    }

    public void ListerChambresParType(string typeChambre)
    {
        if (TypesChambres.ContainsKey(typeChambre))
        {
            foreach (var chambre in Chambres)
                if (chambre.TypeChambre == typeChambre)
                    Console.WriteLine(chambre);
        }
        else Console.WriteLine($"Aucune chambre du type {typeChambre} n'existe.");
    }

    public Boolean PeriodesSeChevauchent(
        DateTime dateDebut1, DateTime dateFin1, DateTime dateDebut2, DateTime dateFin2)
    {
        return (dateDebut1 < dateFin2 && dateFin1 > dateDebut2);
    }

    private Boolean ChambreLibrePourPeriode(int numeroChambre, DateTime dateDebut, DateTime dateFin)
    {
        foreach (var reservation in Reservations)
        {
            if (reservation.NumeroChambre == numeroChambre)
            {
                if (PeriodesSeChevauchent(reservation.DateDebut, reservation.DateFin,
                    dateDebut, dateFin)) return false;
            }
        }
        return true;
    }

    public void ListerChambresLibresParPeriode(DateTime dateDebut, DateTime dateFin)
    {
        List<Chambre> chambresTriees = Chambres;

        foreach (var chambre in Chambres)
        {
            if (!ChambreLibrePourPeriode(chambre.Numero, dateDebut, dateFin))
                chambresTriees.Remove(chambre);
        }
    }

    public Reservation CreerReservation(int numeroChambre, DateTime dateDebut, DateTime dateFin)
    {
        if (dateDebut > dateFin) 
        {
            Console.WriteLine("La date de début est postérieure à la date de fin");

            return null;
        } 

        foreach (var reservation in Reservations)
        {
            if (PeriodesSeChevauchent(reservation.DateDebut, reservation.DateFin, dateDebut, dateFin))
            {
                Console.WriteLine("Les dates se chevauchent");

                return null;
            }
        }

        foreach (var chambre in Chambres)
            if (chambre.Numero == numeroChambre) return null;

        if (!ChambreLibrePourPeriode(numeroChambre, dateDebut, dateFin)) return null;

        return new Reservation(numeroChambre, dateDebut, dateFin);
    }

    public Boolean AnnulerReservation(int numeroChambre, DateTime dateDebut, DateTime dateFin)
    {
        foreach (var reservation in Reservations)
            if (numeroChambre == reservation.NumeroChambre &&
                dateDebut == reservation.DateDebut &&
                dateFin == reservation.DateFin)
            {
                Reservations.Remove(reservation);
                return true;
            }

        return false;
    }

    public void ListerReservations()
    {
        foreach (var reservation in Reservations)
            Console.WriteLine(reservation);
    }

    public void ListerReservationsParNumeroDeChambre(int numeroChambre)
    {
        foreach (var reservation in Reservations)
            if (reservation.NumeroChambre == numeroChambre)
                Console.WriteLine(reservation);
    }
}

public class Chambre
{
    public string TypeChambre { get; set; }
    public int CapaciteChambre { get; set; }
    public int Numero { get; init; }
    public decimal Prix { get; set; }

    public void SetTypeChambre(string typeChambre, int capaciteChambre)
    {
        TypeChambre = typeChambre;
        CapaciteChambre = capaciteChambre;
    }

    public Chambre(int numero, decimal prix, string typeChambre, int capaciteChambre)
    {
        Numero = numero;
        Prix = prix;
        SetTypeChambre(typeChambre, capaciteChambre);
    }

    public override string ToString()
    {
        return $"{Numero} {TypeChambre} ({CapaciteChambre} personnes) - Prix : {Prix}";
    }
}

public class Reservation
{
    public int NumeroChambre { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }

    public Reservation(int numero, DateTime dateDebut, DateTime dateFin)
    {
        NumeroChambre = numero;
        DateDebut = dateDebut;
        DateFin = dateFin;
    }

    public override string ToString()
    {
        CultureInfo culture = new CultureInfo("fr-BE");
        return $"Chambre {NumeroChambre}: Du {DateDebut.ToString("d", culture)} au {DateFin.ToString("d", culture)}";
    }
}
