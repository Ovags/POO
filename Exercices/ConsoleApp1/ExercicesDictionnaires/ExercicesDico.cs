using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace ConsoleApp1.ExercicesDictionnaires
{
    internal class ExercicesDico
    {
        public static void Exo6()
        {
            /*
             Crée un dictionnaire qui associe un code pays ("FR", "BE", "DE") à son nom complet
            ("France", "Belgique", "Allemagne").
            Affiche chaque clé et valeur.
            */
            Dictionary<string, string> dicoPays = new Dictionary<string, string>();
            dicoPays.Add("FR", "France");
            dicoPays.Add("BE", "Belgique");
            dicoPays.Add("DE", "Allemagne");
            foreach (var pays in dicoPays)
            {
                string paysValeur;
                Console.WriteLine($"{pays.Key} - {pays.Value}");
            }
        }

        public static void Exo7()
        {
            /*
            Demande à l’utilisateur de taper un code pays (ex : "BE") et affiche le nom correspondant.
            → Gérer le cas où la clé n’existe pas.
            */
            Dictionary<string, string> dicoPays = new Dictionary<string, string>();
            dicoPays.Add("FR", "France");
            dicoPays.Add("BE", "Belgique");
            dicoPays.Add("DE", "Allemagne");
            Console.Write("Taper un code pays : ");
            string inputUtilisateur = Console.ReadLine();
            string nomPaysTrouve;
            if (dicoPays.TryGetValue(inputUtilisateur, out nomPaysTrouve))
            {
                Console.WriteLine(nomPaysTrouve);
            }
            else
            {
                Console.WriteLine("Pas de pays trouvé");
            }
        }

        public static void Exo8Et9()
        {
            /*
            Crée un dictionnaire où les clés sont des noms de produits ("Pomme", "Banane",
            "Orange") et les valeurs leurs prix.
            Demande à l’utilisateur un produit et affiche son prix. 
            */
            Dictionary<string, double> carte = new Dictionary<string, double>();
            carte.Add("Pomme", 0.5);
            carte.Add("Poire", 0.55);
            carte.Add("Orange", 0.60);
            carte.Add("Banane", 0.65);
            Console.Write("Entrer un article de la liste : ");
            string userInput = Console.ReadLine();
            double resultat;
            if (carte.TryGetValue(userInput, out resultat))
            {
                Console.WriteLine($"Prix : {resultat}");
            }
            /*
            Toujours avec le dictionnaire de prix :
            ● Demande à l’utilisateur de saisir plusieurs produits (jusqu’à écrire "stop")
            ● Calcule et affiche le contenu et le prix total du panier
            */
            Dictionary<string, int> panier = new Dictionary<string, int>();
            userInput = "";
            while (userInput.ToLower() != "stop")
            {
                Console.Write("Saisir un produit à ajouter au panier : ");
                userInput = Console.ReadLine();
                if (carte.ContainsKey(userInput))
                {
                    if (panier.ContainsKey(userInput)) panier[userInput]++;
                    else panier[userInput] = 1;
                }
                else Console.WriteLine($"Article {userInput} inconnu dans la carte.");
            }
            double total = 0;
            foreach (var article in panier)
            {
                total += article.Value * carte[article.Key];
                Console.WriteLine(article.Key + " : " + article.Value);
            }
            Console.WriteLine($"Total = {total}");
        }
        public static void Exo10()
        {
            /*
            Demande à l’utilisateur de taper une phrase.
            Crée un dictionnaire où :
            ● la clé = une lettre
            ● la valeur = le nombre de fois que la lettre apparaît.
            Affiche ensuite le dictionnaire.
            (ex : "bonjour" → b:1, o:2, n:1, j:1, u:1, r:1)
            */
            Console.Write("Entrer une phrase à analyser : ");
            string userInput = Console.ReadLine();
            Dictionary<char, int> dicoAnalyse = new Dictionary<char, int>();
            foreach (var character in userInput)
            {
                if (dicoAnalyse.ContainsKey(character)) dicoAnalyse[character] ++;
                else dicoAnalyse[character] = 1;
            }
            foreach (var entry in dicoAnalyse)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
        }
    }
}
