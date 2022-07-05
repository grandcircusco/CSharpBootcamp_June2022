// See https://aka.ms/new-console-template for more information


using IntroOOPLecture;

Console.WriteLine("Hello, World!");

//Make an instance of pen

//Without a constructor
//Pen myPen = new Pen()
//{
//    Brand = "Bick",
//    Color = "Black",
//    InkType = "Ballpoint",
//    Price = 0.50m,
//    Length = 5.3f
//}; 

//with a constructor
Pen myPen = new Pen("Black", "Bick", "Ballpoint", 0.50m, 5.3f);
Console.WriteLine(myPen.Brand);

//Pen myPen2 = new Pen()
//{
//    Color = "Blue",
//    Brand = "Pilot",
//    InkType = "Gel",
//    Price = 1.50m,
//    Length = 5f
//};
Pen myPen2 = new Pen("Blue", "Pilot", "Gel", 1.50m, 5f);

Console.WriteLine(myPen2.Brand);
Console.WriteLine(myPen2.Color);

Console.WriteLine(myPen.Draw());
Console.WriteLine(myPen2.Draw("Flower"));

//Arrays/Collections 
Pen[] allPens = new Pen[5];
allPens[0] = myPen;
allPens[1] = myPen2;
//creating a new instance directly in array
//allPens[2] = new Pen()
//{
//    Color = "Pink",
//    Brand = "Neon Pens",
//    InkType = "Gel",
//    Price = 2.0m,
//    Length = 5f
//};

allPens[2] = new Pen("Pink", "Neon Pens", "Gel", 2.0m, 5f);

List<Pen> PenCollection = new List<Pen>()
{
    //add new pens directly into new list
    //new Pen()
    //{
    //    Color = "Transperant",
    //    Brand = "Gag Pens",
    //    InkType = "Transperant Ink",
    //    Price =3m,
    //    Length = 5f
    //},

    new Pen("Transperant", "Gag Pens", "Transperant Ink", 3m, 5f),

    //Add pre-existing pens into new list
    myPen,
    myPen2
};

//Accessing values from collections
Console.WriteLine(PenCollection[0].Brand);

foreach (Pen p in PenCollection)
{
    Console.WriteLine(p.Draw());
}

//linq
foreach(Pen p in PenCollection.Where(p => p.Length == 5f))//All pens whose length are 5
{
    Console.WriteLine(p.Length);
}

//test if pen can run out of ink (related to private property)
Pen drawingPen = new Pen("a", "b", "3", 3, 5);
Console.WriteLine(drawingPen.Draw());
Console.WriteLine(drawingPen.Draw());
Console.WriteLine(drawingPen.Draw());
Console.WriteLine(drawingPen.Draw());
Console.WriteLine(drawingPen.Draw());
//run out of ink
Console.WriteLine(drawingPen.Draw());
