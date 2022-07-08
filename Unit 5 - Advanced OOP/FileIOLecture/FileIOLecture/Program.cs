string filepath = "../../../file1.txt";

//written to files 
StreamWriter writer = new StreamWriter(filepath);
writer.Write("Word ");
writer.WriteLine("word 2");
writer.WriteLine("Line");
writer.Close(); //Any time you finish writing/reading, close it


//read from files
StreamReader reader = new StreamReader(filepath);
while (true)
{
    string line = reader.ReadLine();
    if(line == null)
    {
        break;
    }
    else
    {
        Console.WriteLine(line);
    }
}
reader.Close();//Any time you finish writing/reading, close it