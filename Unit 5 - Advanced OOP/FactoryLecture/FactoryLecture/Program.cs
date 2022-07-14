using FactoryLecture;

Console.WriteLine("Please choose a shape");
string choice = Console.ReadLine();

ShapeFactory factory = new ShapeFactory();//Creating the factory
iShape result = factory.getShape(choice);//Returns matching shape based on user input

result.draw();//Automatically use the chosen shapes draw method