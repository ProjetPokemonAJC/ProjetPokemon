using System.Text;

internal class Programm
{
    // Main de l'application pokédex

    static void Main(String[] args)
    {

        bool exit = false;
        while (!exit)
        {
            Console.Write("\nApplication pokédex : Menu principal");
            Console.Write("\nCréer une page pour un seul pokémon : 1");
            Console.Write("\nIndiquer une liste de pokémon à afficher : 2");
            Console.Write("\nFaire une recherche sur le site pokemontruc : 3");
            Console.Write("\nQuitter : 0");
            Console.WriteLine();
            Console.WriteLine("Entrez une commande:");

            string param = Console.ReadLine() ?? "";

            switch (param)
            {
                case "1":
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "0":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("\nCommande non reconnnue");
                    break;
            }
        }
    }
}
