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
}