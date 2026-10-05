namespace Fuhrpark;

public abstract class Fahrzeug
{
    public int Geschwindigkeit { get; set; }
    public string Farbe { get; set; }

    public Fahrzeug(int geschwindigkeit, string farbe)
    {
        Geschwindigkeit = geschwindigkeit;
        Farbe = farbe;
    }

    public abstract void Fahren();

    public virtual void Hupen()
    {
        Console.WriteLine("Ein Signal ertönt.");
    }
}
