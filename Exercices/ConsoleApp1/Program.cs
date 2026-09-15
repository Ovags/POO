using ConsoleApp1.ExercicesDictionnaires;
using Exercices.ExercicesClasses;
Voiture voiture = new Voiture("Bentley", "Continental", 3);
voiture.Demarrer();
/*voiture.Marque = "Bentley";
voiture.Modele = "Continental";
voiture.SousModele = "GT";*/
Console.WriteLine($"{voiture.Marque} {voiture.Modele} {voiture.SousModele}");
voiture.AfficherDetails();
CompteBancaire cb = new CompteBancaire("Coucou", 100000);
Console.WriteLine(cb.Deposer(1000));