using FileIOExercise;

List<Student> students = new List<Student>();//Empty List of students. Will be filled later
string filePath = "../../../Students.txt";


//if file doesn't exist
if (File.Exists(filePath) == false)
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    //Adding starting data
    tempWriter.WriteLine("Justin Jones,2,10");
    tempWriter.WriteLine("Josh Carolin,12,18");
    tempWriter.Close();//Always close the writer
}

//collecting all students in file
StreamReader reader = new StreamReader(filePath);

//loop through all students in file
while (true)
{
    string line = reader.ReadLine();
    if(line == null)//it pulled out current student and found nothing
    {
        break;
    }
    else//found a student
    {
        //Console.WriteLine(line); //debugging
        //take line and turn into student
        string[] values = line.Split(',');
        Student newStudent = new Student(values[0],int.Parse(values[1]), int.Parse(values[2]));
        students.Add(newStudent);
    }
}
//When loop finishes, collected all students

//when finished, close it
reader.Close();

//MAIN PROGRAM
foreach (Student s in students)
{
    Console.WriteLine($"{s.Name} is in grade {s.Grade} and is {s.Age} years old");
}

//user has decided to add a new student
Console.WriteLine("Thank you for adding a new student.");
Console.WriteLine("What is their name?");
string name = Console.ReadLine();
Console.WriteLine("What grade are they in?");
int grade = int.Parse(Console.ReadLine()); //Assume valid input
Console.WriteLine("What is their age?");
int age = int.Parse(Console.ReadLine()); //Assume valid input
Student stu = new Student(name,grade,age);
students.Add(stu);


//UPDATE FILE WITH NEW STUDENT
StreamWriter writer = new StreamWriter(filePath);
foreach(Student student in students)
{
    writer.WriteLine($"{student.Name},{student.Grade},{student.Age}");
}
writer.Close();