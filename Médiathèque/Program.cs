using System;

class Program
{
    static void Main()
    {
        Livre livre1 = CreerLivre();
        Livre livre2 = CreerLivre();
        Livre livre3 = CreerLivre();

        CD cd1 = CreerCD();
        CD cd2 = CreerCD();

        Console.WriteLine("\nInformations des livres créés :");
        Console.WriteLine(livre1);
        Console.WriteLine(livre2);
        Console.WriteLine(livre3);

        Console.WriteLine("\nInformations des CDs créés :");
        Console.WriteLine(cd1);
        Console.WriteLine(cd2);
    }

    static Livre CreerLivre()
    {
        Console.Write("Entrez le titre du livre : ");
        string titre = Console.ReadLine();
        Console.Write("Entrez l'auteur du livre : ");
        string auteur = Console.ReadLine();
        return new Livre(titre, auteur);
    }

    static CD CreerCD()
    {
        Console.Write("Entrez le titre du CD : ");
        string titre = Console.ReadLine();
        Console.Write("Entrez le groupe du CD : ");
        string groupe = Console.ReadLine();
        return new CD(titre, groupe);
    }
}
