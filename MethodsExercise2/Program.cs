// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("What is your favorite color?");
string color = Console.ReadLine();

Console.WriteLine("What is your favorite animal?");
string animal = Console.ReadLine();

Console.WriteLine("What is your favorite band?");
string band = Console.ReadLine();

Console.WriteLine($"Once upon a time, there was a student named {name}. \n One day, {name} brought a {color} {animal} to class. \n The teacher got very upset and asked {name}" +
    $" and {name}'s pet {animal} to leave. \n {name} and {name}'s pet {animal} left class and went to a {band} concert.");



