using InterfaceLecture;

Cat c = new Cat("Yumi", 14, 1.5);
Console.WriteLine(c.GetDescription());
Console.WriteLine(c.Interact());

Dog d = new Dog("Avis",25, 2);
Console.WriteLine(d.GetDescription());
Console.WriteLine(d.Interact());

//polymorphism in collections
List<iAnimal> animals = new List<iAnimal>();
animals.Add(c);
animals.Add(d);
DisplayPet(c);
DisplayPet(d);

foreach(iAnimal animal in animals)
{
    Console.WriteLine(animal.NickName);
}

//polymorphism in methods
static void DisplayPet(iAnimal a)
{
    Console.WriteLine(a.GetDescription());
}