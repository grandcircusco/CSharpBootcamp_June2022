//31
int[] nums1 = { 2, 8, 0, 24, 51 };
Console.WriteLine("Enter an index");
int index1 = int.Parse(Console.ReadLine());
Console.WriteLine(nums1[index1]);
//32
int[] nums2 = { 2, 8, 0, 24, 51 };
Console.WriteLine("Enter a number");
int choice = int.Parse(Console.ReadLine());
int result = -1;
for (int i = 0; i < nums2.Length; i++)
{
    if (choice == nums2[i])
    {
        result = i;
    }
}
Console.WriteLine(result);
//33
int[] nums3 = { 2, 8, 0, 24, 51 };
Console.WriteLine("Please enter an index");
int index3 = int.Parse(Console.ReadLine());
Console.WriteLine($"The value of {index3} is {nums3[index3]}. What should its new value be?");
int choice3 = int.Parse(Console.ReadLine());
nums3[index3] = choice3;
Console.WriteLine(nums3[index3]);
//34
int[] nums4 = { 16, 32, 64, 128, 256 };
Console.WriteLine("Would you like to half or double? half/double");
string choice4 = Console.ReadLine();
for (int i = 0; i < nums4.Length; i++)
{
    if (choice4 == "half")
    {
        nums4[i] /= 2;
    }
    else if (choice4 == "double")
    {
        nums4[i] *= 2;
    }
    Console.WriteLine(nums4[i]);
}
//35
string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };
Console.WriteLine("write 2 numbers seperated by a space");
string choices = Console.ReadLine();
string[] choicesSplit = choices.Split(" ");
int indexAnimal = int.Parse(choicesSplit[0]);
int indexLetter = int.Parse(choicesSplit[1]);
Console.WriteLine($"{animals[indexAnimal]} {animals[indexAnimal][indexLetter]}");