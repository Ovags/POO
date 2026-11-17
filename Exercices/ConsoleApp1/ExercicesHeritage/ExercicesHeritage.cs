namespace Exercices.ExercicesHeritage
{
    /*
    Exercice 1 – Gestion de véhicules
    Une petite entreprise veut répertorier ses véhicules.
    Tous les véhicules ont une marque et une année.
    Certains véhicules sont des voitures, d’autres des camions.
    Spécificités :
        ● Une voiture possède en plus un nombre de portes.
        ● Un camion possède une capacité de chargement (en tonnes).
        ● On souhaite pouvoir afficher les informations complètes d’un véhicule.
    */
    public class Véhicule
    {
        public string Marque { get; set; }
        public int Année { get; set; }
    }

    public class Voiture : Véhicule
    {
        public int NombrePortes { get; set; }
        
        public override string ToString()
        {
            return $"{Marque} - {Année} : Nombre de portes : {NombrePortes}";
        }
    }

    public class Camion : Véhicule
    {
        public double CapacitéChargement {  get; set; }

        public override string ToString()
        {
            return $"{Marque} - {Année} : Capacité de chargement (T) : {CapacitéChargement}";
        }
    }

/*
Exercice 2 – Gestion d’école
Une école veut développer un programme pour sa gestion.
Plusieurs types de personnes seront renseignées dans ce système :
    ● Les enseignants
    ● Les étudiants
Spécificités :
Toutes les personnes ont un nom et un prénom.
Mais :
    ● Un enseignant a en plus une matière enseignée.
    ● Un étudiant a un numéro de matricule et une année d’étude.
    ● On souhaite pouvoir afficher le détail d’un élève ou d’un enseignant
*/
public abstract class Personne
    {
        public string Nom {  get; init; }
        public string Prenom { get; init; }

        public Personne(string  nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public abstract override string ToString();
    }

public class Enseignant : Personne
    {
        public string MatièreEnseignée { get; set; }

        public Enseignant(string nom, string prenom, string matièreEnseignée) : base(nom, prenom)
        {
            MatièreEnseignée = matièreEnseignée;
        }

        public override String ToString()
        {
            return $"{Nom} {Prenom} : {MatièreEnseignée}";
        }
    }

public class Etudiant : Personne
    {
        public string Matricule {  get; init; }

        public Etudiant(string nom, string prénom, string matricule) : base(nom, prénom)
        {
            Matricule = matricule;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} : {Matricule}";
        }
    }

    /*
    Exercice 3 – Boutique en ligne
    Tu travailles sur une application de gestion de stock pour une boutique en ligne et elle
    souhaite informatiser ses stocks.
    La boutique vend :
        ● des produits classiques(nom, prix),
        ● des produits électroniques(nom, prix, marque, garantie en mois).
    Spécificités :
        ● Les produits électroniques partagent les mêmes informations qu’un produit
        classique, mais avec des champs supplémentaires.
        ● Il faut pouvoir donner la valeur totale(en €) du stock de produits.
        ● Il faut pouvoir lister tous les produits, afficher leur quantité disponible et la valeur
        totale en stock.
        ● Il faut pouvoir encoder des produits (classiques ou électroniques)
        ● Il faut pouvoir supprimer un produit
        ● Il faut pouvoir modifier le prix d’un produit
        ● Il faut pouvoir modifier la quantité en stock d’un produit
        ● Chaque produit doit pouvoir afficher le détail de ses informations.
    */

public class 
}