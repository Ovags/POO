using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExercicesListes
{
    internal class ExercicesListe
    {
        public static void Exo1Et2()
        {
            /*
            Exercice 1 : Création et affichage
            Crée une liste de prénoms. Ajoute quelques prénoms puis affiche-les un par un avec une
            boucle foreach.
             */
            List<string> listePrenoms = ["Jean", "Roger", "Gontrand", "Masturbin"];
            foreach (var prenom in listePrenoms)
            {
                Console.WriteLine(prenom);
            }

            /*
            Exercice 2 : Recherche dans une liste
            Demande à l’utilisateur d’entrer un prénom et vérifie si ce prénom existe dans la liste.
            → Utiliser .Contains() ou une boucle.
            */
            Console.WriteLine("Entrez un prénom à chercher dans la liste");
            String prenomUtilisateur = Console.ReadLine();
            if (listePrenoms.Contains(prenomUtilisateur))
            {
                Console.WriteLine($"Le prénom {prenomUtilisateur} existe dans la liste");
            }
            else
            {
                Console.WriteLine($"Le prénom {prenomUtilisateur} n'existe pas dans la liste");
            }
        }

        public static void Exo3()
        {
            /*
            Exercice 3 : Suppression d’un élément
            À partir d’une liste de nombres [1,2,3,4,5], supprime un nombre demandé par
            l’utilisateur (si présent) puis affiche la liste mise à jour.
            */
            List<int> listeNombres = [1, 2, 3, 4, 5];
            Console.Write("Nombre à supprimer (si existant) : ");
            listeNombres.Remove(int.Parse(Console.ReadLine()));
            foreach (var nombre in listeNombres) Console.WriteLine(nombre);
        }

        public static void Exo4()
        {
            /*
            Exercice 4 : Trier une liste
            Génère une liste de nombre aléatoire et trie-la de la manière la plus simple possible.
            Affiche-la avant et après le tri.
            */
            Random rand = new Random();
            List<int> listeEntiersAleatoires = [];
            for (int i = 0; i < 5; i++) listeEntiersAleatoires.Add(rand.Next(0, 10));
            foreach (var entier in listeEntiersAleatoires) Console.WriteLine(entier);
            listeEntiersAleatoires.Sort();
            foreach (var entier in listeEntiersAleatoires) Console.WriteLine(entier);
        }

        public static void Exo5()
        {
            /*
            Exercice 5 : Trouver un élément
            Demande à l’utilisateur de taper une liste de prénoms (par exemple 5).
            Ensuite, demande-lui d’entrer un prénom à rechercher.
            ● Si le prénom est dans la liste → affiche sa position
            ● Sinon → affiche "Prénom introuvable".
            */
            List<string> listePrenoms = [];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Entrez le nom {i + 1}/5 : ");
                listePrenoms.Add(Console.ReadLine());
            }
            Console.Write("Rechercher le nom : ");
            int indicePrenom = listePrenoms.IndexOf(Console.ReadLine());
            if (indicePrenom != -1) Console.WriteLine(indicePrenom);
            else Console.WriteLine("Nom introuvable");
        }


    }
}
