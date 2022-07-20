using EFLecture;
using EFLecture.Models;


Console.WriteLine("Displaying all pokemon");
//To Access database values, use using( )
using (PokemonDBContext context = new PokemonDBContext())
{
    foreach(Pokemon p in context.Pokemons)
    {
        Console.WriteLine(p.Name);
    }
    Console.WriteLine();
    Console.WriteLine("Displaying all trainers");
    foreach(Trainer t in context.Trainers)
    {
        Console.WriteLine($"{t.Name}'s favorite is {t.FavPokemon.Name}");
    }
}
//Once out of { }, no more database connection

Console.WriteLine();
Console.WriteLine("Please type in a new Pokemon name");
string name = Console.ReadLine();
Console.WriteLine("Please enter a type");
string type = Console.ReadLine();
Console.WriteLine("Please enter a secondary type");
string type2 = Console.ReadLine();

using(PokemonDBContext context = new PokemonDBContext())
{
    Pokemon newPokemon = new Pokemon()
    {
        //NO ID. IDENTITY(1,1) HANDLES THAT
        Name = name,
        MainType = type,
        SecondType = type2
    };
    //started a transaction
    context.Pokemons.Add(newPokemon);
    //saving transaction
    context.SaveChanges();
}


//Show how linq enhances EF
Console.WriteLine("Which type do you want to see. Example: Grass");
string choice = Console.ReadLine();
using(PokemonDBContext context = new PokemonDBContext())
{
    List<Pokemon> result = context.Pokemons.Where(
        p => p.MainType.ToLower() == choice.ToLower() || p.SecondType.ToLower() == choice.ToLower()
        ).ToList();

    foreach(Pokemon p in result)
    {
        Console.WriteLine($"{p.Name} is a {p.MainType} and {p.SecondType}");
    }
}