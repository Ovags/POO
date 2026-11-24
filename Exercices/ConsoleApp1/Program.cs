//using ConsoleApp1.ExercicesDictionnaires;
//using System.Diagnostics;
//using Exercices.ExercicesClasses;

//using Exercices.ExercicesClasses;
//using Exercices.ExercicesClasses;
using Exercices.ExercicesHeritage;
///*Voiture voiture = new Voiture("Bentley", "Continental", 3);
//voiture.Demarrer();*/

///*voiture.Marque = "Bentley";
//voiture.Modele = "Continental";
//voiture.SousModele = "GT";*/

///*Console.WriteLine($"{voiture.Marque} {voiture.Modele} {voiture.SousModele}");
//voiture.AfficherDetails();());*/

///*CompteBancaire cb = new CompteBancaire("Coucou", 100000);
//Console.WriteLine(cb.Deposer(1000));
//Console.WriteLine(cb.Retirer(95000));
//Console.WriteLine(cb.Retirer(95000));*/

///*Produit pomme = new Produit("Pomme", 0.5);
//Produit poire = new Produit("Poire", 0.6);
//Produit banane = new Produit("Banane", 0.55);
//Panier panier = new Panier();
//panier.AjouterProduit(pomme);
//panier.AjouterProduit(poire);
//panier.AjouterProduit(banane);
//panier.AfficherPanier();*/

//Livre livre1 = new Livre();
//Livre livre2 = new Livre();
//livre1.Id = "1";
//livre1.Auteur = "Jules Verge";
//livre1.Titre = "20000 vieux sous grand-mère";
//livre1.Annee = 1769;
//livre2 .Id = "2";
//livre2.Auteur = "Jules Verge";
//livre2.Titre = "Le trou immonde en 80 jours";
//livre2.Annee = 1800;
//Bibliotheque bibliotheque =  new Bibliotheque();
//bibliotheque.AjouterLivre(livre1);
//bibliotheque.AjouterLivre(livre2);
//bibliotheque.AfficherLivres();
//bibliotheque.RetirerLivre("1");
//bibliotheque.AfficherLivres();
//Console.WriteLine(bibliotheque.RechercherLivre("trou").ToString());

//Hotel hotel = new Hotel();
//hotel.AjouterChambre(69, "simple", 1);
//hotel.AjouterChambre(69, "simple", 1);
//hotel.AjouterChambre(69, "simple", 1);
//hotel.AjouterChambre(69, "simple", 1);
//hotel.AjouterChambre(100, "double", 2);
//hotel.AjouterChambre(100, "double", 2);
//hotel.AjouterChambre(100, "double", 2);
//Console.WriteLine("Liste des chambres");
//hotel.ListerChambres();
//Console.WriteLine("\n\nListe des chambres de type simple");
//hotel.ListerChambresParType("simple");
//DateTime dateDebut1 = new DateTime(2026, 11, 1);
//DateTime dateFin1 = new DateTime(2026, 11, 30);
//DateTime dateDebut2 = new DateTime(2026, 10, 1);
//DateTime dateFin2 = new DateTime(2026, 10, 2);
//Console.WriteLine(hotel.PeriodesSeChevauchent(
//    dateDebut1, dateFin1, dateDebut2, dateFin2));
//Console.ReadLine();

//Véhicule vehicule = new();
//vehicule.Marque = "bite";
//vehicule.Année = 1969;
//Voiture voiture = new();
//voiture.Marque = "Fiat";
//voiture.Année = 2015;
//voiture.NombrePortes = 5;
//Camion camion = new();
//camion.Marque = "Man";
//camion.Année = 2000;
//Enseignant ah = new Enseignant("Hubert", "Adrien", "POO");
//Console.WriteLine(ah);
//Console.ReadLine();
Produit p = new Produit("Bite", 69.99m);
Produit p2 = new Produit("Couille", 35.99m);
ProduitElectronique pe = new ProduitElectronique("Marco", 19.99m, "Marque", 24);
Dictionary<Produit, int> Produits = new Dictionary<Produit, int>();
Produits.Add(p, 10);
Produits.Add(p2, 10);
Stock stock = new();
stock.Produits = Produits;
stock.getValue();
Console.WriteLine(stock.getValue());
Console.ReadLine();
