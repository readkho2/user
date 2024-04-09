public class CD : ObjetDePret
{
    public string Groupe { get; }

    public CD(string titre, string groupe) : base(titre)
    {
        Groupe = groupe;
    }

    public override string ToString()
    {
        return $"Titre: {Titre}, Groupe: {Groupe}, Date de création: {DateCreation}";
    }
}
