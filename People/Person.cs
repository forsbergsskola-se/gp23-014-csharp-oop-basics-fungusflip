public class Person
{
    //ID MALL
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}