

using Examen_Pokemon;


Pikachu pikachu1 = new Pikachu
{
    Nombre = "Pikachu",
    PuntosAtaque = 50,
    PuntosDefensa = 20
};

pikachu1.Ataques.Add("IMPACT TRUENO");
pikachu1.Ataques.Add("Attack trueno");


Charizard Charizard1 = new Charizard
{

    Nombre = "Charizard",
    PuntosAtaque = 90,
    PuntosDefensa = 40
    

};

Charizard1.Ataques.Add("Bola de fuego");
Charizard1.Ataques.Add("Fuego infernal");
Charizard1.Ataques.Add("Fly");

Squirtle Squirtle1 = new Squirtle
{
    Nombre = "Squirtle",
    PuntosAtaque= 45,
    PuntosDefensa= 30
};

Squirtle1.Ataques.Add("Tackle");
Squirtle1.Ataques.Add("Burbuja");
Squirtle1.Ataques.Add("Refugio");


Cubone Cubone1 = new Cubone
{
    Nombre = "Cubone",
    PuntosAtaque = 55,
    PuntosDefensa = 30
};

Cubone1.Ataques.Add("Golpe de Cabeza");
Cubone1.Ataques.Add("Doble filo");
Cubone1.Ataques.Add("Furia");



Console.WriteLine(pikachu1 +"\n");
Console.WriteLine(Charizard1 + "\n");
Console.WriteLine(Squirtle1 + "\n");
Console.WriteLine(Cubone1 + "\n");
