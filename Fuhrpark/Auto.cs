namespace Fuhrpark;

public class Auto : Fahrzeug
{
    public Auto(int geschwindigkeit, string farbe) : base(geschwindigkeit, farbe) { }

    public override void Fahren()
    {
        Console.WriteLine($"Das {Farbe} Auto fährt mit {Geschwindigkeit} km/h.");
    }

    public override void Hupen()
    {
        Console.WriteLine("Möp möp!");
    }
}
