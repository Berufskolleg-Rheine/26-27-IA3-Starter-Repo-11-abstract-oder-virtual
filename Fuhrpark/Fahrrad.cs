namespace Fuhrpark;

public class Fahrrad : Fahrzeug
{
    public Fahrrad(int geschwindigkeit, string farbe) : base(geschwindigkeit, farbe) { }

    public override void Fahren()
    {
        Console.WriteLine($"Das {Farbe} Fahrrad rollt mit {Geschwindigkeit} km/h.");
    }
}
