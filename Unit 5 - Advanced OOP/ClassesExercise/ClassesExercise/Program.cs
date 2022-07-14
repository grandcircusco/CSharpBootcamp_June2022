// See https://aka.ms/new-console-template for more information

using ClassesExercise;

List<Employee> Staff = new List<Employee>
{
    new Manager("Justin", 1000000),
    new Manager("Josh", 800000),
    new Worker("Travis", 20000),
    new Worker("Asia", 22000),
    new Worker("Daniel", 18000),
    new Worker("Connor", 15000),
    new Worker("Mara", 2000),
    new Worker("Vinh", 22500),
    new Worker("Ali", 20000),
    new Worker("Matt", 22000),
};

foreach(Employee s in Staff)
{
    s.Work();
}