using AnimalInheritence;

Console.WriteLine("Welcome to the GC Animal Showcase. Today we will be having a contest to decide which animal is the best");
Console.WriteLine("Contestants are now preparing their animals");
List<Animal> ShowTimeAnimals = new List<Animal>();
//Place all animals here
ShowTimeAnimals.Add(new Ailuropoda_melanoleuca("Jo", 6, 100, 75, "BlackWhite"));
ShowTimeAnimals.Add(new Cat("Yumi", 1, 20, 1, 10));
ShowTimeAnimals.Add(new Cat2("Macho Man Randy Savage", 1.5, 18, false, "Maine Coon Cat"));
ShowTimeAnimals.Add(new Dolphin("Flipper", 60, 200, 15, 8));
ShowTimeAnimals.Add(new Hippo("Bubba", 7.1, 401, 23.1, 8));
ShowTimeAnimals.Add(new Dog("Georgie", 2, 45, "hound", "white and brown"));
ShowTimeAnimals.Add(new Cat3("jaguar", 3.0, 200, true, "jungle"));
ShowTimeAnimals.Add(new Dragon("Smaug", 430, 5000, true, 1000));
ShowTimeAnimals.Add(new Tiger("Tony", 4, 160, 200, 3));
ShowTimeAnimals.Add(new Shark("WhaleLY", 28, 12000, "Whale", "salt water", "does not have teeth"));
ShowTimeAnimals.Add(new Platypus("Perry", 2, 15, "blue", 11));
ShowTimeAnimals.Add(new Ape("Shelly", 4, 100, "North America" ,6));
ShowTimeAnimals.Add(new Fish("Puffer", .5, 1.3, "Yellow", true));
ShowTimeAnimals.Add(new Bird("Kiwi", 1.5, 3, "green", 3.5));

Console.WriteLine("Animals are prepared. Lets take a look at each of them. Press enter to continue");
Console.ReadLine();
foreach (Animal a in ShowTimeAnimals)
{
    Console.WriteLine(); //Empty Space
    Console.WriteLine(a.GetDescription());
    Console.WriteLine(a.Interact());

    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
}
Console.WriteLine();

//Linq for stats
Console.WriteLine($"Our heaviest Animal is {ShowTimeAnimals.OrderByDescending(a=> a.Weight).First().NickName}");
Console.WriteLine($"Our lightest Animal is {ShowTimeAnimals.OrderByDescending(a => a.Weight).Last().NickName}");
Console.WriteLine($"Our tallest Animal is {ShowTimeAnimals.OrderByDescending(a => a.Height).First().NickName}");
Console.WriteLine($"Our shortest Animal is {ShowTimeAnimals.OrderByDescending(a => a.Height).Last().NickName}");
Console.WriteLine($"Our longest nickname is {ShowTimeAnimals.OrderByDescending(a => a.NickName.Length).First().NickName}");
Console.WriteLine($"Our shortest nickname is {ShowTimeAnimals.OrderByDescending(a => a.NickName.Length).Last().NickName}");

Console.WriteLine("We have taken a look at each animal. Lets find out who our winner is...");
Console.WriteLine("Press enter to continue");
Console.ReadLine();
Random r = new Random();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{ShowTimeAnimals[r.Next(ShowTimeAnimals.Count)].NickName} has won!!!");
Console.ResetColor();
Console.WriteLine("Join us next week on GC Animal Showcase!");