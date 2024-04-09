using System;

public class ObjetDePret
{
    public string Titre { get; }
    public DateTime DateCreation { get; private set; }

    public ObjetDePret(string titre)
    {
        Titre = titre;
        DateCreation = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Titre: {Titre}, Date de création: {DateCreation}";
    }
}
