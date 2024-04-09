public class Livre : ObjetDePret
{
    public string Auteur { get; }

    public Livre(string titre, string auteur) : base(titre)
    {
        Auteur = auteur;
    }

    public override string ToString()
    {
        return $"Titre: {Titre}, Auteur: {Auteur}, Date de création: {DateCreation}";
    }
}
