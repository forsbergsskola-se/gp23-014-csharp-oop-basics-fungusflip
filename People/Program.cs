Person[] people = new Person[3];


// Get these people in there!
people[0] = new Person { Name = "John", Age = 30 };
people[1] = new Person { Name = "Alice", Age = 25 };
people[2] = new Person { Name = "Bob", Age = 35 };


// Get these people out there!
foreach (var person in people)
{
    person.PrintDetails();
}
