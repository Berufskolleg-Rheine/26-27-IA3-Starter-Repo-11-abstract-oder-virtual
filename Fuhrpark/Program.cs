using Fuhrpark;

List<Fahrzeug> fuhrpark = new List<Fahrzeug>();
fuhrpark.Add(new Auto(180, "rote"));
fuhrpark.Add(new Fahrrad(25, "grüne"));

foreach (Fahrzeug f in fuhrpark)
{
    f.Fahren();
    f.Hupen();
}
