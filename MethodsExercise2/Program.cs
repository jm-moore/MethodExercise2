// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your name?");
var name = Console.ReadLine();

Console.WriteLine("What is your favorite color?");
var color = Console.ReadLine();

Console.WriteLine("What is your favorite animal?");
var animal = Console.ReadLine();

Console.WriteLine("What is your favorite band?");
var band = Console.ReadLine();

Console.WriteLine($"Once upon a time, there was a student named {name}. \n One day, {name} brought a {color} {animal} to class. \n The teacher got very upset and asked {name}" +
    $" and {name}'s pet {animal} to leave. \n {name} and {name}'s pet {animal} left class and went to a {band} concert.");

static int Add(int num1, int num2)
{
    return num1 + num2;
}
    static int Subtract(int num1, int num2)
{
    return num1 - num2;
}
    static int Multiply(int num1, int num2)
{
    return num1 * num2;
}
    static int Divide(int num1, int num2)
{
    return num1 / num2;
}
    static int Modulus(int num1, int num2)
{
    return num1 % num2;
}
Console.WriteLine("Enter a number:");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter another number:");

int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"If you add {num1} and {num2} you get:");
    Console.WriteLine(Add(num1, num2));

Console.WriteLine($"If you subtract {num1} and {num2} you get:");
    Console.WriteLine(Subtract(num1, num2));

Console.WriteLine($"If you multiply {num1} and {num2} you get:");    
    Console.WriteLine(Multiply(num1, num2));

Console.WriteLine($"If you divide {num1} and {num2} you get;");
    Console.WriteLine(Divide(num1, num2));

Console.WriteLine($"If you divide {num1} and {num2} you get a remainder of:");
    Console.WriteLine(Modulus(num1, num2));