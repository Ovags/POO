using ConsoleApp1.ExercicesDictionnaires;
using Exercices.ExercicesClasses;
/*Voiture voiture = new Voiture("Bentley", "Continental", 3);
voiture.Demarrer();*/

/*voiture.Marque = "Bentley";
voiture.Modele = "Continental";
voiture.SousModele = "GT";*/

/*Console.WriteLine($"{voiture.Marque} {voiture.Modele} {voiture.SousModele}");
voiture.AfficherDetails();());*/

/*CompteBancaire cb = new CompteBancaire("Coucou", 100000);
Console.WriteLine(cb.Deposer(1000));
Console.WriteLine(cb.Retirer(95000));
Console.WriteLine(cb.Retirer(95000));*/

/*Produit pomme = new Produit("Pomme", 0.5);
Produit poire = new Produit("Poire", 0.6);
Produit banane = new Produit("Banane", 0.55);
Panier panier = new Panier();
panier.AjouterProduit(pomme);
panier.AjouterProduit(poire);
panier.AjouterProduit(banane);
panier.AfficherPanier();*/

Livre livre1 = new Livre();
Livre livre2 = new Livre();
livre1.Id = "1";
livre1.Auteur = "Jules Verge";
livre1.Titre = "20000 vieux sous grand-mère";
livre1.Annee = 1769;
livre2 .Id = "2";
livre2.Auteur = "Jules Verge";
livre2.Titre = "Le trou immonde en 80 jours";
livre2.Annee = 1800;
Bibliotheque bibliotheque =  new Bibliotheque();
bibliotheque.AjouterLivre(livre1);
bibliotheque.AjouterLivre(livre2);
bibliotheque.AfficherLivres();
bibliotheque.RetirerLivre("1");
bibliotheque.AfficherLivres();
Console.WriteLine(bibliotheque.RechercherLivre("trou").ToString());
